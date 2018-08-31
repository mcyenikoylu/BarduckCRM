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
using System.Diagnostics;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class BaglantiHareketiKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = 0;
        int baglantiid = 0;
        public BaglantiHareketiKarti(int id, int _baglantiid)
        {
            InitializeComponent();
            kayitid = id;
            baglantiid = _baglantiid;
        }

        private void BaglantiHareketi_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                tabPane1.SelectedPageIndex = 0;

                barLblKayitAktifPasif.Caption = "Pasif Kayıt";
                barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x16;
                barLblKayitID.Caption = "0";
                barLblKayitTarihi.Caption = "0";

                var durdurulacakhareketler = data.S_DurdurulacakBaglantiHareketleri(baglantiid).ToList();
                if (durdurulacakhareketler.Count > 0)
                    cmbDurdurulacakHareket.Properties.DataSource = durdurulacakhareketler;

                var hareketdurumu = data.S_Tip(26).ToList();
                if (hareketdurumu.Count > 0)
                    cmbHareketDurumu.Properties.DataSource = hareketdurumu;

                var hareketkaynagi = data.S_Tip(43).ToList();
                if (hareketkaynagi.Count > 0)
                    cmbHareketKaynagi.Properties.DataSource = hareketkaynagi;

                var harekettipi = data.S_Tip(17).ToList();
                if (harekettipi.Count > 0)
                    cmbHareketTipi.Properties.DataSource = harekettipi;

                var ofis = data.S_Ofis(-1).ToList();
                if (ofis.Count > 0)
                    cmbOfis.Properties.DataSource = ofis;

                var personel = data.S_Personel(-1).ToList();
                if (personel.Count > 0)
                    cmbPersonel.Properties.DataSource = personel;

                if (kayitid > 0)
                    DataGetir(kayitid);
                else
                {
                    timerSure.Enabled = true;
                    var baglanti = data.S_Baglanti(baglantiid).ToList();
                    lblAdiSoyadi.Text = baglanti.FirstOrDefault().AdiSoyadi;
                    lblMeslek.Text = baglanti.FirstOrDefault().Meslek_TipID2_STR + ", " + baglanti.FirstOrDefault().Sehir;
                    cmbHareketTarihi.EditValue = DateTime.Now.Date;
                    cmbHareketSaati.EditValue = DateTime.Now.ToShortTimeString();
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception hata)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        string sure = "00:00:00";
        bool randevu = false;
        int randevuid = 0;
        bool hatirlatma = false;
        int hatirlatmaid = 0;
        int kampanyaid = 0;
        int epostahareketiid = 0;
        int seskaydihareketiid = 0;
        int smshareketiid = 0;

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                timerSure.Enabled = false;
                var list = data.IUD_BaglantiHareketleri(false, kayitid, baglantiid, Convert.ToInt32(cmbPersonel.EditValue),
                    Convert.ToDateTime(cmbHareketTarihi.EditValue), Convert.ToDateTime(cmbHareketSaati.EditValue),
                    sure, Convert.ToInt32(cmbOfis.EditValue), Convert.ToInt32(cmbHareketTipi.EditValue), Convert.ToInt32(cmbHareketKaynagi.EditValue),
                    memoNotu.Text, Convert.ToInt32(cmbHareketDurumu.EditValue), Convert.ToInt32(trackBarControl_HareketPuani.EditValue),
                    Convert.ToBoolean(toggDevamEdecekHareket.EditValue), Convert.ToInt32(cmbDurdurulacakHareket.EditValue), randevu, randevuid, hatirlatma, hatirlatmaid, 
                    kampanyaid,
                    Convert.ToBoolean(toggAktif.Checked), Genel.AktifKullaniciID, DateTime.Now, Genel.AktifKullaniciID, DateTime.Now, Convert.ToBoolean(toggSMS.EditValue),
                    Convert.ToBoolean(toggEPosta.EditValue), Convert.ToBoolean(toggTelefon.EditValue), epostahareketiid, seskaydihareketiid, smshareketiid).ToList();
                
                Mesaj.MesajVer("Bağlanti Hareketi Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);

                barLblKayitID.Caption = list.FirstOrDefault().ID.ToString();
                barLblKayitTarihi.Caption = list.FirstOrDefault().Tarih.ToString();
                if (Convert.ToBoolean(list.FirstOrDefault().Aktif))
                {
                    barLblKayitAktifPasif.Caption = "Aktif Kayıt";
                    barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x161;
                }
                else
                {
                    barLblKayitAktifPasif.Caption = "Pasif Kayıt";
                    barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x16;
                }

            }
            catch (Exception hata)
            {

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
                data.IUD_BaglantiHareketleri(true, kayitid, baglantiid, -1, null, null, "", -1, -1, -1, "", -1, -1, false, -1, false, -1, false, -1, -1, false, -1, null, -1, null, false, false, false, -1, -1, -1);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BaglantiHareketiKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerSure.Enabled = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DataGetir(int dataid)
        {
            var list = data.S_BaglantiHareketleri(kayitid, -1).ToList();
            if (list.Count > 0)
            {
                toggAktif.Checked = Convert.ToBoolean(list.FirstOrDefault().Aktif);
                //gaugeControl_HareketSuresi.

                toggEPosta.EditValue = list.FirstOrDefault().TanitimTercihiEPosta;
                toggSMS.EditValue = list.FirstOrDefault().TanitimTercihiSMS;
                toggTelefon.EditValue = list.FirstOrDefault().TanitimTercihiTelefon;

                cmbHareketTarihi.EditValue = list.FirstOrDefault().Tarih;
                cmbHareketSaati.EditValue = list.FirstOrDefault().Saat;
                cmbPersonel.EditValue = list.FirstOrDefault().PersonelID;
                cmbOfis.EditValue = list.FirstOrDefault().OfisID;
                cmbHareketTipi.EditValue = list.FirstOrDefault().HareketTipi_TipID17;
                cmbHareketKaynagi.EditValue = list.FirstOrDefault().HareketKaynagi_TipID43;

                cmbHareketDurumu.EditValue = list.FirstOrDefault().HareketDurumTipi_Tip26;
                memoNotu.Text = list.FirstOrDefault().AciklamaNotu;
                trackBarControl_HareketPuani.EditValue = list.FirstOrDefault().HareketPuani;
                toggDevamEdecekHareket.EditValue = list.FirstOrDefault().DevamEdenHareket;
                cmbDurdurulacakHareket.EditValue = list.FirstOrDefault().DurdurulanHareketID;

                var baglanti = data.S_Baglanti(baglantiid).ToList();
                lblAdiSoyadi.Text = baglanti.FirstOrDefault().AdiSoyadi;
                lblMeslek.Text = baglanti.FirstOrDefault().Meslek_TipID2_STR + ", " + baglanti.FirstOrDefault().Sehir;

                sure = list.FirstOrDefault().Sure;
                digitalGauge1.Text = sure;

                barLblKayitID.Caption = list.FirstOrDefault().ID.ToString();
                barLblKayitTarihi.Caption = list.FirstOrDefault().Tarih.ToString();
                if (Convert.ToBoolean(list.FirstOrDefault().Aktif))
                {
                    barLblKayitAktifPasif.Caption = "Aktif Kayıt";
                    barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x161;
                }
                else
                {
                    barLblKayitAktifPasif.Caption = "Pasif Kayıt";
                    barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x16;
                }
            }
        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            timerSure.Enabled = false;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        decimal saat = 0;
        decimal dakika = 0;
        decimal saniye = 0;


        string _saat = "";
        string _dakika = "";
        string _saniye = "";



        private void timerSure_Tick(object sender, EventArgs e)
        {
            saniye++;

            if (saniye == 60)
            {
                saniye = 0;
                dakika++;
            }

            if (dakika == 60)
            {
                dakika = 0;
                saat++;
            }

            if (saniye < 10)
                _saniye = "0" + saniye.ToString();
            else
                _saniye = saniye.ToString();

            if (dakika < 10)
                _dakika = "0" + dakika.ToString();
            else
                _dakika = dakika.ToString();

            if (saat < 10)
                _saat = "0" + saat.ToString();
            else
                _saat = saat.ToString();

            sure = _saat + ":" + _dakika + ":" + _saniye;
            digitalGauge1.Text = sure;

        }
    }
}