using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LegendRectangle : ChartSettingBase
    {
        #region Constructors
        public LegendRectangle()
        {
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("width", typeof(int));
            this.ValueTypes.Add("height", typeof(int));
            this.ValueTypes.Add("margin", typeof(int));
            this.ValueTypes.Add("fill_color", typeof(string));
            this.ValueTypes.Add("fill_alpha", typeof(int));
            this.ValueTypes.Add("line_color", typeof(string));
            this.ValueTypes.Add("line_alpha", typeof(int));
            this.ValueTypes.Add("line_thickness", typeof(int));
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

        public int Margin
        {
            get { return Convert.ToInt32(this.Values["margin"]); }
            set { this.AddValue("margin", value); }
        }

        public string FillColor
        {
            get { return this.Values["fill_color"]; }
            set { this.AddValue("fill_color", value); }
        }

        public int FillAlpha
        {
            get { return Convert.ToInt32(this.Values["fill_alpha"]); }
            set { this.AddValue("fill_alpha", value); }
        }

        public string LineColor
        {
            get { return this.Values["line_color"]; }
            set { this.AddValue("line_color", value); }
        }

        public int LineAlpha
        {
            get { return Convert.ToInt32(this.Values["line_alpha"]); }
            set { this.AddValue("line_alpha", value); }
        }

        public int LineThickness
        {
            get { return Convert.ToInt32(this.Values["line_thickness"]); }
            set { this.AddValue("line_thickness", value); }
        }

        public override string ElementName
        {
            get { return "legend_rect"; }
        }
        #endregion
    }
}
