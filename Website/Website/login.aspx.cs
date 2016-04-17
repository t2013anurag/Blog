using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ser = new ServiceReference1.WebService1SoapClient();
            Boolean check =  ser.validateUser(TextBox1.Text, TextBox2.Text);
            if (check)
            {
                Response.Redirect("createpost.aspx");
            }
            else
            {
                Label1.Text = "Invalid Login Details! Please try again";
            }
        }
    }
}