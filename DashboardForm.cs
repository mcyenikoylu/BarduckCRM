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
using DevExpress.XtraSplashScreen;
using DevExpress.DashboardCommon;

namespace BarduckCRM
{
    public partial class DashboardForm : DevExpress.XtraEditors.XtraForm
    {
        private DataSet datasourcedisardan = new DataSet();
        public DataSet _datasourcedisardan
        {
            get { return datasourcedisardan; }
            set { datasourcedisardan = value; }
        }

        private int DashboardID = 0;
        public DashboardForm(int _DashboardID)
        {
            InitializeComponent();
            DashboardID = _DashboardID;
        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {
           
        }

        void dasboard_DataLoading(object sender, DashboardDataLoadingEventArgs e)
        {
            if (datasourcedisardan != null)
            {
                foreach (DataTable item in datasourcedisardan.Tables)
                {
                    if (e.DataSource.Name == item.TableName)
                    {
                        e.Data = item;

                    }
                }
            }
            else
            {
                DataSet datasourcelist = Genel.DsGetir(DashboardID, true);

                foreach (DataTable item in datasourcelist.Tables)
                {
                    if (e.DataSource.Name == item.TableName)
                    {
                        e.Data = item;

                    }
                }
            }
            //        var list = Application.OpenForms;

            //            list[1].BeginInvoke(new Action(() => list[1].Hide()));

            //          var asdf = "";

        }


        private void Dashboard_Shown(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(BarduckCRM.Bekleyiniz), true, true);
            SplashScreenManager.CloseForm();
            
            var list = Application.OpenForms.OfType<DevExpress.DataAccess.UI.Native.WaitFormWithCancel>().FirstOrDefault();
            if (list != null)
            {
                list.BeginInvoke(new Action(() => list.Hide()));

            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            dashboardPanel1._DashboardID = DashboardID;
            dashboardPanel1.Datagetir();
            
        }
    }
}