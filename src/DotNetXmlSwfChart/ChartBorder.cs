using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartBorder : ChartSettingBase
    {
        #region Constructors
        public ChartBorder()
        {
            this.ValueTypes.Add("top_thickness", typeof(int));
            this.ValueTypes.Add("bottom_thickness", typeof(int));
            this.ValueTypes.Add("left_thickness", typeof(int));
            this.ValueTypes.Add("right_thickness", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
        }
        #endregion

        #region Properties
        public int TopThickness
        {
            get { return Convert.ToInt32(this.Values["top_thickness"]); }
            set { this.AddValue("top_thickness", value); }
        }

        public int BottomThickness
        {
            get { return Convert.ToInt32(this.Values["bottom_thickness"]); }
            set { this.AddValue("bottom_thickness", value); }
        }

        public int LeftThickness
        {
            get { return Convert.ToInt32(this.Values["left_thickness"]); }
            set { this.AddValue("left_thickness", value); }
        }

        public int RightThickness
        {
            get { return Convert.ToInt32(this.Values["right_thickness"]); }
            set { this.AddValue("right_thickness", value); }
        }

        public string Color
        {
            get { return this.Values["color"]; }
            set { this.AddValue("color", value); }
        }

        public override string ElementName
        {
            get { return "chart_border"; }
        }
        #endregion
    }
}
