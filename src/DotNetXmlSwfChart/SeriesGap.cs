using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class SeriesGap : ChartSettingBase
    {
        #region Constructors
        public SeriesGap()
        {
            this.ValueTypes.Add("bar_gap", typeof(int));
            this.ValueTypes.Add("set_gap", typeof(int));
        }
        #endregion

        #region Properties
        public int BarGap
        {
            get { return Convert.ToInt32(this.Values["bar_gap"]); }
            set { this.AddValue("bar_gap", value); }
        }

        public int SetGap
        {
            get { return Convert.ToInt32(this.Values["set_gap"]); }
            set { this.AddValue("set_gap", value); }
        }

        public override string ElementName
        {
            get { return "series_gap"; }
        }
        #endregion
    }
}
