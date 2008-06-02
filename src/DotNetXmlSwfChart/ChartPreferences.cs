using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartPreferences : ChartSettingBase
    {
        #region Constructors
        public ChartPreferences(XmlSwfChartType chartType)
        {
            this.ChartType = chartType;
            
            if (chartType == XmlSwfChartType.Line)
            {
                this.ValueTypes.Add("line_thickness", typeof(int));
                this.ValueTypes.Add("point_shape", typeof(string));
                this.ValueTypes.Add("fill_shape", typeof(bool));
            }

            if (chartType == XmlSwfChartType.Bar || 
                chartType == XmlSwfChartType.BarFloating || 
                chartType == XmlSwfChartType.BarStacked)
            {
                this.ValueTypes.Add("reverse", typeof(bool));
            }

            if (chartType == XmlSwfChartType.Candlestick)
            {
                this.ValueTypes.Add("type", typeof(string));
                this.ValueTypes.Add("line_thickness", typeof(int));
                this.ValueTypes.Add("bull_color", typeof(string));
                this.ValueTypes.Add("bear_color", typeof(string));
            }

            if (chartType == XmlSwfChartType.Scatter)
            {
                this.ValueTypes.Add("point_size", typeof(int));
                this.ValueTypes.Add("point_shape", typeof(string));
                this.ValueTypes.Add("trend_thickness", typeof(int));
                this.ValueTypes.Add("trend_alpha", typeof(int));
                this.ValueTypes.Add("line_thickness", typeof(int));
                this.ValueTypes.Add("line_alpha", typeof(int));
            }

            if (chartType == XmlSwfChartType.Column3d || 
                chartType == XmlSwfChartType.ColumnParallel3d || 
                chartType == XmlSwfChartType.ColumnStacked3d || 
                chartType == XmlSwfChartType.Pie3d)
            {
                this.ValueTypes.Add("rotation_x", typeof(int));
                this.ValueTypes.Add("rotation_y", typeof(int));
            }

            if (chartType == XmlSwfChartType.Polar)
            {
                this.ValueTypes.Add("type", typeof(string));
                this.ValueTypes.Add("grid", typeof(string));
                this.ValueTypes.Add("line_thickness", typeof(int));
                this.ValueTypes.Add("point_shape", typeof(string));
                this.ValueTypes.Add("point_size", typeof(int));
                this.ValueTypes.Add("fill_shape", typeof(bool));
            }
        }
        #endregion

        #region Properties
        public XmlSwfChartType ChartType;

        public int LineThickness
        {
            get { return Convert.ToInt32(this.Values["line_thickness"]); }
            set { this.AddValue("line_thickness", value); }
        }

        public string PointShape
        {
            get { return this.Values["point_shape"]; }
            set { this.AddValue("point_shape", value); }
        }

        public bool FillShape
        {
            get { return Convert.ToBoolean(this.Values["fill_shape"]); }
            set { this.AddValue("fill_shape", value); }
        }

        public bool Reverse
        {
            get { return Convert.ToBoolean(this.Values["reverse"]); }
            set { this.AddValue("reverse", value); }
        }

        public string Type
        {
            get { return this.Values["type"]; }
            set { this.AddValue("type", value); }
        }

        public string BullColor
        {
            get { return this.Values["bull_color"]; }
            set { this.AddValue("bull_color", value); }
        }

        public string BearColor
        {
            get { return this.Values["bear_color"]; }
            set { this.AddValue("bear_color", value); }
        }

        public int PointSize
        {
            get { return Convert.ToInt32(this.Values["point_size"]); }
            set { this.AddValue("point_size", value); }
        }

        public int TrendThickness
        {
            get { return Convert.ToInt32(this.Values["trend_thickness"]); }
            set { this.AddValue("trend_thickness", value); }
        }

        public int LineAlpha
        {
            get { return Convert.ToInt32(this.Values["line_alpha"]); }
            set { this.AddValue("line_alphs", value); }
        }

        public int RotationX
        {
            get { return Convert.ToInt32(this.Values["rotation_x"]); }
            set { this.AddValue("rotation_x", value); }
        }

        public int RotationY
        {
            get { return Convert.ToInt32(this.Values["rotation_y"]); }
            set { this.AddValue("rotation_y", value); }
        }

        public string Grid
        {
            get { return this.Values["grid"]; }
            set { this.AddValue("grid", value); }
        }

        public override string ElementName
        {
            get { return "chart_pref"; }
        }
        #endregion
    }
}
