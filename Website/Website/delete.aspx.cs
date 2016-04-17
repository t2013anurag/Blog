using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace Website
{
    public partial class viewpost : System.Web.UI.Page
    {
        ServiceReference1.WebService1SoapClient ser = new ServiceReference1.WebService1SoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
    
            DataSet data = ser.viewPost();
            GridView1.DataSource = data.Tables[0].DefaultView;
            GridView1.DataBind();

        }

        protected void OnRowDataBound(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {
          
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(GridView1, "Select$" + e.Row.RowIndex);
                e.Row.Attributes["style"] = "cursor:pointer";
            }
        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int index = GridView1.SelectedRow.RowIndex;
                string author = GridView1.SelectedRow.Cells[0].Text;
                string title = GridView1.SelectedRow.Cells[1].Text;
                Label1.Text = "Hello";
                Boolean del = ser.deletePost(title);
                if (del)
                {
                    Label1.Text = "Deleted Successfully! Please refresh the page";
                }
                else
                {
                    Label1.Text = "An error occured while deleting the post!";
                }
            }
            catch (Exception ex)
            {
                Label1.Text = "Please refresh the page to see the changes!";
            }
            //ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('" + message + "');", true);
        }
    }
}