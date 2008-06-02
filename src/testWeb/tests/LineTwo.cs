using System;
using System.Collections.Generic;

using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class LineTwo : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "4c5e6f";
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
                chart.ChartBorder = SetChartBorder();
                chart.ChartGridH = SetChartGridH();
                chart.ChartGridV = SetChartGridV();
                chart.ChartPreferences = SetChartPreferences(xsc.XmlSwfChartType.Line);
                chart.ChartRectangle = SetChartRectangle();
                chart.ChartValue = SetChartValue();
                chart.DrawTexts = SetDrawText();
                chart.LegendRectangle = SetLegendRectangle();
                chart.SeriesColors = SetSeriesColors();
                
                return chart;
            }
        }
        #endregion

        #region Private Methods
        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData data = new xsc.ChartData();

            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "1", 10));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "2", 12));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "3", 11));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "4", 15));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "5", 20));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "6", 22));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "7", 21));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "8", 25));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "9", 31));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "10", 32));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "11", 28));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "12", 29));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "13", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "14", 41));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "15", 45));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "16", 50));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "17", 65));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "18", 45));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "19", 50));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "20", 51));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "21", 65));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "22", 60));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "23", 62));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "24", 65));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "25", 45));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "26", 55));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "27", 59));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "28", 52));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "29", 53));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "30", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region A", "31", 45));

            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "1", 30));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "2", 32));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "3", 35));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "4", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "5", 42));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "6", 35));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "7", 36));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "8", 31));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "9", 35));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "10", 36));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "11", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "12", 42));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "13", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "14", 38));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "15", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "16", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "17", 38));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "18", 36));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "19", 30));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "20", 29));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "21", 28));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "22", 25));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "23", 28));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "24", 29));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "25", 30));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "26", 40));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "27", 32));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "28", 33));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "29", 34));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "30", 30));
            data.AddDataPoint(new xsc.ChartDataPoint("Region B", "31", 35));

            return data;
        }
        #endregion

        #region SetAxisCategory()
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Size = 14;
            ac.Color = "000000";
            ac.Alpha = 0;
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Skip = 0;
            ac.Orientation = "horizontal";
            return ac;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.ValueTicks = true;
            at.CategoryTicks = true;
            at.MajorThickness = 2;
            at.MinorThickness = 1;
            at.MinorCount = 1;
            at.MajorColor = "000000";
            at.MinorColor = "222222";
            at.Position = "outside";
            return at;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Min = 0;
            av.Max = 120;
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "ffffff";
            av.Alpha = 50;
            av.Steps = 6;
            av.Prefix = "";
            av.Suffix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = true;
            return av;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.Color = "000000";
            cb.TopThickness = 2;
            cb.BottomThickness = 2;
            cb.LeftThickness = 2;
            cb.RightThickness = 2;
            return cb;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 10;
            cg.Color = "000000";
            cg.Thickness = 1;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartGridV()
        private xsc.ChartGrid SetChartGridV()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Vertical);
            cg.Alpha = 10;
            cg.Color = "000000";
            cg.Thickness = 1;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartPreferences()
        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType type)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(type);
            cp.LineThickness = 2;
            cp.PointShape = "none";
            cp.FillShape = false;
            return cp;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 40;
            cr.Y = 25;
            cr.Width = 335;
            cr.Height = 200;
            cr.PositiveColor = "000000";
            cr.PositiveAlpha = 30;
            cr.NegativeColor = "ff0000";
            cr.NegativeAlpha = 10;
            return cr;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Position = "cursor";
            cv.Size = 12;
            cv.Color = "ffffff";
            cv.Alpha = 75;
            return cv;
        }
        #endregion

        #region SetDrawText()
        private List<xsc.DrawText> SetDrawText()
        {
            List<xsc.DrawText> texts = new List<xsc.DrawText>();

            xsc.DrawText dt = new xsc.DrawText();
            dt.Color = "ffffff";
            dt.Alpha = 15;
            dt.Font = "Arial";
            dt.Rotation = -90;
            dt.Bold = true;
            dt.Size = 50;
            dt.X = -10;
            dt.Y = 348;
            dt.Width = 300;
            dt.Height = 150;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.top;
            dt.Text = "hertz";

            texts.Add(dt);

            dt = new xsc.DrawText();
            dt.Color = "000000";
            dt.Alpha = 15;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 60;
            dt.X = 0;
            dt.Y = 0;
            dt.Width = 320;
            dt.Height = 300;
            dt.HAlign = xsc.TextHAlign.left;
            dt.VAlign = xsc.TextVAlign.bottom;
            dt.Text = "output";

            texts.Add(dt);

            return texts;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = -100;
            lr.Y = -100;
            lr.Width = 10;
            lr.Height = 10;
            lr.Margin = 10;
            return lr;
        }
        #endregion

        #region SetSeriesColors()
        private List<string> SetSeriesColors()
        {
            List<string> c = new List<string>();
            c.Add("77bb11");
            c.Add("cc5511");
            return c;
        }
        #endregion
        #endregion
    }
}
