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
using BarduckCRM.Properties;

namespace BarduckCRM
{
    public partial class Baglanti : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        BarduckCRMEntities data = new BarduckCRMEntities();


        public Baglanti()
        {
            InitializeComponent();
        }

        private void Baglanti_Load(object sender, EventArgs e)
        {
            RibbonMenuGridAyarlari uc_gridAyarlari = new RibbonMenuGridAyarlari(ribbonPage1.Text);
            uc_gridAyarlari.GrdView = gvBaglanti;
            ribbonControl1.MergeRibbon(uc_gridAyarlari.ribbonControl1);

            var meslek = data.S_Tip(2).ToList();
            cmbMeslek.DataSource = meslek;

            DataGetir(-1);
        }

        private void DataGetir(int id)
        {
            var baglanti = data.S_Baglanti(id).ToList();
            grdBaglanti.DataSource = baglanti;
        }

        private void btnEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            BaglantiKarti frm = new BaglantiKarti(-1);
            frm.ShowDialog();
            if(frm.DialogResult == DialogResult.OK)
            {
                DataGetir(-1);
            }
        }

        private void btnDuzenle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            if (id > 0)
            {
                BaglantiKarti frm = new BaglantiKarti(id);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    DataGetir(-1);
                }
            }
        }

        private void btnSil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("Kayıdı silmek istediğinizden eminmisiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                int id = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
                data.IUD_Baglanti(true, id, "", "", "",false,false,"",1,"",null,"","",1,"",1,false,1,1,"",1,"",1,1,"","","",false,false,false,false,null,"",1,"",1);
                DataGetir(-1);
                MesajVer("Kayıt silinmiştir.", MesajTipi.Hata, this);
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
        /// <summary>
        /// Info mesajları göstermek için kullanılır.
        /// </summary>        
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

        static void tmr_Tick(object sender, EventArgs e)
        {
            if (a.AlertFormList.Count > 0)
                a.AlertFormList[0].Close();

            tmr.Enabled = false;
        }

        private void gvBaglanti_DoubleClick(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(gvBaglanti.GetFocusedRowCellValue("ID"));
            if(id>0)
            {
                BaglantiKarti frm = new BaglantiKarti(id);
                frm.ShowDialog();
                if (frm.DialogResult == DialogResult.OK)
                {
                    DataGetir(-1);
                }
            }
        }
    }
}