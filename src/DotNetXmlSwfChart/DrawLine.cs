using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class DrawLine : DrawBase
    {
        #region Constructors
        public DrawLine() : base()
        {
            this.ValueTypes.Add("x1", typeof(int));
            this.ValueTypes.Add("y1", typeof(int));
            this.ValueTypes.Add("x2", typeof(int));
            this.ValueTypes.Add("y2", typeof(int));
            this.ValueTypes.Add("line_color", typeof(string));
            this.ValueTypes.Add("line_alpha", typeof(int));
            this.ValueTypes.Add("line_thickness", typeof(int));
        }
        #endregion

        #region Properties
        public int X1
        {
            get { return Convert.ToInt32(this.Values["x1"]); }
            set { this.AddValue("x1", value); }
        }

        public int Y1
        {
            get { return Convert.ToInt32(this.Values["y1"]); }
            set { this.AddValue("y1", value); }
        }

        public int X2
        {
            get { return Convert.ToInt32(this.Values["x2"]); }
            set { this.AddValue("x2", value); }
        }

        public int Y2
        {
            get { return Convert.ToInt32(this.Values["y2"]); }
            set { this.AddValue("y2", value); }
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
            get { return "line"; }
        }
        #endregion
    }
}
