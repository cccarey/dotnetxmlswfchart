using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class StackedColumnOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "aab0bb";
                chartHtml.flashFile = "charts/charts.swf";
                chartHtml.libraryPath = "charts/charts_library";
                chartHtml.xmlSource = "xmlData.aspx";
                return chartHtml;
            }
        }
        #endregion

        #region Chart
        public override xsc.Chart Chart
        {
            get
            {
                xsc.Chart chart = new xsc.Chart();
                chart.AddChartType(xsc.XmlSwfChartType.ColumnStacked);

                chart.AxisValue = SetAxisValue();

                chart.ChartBorder = SetChartBorder();
                chart.Data = SetChartData();
                chart.ChartGridH = SetChartGridH();
                chart.ChartGridV = SetChartGridV();
                chart.ChartRectangle = SetChartRectangle();
                chart.ChartTransition = SetChartTransition();

                chart.DrawTexts = SetDrawTexts();

                chart.LegendLabel = SetLegendLabel();
                chart.LegendRectangle = SetLegendRectangle();
                chart.LegendTransition = SetLegendTransition();

                chart.SeriesColors = SetSeriesColors();
                return chart;
            }
        }
        #endregion

        #region Properties
        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "000000";
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
            cb.TopThickness = 0;
            cb.BottomThickness = 3;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
            return cb;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2005", -15));
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2006", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("region A", "2007", 100));

            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2005", 25));
            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2006", 65));
            cd.AddDataPoint(new xsc.ChartDataPoint("region B", "2007", 80));

            cd.AddDataPoint(new xsc.ChartDataPoint("region C", "2005", 10));
            cd.AddDataPoint(new xsc.ChartDataPoint("region C", "2006", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("region C", "2007", 5));
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
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartGridV()
        private xsc.ChartGrid SetChartGridV()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Vertical);
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
            cr.X = 125;
            cr.Y = 65;
            cr.Width = 250;
            cr.Height = 200;
            cr.PositiveColor = "ffffff";
            cr.NegativeColor = "000000";
            cr.PositiveAlpha = 75;
            cr.NegativeAlpha = 15;
            return cr;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.drop;
            ct.Delay = 0;
            ct.Duration = 2;
            ct.Order = xsc.TransitionOrder.series;
            return ct;
        }
        #endregion

        #region SetDrawTexts()
        private List<xsc.DrawText> SetDrawTexts()
        {
            List<xsc.DrawText> text = new List<xsc.DrawText>();
            xsc.DrawText dt = new xsc.DrawText();
            dt.Transition = xsc.TransitionType.slide_up;
            dt.Delay = 1;
            dt.Duration = 0.5;
            dt.Color = "000033";
            dt.Alpha = 15;
            dt.Font = "Arial";
            dt.Rotation = -90;
            dt.Bold = true;
            dt.Size = 64;
            dt.X = 0;
            dt.Y = 295;
            dt.Width = 300;
            dt.Height = 50;
            dt.HAlign = xsc.TextHAlign.right;
            dt.VAlign = xsc.TextVAlign.middle;
            dt.Text = "GROWTH";
            text.Add(dt);

            dt = new xsc.DrawText();
            dt.Transition = xsc.TransitionType.slide_up;
            dt.Delay = 1;
            dt.Duration = 0.5;
            dt.Color = "ffffff";
            dt.Alpha = 40;
            dt.Font = "Arial";
            dt.Rotation = -90;
            dt.Bold = true;
            dt.Size = 25;
            dt.X = 30;
            dt.Y = 300;
            dt.Width = 300;
            dt.Height = 50;
            dt.HAlign = xsc.TextHAlign.right;
            dt.VAlign = xsc.TextVAlign.middle;
            dt.Text = "report";
            text.Add(dt);
            return text;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 13;
            ll.Color = "444466";
            ll.Alpha = 90;
            return ll;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 125;
            lr.Y = 10;
            lr.Width = 250;
            lr.Height = 10;
            lr.Margin = 5;
            lr.FillColor = "ffffff";
            lr.FillAlpha = 35;
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion

        #region SetLegendTransition()
        private xsc.LegendTransition SetLegendTransition()
        {
            xsc.LegendTransition lt = new xsc.LegendTransition();
            lt.Type = xsc.TransitionType.slide_left;
            lt.Delay = 0;
            lt.Duration = 1;
            return lt;
        }
        #endregion

        #region SetSeriesColors()
        private List<string> SetSeriesColors()
        {
            List<string> c = new List<string>();
            c.Add("4e627c");
            c.Add("844648");
            c.Add("c89341");
            return c;
        }
        #endregion
        #endregion
    }
}
