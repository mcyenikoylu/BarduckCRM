using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.Utils;

namespace BarduckCRM
{
    public partial class RibbonMenuGridAyarlari : DevExpress.XtraEditors.XtraUserControl
    {


        private DevExpress.XtraGrid.Views.Grid.GridView _GridView;
        public DevExpress.XtraGrid.Views.Grid.GridView GrdView
        {
            get
            {
                return _GridView;
            }
            set
            {
                _GridView = value;
            }
        }

        public RibbonMenuGridAyarlari(string RibbonTabBaslik)
        {
            InitializeComponent();
            ribbonPage1.Text = RibbonTabBaslik;
        
        }


        private void RibbonMenuGridAyarlari_Load(object sender, EventArgs e)
        {
            //if (_GridView != null)
            //{
            //    //bBI_Grup.Down = _GridView.OptionsView.ShowGroupPanel;
            //    btnGridAyar_Gruplama.Down = _GridView.OptionsView.ShowGroupPanel;
            //    //bBI_Cursor.Down = _GridView.OptionsView.ShowIndicator;
            //    //bBI_Filter.Down = !_GridView.OptionsView.ShowAutoFilterRow;
            //    //bool b = false;
            //    //if (_GridView.OptionsView.ShowVerticalLines != DefaultBoolean.False)
            //    //    b = true;
            //    //bBI_Line.Down = b;
            //    //bBI_BestFit.Down = !_GridView.OptionsView.ColumnAutoWidth;
            //}

        }

        private void btnGridAyar_Filtre_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_GridView == null) return;
                _GridView.OptionsCustomization.AllowFilter = btnGridAyar_Filtre.Down;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(-1, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGridAyar_Gruplama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_GridView == null) return;
                _GridView.OptionsView.ShowGroupPanel = btnGridAyar_Gruplama.Down;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(-1, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGridAyar_Gosterge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_GridView == null) return;
                _GridView.OptionsView.ShowIndicator = btnGridAyar_Gosterge.Down;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(-1, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnGridAyar_Altbilgi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (_GridView == null) return;
                _GridView.OptionsView.ShowFooter = btnGridAyar_Altbilgi.Down;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(-1, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGridAyar_KolonEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _GridView.ShowCustomization();
        }

        private void btnGridAyar_SutunCizgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DefaultBoolean b = DefaultBoolean.False;
            if (btnGridAyar_SutunCizgileri.Down)
                b = DefaultBoolean.True;

            _GridView.OptionsView.ShowVerticalLines = b;
        }

        private void btnGridAyar_SatirCizgileri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DefaultBoolean b = DefaultBoolean.False;
            if (btnGridAyar_SatirCizgileri.Down)
                b = DefaultBoolean.True;

            _GridView.OptionsView.ShowHorizontalLines = b;
        }

        private void btnGridAyar_KolonlariHizala_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _GridView.OptionsView.ColumnAutoWidth = !_GridView.OptionsView.ColumnAutoWidth;
        }

        private void btnGridAyar_GruplamalariAc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _GridView.ExpandAllGroups();
        }

        private void btnGridAyar_GruplamalariKapat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _GridView.CollapseAllGroups();
        }

        private void btnGridAyar_SayfaOnizleme_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGridAyar_KolonFiltreTipi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DevExpress.XtraGrid.Columns.FilterPopupMode fpm = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;

            if (_GridView.Columns[0].OptionsFilter.FilterPopupMode == DevExpress.XtraGrid.Columns.FilterPopupMode.Default)
                fpm = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            else
                fpm = DevExpress.XtraGrid.Columns.FilterPopupMode.Default;

            for (int i = 0; i < _GridView.Columns.Count; i++)
            {
                _GridView.Columns[i].OptionsFilter.FilterPopupMode = fpm;
            }

            this.Cursor = Cursors.Default;
        }

        private void btnGridAyar_DisaAktar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void btnGridAyar_GridAyarKaydet_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }
    }
}
