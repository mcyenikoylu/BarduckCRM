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
using BarduckCRM;

namespace BarduckCRM
{
    public partial class PersonelKarti : DevExpress.XtraBars.Ribbon.RibbonForm 
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public PersonelKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }
        private void XtraForm2_Load(object sender, EventArgs e)
        {
            //var cinsiyet = data.S_Personel(kayitid).ToList();
            //cmbCinsiyet.Properties.DataSource = cinsiyet;

            var cinsiyet = data.S_Tip(72).ToList();
            cmbCinsiyet.Properties.DataSource = cinsiyet;

            var onek = data.S_TipResimli(52).ToList();
            cmbOnek.Properties.DataSource = onek;

            var ulke = data.S_Ulke(-1).ToList();
            cmbUlke.Properties.DataSource = ulke;

            var ofis = data.S_Ofis(-1).ToList();
            cmbOfis.Properties.DataSource = ofis;

            var departman = data.S_Tip(1).ToList();
            cmbDepartman.Properties.DataSource = departman;

            var personeltakimi = data.S_Tip(3).ToList();
            cmbPersonelTakimi.Properties.DataSource = personeltakimi;

            if (kayitid > 0)
                DataGetir(kayitid);
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                data.IUD_Personel(false, kayitid, txtAd.Text, Convert.ToInt32(cmbDepartman.EditValue),
                txtAdres.Text, txtSehir.Text, Convert.ToInt32(cmbUlke.EditValue), txtTelCep.Text,
                txtTelEv.Text, DateTime.Now.Date,
                txtEPosta.Text, Convert.ToBoolean(toggAktif.Checked),
                txtSkype.Text, txtSoyad.Text, Convert.ToInt32(cmbCinsiyet.EditValue),
                Convert.ToDateTime(cmbDogumTarihi.EditValue), 1, DateTime.Now, 1,
                DateTime.Now, txtUnvan.Text, Convert.ToInt32(cmbOnek.EditValue),
                txtSemt.Text, txtPostaKodu.Text, Convert.ToInt32(cmbOfis.EditValue),
                Convert.ToInt32(cmbPersonelTakimi.EditValue),
               Convert.ToDateTime(cmbIseBanlangicTarihi.EditValue),
               Convert.ToDateTime(cmbIstenAyrilmaTarihi.EditValue));
                Mesaj.MesajVer("Personel Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnKaydetVeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                data.IUD_Personel(true, kayitid, "", -1, "", "", -1, "", "", null, "", null, "", "", -1, null, -1, null, -1, null, "", -1, "", "", -1, -1, null, null);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PersonelKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DataGetir(int gelenid)
        {
            var list = data.S_Personel(gelenid).ToList();
            if(list.Count>0)
            {
                txtAd.Text = list.FirstOrDefault().Adi;
                txtSoyad.Text = list.FirstOrDefault().Soyadi;
                cmbCinsiyet.EditValue = list.FirstOrDefault().Cinsiyeti_TipID72;
                cmbDogumTarihi.EditValue = list.FirstOrDefault().DogumTarihi;
                txtUnvan.Text = list.FirstOrDefault().Unvan;
                cmbOnek.EditValue = list.FirstOrDefault().OnekID;
                txtAdres.Text = list.FirstOrDefault().Adres;
                txtSehir.Text = list.FirstOrDefault().Sehir;
                txtSemt.Text = list.FirstOrDefault().Semt;
                cmbUlke.EditValue = list.FirstOrDefault().UlkeID;
                txtPostaKodu.Text = list.FirstOrDefault().PostaKodu;
                txtTelEv.Text = list.FirstOrDefault().EvTel;
                txtTelCep.Text = list.FirstOrDefault().CepTel;
                txtEPosta.Text = list.FirstOrDefault().Email;
                txtSkype.Text = list.FirstOrDefault().Skype;
                cmbOfis.EditValue = list.FirstOrDefault().OfisID;
                cmbDepartman.EditValue = list.FirstOrDefault().Departman_TipID1;
                cmbPersonelTakimi.EditValue = list.FirstOrDefault().PersonelTakimID;
                cmbIseBanlangicTarihi.EditValue = list.FirstOrDefault().IseBaslangicTarihi;
                cmbIstenAyrilmaTarihi.EditValue = list.FirstOrDefault().IstenAyrilisTarihi;

            }
        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}