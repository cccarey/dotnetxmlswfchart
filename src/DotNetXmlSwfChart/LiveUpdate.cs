using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LiveUpdate : ChartSettingBase
    {
        #region Constructors
        public LiveUpdate()
        {
            this.ValueTypes.Add("url", typeof(string));
            this.ValueTypes.Add("delay", typeof(int));
            this.ValueTypes.Add("fail", typeof(bool));
        }
        #endregion

        #region Properties
        public string Url
        {
            get { return this.Values["url"]; }
            set { this.AddValue("url", value); }
        }

        public int Delay
        {
            get { return Convert.ToInt32(this.Values["delay"]); }
            set { this.AddValue("delay", value); }
        }

        public bool Fail
        {
            get { return Convert.ToBoolean(this.Values["fail"]); }
            set { this.AddValue("fail", value); }
        }

        public override string ElementName
        {
            get { return "live_update"; }
        }
        #endregion
    }
}
