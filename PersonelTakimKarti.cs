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
using DevExpress.XtraEditors;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class PersonelTakimKarti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        int kayitid = -1;
        public PersonelTakimKarti(int id)
        {
            InitializeComponent();
            kayitid = id;
        }

        private void btnKaydet_ItemClick(object sender, ItemClickEventArgs e)
        {
            var list = data.IUD_Takim(
                Convert.ToBoolean(toggAktif.Checked),
                Genel.AktifKullaniciID, DateTime.Now,
                kayitid,
                Genel.AktifKullaniciID,
                Genel.AktifKullaniciID, DateTime.Now,
                false,
                txtTakimAdi.Text,
                txtTakimKodu.Text,
                DateTime.Now.Date).ToList();
            kayitid = Convert.ToInt32( list.FirstOrDefault().ID);
            Mesaj.MesajVer("Ofis Kartı başarılı şekilde kayıt edilmiştir.", Mesaj.MesajTipi.Bilgi, this);
        }

        private void btnKaydetVeKapat_ItemClick(object sender, ItemClickEventArgs e)
        {
            btnKaydet_ItemClick(null, null);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTemizle_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnSil_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                data.IUD_Takim(false,Genel.AktifKullaniciID,DateTime.Now,kayitid,Genel.AktifKullaniciID,null,null,true,"","",DateTime.Now);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void PersonelTakimKarti_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void DataGetir(int getirid)
        {
            var list = data.S_Takim(getirid).ToList();
            if (list.Count > 0)
            {
                txtTakimAdi.Text = list.FirstOrDefault().TakimAdi;
                txtTakimKodu.Text = list.FirstOrDefault().TakimKodu;
            }
        }

        private void PersonelTakimKarti_Load(object sender, EventArgs e)
        {
            if (kayitid > 0)
                DataGetir(kayitid);
        }
    }
}