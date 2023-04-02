using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarduckCRM
{
    class SQLRunner
    {
    }


    public enum DataObjectType
    {
        DataTable,
        DataSet,
        None,
        Object
    }

    public class MyDatabase
    {
        private StringBuilder SQLCONNECTIONSTRING = new StringBuilder("data source=#ServerName#;initial catalog=#DatabaseName#;integrated security=#SecurityValue#;password=#Password#;user ID=#UserName#");

        private StringBuilder LOCALCONNECTIONSTRING = new StringBuilder("Data Source=|DataDirectory|\\#DataSource#");
        private StringBuilder CODESERVERNAME = new StringBuilder("#ServerName#");
        private StringBuilder CODEDATABASENAME = new StringBuilder("#DatabaseName#");
        private StringBuilder CODEPASSWORD = new StringBuilder("#Password#");
        private StringBuilder CODEUSERNAME = new StringBuilder("#UserName#");
        private StringBuilder CODESECURITYVALUE = new StringBuilder("#SecurityValue#");

        //private static SqlConnection g_SqlConnection;
        //private static OleDbConnection g_AccessConnection;
        #region Properties
        private string g_strServerName = "";
        private string g_strDatabaseName = "";
        private string g_strUserName = "";
        private string g_strPassword = "";
        private string g_strConnectionString = "";
        private string g_strInfoMessage = "";

        public string ServerName
        {
            get { return g_strServerName; }
            set { g_strServerName = value; }
        }
        public string DatabaseName
        {
            get { return g_strDatabaseName; }
            set { g_strDatabaseName = value; }
        }
        public string UserName
        {
            get { return g_strUserName; }
            set { g_strUserName = value; }
        }
        public string Password
        {
            get { return g_strPassword; }
            set { g_strPassword = value; }
        }
        public string ConnectionString
        {
            get { return g_strConnectionString; }
            set
            {
                g_strConnectionString = value;
            }
        }
        public string InfoMessage
        {
            get { return g_strInfoMessage; }
            set { g_strInfoMessage = value; }
        }
        #endregion

        private void DisplaySqlErrors(SqlException exception)
        {
            foreach (SqlError err in exception.Errors)
            {
                g_strInfoMessage = string.Format("ERROR: {0}", err.Message);
            }
        }

        private void OnInfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            foreach (SqlError info in e.Errors)
            {
                g_strInfoMessage = string.Format("INFO: {0}", info.Message);
            }
        }



        public bool CreateConnection()
        {
            bool bCanConnect = false;
            string strSecurityValue = "";
            if (g_strUserName.Trim() == "")
                strSecurityValue = "true";
            else
                strSecurityValue = "false";

            g_strConnectionString = SQLCONNECTIONSTRING.Replace(CODESERVERNAME.ToString(), g_strServerName).Replace(CODEDATABASENAME.ToString(), g_strDatabaseName)
                .Replace(CODEPASSWORD.ToString(), g_strPassword).Replace(CODEUSERNAME.ToString(), g_strUserName).Replace(CODESECURITYVALUE.ToString(), strSecurityValue).ToString();

            SqlConnection g_SqlConnection = new SqlConnection(g_strConnectionString);



            try
            {
                g_SqlConnection.Open();
                bCanConnect = true;
            }
            catch { bCanConnect = false; }
            if (g_SqlConnection != null && g_SqlConnection.State != ConnectionState.Closed)
                g_SqlConnection.Close();

            return bCanConnect;
        }



        private SqlConnection GetConnectionSql()
        {
            SqlConnection g_SqlConnection = null;
            string strSecurityValue = "";
            if (g_strUserName.Trim() == "")
                strSecurityValue = "true";
            else
                strSecurityValue = "false";

            g_strConnectionString = SQLCONNECTIONSTRING.Replace(CODESERVERNAME.ToString(), g_strServerName).Replace(CODEDATABASENAME.ToString(), g_strDatabaseName)
                .Replace(CODEPASSWORD.ToString(), g_strPassword).Replace(CODEUSERNAME.ToString(), g_strUserName).Replace(CODESECURITYVALUE.ToString(), strSecurityValue).ToString();

            g_SqlConnection = new SqlConnection(g_strConnectionString);

            try
            {
                g_SqlConnection.Open();
            }
            catch { }
            if (g_SqlConnection != null && g_SqlConnection.State != ConnectionState.Closed)
                g_SqlConnection.Close();



            return g_SqlConnection;
        }

        private object LoadDataObject(string p_strSpName, object p_oDataObject, DataObjectType p_dotType, params object[] p_oParameters)
        {
            object oRetunObject = null;

            SqlConnection g_SqlConnection = GetConnectionSql();

            try
            {

                //command oluşturulup parametreleri dolduruluyor.//////////////////////////////
                g_SqlConnection.InfoMessage += OnInfoMessage;
                g_SqlConnection.Open();
                SqlCommand scCommand = new SqlCommand(p_strSpName, g_SqlConnection);
                scCommand.CommandTimeout = 20 * 60 * 1000;
                if (p_oParameters.Length > 0)//spnin parametreleri var ise
                {
                    scCommand.CommandType = CommandType.StoredProcedure;
                    SqlCommandBuilder.DeriveParameters(scCommand);//commandın parametreleri alınıyor.
                    for (int i = 1; i < scCommand.Parameters.Count; i++)
                    {
                        object o = p_oParameters[i - 1];
                        if (o == null)
                            o = DBNull.Value;
                        if (o is DateTime && Convert.ToDateTime(o).Year > 2500)//webserviste null değer gönderilemiyor. bu nedenle tarihler null gönderilecekse 2500 den büyük bir tarih veriliyor. Biz de burda onu yeniden null değere çeviriyoruz.
                            o = DBNull.Value;

                        scCommand.Parameters[i].Value = o;
                    }
                }
                else
                {
                    scCommand.CommandType = CommandType.Text;
                }
                /***********************************************************************/

                if (p_dotType == DataObjectType.DataSet)//dataset döndürecek ise
                {
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter(scCommand);
                    sdaAdapter.Fill((DataSet)p_oDataObject);
                }
                else if (p_dotType == DataObjectType.DataTable)//datatable döndürecek ise
                {
                    SqlDataAdapter sdaAdapter = new SqlDataAdapter(scCommand);
                    sdaAdapter.Fill((DataTable)p_oDataObject);

                    if (((DataTable)p_oDataObject).Rows.Count > 0)
                    {

                        g_strInfoMessage = ((DataTable)p_oDataObject).Rows.Count.ToString() + " rows affected.";
                    }
                }
                else if (p_dotType == DataObjectType.None)//sadece çalışacak ise
                {
                    int iRowCount = scCommand.ExecuteNonQuery();
                    g_strInfoMessage = iRowCount.ToString() + " rows affected.";

                }
                else if (p_dotType == DataObjectType.Object)//obje döndürecek ise
                {
                    oRetunObject = scCommand.ExecuteScalar();
                    g_strInfoMessage = "0 rows affected.";
                }
            }
            catch (SqlException ex)
            {

                DisplaySqlErrors(ex);

                if (g_SqlConnection != null && g_SqlConnection.State != ConnectionState.Closed)
                    g_SqlConnection.Close();
                throw (new Exception("Hata : " + ex.Message + "..."));
                //oRetunObject = ex.Message;
            }
            finally
            {
                //connection kapatılıyor
                if (g_SqlConnection != null && g_SqlConnection.State != ConnectionState.Closed)
                    g_SqlConnection.Close();
            }


            return oRetunObject;
        }





        public DataSet ExecuteDataSet(string p_strSpName, params object[] p_oParameters)
        {
            DataSet dsReturnDataset = new DataSet();
            LoadDataObject(p_strSpName, dsReturnDataset, DataObjectType.DataSet, p_oParameters);
            return dsReturnDataset;

        }
        public DataRow ExecuteDataRow(string p_strSpName, params object[] p_oParameters)
        {
            DataTable dsReturnDataTable = new DataTable();
            LoadDataObject(p_strSpName, dsReturnDataTable, DataObjectType.DataTable, p_oParameters);

            if (dsReturnDataTable.Rows.Count > 0)
            {
                return dsReturnDataTable.Rows[0];
            }
            else
                return null;

        }
        public DataTable ExecuteDataTable(string p_strSpName, params object[] p_oParameters)
        {
            DataTable dsReturnDataTable = new DataTable();
            LoadDataObject(p_strSpName, dsReturnDataTable, DataObjectType.DataTable, p_oParameters);
            return dsReturnDataTable;
        }
        public void ExecuteNonQuery(string p_strSpName, params object[] p_oParameters)
        {
            LoadDataObject(p_strSpName, null, DataObjectType.None, p_oParameters);
        }
        public void ExecuteNonQueryAsync(string p_strSpName, params object[] p_oParameters)
        {
            ExecuteNonQuery(p_strSpName, p_oParameters);
        }
        public object ExecuteScalar(string p_strSpName, params object[] p_oParameters)
        {
            object oReturnObject = null;
            oReturnObject = LoadDataObject(p_strSpName, oReturnObject, DataObjectType.Object, p_oParameters);
            return oReturnObject;
        }

    }

}
