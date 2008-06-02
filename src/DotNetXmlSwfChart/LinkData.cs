using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LinkData : ChartSettingBase
    {
        #region Constructors
        public LinkData()
        {
            this.ValueTypes.Add("url", typeof(string));
            this.ValueTypes.Add("target", typeof(string));
        }
        #endregion

        #region Properties
        public string Url
        {
            get { return this.Values["url"]; }
            set { this.AddValue("url", value); }
        }

        public string Target
        {
            get { return this.Values["target"]; }
            set { this.AddValue("target", value); }
        }

        public override string ElementName
        {
            get { return "link_data"; }
        }
        #endregion
    }
}
