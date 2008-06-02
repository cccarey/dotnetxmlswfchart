using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class AxisValue : ChartSettingBase
    {
        #region Constructors
        public AxisValue()
        {
            this.ValueTypes.Add("min", typeof(float));
            this.ValueTypes.Add("max", typeof(float));
            this.ValueTypes.Add("steps", typeof(int));
            this.ValueTypes.Add("prefix", typeof(string));
            this.ValueTypes.Add("suffix", typeof(string));
            this.ValueTypes.Add("decimals", typeof(int));
            this.ValueTypes.Add("decimal_char", typeof(string));
            this.ValueTypes.Add("separator", typeof(string));
            this.ValueTypes.Add("show_min", typeof(bool));
            this.ValueTypes.Add("font", typeof(string));
            this.ValueTypes.Add("bold", typeof(bool));
            this.ValueTypes.Add("size", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("background_color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
            this.ValueTypes.Add("orientation", typeof(string));
        }
        #endregion

        #region Properties
        public float Min
        {
            get { return Convert.ToSingle(this.Values["min"]); }
            set { this.AddValue("min", value); }
        }

        public float Max
        {
            get { return Convert.ToSingle(this.Values["max"]); }
            set { this.AddValue("max", value); }
        }

        public int Steps
        {
            get { return Convert.ToInt32(this.Values["steps"]); }
            set { this.AddValue("steps", value); }
        }

        public string Prefix
        {
            get { return this.Values["prefix"]; }
            set { this.AddValue("prefix", value); }
        }

        public string Suffix
        {
            get { return this.Values["suffix"]; }
            set { this.AddValue("suffix", value); }
        }

        public int Decimals
        {
            get { return Convert.ToInt32(this.Values["decimals"]); }
            set { this.AddValue("decimals", value); }
        }

        public string DecimalChar
        {
            get { return this.Values["decimal_char"]; }
            set { this.AddValue("decimal_char", value); }
        }

        public string Separator
        {
            get { return this.Values["separator"]; }
            set { this.AddValue("separator", value); }
        }

        public bool ShowMin
        {
            get { return Convert.ToBoolean(this.Values["show_min"]); }
            set { this.AddValue("show_min", value); }
        }

        public string Font
        {
            get { return this.Values["font"]; }
            set { this.AddValue("font", value); }
        }

        public bool Bold
        {
            get { return Convert.ToBoolean(this.Values["bold"]); }
            set { this.AddValue("bold", value); }
        }

        public int Size
        {
            get { return Convert.ToInt32(this.Values["size"]); }
            set { this.AddValue("size", value); }
        }

        public string Color
        {
            get { return this.Values["color"]; }
            set { this.AddValue("color", value); }
        }

        public string BackgroundColor
        {
            get { return this.Values["background_color"]; }
            set { this.AddValue("background_color", value); }
        }

        public int Alpha
        {
            get { return Convert.ToInt32(this.Values["alpha"]); }
            set { this.AddValue("alpha", value); }
        }

        public string Orientation
        {
            get { return this.Values["orientation"]; }
            set { this.AddValue("orientation", value); }
        }

        public override string ElementName
        {
            get { return "axis_value"; }
        }
        #endregion
    }
}
