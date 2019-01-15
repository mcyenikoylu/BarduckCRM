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
using DevExpress.XtraBars.Ribbon;
using DevExpress.Utils;
using DevExpress.XtraBars.Alerter;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class Ofis : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();

        public Ofis()
        {
            InitializeComponent();
        }

        private void Ofis_Load(object sender, EventArgs e)
        {
            RibbonMenuGridAyarlari uc_gridAyarlari = new RibbonMenuGridAyarlari(ribbonPage1.Text);
            uc_gridAyarlari.GrdView = gvOfis;
            ribbonControl1.MergeRibbon(uc_gridAyarlari.ribbonControl1);

            DataGetir();
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OfisKarti frm = new OfisKarti(-1);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gvOfis.GetFocusedRowCellValue("ID"));
            OfisKarti frm = new OfisKarti(id);
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
                int id = Convert.ToInt32(gvOfis.GetFocusedRowCellValue("ID"));
                data.IUD_Ofis(true, 1, id, -1, "", "", -1, "", "", "", -1, -1, null, null, -1, null, null,null);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                DataGetir();
            }
        }

        private void gvOfis_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvOfis.GetFocusedRowCellValue("ID"));
            OfisKarti frm = new OfisKarti(id);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir();
            }
        }

        private void DataGetir()
        {
            var list = data.S_Ofis(-1).ToList();
            if (list.Count > 0)
                grdOfis.DataSource = list;
            else
                grdOfis.DataSource = null;
        }

    }
}