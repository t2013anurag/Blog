using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Website
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient ser = new ServiceReference1.WebService1SoapClient();
            Boolean res = ser.createPost(TextBox1.Text, TextBox2.Text, TextArea1.InnerText);
            if (res)
            {
                Label4.Text = "Created the post successfully";
            }
            else
            {
                Label4.Text = "We are facing an error while creating the post. Please try again after some time!";
            }
        }
    }
}