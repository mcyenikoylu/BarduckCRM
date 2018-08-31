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

namespace BarduckCRM
{
    public partial class KullaniciKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int KullaniciID = -1;
        public KullaniciKarti(int _KullaniciID)
        {
            InitializeComponent();
            KullaniciID = _KullaniciID;
        }

        private void KullaniciKarti_Load(object sender, EventArgs e)
        {
            tabPane1.SelectedPageIndex = 2;

            var perlist = data.S_Personel(-1).ToList();
            if(perlist.Count>0)
                cmbPersonel.Properties.DataSource = perlist;

            var dashlist = data.S_Evraklar(-1, true, -1).ToList();
            if (dashlist.Count > 0)
                cmbDashboard.Properties.DataSource = dashlist;

            var list = data.S_Kullanici(KullaniciID).ToList();
            if(list.Count>0)
            {
                txtKullaniciAdi.Text = list.FirstOrDefault().KullaniciAdi;
                txtParola.Text = list.FirstOrDefault().Parola;
                txtEPosta.Text = list.FirstOrDefault().EPosta;
                cmbPersonel.EditValue = list.FirstOrDefault().PersonelID;
            }

            var ayarlist = data.S_KullaniciAyarlari(KullaniciID).ToList();
            if(ayarlist.Count>0)
            {
                toggDashboardOtomatikYenilensin.EditValue = ayarlist.FirstOrDefault().DashboardYenileme;
                txtDashboardYenilenmeSuresi.EditValue = ayarlist.FirstOrDefault().DashboardYenilemeSure;
                cmbDashboard.EditValue = ayarlist.FirstOrDefault().DashboardID;
            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_KullaniciAyarlari(KullaniciID, "", "", null, "", false, 0, Convert.ToInt32( cmbDashboard.EditValue), Convert.ToBoolean( toggDashboardOtomatikYenilensin.EditValue), 
                Convert.ToInt32(txtDashboardYenilenmeSuresi.EditValue),1);
        }

        private void btnKaydetveKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_KullaniciAyarlari(KullaniciID, "", "", null, "", false, 0, Convert.ToInt32( cmbDashboard.EditValue), Convert.ToBoolean( toggDashboardOtomatikYenilensin.EditValue), 
                Convert.ToInt32(txtDashboardYenilenmeSuresi.EditValue),1);
            this.Close();
        }
    }
}