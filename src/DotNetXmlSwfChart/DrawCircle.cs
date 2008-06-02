using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class DrawCircle : DrawBase
    {
        #region Constructors
        public DrawCircle() : base()
        {
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("radius", typeof(int));
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

        public int Radius
        {
            get { return Convert.ToInt32(this.Values["radius"]); }
            set { this.AddValue("radius", value); }
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
            get { return "circle"; }
        }
        #endregion
    }
}
