using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace testWeb
{
    public partial class xmlData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string test = Session["test"] as string;
            if (Request.QueryString["test"] != null) test = Request.QueryString["test"];

            Response.Expires = -1;
            Response.ContentType = "text/xml";
            Response.Write(tests.ChartTestFactory.GetTest(test).Chart.ToSourceXML());
            Response.End();
        }
    }
}
