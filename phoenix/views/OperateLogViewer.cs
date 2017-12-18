using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phoenix.views
{
    public partial class OperateLogViewer : UserControl
    {
        private PrivilegeManager privilegeManager = null;

        public OperateLogViewer(PrivilegeManager privilege)
        {
            privilegeManager = privilege;
            privilegeManager.NewOpLogArrived += privilegeManager_NewOpLogArrived;

            InitializeComponent();
        }

        void privilegeManager_NewOpLogArrived(OpLog log)
        {
            string[] item = new string[] { log.OpDate, log.User, log.FuncName, log.Outfile };
            listViewLog.Items.Insert(0, new ListViewItem(item));
        }

        private void OperateLogViewer_Load(object sender, EventArgs e)
        {
            listViewLog.Columns[2].Width = 270;
            listViewLog.Columns[3].Width = 420;

            foreach (OpLog log in privilegeManager.GetOperatorLog())
            {
                string[] item = new string[] { log.OpDate, log.User, log.FuncName, log.Outfile };
                listViewLog.Items.Add(new ListViewItem(item));
            }
        }

        private void listViewLog_DoubleClick(object sender, EventArgs e)
        {

        }

        private void listViewLog_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = listViewLog.HitTest(e.X, e.Y);
            if (info != null)
            {
                string path = info.Item.SubItems[3].Text;
                System.Diagnostics.Process.Start("explorer", "/select," + path);
            }
        }
    }
}
