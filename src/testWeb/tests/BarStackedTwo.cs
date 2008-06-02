using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class BarStackedTwo : ChartTestBase
    {
        #region ChartInclude
        public override ChartHTML ChartInclude
        {
            get
            {
                ChartHTML chartHtml = new ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "eecc55";
                chartHtml.flashFile = "charts/charts.swf";
                chartHtml.libraryPath = "charts/charts_library";
                chartHtml.xmlSource = "xmlData.aspx";
                return chartHtml;
            }
        }
        #endregion

        #region Chart
        public override Chart Chart
        {
            get
            {
                Chart c = new Chart();
                c.AddChartType(XmlSwfChartType.BarStacked);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartTransition = SetChartTransition();

                c.AddDrawText(CreateDrawText(1));
                c.AddDrawText(CreateDrawText(2));

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();
                c.LegendTransition = SetLegendTransition();

                c.AddSeriesColor("5a4b6e");
                c.AddSeriesColor("4c6b41");

                return c;
            }
        }
        #endregion

        #region Helpers
        private AxisCategory SetAxisCategory(XmlSwfChartType xmlSwfChartType)
        {
            AxisCategory ac = new AxisCategory(xmlSwfChartType);
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Size = 13;
            ac.Color = "000022";
            ac.Alpha = 50;
            ac.Skip = 0;
            ac.Orientation = "diagonal_up";
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = false;
            at.CategoryTicks = true;
            at.MajorThickness = 0;
            at.MinorThickness = 0;
            at.MinorCount = 3;
            at.MajorColor = "000000";
            at.MinorColor = "888888";
            at.Position = "outside";
            return at;
        }

        private AxisValue SetAxisValue()
        {
            AxisValue av = new AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "000022";
            av.Alpha = 50;
            av.Steps = 4;
            av.Prefix = "";
            av.Suffix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = true;
            av.Orientation = "horizontal";
            return av;
        }

        private ChartBorder SetChartBorder()
        {
            ChartBorder cb = new ChartBorder();
            cb.Color = "000000";
            cb.TopThickness = 0;
            cb.BottomThickness = 0;
            cb.LeftThickness = 3;
            cb.RightThickness = 0;
            return cb;
        }

        private ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("region A", "2004", -60);
            cd.AddDataPoint("region A", "2005", -25);
            cd.AddDataPoint("region A", "2006", 75);
            cd.AddDataPoint("region A", "2007", 50);

            cd.AddDataPoint("region B", "2004", 60);
            cd.AddDataPoint("region B", "2005", 10);
            cd.AddDataPoint("region B", "2006", 75);
            cd.AddDataPoint("region B", "2007", 25);
            return cd;
        }

        private ChartGrid SetChartGrid(ChartGridType chartGridType)
        {
            ChartGrid cg = new ChartGrid(chartGridType);
            cg.Alpha = 10;
            cg.Color = "000000";
            switch (chartGridType)
            {
                case ChartGridType.Horizontal:
                    cg.Thickness = 5;
                    break;
                case ChartGridType.Vertical:
                    cg.Thickness = 1;
                    break;
            }
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 320;
            cr.Height = 200;
            cr.PositiveColor = "00ff00";
            cr.NegativeColor = "ff0000";
            cr.PositiveAlpha = 20;
            cr.NegativeAlpha = 20;
            return cr;
        }

        private ChartTransition SetChartTransition()
        {
            ChartTransition ct = new ChartTransition();
            ct.TransitionType = TransitionType.slide_right;
            ct.Delay = 0;
            ct.Duration = 0.75;
            ct.Order = TransitionOrder.series;
            return ct;
        }

        private DrawText CreateDrawText(int p)
        {
            DrawText dt = new DrawText();
            dt.Transition = TransitionType.dissolve;
            dt.Delay = 1.5;
            dt.Duration = 0.5;
            dt.Color="000033";
            dt.Alpha = 15;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 30;
            dt.X = 0;
            dt.Y = 5;
            dt.Width = 372;
            dt.Height = 40;
            dt.HAlign = TextHAlign.right;
            dt.VAlign = TextVAlign.bottom;
            dt.Text = "regional report";
            if (p == 2)
            {
                dt.Color = "ffffff";
                dt.Rotation = -5;
                dt.Size = 150;
                dt.X = 110;
                dt.Y = 290;
                dt.Width = 400;
                dt.Height = 50;
                dt.HAlign = TextHAlign.left;
                dt.Text = "2007";
            }
            return dt;
        }

        private LegendLabel SetLegendLabel()
        {
            LegendLabel ll = new LegendLabel();
            ll.Layout = LegendLabelLayout.vertical;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 13;
            ll.Color = "000022";
            ll.Alpha = 50;
            return ll;
        }

        private LegendRectangle SetLegendRectangle()
        {
            LegendRectangle lr = new LegendRectangle();
            lr.X = 50;
            lr.Y = 15;
            lr.Width = 10;
            lr.Height = 30;
            lr.Margin = 0;
            lr.FillColor = "000066";
            lr.FillAlpha = 0;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }

        private LegendTransition SetLegendTransition()
        {
            LegendTransition lt = new LegendTransition();
            lt.Type = TransitionType.dissolve;
            lt.Delay = 2;
            lt.Duration = 0.5;
            return lt;
        }
        #endregion
    }
}
