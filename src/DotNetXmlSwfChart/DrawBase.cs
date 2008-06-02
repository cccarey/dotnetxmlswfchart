using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public abstract class DrawBase : ChartSettingBase
    {
        #region Constructors
        public DrawBase()
        {
            this.ValueTypes.Add("layer", typeof(DrawLayer));
            this.ValueTypes.Add("transition", typeof(TransitionType));
            this.ValueTypes.Add("delay", typeof(double));
            this.ValueTypes.Add("duration", typeof(double));
        }
        #endregion

        #region Properties
        public DrawLayer Layer
        {
            get { return (DrawLayer)Enum.Parse(typeof(DrawLayer), this.Values["layer"]); }
            set { this.AddValue("layer", value); }
        }

        public TransitionType Transition
        {
            get { return (TransitionType)Enum.Parse(typeof(TransitionType), this.Values["transition"]); }
            set { this.AddValue("transition", value); }
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
        #endregion
    }
}
