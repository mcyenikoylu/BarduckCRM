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
using DevExpress.XtraBars;
using BarduckCRM;

namespace BarduckCRM
{
    public partial class QueryBuilder : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        MyDatabase sql = new MyDatabase();
        BarduckCRMEntities data = new BarduckCRMEntities();
        public QueryBuilder()
        {
            InitializeComponent();
        }

        private void QueryBuilder_Load(object sender, EventArgs e)
        {
            Genel.Sunucu = "DESKTOP-VQ5O2D7\\SQLEXPRESS";
            Genel.Veritabani = "BarduckCRM";
            Genel.UserName = "mcy";
            Genel.Password = "mcy123";

            sql.ServerName = Genel.Sunucu;
            sql.DatabaseName = Genel.Veritabani;
            sql.UserName = Genel.UserName;
            sql.Password = Genel.Password;
            bool bbbb = sql.CreateConnection();

            if (bbbb)
            {
                DataTable dtTables = sql.ExecuteDataTable(@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE' ORDER BY TABLE_NAME");
                cmbTablo.Properties.DataSource = dtTables;
            }
        }

        private void btnQueryOlustur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            //XtraMessageBox.Show(txtSPAdi.Text); 
            //string asd = txtSPAdi.Text;

            if (cmbTablo.EditValue == null || txtSPAdi.Text.Trim() == "" || cmbKullaniciAdi.Text.Trim() == "")
            {
                //Ayar.InfoMesajGoster("Tüm alanları doldurunuz !", Ayar.MesajTipi.Hata, this);
                return;
            }

            SelectQuery();
            InsertUpdateQuery();
        }

        private void SelectQuery()
        {
            DataTable dtAlanlar = sql.ExecuteDataTable("SELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE " +
                   "FROM BarduckCRM.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + cmbTablo.EditValue.ToString() + "'");


            string strSelect = "USE [BarduckCRM] " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "SET ANSI_NULLS ON " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "SET QUOTED_IDENTIFIER ON " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "-- =============================================" + Environment.NewLine +
            "-- Author     : " + cmbKullaniciAdi.Text.ToString().Trim() + Environment.NewLine +
            "-- Create date: " + DateTime.Now.Day.ToString("00") + "." + DateTime.Now.Month.ToString("00") + "." + DateTime.Now.Year.ToString() + Environment.NewLine +
            "-- Description: " + Environment.NewLine +
            "-- =============================================" + Environment.NewLine +
            "CREATE PROCEDURE [dbo].[" + "S_" + txtSPAdi.Text.Trim() + "]" + Environment.NewLine +
            "AS" + Environment.NewLine +
            "SET NOCOUNT ON" + Environment.NewLine +
            "BEGIN TRY" + Environment.NewLine +
            "SELECT ";


            string strAlanlar = "";
            foreach (DataRow row in dtAlanlar.Rows)
            {
                strAlanlar += row["COLUMN_NAME"].ToString() + "," + Environment.NewLine;
            }
            strAlanlar = strAlanlar.Remove(strAlanlar.Length - 3, 3);
            strSelect += strAlanlar + " " + Environment.NewLine;
            strSelect += "FROM dbo." + cmbTablo.EditValue.ToString() + " WITH (NOLOCK) " + Environment.NewLine +
            "END TRY" + Environment.NewLine + "BEGIN CATCH" + Environment.NewLine +
            "SELECT" + Environment.NewLine;

            string strCatchAlanlar = "";
            foreach (DataRow row in dtAlanlar.Rows)
            {
                string strTip = row["DATA_TYPE"].ToString();
                if (strTip.Contains("char"))
                    strTip = "'' AS " + row["COLUMN_NAME"].ToString() + ",";
                else if (strTip == ("decimal"))
                    strTip = "CAST(0 AS DECIMAL(" + row["NUMERIC_PRECISION"].ToString() + "," + row["NUMERIC_SCALE"].ToString() + ")" + ") AS " + row["COLUMN_NAME"].ToString() + ",";
                else if (strTip == ("bit"))
                    strTip = "CAST(0 AS BIT) AS " + row["COLUMN_NAME"].ToString() + ",";
                else if (strTip == ("int"))
                    strTip = "-1 AS " + row["COLUMN_NAME"].ToString() + ",";
                else if (strTip == ("datetime"))
                    strTip = "NULL AS " + row["COLUMN_NAME"].ToString() + ",";
                strCatchAlanlar += strTip + Environment.NewLine;
            }
            strCatchAlanlar = strCatchAlanlar.Remove(strCatchAlanlar.Length - 3, 3);


            strSelect += strCatchAlanlar + Environment.NewLine +
            "END CATCH" + Environment.NewLine + "SET NOCOUNT OFF";

            mSelect.Text = strSelect;
        }
        private void InsertUpdateQuery()
        {
            DataTable dtAlanlar = sql.ExecuteDataTable("SELECT TABLE_NAME,COLUMN_NAME,DATA_TYPE,CHARACTER_MAXIMUM_LENGTH,NUMERIC_PRECISION,NUMERIC_SCALE " +
                   "FROM BarduckCRM.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + cmbTablo.EditValue.ToString() + "'");


            string strInsertUpdate = "USE [BarduckCRM] " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "SET ANSI_NULLS ON " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "SET QUOTED_IDENTIFIER ON " + Environment.NewLine +
            "GO" + Environment.NewLine +
            "-- =============================================" + Environment.NewLine +
            "-- Author     : " + cmbKullaniciAdi.Text.ToString().Trim() + Environment.NewLine +
            "-- Create date: " + DateTime.Now.Day.ToString("00") + "." + DateTime.Now.Month.ToString("00") + "." + DateTime.Now.Year.ToString() + Environment.NewLine +
            "-- Description: " + Environment.NewLine +
            "-- =============================================" + Environment.NewLine +
            "CREATE PROCEDURE [dbo].[" + "IUD_" + txtSPAdi.Text.Trim() + "]" + Environment.NewLine;

            string strAlanlar = "@IslemTipi int ,  -- 1 Insert, 2 Update, 3 Delete" + Environment.NewLine;
            string strID_Degiskeni = "";

            int iFlag = 0;
            foreach (DataRow row in dtAlanlar.Rows)
            {
                string strTip = row["DATA_TYPE"].ToString();
                if (strTip.Contains("char"))
                    strTip += "(" + row["CHARACTER_MAXIMUM_LENGTH"].ToString() + ")";
                else if (strTip == ("decimal"))
                    strTip += "(" + row["NUMERIC_PRECISION"].ToString() + "," + row["NUMERIC_SCALE"].ToString() + ")";

                strAlanlar += "@" + row["COLUMN_NAME"].ToString() + " " + strTip + "," + Environment.NewLine;

                if (iFlag == 0)
                    strID_Degiskeni = "@" + row["COLUMN_NAME"].ToString();
                iFlag++;
            }




            strAlanlar += "@AktifKullaniciID	INT -- Description: SEDS_TabloKayitOlusturanDegistiren" + Environment.NewLine +
                          "-- ========================================================================" + Environment.NewLine;
            strInsertUpdate += strAlanlar +
            "AS" + Environment.NewLine +
            "SET NOCOUNT ON" + Environment.NewLine +
            "BEGIN" + Environment.NewLine +
            "BEGIN TRY " + Environment.NewLine +
            "IF (@IslemTipi=1)  --=============================INSERT=================================" + Environment.NewLine +
            "BEGIN" + Environment.NewLine +


            //INSERT
            "INSERT INTO " + cmbTablo.EditValue.ToString() + " (" + Environment.NewLine;



            iFlag = 0;
            string strAlanlarInsert = "";
            foreach (DataRow row in dtAlanlar.Rows)
            {
                if (iFlag > 0)
                    strAlanlarInsert += row["COLUMN_NAME"].ToString() + "," + Environment.NewLine;

                iFlag++;
            }
            strAlanlarInsert = strAlanlarInsert.Remove(strAlanlarInsert.Length - 3, 3);


            string strAlanlarDegisken = "";
            iFlag = 0;
            foreach (DataRow row in dtAlanlar.Rows)
            {

                if (iFlag > 0)
                    strAlanlarDegisken += "@" + row["COLUMN_NAME"].ToString() + "," + Environment.NewLine;
                strAlanlar += row["COLUMN_NAME"].ToString() + "," + Environment.NewLine;
                iFlag++;
            }
            strAlanlarDegisken = strAlanlarDegisken.Remove(strAlanlarDegisken.Length - 3, 3);



            strInsertUpdate += strAlanlarInsert + ")" + Environment.NewLine + " VALUES ( " + strAlanlarDegisken + ")" + Environment.NewLine +
            "SET " + strID_Degiskeni + " = SCOPE_IDENTITY() " + Environment.NewLine+
            //string strTabloID = sql.ExecuteScalar("SELECT ID FROM dbo.Tn_Tablo WHERE TabloAdi = '" + cmbTablo.EditValue.ToString() + "'").ToString();
            //strInsertUpdate += "EXEC SEDS_TabloKayitOlusturanDegistiren " + strTabloID + ", " + strID_Degiskeni + ", @AktifKullaniciID" + Environment.NewLine +
            "SELECT 1 Sonuc , " + strID_Degiskeni + " ID  " + Environment.NewLine +
            "END" + Environment.NewLine;

            strInsertUpdate += "ELSE IF (@IslemTipi=2)  --=============================UPDATE=================================" + Environment.NewLine +
            "BEGIN" + Environment.NewLine +


            //UPDATE
            "UPDATE " + cmbTablo.EditValue.ToString() +
            " SET" + Environment.NewLine;
            string strAlanlar3 = "";
            iFlag = 0;
            foreach (DataRow row in dtAlanlar.Rows)
            {
                if (iFlag > 0)
                    strAlanlar3 += row["COLUMN_NAME"].ToString() + "=@" + row["COLUMN_NAME"].ToString() + "," + Environment.NewLine;
                iFlag++;
            }
            strAlanlar3 = strAlanlar3.Remove(strAlanlar3.Length - 3, 3) + Environment.NewLine;

            strInsertUpdate += strAlanlar3 + "WHERE " + strID_Degiskeni.Replace("@", "") + "=" + strID_Degiskeni + Environment.NewLine+
            //strInsertUpdate += "EXEC SEDS_TabloKayitOlusturanDegistiren " + strTabloID + ", " + strID_Degiskeni + ", @AktifKullaniciID" + Environment.NewLine +
           "SELECT 1 Sonuc , " + strID_Degiskeni + " ID  " + Environment.NewLine +
           "END" + Environment.NewLine;

            //DELETE
            strInsertUpdate += "ELSE IF (@IslemTipi=3)  --=============================DELETE=================================" + Environment.NewLine +
                                "BEGIN" + Environment.NewLine +
                                "DELETE FROM " + cmbTablo.EditValue.ToString() + Environment.NewLine +
                                "WHERE " + strID_Degiskeni.Replace("@", "") + "=" + strID_Degiskeni + Environment.NewLine +
                                "SELECT 1 Sonuc , " + strID_Degiskeni + " ID" + Environment.NewLine +
                                "END" + Environment.NewLine +
                                "END TRY" + Environment.NewLine +
                                "BEGIN CATCH" + Environment.NewLine +
                                "SELECT -1 AS Sonuc," + strID_Degiskeni + " ID  " + Environment.NewLine +
                                "END CATCH" + Environment.NewLine +
                                "END" + Environment.NewLine +
                                "SET NOCOUNT OFF  " + Environment.NewLine;



            mInsert.Text = strInsertUpdate;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (cmbTablo.EditValue == null || txtSPAdi.Text.Trim() == "" || cmbKullaniciAdi.Text.Trim() == "")
            {
                //Ayar.InfoMesajGoster("Tüm alanları doldurunuz !", Ayar.MesajTipi.Hata, this);
                return;
            }
            SelectQuery();
            InsertUpdateQuery();
        }

        private void QueryBuilder_Shown(object sender, EventArgs e)
        {

            splitContainerControl1_Resize(null,null);

        }

        private void splitContainerControl1_Resize(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = splitContainerControl1.Width / 2;
        }

    
    }
}