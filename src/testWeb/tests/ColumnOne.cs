using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class ColumnOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ffffff";
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

                chart.AddChartType(xsc.XmlSwfChartType.Column);

                chart.AxisValue = SetAxisValue(xsc.XmlSwfChartType.Column);
                chart.ChartBorder = SetChartBorder();
                chart.Data = SetChartData();
                chart.ChartGridH = SetChartGridH();
                chart.ChartRectangle = SetChartRectangle();
                chart.ChartTransition = SetChartTransition();
                chart.ChartValue = SetChartValue();
                chart.DrawTexts = SetDrawTexts();
                chart.LegendLabel = SetLegendLabel();
                chart.LegendRectangle = SetLegendRectangle();
                chart.SeriesColors = SetSeriesColors();
                chart.SeriesGap = SetSeriesGap();
                return chart;
            }
        }
        #endregion

        #region Properties
        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue(xsc.XmlSwfChartType type)
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Min = -60;
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "000000";
            av.Alpha = 50;
            av.Steps = 4;
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
            cb.TopThickness = 1;
            cb.BottomThickness = 2;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
            return cb;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2005", -20));
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2006", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2007", 100));

            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2005", -40));
            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2006", 65));
            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2007", 80));
            return cd;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 20;
            cg.Color = "000000";
            cg.Thickness = 1;
            cg.GridLineType = xsc.ChartGridLineType.dashed;
            return cg;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 75;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 200;
            cr.PositiveColor = "000066";
            cr.NegativeColor = "000000";
            cr.PositiveAlpha = 10;
            cr.NegativeAlpha = 30;
            return cr;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.scale;
            ct.Delay = 0.5;
            ct.Duration = 0.5;
            ct.Order = xsc.TransitionOrder.series;
            return ct;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "ffffff";
            cv.Alpha = 85;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 10;
            cv.Position = "middle";
            cv.Suffix = "";
            cv.Prefix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = false;
            return cv;
        }
        #endregion

        #region SetDrawTexts()
        private List<xsc.DrawText> SetDrawTexts()
        {
            List<xsc.DrawText> t = new List<xsc.DrawText>();
            xsc.DrawText dt = new xsc.DrawText();
            dt.Color = "000000";
            dt.Alpha = 10;
            dt.Font = "Arial";
            dt.Rotation = -90;
            dt.Bold = true;
            dt.Size = 75;
            dt.X = -20;
            dt.Y = 300;
            dt.Width = 300;
            dt.Height = 200;
            dt.HAlign = xsc.TextHAlign.left;
            dt.VAlign = xsc.TextVAlign.top;
            dt.Text = "revenue";
            t.Add(dt);

            dt = new xsc.DrawText();
            dt.Color = "000033";
            dt.Alpha = 50;
            dt.Font = "Arial";
            dt.Rotation = -90;
            dt.Bold = true;
            dt.Size = 16;
            dt.X = 7;
            dt.Y = 230;
            dt.Width = 300;
            dt.Height = 50;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.middle;
            dt.Text = "(millions)";
            t.Add(dt);

            return t;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 12;
            ll.Color = "333355";
            ll.Alpha = 90;
            return ll;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 75;
            lr.Y = 27;
            lr.Width = 300;
            lr.Height = 20;
            lr.Margin = 5;
            lr.FillColor = "000066";
            lr.FillAlpha = 8;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion

        #region SetSeriesColors()
        private List<string> SetSeriesColors()
        {
            List<string> c = new List<string>();
            c.Add("666666");
            c.Add("768bb3");
            return c;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.SetGap = 40;
            sg.BarGap = -25;
            return sg;
        }
        #endregion
        #endregion
    }
}
