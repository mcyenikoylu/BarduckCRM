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
    public partial class Personel : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        public Personel()
        {
            InitializeComponent();
        }

        private void Personel_Load(object sender, EventArgs e)
        {
            DataGetir();
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            PersonelKarti frm = new PersonelKarti(-1);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gvPersonel.GetFocusedRowCellValue("ID"));
            PersonelKarti frm = new PersonelKarti(id);
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
                int id = Convert.ToInt32(gvPersonel.GetFocusedRowCellValue("ID"));
                data.IUD_Personel(true, id, "", -1, "", "", -1, "", "", null, "", null, "", "", -1, null, -1, null, -1, null, "", -1, "", "", -1, -1, null, null);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                DataGetir();
            }
        }

        private void gvPersonel_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvPersonel.GetFocusedRowCellValue("ID"));
            PersonelKarti frm = new PersonelKarti(id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }
        private void DataGetir()
        {
            var list = data.S_Personel(-1).ToList();
            if (list.Count > 0)
                grdPersonel.DataSource = list;
        }
    }
}