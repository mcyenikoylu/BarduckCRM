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
    public partial class ProjeKarti : DevExpress.XtraEditors.XtraForm
    {
        int KayitID = 0;
        BarduckCRMEntities data = new BarduckCRMEntities();

        public ProjeKarti(int id)
        {
            InitializeComponent();
            KayitID = id;
        }

        private void ProjeKarti_Load(object sender, EventArgs e)
        {
            colCheckbox.Caption = " ";
            colCheckbox1.Caption = " ";
            colCheckbox2.Caption = " ";
            gridColumn3.Caption = " ";
            gridColumn17.Caption = " ";

            if (KayitID > 0)
                DataGetir(KayitID);

            //var odeme = data.S_EsnekKayitData(1, KayitID.ToString(), "", "").ToList();
            //grdOdemeSecemekleri.DataSource = odeme;
            //var banka = data.S_EsnekKayitData(2, KayitID.ToString(), "", "").ToList();
            //grdBankaSecemekleri.DataSource = banka;
            //var doviz = data.S_EsnekKayitData(3, KayitID.ToString(), "", "").ToList();
            //grdDovizSecemekleri.DataSource = doviz;
            //var anafiyatlistesi = data.S_EsnekKayitData(5, KayitID.ToString(), "", "").ToList();
            //grdAnaFiyatListesi.DataSource = anafiyatlistesi;
            //var kullanilacakfiyatlisteleri = data.S_EsnekKayitData(4, KayitID.ToString(), "", "").ToList();
            //grdKullanilacakFiyatListeleri.DataSource = kullanilacakfiyatlisteleri;

            var firma = data.S_Firma(-1).ToList();
            cmbFirma.Properties.DataSource = firma;
        }

        private void DataGetir(int id)
        {
            var list = data.S_Proje(id).ToList();
            if(list.Count>0)
            {
                txtProjeKodu.Text = list.FirstOrDefault().ProjeKodu;
                txtProjeAdi.Text = list.FirstOrDefault().ProjeAdi;
                cmbFirma.EditValue = list.FirstOrDefault().FirmaID;
                cmbOfis.EditValue = 0;
                cmbImalatBaslangicTarihi.EditValue = list.FirstOrDefault().ImalatBaslangic;
                cmbImalatBitisTarihi.EditValue = list.FirstOrDefault().ImalatBitis;
                cmbSatisBaslangicTarihi.EditValue = list.FirstOrDefault().SatisBaslangic;
                cmbSatisBitisTarihi.EditValue = list.FirstOrDefault().SatisBitis;
                toggSatisaUygun.EditValue = list.FirstOrDefault().SatisaUygun;
                toggTeslimeUygun.EditValue = list.FirstOrDefault().TeslimeUygun;
                barToggAktif.Checked = Convert.ToBoolean(list.FirstOrDefault().Aktif);

            }

         

        }
        
        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                data.IUD_Proje(true, KayitID, "", "", null, null, null, null, null, null, null,null,null,1);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnKaydetVeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DateTime? ImalatBaslangicTarihi = new DateTime?();
            if (cmbImalatBaslangicTarihi.EditValue != null && cmbImalatBaslangicTarihi.DateTime.Year != 1)
                ImalatBaslangicTarihi = Convert.ToDateTime(cmbImalatBaslangicTarihi.EditValue);
            else
                ImalatBaslangicTarihi = null;

            DateTime? ImalatBitisTarihi = new DateTime?();
            if (cmbImalatBitisTarihi.EditValue != null && cmbImalatBitisTarihi.DateTime.Year != 1)
                ImalatBitisTarihi = Convert.ToDateTime(cmbImalatBitisTarihi.EditValue);
            else
                ImalatBitisTarihi = null;

            DateTime? SatisBaslangicTarihi = new DateTime?();
            if (cmbSatisBaslangicTarihi.EditValue != null && cmbSatisBaslangicTarihi.DateTime.Year != 1)
                SatisBaslangicTarihi = Convert.ToDateTime(cmbSatisBaslangicTarihi.EditValue);
            else
                SatisBaslangicTarihi = null;

            DateTime? SatisBitisTarihi = new DateTime?();
            if (cmbSatisBitisTarihi.EditValue != null && cmbSatisBitisTarihi.DateTime.Year != 1)
                SatisBitisTarihi = Convert.ToDateTime(cmbSatisBitisTarihi.EditValue);
            else
                SatisBitisTarihi = null;

            var list = data.IUD_Proje(false, KayitID, txtProjeKodu.Text, txtProjeAdi.Text, ImalatBaslangicTarihi,
                ImalatBitisTarihi, SatisBaslangicTarihi, SatisBitisTarihi, DateTime.Now.Date, barToggAktif.Checked,
                Convert.ToBoolean(toggSatisaUygun.EditValue), Convert.ToBoolean(toggTeslimeUygun.EditValue), Convert.ToInt32(cmbFirma.EditValue), 1).ToList();

            //Önce SecmeliAlanID'si tutan tüm kayıtlar T_SecmeliAlanlarData tablosundan siliniyor.
            string SQLScript = "DELETE FROM dbo.T_EsnekKayitData WHERE EsnekKayitQueryID=5 AND KayitID=" + KayitID.ToString() + Environment.NewLine;
            gvAnaFiyatListesi.PostEditor();
            gvAnaFiyatListesi.UpdateCurrentRow();
            //Sonra check ile işaretlenenler insert ediliyor
            for (int i = 0; i < gvAnaFiyatListesi.DataRowCount; i++)
            {
                bool bChecked = Convert.ToBoolean(gvAnaFiyatListesi.GetRowCellValue(i, "Checkbox"));
                int SecilenKayitID = Convert.ToInt32(gvAnaFiyatListesi.GetRowCellValue(i, "ID"));
                if (bChecked)
                {
                    SQLScript += "INSERT INTO T_EsnekKayitData(EsnekKayitQueryID , KayitID, SecilenKayitID) VALUES (" + 5 + "," + KayitID + "," + SecilenKayitID + ")" + Environment.NewLine;
                }
            }
            data.S_QueryCalistir(SQLScript);
            Mesaj.MesajVer("Bağlantı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);

        }

        private void btnKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void ProjeKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}