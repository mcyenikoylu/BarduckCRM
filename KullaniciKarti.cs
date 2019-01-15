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

            if(KullaniciID>0)
            {
                var list = data.S_Kullanici(KullaniciID).ToList();
                if (list.Count > 0)
                {
                    txtKullaniciAdi.Text = list.FirstOrDefault().KullaniciAdi;
                    txtParola.Text = list.FirstOrDefault().Parola;
                    txtEPosta.Text = list.FirstOrDefault().EPosta;
                    cmbPersonel.EditValue = list.FirstOrDefault().PersonelID;
                }
            }
            else
            {
                txtKullaniciAdi.Text = "";
                txtParola.Text = "";
                txtEPosta.Text = "";
                cmbPersonel.EditValue = -1;
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
            var list = data.S_KullaniciKontrol(txtKullaniciAdi.Text).ToList();
            if(list.FirstOrDefault().ID>0)
            {
                XtraMessageBox.Show("Kullanıcı Adi daha önce kayıt edilmiştir.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                data.IUD_Kullanici(false,
                KullaniciID,
                txtKullaniciAdi.Text,
                txtParola.Text,
                txtEPosta.Text,
                Convert.ToInt32(cmbPersonel.EditValue));
                data.IUD_KullaniciAyarlari(KullaniciID, "", "", null, "", false, 0,
                    Convert.ToInt32(cmbDashboard.EditValue), Convert.ToBoolean(toggDashboardOtomatikYenilensin.EditValue),
                    Convert.ToInt32(txtDashboardYenilenmeSuresi.EditValue), 1);
                Mesaj.MesajVer("Kullanıcı Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);

            }
        }

        private void btnKaydetveKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_Kullanici(false,
                KullaniciID,
                txtKullaniciAdi.Text,
                txtParola.Text,
                txtEPosta.Text,
                Convert.ToInt32(cmbPersonel.EditValue));
            data.IUD_KullaniciAyarlari(KullaniciID, "", "", null, "", false, 0, 
                Convert.ToInt32( cmbDashboard.EditValue), 
                Convert.ToBoolean( toggDashboardOtomatikYenilensin.EditValue), 
                Convert.ToInt32(txtDashboardYenilenmeSuresi.EditValue),1);
            Mesaj.MesajVer("Kullanıcı Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void KullaniciKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}