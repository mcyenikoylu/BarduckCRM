using BarduckCRM;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using DevExpress.XtraTabbedMdi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace BarduckCRM
{
    public partial class Master : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public Master()
        {
            InitializeComponent();

            tmrDashboard.Interval = 1000; // ilk açılışta form hemen yüklensin diye 1 saniye yapıyorum. aşağıda timer da 10 saniye olarak güncelliyorum.
            tmrDashboard.Enabled = Genel.AktifKullanici_DashboardOtomatikYenilensinMi;


        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BaglantiHareketi frm = new BaglantiHareketi();
            //frm.MdiParent = this;
            //frm.Show();

           
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //PersonelKarti frm = new PersonelKarti();
            //frm.Show();
           
        }

        private void ribbonControl1_Paint(object sender, PaintEventArgs e)
        {

            //if (IsCurrentAbout)
            //    return;
            DevExpress.XtraBars.Ribbon.ViewInfo.RibbonViewInfo ribbonViewInfo = ribbonControl1.ViewInfo;
            if (ribbonViewInfo == null)
                return;
            DevExpress.XtraBars.Ribbon.ViewInfo.RibbonPanelViewInfo panelViewInfo = ribbonViewInfo.Panel;
            if (panelViewInfo == null)
                return;
            Rectangle bounds = panelViewInfo.Bounds;
            int minX = bounds.X;
            DevExpress.XtraBars.Ribbon.ViewInfo.RibbonPageGroupViewInfoCollection groups = panelViewInfo.Groups;
            if (groups == null)
                return;
            if (groups.Count > 0)
                minX = groups[groups.Count - 1].Bounds.Right;
            Image image = BarduckCRM.Properties.Resources.barduckCRMx32; // DevExpress.Utils.Frames.ApplicationCaption8_1.GetImageLogoEx(LookAndFeel);
            if (bounds.Height < image.Height)
                return;
            int offset = (bounds.Height - image.Height) / 2;
            int width = image.Width + 15;
            bounds.X = bounds.Width - width;
            if (bounds.X < minX)
                return;
            bounds.Width = width;
            bounds.Y += offset;
            bounds.Height = image.Height;
            e.Graphics.DrawImage(image, bounds.Location);
        }

        private void backstageViewTabItem1_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem2_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void backstageViewTabItem3_SelectedChanged(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //BaglantiKarti frm = new BaglantiKarti();
            //frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //KullaniciKarti frm = new KullaniciKarti();
            //frm.ShowDialog();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //DashboardTasarim frm = new DashboardTasarim();
            //frm.ShowDialog();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //ProjeKarti frm = new ProjeKarti();
            //frm.ShowDialog();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //GayrimenkulKarti frm = new GayrimenkulKarti();
            //frm.ShowDialog();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Form AcikFormlar = Application.OpenForms["Dashboard"];
            //if (AcikFormlar != null)
            //{
            //    XtraMdiTabPage page = FindPageByText("Dashboard");
            //    xtraTabbedMdiManager1.SelectedPage = page;
            //    ribbonControl1.HideApplicationButtonContentControl();
            //    return;
            //}
            //Dashboard frm = new Dashboard();
            //frm.MdiParent = this;
            //frm.Show();
        }

        private XtraMdiTabPage FindPageByText(string pageText)
        {
            foreach (XtraMdiTabPage page in xtraTabbedMdiManager1.Pages)
            {
                if (page.MdiChild.Text == pageText)
                    return page;
            }
            return null;
        }

        private void backstageViewButtonItem_Cikis_ItemClick(object sender, DevExpress.XtraBars.Ribbon.BackstageViewItemEventArgs e)
        {
            Application.Exit();
        }
        
        private bool MDIFormAcikMi(XtraForm frm)
        {
            try
            {
                Form AcikFormlar = Application.OpenForms[frm.Name];
                if (AcikFormlar == null)
                    return false;
                else
                    return true;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
        }

        BarduckCRMEntities data = new BarduckCRMEntities();
        private bool bFormYuklendiMi = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            bFormYuklendiMi = true;

            //yapım aşamasındaki menüleri gizliyorum.
            //backstageViewControl1.SelectedTab = backstageViewTabItem1; //ana menü açıldığında her zaman ofis tanımları olarak açar.
            backstageViewControl1.SelectedTab = backstageViewTabItem2;
            backstageViewTabItem1.Visible = false;
            backstageViewTabItem6.Visible = false;
            backstageViewTabItem10.Visible = false;
            backstageViewTabItem14.Visible = false;
            backstageViewTabItem11.Visible = false;
            backstageViewTabItem5.Visible = false;
            backstageViewTabItem12.Visible = false;
            backstageViewTabItem13.Visible = false;
            backstageViewTabItem4.Visible = false;
            backstageViewTabItem3.Visible = false;
            //yapım aşamasındaki menüleri gizliyorum.

            var kullaniciAyarlariList = data.S_KullaniciAyarlari(Genel.AktifKullaniciID).ToList();
            DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(kullaniciAyarlariList.FirstOrDefault().Tema); //"Office 2013 Light Gray"
            this.Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
            this.Text = "Barduck CRM | Versiyon " + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            
            if(kullaniciAyarlariList.Count>0)
            {
                string[] Formlar = kullaniciAyarlariList.FirstOrDefault().SikKullanilanlar.Split(';');
                foreach (string item in Formlar)
                {
                    if (item.Trim() == "") continue;

                    RibbonPageGroup grp = ribbonControl1.Pages[1].Groups[0]; // benim menum
                    BarButtonItem itmForm = new BarButtonItem();
                    XtraForm frm = FormBul(item);
                    itmForm.Glyph = frm.Icon.ToBitmap();
                    itmForm.LargeGlyph = frm.Icon.ToBitmap();
                    itmForm.Name = item;
                    var formList = data.S_Form(-1).ToList();
                    string formBaslik = formList.Where(c => c.FormAdi == item).FirstOrDefault().FormBaslik;
                    itmForm.Caption = formBaslik;
                    grp.ItemLinks.Add(itmForm);
                    itmForm.ItemClick += itmForm_ItemClick;

                }
            }
        }

        private void itmForm_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                BenimMenumItemClickMethod(e);
                //XtraMessageBox.Show("tıklandı.");
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BenimMenumItemClickMethod(ItemClickEventArgs e)
        {
            try
            {
                RibbonForm f = FormBul(e.Item.Name);
                if (MDIFormAcikMi(f))
                {
                    XtraMdiTabPage page = FindPageByText(f.Text);
                    xtraTabbedMdiManager1.SelectedPage = page;
                    ribbonControl1.HideApplicationButtonContentControl();
                    return;
                }
                ribbonControl1.HideApplicationButtonContentControl();
                f.Ribbon.MdiMergeStyle = RibbonMdiMergeStyle.Always;
                f.MdiParent = this;
                f.Show();
                ribbonControl1.SelectedPage = f.Ribbon.Pages[0];
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private RibbonForm FormBul(string FormAdi)
        {
            try
            {
                if (FormAdi == "") return null;

                string FormTypeFullName = string.Format("{0}.{1}", this.GetType().Namespace, FormAdi);
                Type type = Type.GetType(FormTypeFullName, true);
                RibbonForm frm = (RibbonForm)Activator.CreateInstance(type);
                return frm;
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
        private void xtraTabbedMdiManager1_SelectedPageChanged(object sender, EventArgs e)
        {
            
            //if (xtraTabbedMdiManager1.SelectedPage == null)
            //{
            //    ribbonControl1.SelectedPage = this.Ribbon.Pages[0];
            //    return;
            //}

            //string formbaslik = xtraTabbedMdiManager1.SelectedPage.Text;

            //var formlist = data.S_Form(-1).ToList();
            //string formadi = formlist.Where(c => c.FormBaslik == formbaslik).FirstOrDefault().FormAdi.ToString();

            //string FormTypeFullName = string.Format("{0}.{1}", this.GetType().Namespace, formadi);
            //Type type = Type.GetType(FormTypeFullName, true);
            //RibbonForm frm = (RibbonForm)Activator.CreateInstance(type);

            //if (xtraTabbedMdiManager1.SelectedPage.MdiChild.Name == frm.Name)
            //{
            //    ribbonControl1.SelectedPage = frm.Ribbon.Pages[0];
            
            //}

        }
        private void btnQueryBuilder_ItemClick(object sender, ItemClickEventArgs e)
        {
            QueryBuilder frm = new QueryBuilder();
            frm.MdiParent = this;
            frm.Show();
        }

        RibbonPage ownPage = null;
        private void ribbonControl1_Merge(object sender, RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = Ribbon.MergedPages[0];
            //ribbonStatusBar.MergeStatusBar(e.MergedChild.StatusBar);
        }

        private void ribbonControl1_UnMerge(object sender, RibbonMergeEventArgs e)
        {
            ribbonControl1.SelectedPage = ownPage;
            //ribbonStatusBar.UnMergeStatusBar();
        }

        private void Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (e == null || e.CloseReason == CloseReason.UserClosing)
                {
                    if (XtraMessageBox.Show("Programı kapatmak istediğinizden eminmisiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        GorunumKaydet();

                        //Genel.PrmDb.SEDS_KullaniciOturum(2, Genel.KullaniciOturumID, -1, -1, "", "", "", "", Genel.AktifKullaniciID, Genel.Versiyon);


                        Application.Exit();
                    }
                    else if (e != null)
                        e.Cancel = true;
                }
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void GorunumKaydet()
        {
            try
            {
                if (Genel.AktifKullaniciID < 1) return;
                RibbonPageGroup grp = ribbonControl1.Pages[1].Groups[0]; //BenimMenum
                string strBenimMenum = "";


                foreach (BarItemLink lnk in grp.ItemLinks)
                {
                    BarItem item = lnk.Item;
                    strBenimMenum += item.Name + ";";
                }

                if (!bFormYuklendiMi) return;

                #region Quick Access Toolbar ayarları stream değişkene atılıyor...
                System.IO.Stream str;
                str = new System.IO.MemoryStream();
                ribbonControl1.Toolbar.SaveLayoutToStream(str);
                str.Seek(0, System.IO.SeekOrigin.Begin);
                byte[] QAT = Genel.StreamToByteArray(str);
                #endregion

                //bool bSolNavigasyonAcikMi = false;
                //if (nbcNavigasyon.OptionsNavPane.NavPaneState == DevExpress.XtraNavBar.NavPaneState.Expanded)
                //    bSolNavigasyonAcikMi = true;

                data.IUD_KullaniciAyarlari(Genel.AktifKullaniciID,
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SkinName.ToString(), strBenimMenum, QAT, ribbonControl1.ToolbarLocation.ToString(),
                false,-1,-1,false,-1,2);//bSolNavigasyonAcikMi, iSolNavigasyonGenislik
                
            }
            catch (Exception Hata)
            {
                //Genel.LogErrorYaz(iFormID, Hata);
                //XtraMessageBox.Show(Genel.DilGetirMesaj(1034) + "\n\n" + Hata.Message, Genel.DilGetirMesaj(2), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void ribbonControl1_ApplicationButtonClick(object sender, EventArgs e)
        {
            menuOfisYonetimi1.Ribbon = ribbonControl1;
            menuCRMYonetimi1.Ribbon = ribbonControl1;
            menuGayrimenkulYonetimi1.Ribbon = ribbonControl1;
            menuTanimlamalar1.Ribbon = ribbonControl1;
            menuSatisSiparisYonetimi1.Ribbon = ribbonControl1;
            menuRaporlar1.Ribbon = ribbonControl1;
            menuTelekomunikasyonYonetimi1.Ribbon = ribbonControl1;
        }

        bool dashboardTimerCalisti = false;
        private void tmrDashboard_Tick(object sender, EventArgs e)
        {
            if(!dashboardTimerCalisti)
            {
                if (Genel.AktifKullanici_DashboardOtomatikYenilensinMi == false || Genel.AktifKullanici_DashboardID <= 0)
                {
                    tmrDashboard.Enabled = false;
                    return;
                }

                if (Convert.ToInt32(Genel.AktifKullanici_DashboardYenilemeSuresi) > 0)
                {
                    tmrDashboard.Interval = Genel.AktifKullanici_DashboardYenilemeSuresi * 60000;
                }

                //F_EvraklarDashboardGoster frmdashboardgoster = new F_EvraklarDashboardGoster(Genel.AktifKullanici_DashboardID, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null);

                Dashboard frm = new Dashboard(Genel.AktifKullanici_DashboardID); //Genel.AktifKullanici_DashboardID
                if (MDIFormAcikMi(frm))
                {
                    XtraMdiTabPage page = FindPageByText(frm.Text);
                    page.MdiChild.Close();
                }
                frm.MdiParent = this;
                frm.Show();
                dashboardTimerCalisti = true;
            }
        }

        private void xtraTabbedMdiManager1_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            e.Page.Pinned = true;
        }
    }
}
