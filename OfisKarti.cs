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
    public partial class OfisKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public OfisKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void OfisKarti_Load(object sender, EventArgs e)
        {
            var personel = data.S_Personel(-1).ToList();
            cmbYetkiliPersonel.Properties.DataSource = personel;
            cmbKarsilamaPersoneli.Properties.DataSource = personel;
            var ulke = data.S_Ulke(-1).ToList();
            cmbUlke.Properties.DataSource = ulke;

            if (kayitid > 0)
                DataGetir(kayitid);
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_Ofis(false, 1, kayitid, -1, txtOfisKodu.Text, txtOfisAdi.Text, Convert.ToInt32( cmbUlke.EditValue),
                txtSehir.Text, txtSemt.Text, txtAdres.Text, Convert.ToInt32( cmbYetkiliPersonel.EditValue), Convert.ToInt32( cmbKarsilamaPersoneli.EditValue), Convert.ToBoolean(toggAktif.Checked),
                DateTime.Now.Date, 1, DateTime.Now, -1, null);
            Mesaj.MesajVer("Ofis Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
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
                data.IUD_Ofis(true, 1, -1, -1, "", "", -1, "", "", "", -1, -1, null, null, -1, null, -1, null);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void OfisKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DataGetir(int dataid)
        {
            var list = data.S_Ofis(dataid).ToList();
            if(list.Count>0)
            {
                txtOfisKodu.Text = list.FirstOrDefault().OfisKodu;
                txtOfisAdi.Text = list.FirstOrDefault().OfisAdi;
                cmbUlke.EditValue = list.FirstOrDefault().UlkeID;
                txtAdres.Text = list.FirstOrDefault().Adres;
                txtSehir.Text = list.FirstOrDefault().Sehir;
                txtSemt.Text = list.FirstOrDefault().Semt;
                toggAktif.Checked = Convert.ToBoolean( list.FirstOrDefault().Aktif);
                cmbKarsilamaPersoneli.EditValue = Convert.ToInt32(list.FirstOrDefault().KarsilamaPersoneliID);
                cmbYetkiliPersonel.EditValue = Convert.ToInt32(list.FirstOrDefault().YetkiliPersonelID);
            }
        }
    }
}