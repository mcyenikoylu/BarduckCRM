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
using DevExpress.XtraScheduler;
using DevExpress.DataAccess.ConnectionParameters;
using DevExpress.DashboardCommon;
using DevExpress.DataAccess.Sql;
using DevExpress.XtraBars.Alerter;
using System.IO;
using BarduckCRM;
using BarduckCRM.Properties;

namespace BarduckCRM
{
    public partial class BaglantiKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = 0;
        //bool DuzenlemeModu = false;
        List<S_TipResimli_Result> tipresimli = new List<S_TipResimli_Result>();

        public BaglantiKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void XtraForm3_Load(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                tabPane1.SelectedPageIndex = 0; //tab ların hangisi seçili geleceğini belirler.

                barLblKayitAktifPasif.Caption = "Pasif Kayıt";
                barLblKayitAktifPasif.Glyph = BarduckCRM.Properties.Resources.Apply_16x16;
                barLblKayitID.Caption = "0";
                barLblKayitTarihi.Caption = "0";

                var list = data.S_Tip(-1).ToList();
                if (list.Count > 0)
                {
                    cmbMedeniHali.Properties.DataSource = list.Where(c => c.UstID == 44).ToList();
                    cmbMeslek.Properties.DataSource = list.Where(c => c.UstID == 2).ToList();
                }

                tipresimli = data.S_TipResimli(52).ToList();
                if (tipresimli.Count > 0)
                    cmbOnek.Properties.DataSource = tipresimli;

                var ulkelist = data.S_Ulke(-1).ToList();
                if (ulkelist.Count>0)
                {
                    cmbUlke.Properties.DataSource = ulkelist;
                    cmbUyrugu.Properties.DataSource = ulkelist;
                }

                //var firmalist = data.S_Firma(-1).ToList();
                //if(firmalist.Count>0)
                //    cmbFirma.Properties.DataSource = firmalist;

                if (kayitid > 0)
                    DataGetir(kayitid);

                //if (kayitid > 0)
                //    KayitIzlemeModu(true);

                //FormYetkileri(1);

                var esnekozeltercihler = Data.EsnekKayitlar(1, kayitid).ToList();
                if(esnekozeltercihler.Count >0)                    
                    grdOTT.DataSource = esnekozeltercihler;

                var geneltercihler = Data.EsnekKayitlar(2, kayitid).ToList();
                if (geneltercihler.Count > 0)
                {
                    DataTable dt = Genel.ListToDt(geneltercihler);
                    checkedListBoxControl1.ValueMember = "ID";
                    checkedListBoxControl1.DisplayMember = "Aciklama";
                    checkedListBoxControl1.CheckMember = "Checkbox";
                    checkedListBoxControl1.DataSource = dt;
                }

                Cursor.Current = Cursors.Default;
            }
            catch (Exception hata)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        List<S_Baglanti_Result> list = new List<S_Baglanti_Result>();
        private void DataGetir(int id)
        {
            list = data.S_Baglanti(id).ToList();
            if (list.Count > 0)
            {
                //rgBireyselKurumsal.SelectedIndex = list.FirstOrDefault().Kurumsal == true ? 1 : 0;
                rcReyting.EditValue = list.FirstOrDefault().Reyting;
                txtAdi.Text = list.FirstOrDefault().Adi;
                txtSoyadi.Text = list.FirstOrDefault().Soyadi;
                cmbDogumTarihi.EditValue = list.FirstOrDefault().DogumTarihi;
                cmbMeslek.EditValue = list.FirstOrDefault().Meslek_TipID2;
                cmbOnek.EditValue = list.FirstOrDefault().OnekID;
                cmbMedeniHali.EditValue = list.FirstOrDefault().MedeniHali_TipID44;
                cmbUyrugu.EditValue = list.FirstOrDefault().UyruguID;

                txtAdres.Text = list.FirstOrDefault().Adres;
                txtSehir.Text = list.FirstOrDefault().Sehir;
                txtSemt.Text = list.FirstOrDefault().Semt;
                txtPostaKodu.Text = list.FirstOrDefault().PostaKodu;
                cmbUlke.EditValue = list.FirstOrDefault().UlkeID;

                txtEvTel.Text = list.FirstOrDefault().EvTel;
                toggEvTel.EditValue = list.FirstOrDefault().TanitimEvTel;
                txtCepTel.Text = list.FirstOrDefault().CepTel;
                toggCepTel.EditValue = list.FirstOrDefault().TanitimCepTel;
                txtEPosta.Text = list.FirstOrDefault().Email;
                toggEPosta.EditValue = list.FirstOrDefault().TanitimEPosta;
                //txtIsTel.Text = list.FirstOrDefault().IsTel;
                //toggIsTel.EditValue = list.FirstOrDefault().TanitimIsTel;

                //cmbFirma.EditValue = list.FirstOrDefault().FirmaID;
                //txtUnvan.Text = list.FirstOrDefault().Unvan;
                //txtDahili.Text = list.FirstOrDefault().Dahili;
                tbcPuan.EditValue = list.FirstOrDefault().Puan;

                //memoNotlar.Text = list.FirstOrDefault().Notlar;
                //peResim.EditValue = list.FirstOrDefault().re

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

        private void KayitIzlemeModu(bool durum)
        {
            foreach (Control item in this.Controls)
            {
                if (durum)
                    item.Enabled = false;
                else
                    item.Enabled = true;
            }
            ribbonControl1.Enabled = true;
            ribbonStatusBar1.Enabled = true;
        }

        private void FormYetkileri(int KullaniciID)
        {
            btnDuzenle.Enabled = true;
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                //if(DuzenlemeModu)
                //{

                DateTime? Tarih1 = new DateTime?();
                if (cmbDogumTarihi.EditValue != null && cmbDogumTarihi.DateTime.Year != 1)
                    Tarih1 = Convert.ToDateTime(cmbDogumTarihi.EditValue);
                else
                    Tarih1 = null;

                var list = data.IUD_Baglanti(false, kayitid,
                    txtAdi.Text,
                    txtAdi.Text + " " + txtSoyadi.Text,
                    txtAdres.Text,
                    toggAktif.Checked,
                    true,//rgBireyselKurumsal.SelectedIndex == 0 ? true : false,
                    txtCepTel.Text,
                    -1,
                    "",//txtDahili.Text,
                    Tarih1,
                    txtEPosta.Text,
                    txtEvTel.Text,
                    null,//Convert.ToInt32(cmbFirma.EditValue),
                    "",//txtIsTel.Text,
                    1, //kullanici id
                    true,//rgBireyselKurumsal.SelectedIndex == 1 ? true : false,
                    Convert.ToInt32(cmbMedeniHali.EditValue),
                    Convert.ToInt32(cmbMeslek.EditValue),
                    "",//memoNotlar.Text,
                    Convert.ToInt32(cmbOnek.EditValue),
                    txtPostaKodu.Text,
                    Convert.ToInt32(tbcPuan.EditValue),
                    Convert.ToInt32(rcReyting.EditValue),
                    txtSehir.Text,
                    txtSemt.Text,
                    txtSoyadi.Text,
                    Convert.ToBoolean(toggCepTel.EditValue),
                    Convert.ToBoolean(toggEPosta.EditValue),
                    Convert.ToBoolean(toggEvTel.EditValue),
                    null,//Convert.ToBoolean(toggIsTel.EditValue),
                    DateTime.Now.Date,
                    "",//ülke string
                    Convert.ToInt32(cmbUlke.EditValue),
                    "",//txtUnvan.Text,
                    Convert.ToInt32(cmbUyrugu.EditValue)).ToList();

                //genel tercihler
                string text = string.Empty;
                foreach (object item in checkedListBoxControl1.CheckedItems)
                {
                    DataRowView row = item as DataRowView;
                    text += string.Format("{0},", row.Row.ItemArray[0].ToString());
                }
                text = text.TrimEnd(',');
                Data.EsnekKayitlarKaydet_checkedList(text, kayitid, 2);

                //özel tercihler
                text = "";
                string deger = "";
                for (int i = 0; i < gvOTT.DataRowCount; i++)
                {
                    if(gvOTT.GetRowCellValue(i, "SecilenKayitDegeriNvarchar").ToString().Trim() != "")
                    {
                        text += string.Format("{0},", gvOTT.GetRowCellValue(i, "ID").ToString());
                        deger += string.Format("{0},", gvOTT.GetRowCellValue(i, "SecilenKayitDegeriNvarchar").ToString());
                    }
                }
                text = text.TrimEnd(',');
                deger = deger.TrimEnd(',');
                Data.EsnekKayitlarKaydet_grid(text, kayitid, 1, -1, deger, 0, DateTime.Now);

                MesajVer("Bağlantı başarılı şekilde kayıt edilmiştir.", MesajTipi.Bilgi, this);

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

                //}
                //else
                //    MesajVer("Sadece düzenleme modunda işlem yapabilirsiniz.", MesajTipi.Uyari, this);
            }
            catch (Exception hata)
            {

                
            }
        }

        public enum MesajTipi
        {
            Uyari,
            Hata,
            Onay,
            Bilgi
        };
        public static Timer tmr = new Timer();
        public static AlertControl a;
        static void tmr_Tick(object sender, EventArgs e)
        {
            if (a.AlertFormList.Count > 0)
                a.AlertFormList[0].Close();

            tmr.Enabled = false;
        }

        public static void MesajVer(string Mesaj, MesajTipi Tip, XtraForm OwnerForm, int KacSaniye = 3)
        {
            a = new AlertControl();
            a.FormShowingEffect = AlertFormShowingEffect.SlideVertical;
            a.AppearanceText.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            if (Tip == MesajTipi.Uyari)
                a.AppearanceText.ForeColor = Color.Blue;
            else if (Tip == MesajTipi.Hata)
                a.AppearanceText.ForeColor = Color.Red;

            a.ShowCloseButton = true;
            a.ShowPinButton = false;
            a.AllowHotTrack = false;

            Font fntBaslik = new Font("Arial", 8.3F, FontStyle.Bold | FontStyle.Underline);
            a.AppearanceCaption.Font = fntBaslik;
            Font fntText = new Font("Arial", 8, FontStyle.Regular);
            a.AppearanceText.Font = fntText;


            string Baslik = "";
            Image img = null;
            if (Tip == MesajTipi.Bilgi)
            {
                img = Resources.Info_32x32;
                Baslik = "Bilgi";
            }
            else if (Tip == MesajTipi.Hata)
            {
                img = Resources.Info_32x32;
                Baslik = "Hata";
            }
            else if (Tip == MesajTipi.Onay)
            {
                img = Resources.Info_32x32;
                Baslik = "Onay";
            }
            else if (Tip == MesajTipi.Uyari)
            {
                img = Resources.Info_32x32;
                Baslik = "Uyarı";
            }

            AlertInfo info = new AlertInfo(Baslik, Mesaj);
            info.Image = img;
            tmr.Tick += tmr_Tick;
            tmr.Interval = KacSaniye * 1000;
            tmr.Enabled = true;
            a.Show(OwnerForm, info);
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DuzenlemeModu = true;
            //KayitIzlemeModu(false);
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                data.IUD_Baglanti(true, kayitid, "", "", "", false, false, "", 1, "", null, null, null, -1, "", -1, false, 1, 1, null, -1, "", -1, 1, "", "", "", false, null, null, null, null, null, -1, null, -1);
                MesajVer("Kayıt silinmiştir.", MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void cmbOnek_EditValueChanged(object sender, EventArgs e)
        {
            if (list.FirstOrDefault().OnekID != 0)
            {
                Byte[] image = tipresimli.Where(c => c.ID == Convert.ToInt32(cmbOnek.EditValue)).FirstOrDefault().Resim;
                if (image == null)
                    return;
                MemoryStream imgStream = new MemoryStream(image);
                Image img = Image.FromStream(imgStream);
                cmbOnek.Properties.Buttons[1].Image = img;
            }
        }

        private void btnKaydetVeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void BaglantiKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        //private void cmbFirma_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        //{
        //    if (e.Button.Index == 1) //yeni alan ekle buttonu
        //    {
        //        int seciliFirmaID = Convert.ToInt32(cmbFirma.EditValue);
        //        FirmaKarti frm = new FirmaKarti(-1,true);
        //        frm.ShowDialog();
        //        if (frm.DialogResult == DialogResult.OK)
        //        {
        //            var firmalist = data.S_Firma(-1).ToList();
        //            cmbFirma.Properties.DataSource = firmalist;
        //            cmbFirma.EditValue = frm._FirmaID;
        //        }
        //        else
        //            cmbFirma.EditValue = seciliFirmaID;
        //    }
        //    else if (e.Button.Index == 2) //temizle buttonu
        //    {
        //        cmbFirma.EditValue = -1;
        //    }

        //}

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnTemizle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Alanları temizlemek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {

            }
        }
    }
}