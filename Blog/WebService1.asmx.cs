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
            OleDbDataAdapter da = new OleDbDataAdapter("select * from createpost",conn);
            DataSet DS = new DataSet();
            da.Fill(DS);
            return DS;
            conn.Close();
            conn = null;
        }
        [WebMethod]
        public Boolean createPost(string author, string title, string description)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Anurag\\Documents\\Visual Studio 2013\\Projects\\Blog\\db\\Database2.mdb");
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter();
            string sql = "insert into createpost(author, title, description) values ('" + author + "' ,'" + title + "','" + description + "')";
            da.InsertCommand = conn.CreateCommand();
            da.InsertCommand.CommandText = sql;
            if (da.InsertCommand.ExecuteNonQuery() > 0)
                return true;
            else
                return false;
        }
        [WebMethod]
        public Boolean deletePost(string title)
        {
            OleDbConnection conn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\Anurag\\Documents\\Visual Studio 2013\\Projects\\Blog\\db\\Database2.mdb");
            conn.Open();     
            OleDbDataAdapter oledbAdapter = new OleDbDataAdapter();
            string sql = "delete from createblog where title = '" + title + "'";
            oledbAdapter.DeleteCommand = conn.CreateCommand();
            oledbAdapter.DeleteCommand.CommandText = sql;
            if (oledbAdapter.DeleteCommand.ExecuteNonQuery()>0)
                return true;
            else
                return false;            
        }
    }
}
