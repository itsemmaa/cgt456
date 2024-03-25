using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace Assign05
{
    public class DbConn
    {
        public string connStr = "Data Source-ecn-classmssql.ecn.purdue.edu;Initial Catalog=zCGT456_rjglotz;Integrated Security=True;";
        public SqlDataAdapter dbSDA;
        public DataSet dbDS;
        public SqlDataReader dbDR;
        public DataTable dbDT;
        public SqlConnection dbConn;
        public SqlCommand dbCmd;
        public string SQL;

        public DbConn()
        {

        }

        public System.Data.DataSet createDataSet(string sql)
        {
            dbConn = new SqlConnection(connStr);
            dbConn.Open();
            dbCmd = new SqlCommand(sql, dbConn);
            dbSDA = new SqlDataAdapter();
            dbSDA.SelectCommand = dbCmd;
            dbDS = new DataSet();
            dbSDA.Fill(dbDS);
            return dbDS;
        }

        public System.Data.SqlClient.SqlDataReader createDataReader(string sql)
        {
            dbConn = new SqlConnection(connStr);
            dbConn.Open();
            dbCmd = new SqlCommand(sql, dbConn);

            dbDR = dbCmd.ExecuteReader();

            return dbDR;
        }
    }
}