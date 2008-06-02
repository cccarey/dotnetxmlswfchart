using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class AxisTicks : ChartSettingBase
    {
        #region Constructors
        public AxisTicks()
        {
            this.ValueTypes.Add("value_ticks", typeof(bool));
            this.ValueTypes.Add("category_ticks", typeof(bool));
            this.ValueTypes.Add("position", typeof(string));
            this.ValueTypes.Add("major_thickness", typeof(int));
            this.ValueTypes.Add("major_color", typeof(string));
            this.ValueTypes.Add("minor_thickness", typeof(int));
            this.ValueTypes.Add("minor_color", typeof(string));
            this.ValueTypes.Add("minor_count", typeof(int));
        }
        #endregion

        #region Properties
        public bool ValueTicks
        {
            get { return Convert.ToBoolean(this.Values["value_ticks"]); }
            set { this.AddValue("value_ticks", value); }
        }

        public bool CategoryTicks
        {
            get { return Convert.ToBoolean(this.Values["category_ticks"]); }
            set { this.AddValue("category_ticks", value); }
        }

        public string Position
        {
            get { return this.Values["position"]; }
            set { this.AddValue("position", value); }
        }

        public int MajorThickness
        {
            get { return Convert.ToInt32(this.Values["major_thickness"]); }
            set { this.AddValue("major_thickness", value); }
        }

        public string MajorColor
        {
            get { return this.Values["major_color"]; }
            set { this.AddValue("major_color", value); }
        }

        public int MinorThickness
        {
            get { return Convert.ToInt32(this.Values["minor_thickness"]); }
            set { this.AddValue("minor_thickness", value); }
        }

        public string MinorColor
        {
            get { return this.Values["minor_color"]; }
            set { this.AddValue("minor_color", value); }
        }

        public int MinorCount
        {
            get { return Convert.ToInt32(this.Values["minor_count"]); }
            set { this.AddValue("minor_count", value); }
        }

        public override string ElementName
        {
            get { return "axis_ticks"; }
        }
        #endregion
    }
}
