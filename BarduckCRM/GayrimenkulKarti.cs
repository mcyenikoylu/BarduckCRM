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
    public partial class GayrimenkulKarti : DevExpress.XtraEditors.XtraForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public GayrimenkulKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void GayrimenkulKarti_Load(object sender, EventArgs e)
        {
            //var 
            //cmbBlok

            if (kayitid > 0)
                DataGetir(-1);
           
        }

        private void DataGetir(int kayitdegeri)
        {
            var list = data.S_Gayrimenkul(kayitdegeri).ToList();
            if(list.Count>0)
            {
                cmbProje.EditValue = list.FirstOrDefault().ProjeID;
                cmbGayrimenkulTipi.EditValue = list.FirstOrDefault().GayrimenkulTipi_TipID84;
                cmbYapiTipi.EditValue = list.FirstOrDefault().YapiTipi_TipID85;
                cmbBlok.EditValue = list.FirstOrDefault().BlokID;
                cmbBlokGiris.EditValue = list.FirstOrDefault().BlokGiris_TipID86;
                cmbKat.EditValue = list.FirstOrDefault().KatID;
                txtDaireNo.Text = list.FirstOrDefault().DaireNo;
                cmbYon.EditValue = list.FirstOrDefault().Yon_TipID87;
                cmbManzara.EditValue = list.FirstOrDefault().Manzara_TipID88;
                txtOdaSayisi.EditValue = list.FirstOrDefault().OdaSayisi;

                txtBrutMetrekare.EditValue = list.FirstOrDefault().BrutM2;
                txtNetMetrekare.EditValue = list.FirstOrDefault().NetM2;
                txtEklentiMetrekare.EditValue = list.FirstOrDefault().EklentiM2;
                txtKatMetrekare.EditValue = list.FirstOrDefault().KatBrutM2;
                txtBalkonMetrekare.EditValue = list.FirstOrDefault().BalkonM2;
                txtTerasMetrekare.EditValue = list.FirstOrDefault().TerasM2;
                txtBahceMetrekare.EditValue = list.FirstOrDefault().BahceM2;
                txtGenelBrutMetrekare.EditValue = list.FirstOrDefault().GenelBrutM2;
                txtAdaMetrekare.EditValue = list.FirstOrDefault().AdaM2;
                txtPaftaMetrekare.EditValue = list.FirstOrDefault().PaftaM2;
                txtParselMetrekare.EditValue = list.FirstOrDefault().ParselM2;

                txtOtoparkAdedi.EditValue = list.FirstOrDefault().OtoParkAdedi;
                txtOtoparkNo.Text = list.FirstOrDefault().OtoParkNo;
                cmbOtoparkTipi.EditValue = list.FirstOrDefault().OtoParkTipi_TipID89;

                txtTapuKat.Text = list.FirstOrDefault().TapuKat;
                txtTapuNo.Text = list.FirstOrDefault().TapuBagNo;
                txtTapuBlok.Text = list.FirstOrDefault().TapuBlok;

                toggSatisaKapali.EditValue = list.FirstOrDefault().SatisaKapali;
                memoSatisaKapali.Text = list.FirstOrDefault().SatisaKapaliNotu;

                txtFiyat.EditValue = list.FirstOrDefault().Fiyat;
                cmbFiyatDoviz.EditValue = list.FirstOrDefault().DovizID;
                toggKDV.EditValue = list.FirstOrDefault().Kdv;
                txtKDVOrani.EditValue = list.FirstOrDefault().KdvOrani;

                toggAktif.Checked = Convert.ToBoolean(list.FirstOrDefault().Aktif);
            }
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            data.IUD_Gayrimenkul(false, kayitid, Convert.ToInt32(cmbProje),
                Convert.ToInt32(cmbGayrimenkulTipi.EditValue),
                Convert.ToInt32(cmbYapiTipi.EditValue),
                Convert.ToInt32(cmbBlok.EditValue),
                Convert.ToInt32(cmbBlokGiris.EditValue),
                Convert.ToInt32(cmbKat.EditValue),
                txtDaireNo.Text,
                Convert.ToInt32(cmbYon.EditValue),
                Convert.ToInt32(cmbManzara.EditValue),
                Convert.ToInt32(txtOdaSayisi.EditValue),
                Convert.ToDecimal(txtBrutMetrekare.EditValue),
                Convert.ToDecimal(txtNetMetrekare.EditValue),
                Convert.ToDecimal(txtEklentiMetrekare.EditValue),
                Convert.ToDecimal(txtKatMetrekare.EditValue),
                Convert.ToDecimal(txtBalkonMetrekare.EditValue),
                Convert.ToDecimal(txtTerasMetrekare.EditValue),
                Convert.ToDecimal(txtBahceMetrekare.EditValue),
                Convert.ToDecimal(txtGenelBrutMetrekare.EditValue),
                Convert.ToDecimal(txtAdaMetrekare.EditValue),
                Convert.ToDecimal(txtPaftaMetrekare.EditValue),
                Convert.ToDecimal(txtParselMetrekare.EditValue),
                Convert.ToInt32(txtOtoparkAdedi.EditValue),
                txtOtoparkNo.Text,
                Convert.ToInt32(cmbOtoparkTipi.EditValue),
                txtTapuKat.Text,
                txtTapuNo.Text,
                txtTapuBlok.Text,
                Convert.ToBoolean(toggSatisaKapali.EditValue),
                memoSatisaKapali.Text,
                toggAktif.Checked,
                DateTime.Now.Date,
                Genel.AktifKullaniciID,
                DateTime.Now,
                Genel.AktifKullaniciID,
                DateTime.Now,
                Convert.ToDecimal(txtFiyat.EditValue),
                Convert.ToInt32(cmbFiyatDoviz.EditValue),
                Convert.ToBoolean(toggKDV.EditValue),
                Convert.ToDecimal(txtKDVOrani.Text));
            Mesaj.MesajVer("Gayrimenkul Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
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

        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GayrimenkulKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void txtKDVTutari_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}