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
            ListView1.DataSource = data.Tables[0].DefaultView;
            ListView1.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
             
              
        }
    }
}