using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using XMLDemo.XMLWriterService;

namespace XMLDemo
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClick_Click(object sender, EventArgs e)
        {
            XMLFileWriterSoapClient c = new XMLFileWriterSoapClient();
            lbltxt.Text = c.HelloWorld();
        }
    }
}