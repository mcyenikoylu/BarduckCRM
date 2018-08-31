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
    public partial class FirmaKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public int _FirmaID
        {
            get { return kayitid; }
            set { kayitid = value; }
        }

        bool _baglantiEkranindanAcildi = false;
        public FirmaKarti(int id, bool baglantiEkranindanAcildi)
        {
            InitializeComponent();
            kayitid = id;
            _baglantiEkranindanAcildi = baglantiEkranindanAcildi;
        }

        private void FirmaKarti_Load(object sender, EventArgs e)
        {
            if(kayitid > 0)
                DataGetir();

            if (_baglantiEkranindanAcildi)
                btnKaydet.Enabled = false;
        }

        private void DataGetir()
        {
            var list = data.S_Firma(kayitid).ToList();
            if(list.Count>0)
                txtFirmaAdi.Text = list.FirstOrDefault().FirmaAdi;
        }

        private void btnKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var list = data.IUD_Firma(false, kayitid, txtFirmaAdi.Text, txtFirmaKodu.Text, toggAktif.Checked, 1).ToList();
            if(list.FirstOrDefault().Sonuc == 1)
                kayitid = Convert.ToInt32(list.FirstOrDefault().ID);

            Mesaj.MesajVer("Firma Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
        }

        private void btnKaydetVeKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                data.IUD_Firma(true, kayitid, "", "", null, 1);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void FirmaKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_baglantiEkranindanAcildi)
                this.DialogResult = DialogResult.No;
            else
                this.DialogResult = DialogResult.Yes;

            this.Close();
        }
    }
}