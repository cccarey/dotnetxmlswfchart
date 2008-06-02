using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetXmlSwfChart
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:XmlData runat=server></{0}:XmlData>")]
    public class XmlData : WebControl
    {
        [Bindable(false)]
        [Category("Appearance")]
        [Localizable(false)]
        public Chart Chart
        {
            get { return _chart; }
            set { _chart = value; }
        }
        private Chart _chart = null;

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write(this.Chart.ToSourceXML());
        }
    }
}
