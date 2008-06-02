using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartValue : ChartSettingBase
    {
        #region Constructors
        public ChartValue()
        {
            this.ValueTypes.Add("prefix", typeof(string));
            this.ValueTypes.Add("suffix", typeof(string));
            this.ValueTypes.Add("decimals", typeof(int));
            this.ValueTypes.Add("decimal_char", typeof(string));
            this.ValueTypes.Add("separator", typeof(string));
            this.ValueTypes.Add("position", typeof(string));
            this.ValueTypes.Add("hide_zero", typeof(bool));
            this.ValueTypes.Add("as_percentage", typeof(bool));
            this.ValueTypes.Add("font", typeof(string));
            this.ValueTypes.Add("bold", typeof(bool));
            this.ValueTypes.Add("size", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("background_color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
        }
        #endregion

        #region Properties
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

        public string Position
        {
            get { return this.Values["position"]; }
            set { this.AddValue("position", value); }
        }

        public bool HideZero
        {
            get { return Convert.ToBoolean(this.Values["hide_zero"]); }
            set { this.AddValue("hide_zero", value); }
        }

        public bool AsPercentage
        {
            get { return Convert.ToBoolean(this.Values["as_percentage"]); }
            set { this.AddValue("as_percentage", value); }
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

        public override string ElementName
        {
            get { return "chart_value"; }
        }
        #endregion
    }
}
