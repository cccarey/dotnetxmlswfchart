using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartRectangle : ChartSettingBase
    {
        #region Constructors
        public ChartRectangle()
        {
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("width", typeof(int));
            this.ValueTypes.Add("height", typeof(int));
            this.ValueTypes.Add("positive_color", typeof(string));
            this.ValueTypes.Add("negative_color", typeof(string));
            this.ValueTypes.Add("positive_alpha", typeof(int));
            this.ValueTypes.Add("negative_alpha", typeof(int));
        }
        #endregion

        #region Properties
        public int X
        {
            get { return Convert.ToInt32(this.Values["x"]); }
            set { this.AddValue("x", value); }
        }

        public int Y
        {
            get { return Convert.ToInt32(this.Values["y"]); }
            set { this.AddValue("y", value); }
        }

        public int Width
        {
            get { return Convert.ToInt32(this.Values["width"]); }
            set { this.AddValue("width", value); }
        }

        public int Height
        {
            get { return Convert.ToInt32(this.Values["height"]); }
            set { this.AddValue("height", value); }
        }

        public string PositiveColor
        {
            get { return this.Values["positive_color"]; }
            set { this.AddValue("positive_color", value); }
        }

        public string NegativeColor
        {
            get { return this.Values["negative_color"]; }
            set { this.AddValue("negative_color", value); }
        }

        public int PositiveAlpha
        {
            get { return Convert.ToInt32(this.Values["positive_alpha"]); }
            set { this.AddValue("positive_alpha", value); }
        }

        public int NegativeAlpha
        {
            get { return Convert.ToInt32(this.Values["negative_alpha"]); }
            set { this.AddValue("negative_alpha", value); }
        }

        public override string ElementName
        {
            get { return "chart_rect"; }
        }
        #endregion
    }
}
