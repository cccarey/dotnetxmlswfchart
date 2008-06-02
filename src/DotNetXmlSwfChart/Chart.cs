using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class Chart
    {
        #region Constructors
        public Chart() { }
        #endregion

        #region Properties
        public ChartData Data;

        public AxisCategory AxisCategory;
        public AxisTicks AxisTicks;
        public AxisValue AxisValue;
        public List<string> AxisValueText;

        public ChartBorder ChartBorder;
        public ChartGrid ChartGridH;
        public ChartGrid ChartGridV;
        public ChartPreferences ChartPreferences;
        public ChartRectangle ChartRectangle;
        public ChartTransition ChartTransition;
        public List<XmlSwfChartType> ChartType;
        public ChartValue ChartValue;
        public List<List<string>> ChartValueText;

        public List<DrawCircle> DrawCircles;
        public List<DrawImage> DrawImages;
        public List<DrawLine> DrawLines;
        public List<DrawRectangle> DrawRectangles;
        public List<DrawText> DrawTexts;

        public LegendLabel LegendLabel;
        public LegendRectangle LegendRectangle;
        public LegendTransition LegendTransition;
        public List<LinkArea> LinkAreas;
        public LinkData LinkData;
        public LiveUpdate LiveUpdate;

        public List<string> SeriesColors;
        public List<int> SeriesExplode
        {
            get { return _seriesExplode; }
            set
            {
                CheckChartTypeSet();
                if (this.ChartType.Contains(XmlSwfChartType.Pie) ||
                    this.ChartType.Contains(XmlSwfChartType.Pie3d) ||
                    this.ChartType.Contains(XmlSwfChartType.Line) ||
                    this.ChartType.Contains(XmlSwfChartType.Scatter))
                {
                    _seriesExplode = value;
                }
                else
                {
                    throw new NotSupportedException("SeriesExplode only applies to pie, line and scatter chart types.");
                }
            }
        }
        private List<int> _seriesExplode = null;

        public SeriesGap SeriesGap
        {
            get { return _seriesGap; }
            set
            {
                CheckChartTypeSet();
                if (this.ChartType.Contains(XmlSwfChartType.Bar) ||
                    this.ChartType.Contains(XmlSwfChartType.BarFloating) ||
                    this.ChartType.Contains(XmlSwfChartType.BarStacked) ||
                    this.ChartType.Contains(XmlSwfChartType.Column) ||
                    this.ChartType.Contains(XmlSwfChartType.Column3d) ||
                    this.ChartType.Contains(XmlSwfChartType.ColumnFloating) ||
                    this.ChartType.Contains(XmlSwfChartType.ColumnParallel3d) ||
                    this.ChartType.Contains(XmlSwfChartType.ColumnStacked) ||
                    this.ChartType.Contains(XmlSwfChartType.ColumnStacked3d))
                {
                    _seriesGap = value;
                }
                else
                {
                    throw new NotSupportedException("SeriesGap only applies to bar and column chart types.");
                }
            }
        }
        private SeriesGap _seriesGap = null;
        
        public bool SeriesSwitch
        {
            get { return _seriesSwitch; }
            set
            {
                CheckChartTypeSet();
                if (this.ChartType.Count > 1 ||
                    this.ChartType.Contains(XmlSwfChartType.Line) ||
                    this.ChartType.Contains(XmlSwfChartType.Scatter) ||
                    this.ChartType.Contains(XmlSwfChartType.Area) ||
                    this.ChartType.Contains(XmlSwfChartType.AreaStacked))
                {
                    throw new NotSupportedException("SeriesSwitch not applicable to line, area, scatter or mixed charts");
                }
                _seriesSwitch = value;
            }
        }
        private bool _seriesSwitch = false;
        #endregion

        #region AddChartType(XmlSwfChartType)
        public void AddChartType(XmlSwfChartType type)
        {
            if (this.ChartType == null) this.ChartType = new List<XmlSwfChartType>();
            this.ChartType.Add(type);
        }
        #endregion

        #region AddAxisValueText(string)
        public void AddAxisValueText(string text)
        {
            if (this.AxisValueText == null) this.AxisValueText = new List<string>();
            this.AxisValueText.Add(text);
        }
        #endregion

        #region AddDrawCircle(DrawCircle)
        public void AddDrawCircle(DrawCircle circle)
        {
            if (this.DrawCircles == null) this.DrawCircles = new List<DrawCircle>();
            this.DrawCircles.Add(circle);
        }
        #endregion

        #region AddDrawImage(DrawImage)
        public void AddDrawImage(DrawImage image)
        {
            if (this.DrawImages == null) this.DrawImages = new List<DrawImage>();
            this.DrawImages.Add(image);
        }
        #endregion

        #region AddDrawLine(DrawLine)
        public void AddDrawLine(DrawLine line)
        {
            if (this.DrawLines == null) this.DrawLines = new List<DrawLine>();
            this.DrawLines.Add(line);
        }
        #endregion

        #region AddDrawRectangle(DrawRectangle)
        public void AddDrawRectangle(DrawRectangle rectangle)
        {
            if (this.DrawRectangles == null) this.DrawRectangles = new List<DrawRectangle>();
            this.DrawRectangles.Add(rectangle);
        }
        #endregion

        #region AddDrawText(DrawText)
        public void AddDrawText(DrawText text)
        {
            if (this.DrawTexts == null) this.DrawTexts = new List<DrawText>();
            this.DrawTexts.Add(text);
        }
        #endregion

        #region AddSeriesColor(string)
        public void AddSeriesColor(string color)
        {
            if (this.SeriesColors == null) this.SeriesColors = new List<string>();
            this.SeriesColors.Add(color);
        }
        #endregion

        #region AddSeriesExplode(int)
        public void AddSeriesExplode(int value)
        {
            if (this.SeriesExplode == null) this.SeriesExplode= new List<int>();
            this.SeriesExplode.Add(value);
        }
        #endregion

        #region CheckChartTypeSet() (private)
        private void CheckChartTypeSet()
        {
            if (this.ChartType == null || this.ChartType.Count == 0)
                throw new InvalidOperationException("ChartType must be set first.");
        }
        #endregion

        #region GetChartTypeString(type)
        private string GetChartTypeString(XmlSwfChartType type)
        {
            switch (type)
            {
                case XmlSwfChartType.ColumnStacked:
                    return "stacked column";
                case XmlSwfChartType.ColumnFloating:
                    return "floating column";
                case XmlSwfChartType.Column3d:
                    return "3d column";
                case XmlSwfChartType.ColumnStacked3d:
                    return "stacked 3d column";
                case XmlSwfChartType.ColumnParallel3d:
                    return "parallel 3d column";
                case XmlSwfChartType.Pie3d:
                    return "3d pie";
                case XmlSwfChartType.BarStacked:
                    return "stacked bar";
                case XmlSwfChartType.BarFloating:
                    return "floating bar";
                default:
                    return Enum.GetName(typeof(XmlSwfChartType), type);
            }
        }
        #endregion

        #region ToSourceXML()
        public string ToSourceXML()
        {
            StringBuilder sb = new StringBuilder();
            //sb.Append("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            sb.Append("<chart>");
            if (this.AxisCategory != null) sb.Append(this.AxisCategory.ToSourceXML());
            if (this.AxisTicks != null) sb.Append(this.AxisTicks.ToSourceXML());
            if (this.AxisValue != null) sb.Append(this.AxisValue.ToSourceXML());
            if (this.AxisValueText != null && this.AxisValueText.Count > 0)
            {
                sb.Append("<axis_value_text>");
                foreach (string value in this.AxisValueText)
                {
                    sb.AppendFormat("<string>{0}</string>", value);
                }
                sb.Append("</axis_value_text>");
            }
            if (this.ChartBorder != null) sb.Append(this.ChartBorder.ToSourceXML());
            if (this.Data != null) sb.Append(this.Data.ToSourceXML());
            if (this.ChartGridH != null) sb.Append(this.ChartGridH.ToSourceXML());
            if (this.ChartGridV != null) sb.Append(this.ChartGridV.ToSourceXML());
            if (this.ChartPreferences != null) sb.Append(this.ChartPreferences.ToSourceXML());
            if (this.ChartRectangle != null) sb.Append(this.ChartRectangle.ToSourceXML());
            if (this.ChartTransition != null) sb.Append(this.ChartTransition.ToSourceXML());
            if (this.ChartType != null)
            {
                if (this.ChartType.Count > 1)
                {
                    sb.Append("<chart_type>");
                    foreach (XmlSwfChartType type in this.ChartType)
                    {
                        sb.AppendFormat("<string>{0}</string>", GetChartTypeString(type));
                    }
                    sb.Append("</chart_type>");
                }
                else
                {
                    sb.AppendFormat("<chart_type>{0}</chart_type>", GetChartTypeString(this.ChartType[0]));
                }
            }
            if (this.ChartValue != null) sb.Append(this.ChartValue.ToSourceXML());
            if (this.ChartValueText != null)
            {
                sb.Append("<chart_value_text>");
                foreach (List<string> items in this.ChartValueText)
                {
                    sb.Append("<row>");
                    foreach (string item in items)
                    {
                        if (item == null)
                            sb.Append("<null/>");
                        else
                            sb.AppendFormat("<string>{0}</string>", item);
                    }
                    sb.Append("</row>");
                }
                sb.Append("</chart_value_text>");
            }
            if (this.DrawCircles != null ||
                this.DrawImages != null ||
                this.DrawLines != null ||
                this.DrawRectangles != null ||
                this.DrawTexts != null)
            {
                sb.Append("<draw>");
                if (this.DrawCircles != null)
                {
                    foreach (DrawCircle circle in this.DrawCircles)
                    {
                        sb.Append(circle.ToSourceXML());
                    }
                }
                if (this.DrawImages != null)
                {
                    foreach (DrawImage image in this.DrawImages)
                    {
                        sb.Append(image.ToSourceXML());
                    }
                }
                if (this.DrawLines != null)
                {
                    foreach (DrawLine line in this.DrawLines)
                    {
                        sb.Append(line.ToSourceXML());
                    }
                }
                if (this.DrawRectangles != null)
                {
                    foreach (DrawRectangle rectangle in this.DrawRectangles)
                    {
                        sb.Append(rectangle.ToSourceXML());
                    }
                }
                if (this.DrawTexts != null)
                {
                    foreach (DrawText text in this.DrawTexts)
                    {
                        sb.Append(text.ToSourceXML());
                    }
                }
                sb.Append("</draw>");
            }
            if (this.LegendLabel != null) sb.Append(this.LegendLabel.ToSourceXML());
            if (this.LegendRectangle != null) sb.Append(this.LegendRectangle.ToSourceXML());
            if (this.LegendTransition != null) sb.Append(this.LegendTransition.ToSourceXML());
            if (this.LinkAreas != null && this.LinkAreas.Count > 0)
            {
                sb.Append("<link>");
                foreach (LinkArea link in this.LinkAreas)
                {
                    sb.Append(link.ToSourceXML());
                }
                sb.Append("</link>");
            }
            if (this.LinkData != null) sb.Append(this.LinkData.ToSourceXML());
            if (this.LiveUpdate != null) sb.Append(this.LiveUpdate.ToSourceXML());
            if (this.SeriesColors != null && this.SeriesColors.Count > 0)
            {
                sb.Append("<series_color>");
                foreach (string color in this.SeriesColors)
                {
                    sb.AppendFormat("<color>{0}</color>", color);
                }
                sb.Append("</series_color>");
            }
            if (this.SeriesExplode != null && this.SeriesExplode.Count > 0)
            {
                sb.Append("<series_explode>");
                foreach (int explode in this.SeriesExplode)
                {
                    sb.AppendFormat("<number>{0}</number>", explode);
                }
                sb.Append("</series_explode>");
            }
            if (this.SeriesGap != null) sb.Append(this.SeriesGap.ToSourceXML());
            if (this.SeriesSwitch) sb.Append("<series_switch>true</series_switch>");
            sb.Append("</chart>");
            return sb.ToString();
        }
        #endregion
    }
}
