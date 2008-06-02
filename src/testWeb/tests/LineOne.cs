using System;
using System.Collections.Generic;

using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class LineOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ff8800";
                chartHtml.flashFile = "charts/charts.swf";
                chartHtml.libraryPath = "charts/charts_library";
                chartHtml.xmlSource = "xmlData.aspx";
                return chartHtml;
            }
        }
        #endregion

        #region Chart
        public override DotNetXmlSwfChart.Chart Chart
        {
            get 
            {
                xsc.Chart chart = new xsc.Chart();
                chart.AddChartType(xsc.XmlSwfChartType.Line);

                chart.Data = SetChartData();

                chart.AxisCategory = SetAxisCategory(xsc.XmlSwfChartType.Line);
                chart.AxisTicks = SetAxisTicks();
                chart.AxisValue = SetAxisValue();
                chart.ChartGridH = SetChartGridH();
                chart.ChartPreferences = SetChartPreferences();
                chart.ChartRectangle = SetChartRectangle();
                chart.ChartTransition = SetChartTransition();
                chart.ChartValue = SetChartValue();
                chart.DrawTexts = SetDrawText();
                chart.LegendLabel = SetLegendLabel();
                chart.LegendRectangle = SetLegendRectangle();
                chart.LegendTransition = SetLegendTransition();
                chart.SeriesColors = SetSeriesColors();
                chart.SeriesExplode = SetSeriesExplode();

                return chart;
            }
        }
        #endregion

        #region Private Methods
        #region SetAxisCategory(chartType)
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType Type)
        {
            xsc.AxisCategory setting = new xsc.AxisCategory(xsc.XmlSwfChartType.Line);
            setting.Size = 16;
            setting.Color = "000000";
            setting.Alpha = 75;
            setting.Skip = 0;
            setting.Orientation = "horizontal";
            return setting;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks setting = new xsc.AxisTicks();
            setting.ValueTicks = false;
            setting.CategoryTicks = true;
            setting.MajorThickness = 2;
            setting.MinorThickness = 1;
            setting.MinorCount = 1;
            setting.MajorColor = "000000";
            setting.MinorColor = "222222";
            setting.Position = "inside";
            return setting;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue setting = new xsc.AxisValue();
            setting.Min = -40;
            setting.Size = 10;
            setting.Color = "ffffff";
            setting.Alpha = 50;
            setting.Steps = 6;
            setting.Prefix = "";
            setting.Suffix = "";
            setting.Decimals = 0;
            setting.Separator = "";
            setting.ShowMin = false;
            return setting;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData data = new xsc.ChartData();

            data.AddDataPoint(new xsc.ChartDataPoint("region1", "2004", 48));
            data.AddDataPoint(new xsc.ChartDataPoint("region1", "2005", 55));
            data.AddDataPoint(new xsc.ChartDataPoint("region1", "2006", 80));
            data.AddDataPoint(new xsc.ChartDataPoint("region1", "2007", 100));

            data.AddDataPoint(new xsc.ChartDataPoint("region2", "2004", -12));
            data.AddDataPoint(new xsc.ChartDataPoint("region2", "2005", 10));
            data.AddDataPoint(new xsc.ChartDataPoint("region2", "2006", 55));
            data.AddDataPoint(new xsc.ChartDataPoint("region2", "2007", 65));

            data.AddDataPoint(new xsc.ChartDataPoint("region3", "2004", 27));
            data.AddDataPoint(new xsc.ChartDataPoint("region3", "2005", -20));
            data.AddDataPoint(new xsc.ChartDataPoint("region3", "2006", 15));
            data.AddDataPoint(new xsc.ChartDataPoint("region3", "2007", 80));
            
            return data;
        }
        #endregion

        #region SetChartGrid()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid setting = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            setting.Alpha = 10;
            setting.Color = "000000";
            setting.Thickness = 1;
            return setting;
        }
        #endregion

        #region SetChartPreferences()
        private xsc.ChartPreferences SetChartPreferences()
        {
            xsc.ChartPreferences setting = new xsc.ChartPreferences(xsc.XmlSwfChartType.Line);
            setting.LineThickness = 2;
            setting.PointShape = "circle";
            setting.FillShape = false;
            return setting;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle setting = new xsc.ChartRectangle();
            setting.X = 50;
            setting.Y = 100;
            setting.Width = 320;
            setting.Height = 150;
            setting.PositiveColor = "ffffff";
            setting.PositiveAlpha = 50;
            setting.NegativeColor = "000000";
            setting.NegativeAlpha = 10;
            return setting;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition setting = new xsc.ChartTransition();
            setting.TransitionType = xsc.TransitionType.slide_left;
            setting.Delay = 0.5;
            setting.Duration = 0.5;
            setting.Order = xsc.TransitionOrder.series;
            return setting;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue setting = new xsc.ChartValue();
            setting.Position = "cursor";
            setting.Size = 12;
            setting.Color = "000000";
            setting.BackgroundColor = "aaff00";
            setting.Alpha = 80;
            return setting;
        }
        #endregion

        #region SetDrawText()
        private List<xsc.DrawText> SetDrawText()
        {
            xsc.DrawText dt = new xsc.DrawText();
            dt.Transition = xsc.TransitionType.dissolve;
            dt.Delay = 0.0;
            dt.Duration = 0.5;
            dt.Color = "000000";
            dt.Alpha = 8;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 48;
            dt.X = 8;
            dt.Y = 7;
            dt.Width = 400;
            dt.Height = 75;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.bottom;
            dt.Text = "annual report";
            
            List<xsc.DrawText> list = new List<xsc.DrawText>();
            list.Add(dt);
            return list;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel setting = new xsc.LegendLabel();
            setting.Layout = xsc.LegendLabelLayout.horizontal;
            setting.Bullet = xsc.LegendLabelBullet.line;
            setting.Font = "Arial";
            setting.Bold = true;
            setting.Size = 13;
            setting.Color = "ffffff";
            setting.Alpha = 65;
            return setting;
        }
        #endregion

        #region SetLegendRectange()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle setting = new xsc.LegendRectangle();
            setting.X = 50;
            setting.Y = 75;
            setting.Width = 320;
            setting.Height = 5;
            setting.Margin = 5;
            setting.FillColor = "000000";
            setting.FillAlpha = 7;
            setting.LineColor = "000000";
            setting.LineAlpha = 0;
            setting.LineThickness = 0;
            return setting;
        }
        #endregion

        #region SetLegendTransition()
        private xsc.LegendTransition SetLegendTransition()
        {
            xsc.LegendTransition setting = new xsc.LegendTransition();
            setting.Type = xsc.TransitionType.dissolve;
            setting.Delay = 0;
            setting.Duration = 0.5;
            return setting;
        }
        #endregion

        #region SetSeriesColors()
        private List<string> SetSeriesColors()
        {
            List<string> colors = new List<string>();
            colors.Add("ff4444");
            colors.Add("ffff00");
            colors.Add("8844ff");
            return colors;
        }
        #endregion

        #region SetSeriesExplode()
        private List<int> SetSeriesExplode()
        {
            List<int> e = new List<int>();
            e.Add(400);
            return e;
        }
        #endregion
        #endregion
    }
}
