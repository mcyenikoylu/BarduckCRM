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
    public partial class Firma : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();
     
        public Firma()
        {
            InitializeComponent();
        }
        private void Firma_Load(object sender, EventArgs e)
        {
            RibbonMenuGridAyarlari uc_gridAyarlari = new RibbonMenuGridAyarlari(ribbonPage1.Text);
            uc_gridAyarlari.GrdView = gvFirma;
            ribbonControl1.MergeRibbon(uc_gridAyarlari.ribbonControl1);

            DataGetir(-1);
        }
        private void DataGetir(int id)
        {
            var list = data.S_Firma(id).ToList();
            grdFirma.DataSource = list;
        }
        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FirmaKarti frm = new FirmaKarti(-1,false);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir(-1);
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gvFirma.GetFocusedRowCellValue("ID"));
            FirmaKarti frm = new FirmaKarti(id,false);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir(-1);
            }
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(gvFirma.GetFocusedRowCellValue("ID"));
                data.IUD_Firma(true, id, "", "", null, 1);
                Mesaj.MesajVer("Kayıt silinmiştir.", Mesaj.MesajTipi.Onay, this);
                DataGetir(-1);
            }
        }

        private void gvFirma_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvFirma.GetFocusedRowCellValue("ID"));
            FirmaKarti frm = new FirmaKarti(id,false);
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DataGetir(-1);
            }
        }
    }
}