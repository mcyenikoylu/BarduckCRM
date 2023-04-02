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
    public partial class VaziyetKarti : DevExpress.XtraEditors.XtraForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public VaziyetKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void VaziyetKarti_Load(object sender, EventArgs e)
        {
            var projelist = data.S_Proje(-1).ToList();
            cmbProje.Properties.DataSource = projelist;

            var yasamlist = data.S_Tip(78).ToList();
            cmbYasamAlaniOzellikleri.Properties.DataSource = yasamlist;

            var resimlist = data.S_Resim(-1, 83).ToList();
            cmbVaziyetinResmi.Properties.DataSource = resimlist;

            if (kayitid > 0)
                DataGetir(kayitid);


        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_Vaziyet(false, kayitid, Convert.ToInt32(cmbProje.EditValue), txtAdres.Text, Convert.ToDecimal(txtMetrekare.Text), txtPaftaNo.Text,
                txtCiltNo.Text, txtSehir.Text, txtIlceNo.Text, txtMahalle.Text, txtKoy.Text, txtBucak.Text, txtSokak.Text, txtAdaNo.Text, txtYevmiyeNo.Text,
                txtSahifeNo.Text, txtSiraNo.Text, "", "", txtVaziyetAdi.Text, txtVaziyetKodu.Text, txtYapiBinaAdedi.Text, txtKapiGayrimenkulAdedi.Text, Convert.ToDecimal(txtYesilAlanM2.Text),
               Convert.ToInt32(cmbVaziyetinResmi.EditValue), DateTime.Now.Date, Convert.ToBoolean(toggAktif.Checked), DateTime.Now, Genel.AktifKullaniciID, null, -1);
            Mesaj.MesajVer("Vaziyet Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
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
                data.IUD_Vaziyet(false, kayitid, -1, "", null, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", null, -1, null, null, null, -1, null, -1);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void VaziyetKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

    
        private void DataGetir(int dataid)
        {
            var list = data.S_Vaziyet(dataid).ToList();
            if (list.Count > 0)
            {
                txtVaziyetAdi.Text = list.FirstOrDefault().VaziyetAdi;
                txtVaziyetKodu.Text = list.FirstOrDefault().VaziyetKodu;
                cmbProje.EditValue = list.FirstOrDefault().ProjeID;
                txtYapiBinaAdedi.Text = list.FirstOrDefault().YapiAdedi;
                txtKapiGayrimenkulAdedi.Text = list.FirstOrDefault().KapiAdedi;
                //cmbYasamAlaniOzellikleri
                txtYesilAlanM2.Text = list.FirstOrDefault().YesilAlan.ToString();
                cmbVaziyetinResmi.EditValue = list.FirstOrDefault().VaziyetResimID;
                txtMetrekare.Text = list.FirstOrDefault().Metrekare.ToString();
                txtPaftaNo.Text = list.FirstOrDefault().PaftaNo;
                txtCiltNo.Text = list.FirstOrDefault().CiltNo;
                txtSehir.Text = list.FirstOrDefault().Sehir;
                txtIlceNo.Text = list.FirstOrDefault().Ilce;
                txtMahalle.Text = list.FirstOrDefault().Mahalle;
                txtKoy.Text = list.FirstOrDefault().Koy;
                txtBucak.Text = list.FirstOrDefault().Bucak;
                txtSokak.Text = list.FirstOrDefault().Sokak;
                txtAdaNo.Text = list.FirstOrDefault().AdaNo;
                txtYevmiyeNo.Text = list.FirstOrDefault().YevmiyeNo;
                txtAdaNo.Text = list.FirstOrDefault().AdaNo;
                txtYevmiyeNo.Text = list.FirstOrDefault().YevmiyeNo;
                txtSahifeNo.Text = list.FirstOrDefault().SahifeNo;
                txtSiraNo.Text = list.FirstOrDefault().SahifeNo;
                txtAdres.Text = list.FirstOrDefault().Adres;
            }
        }
    }
}