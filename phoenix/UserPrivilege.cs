using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phoenix
{
    public enum Privilege
    {
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
        }
    }

    public class PrivilegeManager
    {
        public ArrayList Privileges = new ArrayList();

        public PrivilegeManager()
        {
            Privileges.Add(new PrivilegeData(Privilege.PREPROCESS, @"交叉定标数据预处理", new PreprocessPanel()));
            Privileges.Add(new PrivilegeData(Privilege.BRDFMODEL, @"定标场地BRDF模型", new BRDFModelPanel()));
            Privileges.Add(new PrivilegeData(Privilege.BRDF, @"观测几何校正因子计算", new BRDFPanel()));
            Privileges.Add(new PrivilegeData(Privilege.SITEREFLECTANCE, @"场地光谱信息提取", new SiteReflectancePanel()));
            Privileges.Add(new PrivilegeData(Privilege.SITEATMPARAS, @"场地大气参数提取", new SiteAtmParasPanel()));
            Privileges.Add(new PrivilegeData(Privilege.SBAFCORRECTION, @"光谱匹配校正因子计算", new SBAFCorrectionPanel()));
            Privileges.Add(new PrivilegeData(Privilege.CROSSCALIBRATION, @"交叉定标", new CrossCalibrationPanel()));
            Privileges.Add(new PrivilegeData(Privilege.BATCHCROSSCALIBRATION, @"可见近红外全过程交叉定标", new BatchCrossCalibrationPanel()));
            Privileges.Add(new PrivilegeData(Privilege.TIRCROSSCALIBRATION, @"热红外全过程交叉定标", new TIRCrossCalibrationPanel()));
            Privileges.Add(new PrivilegeData(Privilege.IMAGEUNCERTAINTY, @"图像噪声不确定性分析", new ImageUncertaintyPanel()));
            Privileges.Add(new PrivilegeData(Privilege.BRDFUNCERTAINTY, @"观测几何不确定性分析", new BRDFUncertaintyPanel()));
            Privileges.Add(new PrivilegeData(Privilege.SBAFUNCERTAINTY, @"光谱匹配不确定性分析", new SBAFUncertaintyPanel()));
            Privileges.Add(new PrivilegeData(Privilege.TOTALUNCERTAINTY, @"总的不确定性分析", new TotalUncertaintyPanel()));
        }       
    }

    public class UserPrivilege
    {
        public string UserName;
        public Privilege Privileges = Privilege.ALL;
    }
}
