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
    public partial class PersonelTakimlari : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
        public PersonelTakimlari()
        {
            InitializeComponent();
        }

        private void PersonelTakimlari_Load(object sender, EventArgs e)
        {
            DataGetir();
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelTakimKarti frm = new PersonelTakimKarti(-1);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gvTakim.GetFocusedRowCellValue("ID"));
            PersonelTakimKarti frm = new PersonelTakimKarti(id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int kayitid = Convert.ToInt32(gvTakim.GetFocusedRowCellValue("ID"));
                data.IUD_Takim(false, Genel.AktifKullaniciID, DateTime.Now, kayitid, Genel.AktifKullaniciID, null, null, true, "", "", DateTime.Now);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                DataGetir();
            }
        }

        private void gvTakim_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvTakim.GetFocusedRowCellValue("ID"));
            PersonelTakimKarti frm = new PersonelTakimKarti(id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void DataGetir()
        {
            var list = data.S_Takim(-1).ToList();
            if (list.Count > 0)
                grdTakim.DataSource = list;
        }
    }
}