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
    public partial class Proje : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        public Proje()
        {
            InitializeComponent();
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProjeKarti frm = new ProjeKarti(-1);
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void Proje_Load(object sender, EventArgs e)
        {
            DataGetir();
        }

        private void DataGetir()
        {
            var proje = data.S_Proje(-1).ToList();
            grdProje.DataSource = proje;
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32( gvProje.GetFocusedRowCellValue("ID"));
            ProjeKarti frm = new ProjeKarti(id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void gvProje_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvProje.GetFocusedRowCellValue("ID"));
            ProjeKarti frm = new ProjeKarti(id);
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
                int id = Convert.ToInt32(gvProje.GetFocusedRowCellValue("ID"));
                data.IUD_Proje(true, id, "", "", null, null, null, null, null, null, null, null, null, 1);
                DataGetir();
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
            }
        }
    }
}