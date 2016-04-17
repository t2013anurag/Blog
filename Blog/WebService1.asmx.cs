using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.OleDb;
using System.Data;

namespace Blog
{
    /// <summary>
    /// Summary description for WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public Boolean validateUser(string username, string password)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Anurag\\Documents\\Visual Studio 2013\\Projects\\Blog\\db\\Database2.mdb");
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("select password from userdetails where username='" + username + "' and password='" + password + "'", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            return dr.Read();
            conn.Close();
        }
        [WebMethod]
        public DataSet viewPost()
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Anurag\\Documents\\Visual Studio 2013\\Projects\\Blog\\db\\Database2.mdb");
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("select * from createblog",conn);
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;
            conn.Close();
            conn = null;
        }
    }
}
