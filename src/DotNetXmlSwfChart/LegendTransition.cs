using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LegendTransition : ChartSettingBase
    {
        #region Constructors
        public LegendTransition()
        {
            this.ValueTypes.Add("type", typeof(TransitionType));
            this.ValueTypes.Add("delay", typeof(int));
            this.ValueTypes.Add("duration", typeof(double));
        }
        #endregion

        #region Properties
        public TransitionType Type
        {
            get { return (TransitionType)Enum.Parse(typeof(TransitionType), this.Values["type"]); }
            set { this.AddValue("type", value); }
        }

        public int Delay
        {
            get { return Convert.ToInt32(this.Values["delay"]); }
            set { this.AddValue("delay", value); }
        }

        public double Duration
        {
            get { return Convert.ToDouble(this.Values["duration"]); }
            set { this.AddValue("duration", value); }
        }

        public override string ElementName
        {
            get { return "legend_transition"; }
        }
        #endregion
    }
}
