using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace phoenix
{
    public enum Privilege
    {
        NON                   =  0,
        PREPROCESS            =  1 << 0,
        BRDFMODEL             =  1 << 1,
        BRDF                  =  1 << 2,
        SITEREFLECTANCE       =  1 << 3,
        SITEATMPARAS          =  1 << 4,
        SBAFCORRECTION        =  1 << 5,
        CROSSCALIBRATION      =  1 << 6,
        BATCHCROSSCALIBRATION =  1 << 7,
        TIRCROSSCALIBRATION   =  1 << 8,
        IMAGEUNCERTAINTY      =  1 << 9,
        BRDFUNCERTAINTY       =  1 << 10,
        SBAFUNCERTAINTY       =  1 << 11,
        TOTALUNCERTAINTY      =  1 << 12,
        ALL                   =  (1 << 13) -1
    }

    public class PrivilegeData
    {
        public Privilege PrivilegeName;
        public string PrivilegeText;
        public ContainerControl Container;

        public PrivilegeData(Privilege name, string text, ContainerControl container)
        {
            PrivilegeName = name;
            PrivilegeText = text;
            Container = container;
            Container.Text = PrivilegeText;
        }

        public override string ToString()
        {
            return PrivilegeText;
        }
    }

    public class UserPrivilege
    {
        public static string CreateMD5Hash(string input)
        {
            // Use input string to calculate MD5 hash
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            // Convert the byte array to hexadecimal string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                sb.Append(hashBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        public string UserName;
        public string UserPwd; // MD5
        public Privilege Privileges = Privilege.ALL;

        public override string ToString()
        {
            return UserName;
        }
    }

    public class OpLog
    {
        public string User;
        public string OpDate;
        public string FuncName;
        public string Outfile;
    }

    public delegate void NewOpLogArrivedEventHandler(OpLog log);

    public class PrivilegeManager
    {
        private DBExecutor dbExecutor;
        public ArrayList Privileges = new ArrayList();
        public string LoggedUser;

        public event NewOpLogArrivedEventHandler NewOpLogArrived = null;

        public PrivilegeManager()
        {
            Privileges.Add(new PrivilegeData(Privilege.PREPROCESS, @"交叉定标数据预处理", new PreprocessPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.BRDFMODEL, @"定标场地BRDF模型", new BRDFModelPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.BRDF, @"观测几何校正因子计算", new BRDFPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.SITEREFLECTANCE, @"场地光谱信息提取", new SiteReflectancePanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.SITEATMPARAS, @"场地大气参数提取", new SiteAtmParasPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.SBAFCORRECTION, @"光谱匹配校正因子计算", new SBAFCorrectionPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.CROSSCALIBRATION, @"交叉定标", new CrossCalibrationPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.BATCHCROSSCALIBRATION, @"可见近红外全过程交叉定标", new BatchCrossCalibrationPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.TIRCROSSCALIBRATION, @"热红外全过程交叉定标", new TIRCrossCalibrationPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.IMAGEUNCERTAINTY, @"图像噪声不确定性分析", new ImageUncertaintyPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.BRDFUNCERTAINTY, @"观测几何不确定性分析", new BRDFUncertaintyPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.SBAFUNCERTAINTY, @"光谱匹配不确定性分析", new SBAFUncertaintyPanel(this)));
            Privileges.Add(new PrivilegeData(Privilege.TOTALUNCERTAINTY, @"总的不确定性分析", new TotalUncertaintyPanel(this)));

            Initialize();
        }

        private void Initialize()
        {
            string strPath = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            strPath = Directory.GetParent(strPath).FullName + "\\dat";
            dbExecutor = new DBExecutor(strPath);
            if (dbExecutor.NewCreated)
            {
                // 创建用户表
                string sql = "CREATE TABLE user(name varchar(20), pwd varchar(32), privileges int)";
                dbExecutor.ExecuteSQL(sql);

                // 创建日志表
                sql = "CREATE TABLE log(user varchar(20), date datetime, func varchar(32), outfile varchar(256))";
                dbExecutor.ExecuteSQL(sql);
            }
        }

        public bool AppendLog(string func, string outfile)
        {
            string date = DateTime.Now.ToString("s");
            string sql = String.Format("INSERT INTO log(user, date, func, outfile) VALUES('{0}','{1}','{2}','{3}')", this.LoggedUser,date, func, outfile);
            bool success = dbExecutor.ExecuteSQL(sql);
            if (success && (NewOpLogArrived != null))
            {
                OpLog log = new OpLog();
                log.User = this.LoggedUser;
                log.OpDate = date;
                log.FuncName = func;
                log.Outfile = outfile;
                NewOpLogArrived(log);
            }
            return success;
        }

        public ArrayList GetOperatorLog()
        {
            ArrayList opLogs = new ArrayList();
            string sql = String.Format("SELECT user, date, func, outfile FROM log order by date desc limit 2000");
            SQLiteDataReader reader = dbExecutor.QuerySQL(sql);
            if (reader != null)
            {
                while (reader.Read())
                {
                    OpLog log = new OpLog();
                    log.User = reader["user"] as string;
                    log.OpDate = reader["date"].ToString();
                    log.FuncName = reader["func"] as string;
                    log.Outfile = reader["outfile"] as string;
                    opLogs.Add(log);
                }
            }

            if (opLogs.Count >= 2000)
            {
                // 删除旧记录
                string date = (opLogs[2000] as OpLog).OpDate;
                sql = String.Format("DELETE FROM log where date<'{0}'", date);
                dbExecutor.ExecuteSQL(sql);
            }

            return opLogs;
        }

        public bool AddUser(UserPrivilege privilege)
        {
            string sql = String.Format("INSERT INTO user(name, pwd, privileges) VALUES('{0}','{1}',{2})", privilege.UserName, privilege.UserPwd, (int)privilege.Privileges);
            return dbExecutor.ExecuteSQL(sql);
        }

        public bool IsUserExisted(string userName)
        {
            string sql = String.Format("SELECT privileges FROM user WHERE name='{0}'", userName);
            SQLiteDataReader reader = dbExecutor.QuerySQL(sql);
            return (reader != null) && reader.Read();
        }

        public UserPrivilege GetUser(string userName, string userPwd)
        {
            UserPrivilege privilege = null;
            string sql = String.Format("SELECT privileges FROM user WHERE name='{0}' and pwd = '{1}'", userName, userPwd);
            SQLiteDataReader reader = dbExecutor.QuerySQL(sql);
            if (reader != null)
            {
                while (reader.Read())
                {
                    privilege = new UserPrivilege();
                    privilege.UserName = userName;
                    privilege.UserPwd = userPwd;
                    privilege.Privileges = (Privilege)reader["privileges"];
                }
            }
            return privilege;
        }

        public bool UpdateUser(UserPrivilege privilege)
        {
            string sql = String.Format("UPDATE user SET pwd='{0}', privileges={1} WHERE name='{2}'", privilege.UserPwd, (int)privilege.Privileges, privilege.UserName);
            return dbExecutor.ExecuteSQL(sql);
        }

        public bool DeleteUser(string userName)
        {
            string sql = String.Format("DELETE FROM user WHERE name='{0}'", userName);
            return dbExecutor.ExecuteSQL(sql);
        }

        public ArrayList GetAllUsers()
        {
            ArrayList results = new ArrayList();

            string sql = "SELECT name,pwd,privileges FROM user";
            SQLiteDataReader reader = dbExecutor.QuerySQL(sql);
            if (reader != null)
            {
                while (reader.Read())
                {
                    UserPrivilege privilege = new UserPrivilege();
                    privilege.UserName = reader["name"].ToString();
                    privilege.UserPwd = reader["pwd"].ToString();
                    privilege.Privileges = (Privilege)reader["privileges"];
                    results.Add(privilege);
                }
            }
            return results;
        }
    }
}
