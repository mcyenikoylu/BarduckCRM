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
using BarduckCRM;

namespace BarduckCRM
{
    public partial class SadakatPuani : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = 0;
        decimal puan = 0;
        decimal islempuani = 0;
        decimal toplampuan = 0;
        public SadakatPuani(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void SadakatPuani_Load(object sender, EventArgs e)
        {
            var list = data.S_SadakatPuaniHesapla(1).ToList();
            puan = Convert.ToDecimal( list.FirstOrDefault().PuanMiktari);
            toplampuan = puan;
            digitalGauge1.Text = puan.ToString();
            var puankategori = data.S_Tip(75).ToList();
            cmbPuanKategorisi.Properties.DataSource = puankategori;
            var musterilist = data.S_Baglanti(kayitid).ToList();
            lblAdiSoyadi.Text = musterilist.FirstOrDefault().AdiSoyadi;
        }

        private void btnKaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(Convert.ToDecimal(txtIslemYapilacakPuan.EditValue) != 0)
            {
                Mesaj.MesajVer("Girişini yapmış olduğunuz puanı henüz eklemediniz. Kaydetmeden önce lütfen ekle butonuna basınız.", Mesaj.MesajTipi.Bilgi, this); return;
            }

            if(islempuani == 0)
            {
                Mesaj.MesajVer("İşlem puanı sıfır (0) olamaz", Mesaj.MesajTipi.Bilgi, this); return;
            }

            islempuani = puan - toplampuan;
            data.IUD_SadakatPuaniHesapla(kayitid, islempuani, memoAciklama.Text, Convert.ToDateTime( cmbTarih.EditValue), Convert.ToInt32( cmbPuanKategorisi.EditValue));
            Mesaj.MesajVer("Puan başarıyla eklenmiştir.", Mesaj.MesajTipi.Bilgi, this);
        }

        private void btnKaydetVeKapat_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.Close();
        }

        private void btnPuanEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            islempuani = Convert.ToDecimal(txtIslemYapilacakPuan.EditValue);
            puan = puan + islempuani;
            digitalGauge1.Text = puan.ToString();
            txtIslemYapilacakPuan.EditValue = 0;
        }

        private void btnPuanCikart_ItemClick(object sender, ItemClickEventArgs e)
        {
            islempuani = Convert.ToDecimal(txtIslemYapilacakPuan.EditValue);
            puan = puan - islempuani;
            digitalGauge1.Text = puan.ToString();
            txtIslemYapilacakPuan.EditValue = 0;
        }

        private void btnKapat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}