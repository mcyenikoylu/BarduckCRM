using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DevExpress.DashboardCommon;
using BarduckCRM;
using DevExpress.XtraSplashScreen;

namespace BarduckCRM
{
    public partial class DashboardPanel : UserControl
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        private DataSet datasourcedisardan = new DataSet();
        public DataSet _datasourcedisardan
        {
            get { return datasourcedisardan; }
            set { datasourcedisardan = value; }
        }

        private int DashboardID = -1;
        public int _DashboardID
        {
            get { return DashboardID; }
            set { DashboardID = value; }
        }

        public DashboardPanel()
        {
            InitializeComponent();

            if(Genel.AktifKullanici_DashboardOtomatikYenilensinMi)
            {
                if (Convert.ToInt32(Genel.AktifKullanici_DashboardYenilemeSuresi) > 0)
                {
                    timerDashboard.Enabled = true;
                    timerDashboard.Interval = Genel.AktifKullanici_DashboardYenilemeSuresi * 60000;
                }
            }
            
        }

        private void dashboardViewer1_Load(object sender, EventArgs e)
        {
            
        }

        public S_Evraklar_Result Evrak = new S_Evraklar_Result(); //Model.S_Evraklar_Result Evrak = new Model.S_Evraklar_Result();
        public void Datagetir()
        {
            //açınca ekran kitleniyor. incelemek lazım.
            //SplashScreenManager.ShowForm(this, typeof(BarduckCRM.Bekleyiniz), true, true);
            //SplashScreenManager.CloseForm();

            Evrak = data.S_Evraklar(DashboardID, true,1).FirstOrDefault(); //Genel.PrmDb.S_Evraklar(DashboardID, true, Genel.DilID).FirstOrDefault();

            var DosyaYolu = data.S_AyarKarakter(2, 1).FirstOrDefault().Deger; //Genel.PrmDb.S_AyarKarakter(2, Genel.DilID).FirstOrDefault().Deger;
            DosyaYolu += Evrak.DosyaAdi + ".xml";
            byte[] bytearry = data.S_DosyaGet(DosyaYolu).FirstOrDefault();
            if (bytearry == null)
            {
                //Ayar.InfoMesajGoster(Genel.DilGetirMesaj(0), Ayar.MesajTipi.Hata, this);
                return;
            }
            Stream RepData = Genel.ByteArrayToStream(bytearry);
            DevExpress.DashboardCommon.Dashboard dasboard = new DevExpress.DashboardCommon.Dashboard();
            dasboard.BeginUpdateLayout();
            dasboard.LoadFromXml(RepData);

            dasboard.DataLoading += dasboard_DataLoading;
            dasboard.EndUpdateLayout();

            //    DataSet datasourcelist = Ayar.DsGetir(DashboardID, MusteriID, ProjeID, AktiviteID, Parametre4, Parametre5, Parametre6, Parametre7, Parametre8, Parametre9, Parametre10);
            ////    dasboard.DataSources.Clear();
            //    foreach (DataTable item in datasourcelist.Tables)
            //    {
            //        dasboard.AddDataSource(item.TableName, item);
            //        //if (dasboard.DataSources.Where(z => z.Name == item.TableName).FirstOrDefault() == null)
            //        //{
            //        //    dasboard.AddDataSource(item.TableName, item);
            //        //} 
            //    }

            if (dasboard != null)
            {
                dashboardViewer1.Dashboard = dasboard;
                
                // dashboardViewer1.PopulateUnusedDataSources = true;
                // dashboardViewer1.ReloadData();
            }

            
        }

        void dasboard_DataLoading(object sender, DashboardDataLoadingEventArgs e)
        {
            try
            {


                if (datasourcedisardan != null)
                {
                    foreach (DataTable item in datasourcedisardan.Tables)
                    {
                        e.Data = item;
                        //if (e.DataSource.Name == item.TableName)
                        //{
                        //    e.Data = item;

                        //}
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

            }
            catch (Exception)
            {


            }
            //        var list = Application.OpenForms;

            //            list[1].BeginInvoke(new Action(() => list[1].Hide()));

            //          var asdf = "";

        }

        private void DashboardPanel_Load(object sender, EventArgs e)
        {
            
        }

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            Datagetir();
        }
    }
}
