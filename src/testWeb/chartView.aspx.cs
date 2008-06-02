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
    public partial class chartView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string test = Request.QueryString["test"];
            if (test == null) test = "line1";
            this.Header.Title = string.Format(this.Header.Title, test);

            Session.Add("test", test);

            DotNetXmlSwfChart.ChartHTML testChartInclude = tests.ChartTestFactory.GetTest(test).ChartInclude;

            chartHtml.bgColor = testChartInclude.bgColor;
            chartHtml.height = testChartInclude.height;
            chartHtml.flashFile = testChartInclude.flashFile;
            chartHtml.libraryPath = testChartInclude.libraryPath;
            chartHtml.xmlSource = testChartInclude.xmlSource;
        }
    }
}
