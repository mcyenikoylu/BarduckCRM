using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.DashboardCommon;
using BarduckCRM;
using System.IO;

namespace BarduckCRM
{
    public partial class DashboardKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        int DashboardID = 0;
        string DosyaAdi = "";
        public DashboardKarti(int _DashboardID, string _DosyaAdi)
        {
            InitializeComponent();
            DashboardID = _DashboardID;
            DosyaAdi = _DosyaAdi;
        }

        private void btnKaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            DevExpress.DashboardCommon.Dashboard rep = new DevExpress.DashboardCommon.Dashboard();

            int iEkleyenID = 0;

            iEkleyenID = Genel.AktifKullaniciID;

            DashboardParameter prmUser = new DashboardParameter();
            prmUser.Name = "EkleyenID";
            prmUser.Type = typeof(System.Int32);
            prmUser.Value = iEkleyenID;
            prmUser.Description = "EkleyenID";
            prmUser.Visible = false;
            rep.Parameters.Add(prmUser);

            MemoryStream stream = new MemoryStream();
            rep.SaveToXml(stream);
            stream.Position = 0;
            byte[] RaporData = Genel.StreamToByteArray(stream);


            var IslemEkle = data.IUD_Evraklar(1, -1, RaporData, txtAdi.Text, txtAdi.Text, -1,
                -1, true, false, -1, -1,
                true, Genel.AktifKullaniciID).ToList();

            if (IslemEkle != null && IslemEkle.FirstOrDefault().ID > 0)
            {
                //Ayar.InfoMesajGoster(Genel.DilGetirMesaj(1017), Ayar.MesajTipi.Bilgi, this);
            }

        }

        private void DashboardKarti_Load(object sender, EventArgs e)
        {
            var list = data.S_Evraklar(DashboardID, true, 1).ToList();
            if(list.Count>0)
                txtAdi.Text = list.FirstOrDefault().EvrakTanimBasligi;
        }

        private void btnTasarim_ItemClick(object sender, ItemClickEventArgs e)
        {
            //DevExpress.DashboardCommon.Dashboard dasboard = new DevExpress.DashboardCommon.Dashboard();

            //var DosyaYolu = data.S_AyarKarakter(2, 1).ToList().FirstOrDefault().Deger + "dash.xml";//gv.GetRowCellValue(iRowID, "DosyaAdi").ToString() + ".xml"; 
            //if (DosyaYolu == null)
            //    return;

            //byte[] bytearry = data.S_DosyaGet(DosyaYolu).FirstOrDefault();
            //if (bytearry != null)
            //{
            //    Stream RepData = Genel.ByteArrayToStream(bytearry);
            //    dasboard.LoadFromXml(RepData);
            //}



            ////DataSet datasourcelist = Ayar.DsGetir(iSelectedReportID, 1, 1, 1, 1, 1, 1, 1, 1, 1, 99, true);
            //////dasboard.DataSources.Clear();
            ////foreach (DataTable item in datasourcelist.Tables)
            ////{

            ////    if (dasboard.DataSources.Where(z => z.Name == item.TableName).FirstOrDefault() == null)
            ////    {
            ////        dasboard.AddDataSource(item.TableName, item);
            ////    }
            ////}
            ////dasboard.DataLoading += dasboard_DataLoading;

            //DashboardTasarim frm = new DashboardTasarim(dasboard);
            //frm.Show();

            #region Dashboard
            var DosyaYolu = data.S_AyarKarakter(2, 1).FirstOrDefault().Deger + DosyaAdi + ".xml";
            byte[] bytearry = data.S_DosyaGet(DosyaYolu).FirstOrDefault();
            if(bytearry != null)
            {
                Stream RepData = Genel.ByteArrayToStream(bytearry);
                DevExpress.DashboardCommon.Dashboard dasboard = new DevExpress.DashboardCommon.Dashboard();
                dasboard.LoadFromXml(RepData);

                DataSet datasourcelist = Genel.DsGetir(DashboardID, true);
                //dasboard.DataSources.Clear();
                foreach (DataTable item in datasourcelist.Tables)
                {
                    if (dasboard.DataSources.Where(z => z.Name == item.TableName).FirstOrDefault() == null)
                    {
                        dasboard.AddDataSource(item.TableName, item);
                    }
                }
                dasboard.DataLoading += dasboard_DataLoading;

                DashboardTasarim rep = new DashboardTasarim(dasboard);

                rep.ShowDialog();

                if (rep.SaveDashboard)
                {
                    MemoryStream stream = new MemoryStream();
                    rep.Dashboard.SaveToXml(stream);
                    stream.Position = 0;
                    byte[] RaporData = Genel.StreamToByteArray(stream);
                    data.IUD_Evraklar(4, DashboardID, RaporData, null, null, null, null, null, null, null, null, true, Genel.AktifKullaniciID);
                }
            }
            
            
            #endregion
        }

        private void dasboard_DataLoading(object sender, DashboardDataLoadingEventArgs e)
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
}