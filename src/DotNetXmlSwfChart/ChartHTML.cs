using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DotNetXmlSwfChart
{
    [DefaultProperty("htmlId")]
    [ToolboxData("<{0}:ChartHTML runat=server></{0}:ChartHTML>")]
    public class ChartHTML : WebControl
    {
        [Bindable(false)]
        [Category("Design")]
        [DefaultValue("charts")]
        public string htmlId = "charts";

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue("charts.swf")]
        public string flashFile = "charts.swf";

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue("charts_library")]
        public string libraryPath = "charts_library";

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue(400)]
        public int width = 400;

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue(250)]
        public int height = 250;

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue("666666")]
        public string bgColor = "666666";

        [Bindable(false)]
        [Category("Design")]
        [DefaultValue(false)]
        public bool transparent = false;

        [Bindable(false)]
        [Category("Design")]
        public string license = null;

        [Bindable(false)]
        [Category("Design")]
        public string xmlSource;

        protected override void RenderContents(HtmlTextWriter output)
        {
            output.Write("<object ");
            output.Write("classid='clsid:D27CDB6E-AE6D-11cf-96B8-444553540000' ");
            output.Write("codebase='http://download.macromedia.com/pub/shockwave/cabs/flash/swflash.cab#version=6,0,0,0' ");
            output.Write("width='{0}' height='{1}' id='{2}' ", this.width, this.height, this.htmlId);
            output.Write("align=''>");

            output.Write("<param name='movie' value='{0}", this.flashFile);
            output.Write("?library_path={0}", this.libraryPath);
            output.Write("&xml_source={0}", this.xmlSource);
            output.Write("&stage_width={0}", this.width);
            output.Write("&stage_height={0}", this.height);
            if (this.license != null) output.Write("&license={0}", this.license);
            output.Write("'>");

            output.Write("<param name='quality' value='high'>");

            output.Write("<param name='bgcolor' value='#{0}'>", this.bgColor);

            if (this.transparent) output.Write("<param name='wmode' value='transparent'>");

            output.Write("<embed src='{0}", this.flashFile);
            output.Write("?library_path={0}", this.libraryPath);
            output.Write("&xml_source={0}", this.xmlSource);
            output.Write("&stage_width={0}", this.width);
            output.Write("&stage_height={0}", this.height);
            if (this.license != null) output.Write("&license={0}", this.license);
            output.Write("' quality='high' ");
            output.Write("bgcolor='#{0}' ", this.bgColor);
            output.Write("width='{0}' height='{1}' ", this.width, this.height);
            output.Write("name='{0}' ", this.htmlId);
            output.Write("align='' "); // swLiveConnect='true' ");
            if (this.transparent) output.Write("wmode='transparent' ");
            output.Write("type='application/x-shockwave-flash' pluginspage='http://www.macromedia.com/go/getflashplayer'>");

            output.Write("</embed></object>");
        }
    }
}
