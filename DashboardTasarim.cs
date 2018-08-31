using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardCommon;

namespace BarduckCRM
{
    public partial class DashboardTasarim : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        bool saveDashboard;

        public DevExpress.DashboardCommon.Dashboard Dashboard { get { return dashboardDesigner1.Dashboard; } }
        public bool SaveDashboard { get { return saveDashboard; } }

        public DashboardTasarim(DevExpress.DashboardCommon.Dashboard dashboard)
        {
            InitializeComponent();
            dashboardDesigner1.Dashboard = dashboard;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (dashboardDesigner1.IsDashboardModified)
            {
                DialogResult result = XtraMessageBox.Show(LookAndFeel, this, "Do you want to save changes ?", "Dashboard Designer",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Cancel)
                    e.Cancel = true;
                else
                    saveDashboard = result == DialogResult.Yes;
            }
        }

        private void DashboardTasarim_Load(object sender, EventArgs e)
        {
            //fileRibbonPageGroup1.Enabled = false;
            //fileNewBarItem1.Enabled = false;
            //fileOpenBarItem1.Enabled = false;
            //ribbonControl1.Toolbar.ItemLinks.Remove(fileSaveBarItem1);
            //dashboardBackstageViewControl1.Enabled = false;
        }
    }

   

}