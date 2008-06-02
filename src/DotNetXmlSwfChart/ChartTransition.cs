using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartTransition : ChartSettingBase
    {
        #region Constructors
        public ChartTransition()
        {
            this.ValueTypes.Add("type", typeof(TransitionType));
            this.ValueTypes.Add("delay", typeof(double));
            this.ValueTypes.Add("duration", typeof(double));
            this.ValueTypes.Add("order", typeof(TransitionOrder));
        }
        #endregion

        #region Properties
        public TransitionType TransitionType
        {
            get { return (TransitionType)Enum.Parse(typeof(TransitionType), this.Values["type"]); }
            set { this.AddValue("type", value); }
        }

        public double Delay
        {
            get { return Convert.ToDouble(this.Values["delay"]); }
            set { this.AddValue("delay", value); }
        }

        public double Duration
        {
            get { return Convert.ToDouble(this.Values["duration"]); }
            set { this.AddValue("duration", value); }
        }

        public TransitionOrder Order
        {
            get { return (TransitionOrder)Enum.Parse(typeof(TransitionOrder), this.Values["order"]); }
            set { this.AddValue("order", value); }
        }

        public override string ElementName
        {
            get { return "chart_transition"; }
        }
        #endregion
    }
}
