using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class ParallelColumn3DTwo : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                xsc.ChartHTML chartHtml = new xsc.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "667788";
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
                xsc.Chart c = new xsc.Chart();
                c.AddChartType(xsc.XmlSwfChartType.ColumnParallel3d);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(xsc.ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(xsc.ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartTransition = SetChartTransition();
                c.ChartValue = SetChartValue();

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("ff8844");
                c.AddSeriesColor("88ff00");
                c.SeriesGap = SetSeriesGap();

                return c;
            }
        }
        #endregion

        #region Helpers
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType xmlSwfChartType)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(xmlSwfChartType);
            ac.Size = 10;
            ac.Color = "ffffff";
            ac.Alpha = 75;
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Skip = 0;
            ac.Orientation = "diagonal_up";
            return ac;
        }

        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.ValueTicks = true;
            at.CategoryTicks = true;
            return at;
        }

        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Alpha = 90;
            av.Orientation = "horizontal";
            return av;
        }

        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.TopThickness = 0;
            cb.BottomThickness = 3;
            cb.LeftThickness = 3;
            cb.RightThickness = 0;
            return cb;
        }

        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("Region 1", "Su", 70);
            cd.AddDataPoint("Region 1", "M", 60);
            cd.AddDataPoint("Region 1", "Tu", 11);
            cd.AddDataPoint("Region 1", "W", 15);
            cd.AddDataPoint("Region 1", "Th", 20);
            cd.AddDataPoint("Region 1", "F", 22);
            cd.AddDataPoint("Region 1", "Sa", 21);

            cd.AddDataPoint("Region 2", "Su", 30);
            cd.AddDataPoint("Region 2", "M", 32);
            cd.AddDataPoint("Region 2", "Tu", 35);
            cd.AddDataPoint("Region 2", "W", 80);
            cd.AddDataPoint("Region 2", "Th", 84);
            cd.AddDataPoint("Region 2", "F", 70);
            cd.AddDataPoint("Region 2", "Sa", 36);
            return cd;
        }

        private xsc.ChartGrid SetChartGrid(xsc.ChartGridType chartGridType)
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(chartGridType);
            cg.Thickness = 1;
            cg.Color = "000000";
            cg.Alpha = 20;
            return cg;
        }

        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = -15;
            cr.Y = 25;
            cr.Width = 425;
            cr.Height = 200;
            cr.PositiveAlpha = 20;
            return cr;
        }

        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType xmlSwfChartType)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(xmlSwfChartType);
            cp.RotationX = 20;
            cp.RotationY = 40;
            return cp;
        }

        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.blink;
            ct.Delay = 0.5;
            ct.Duration = 1;
            ct.Order = xsc.TransitionOrder.series;
            return ct;
        }

        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "000000";
            cv.BackgroundColor = "ffff00";
            cv.Alpha = 90;
            cv.Size = 12;
            cv.Position = "cursor";
            return cv;
        }

        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 12;
            ll.Color = "000000";
            ll.Alpha = 50;
            return ll;
        }

        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 25;
            lr.Y = 250;
            lr.Width = 350;
            lr.Height = 50;
            lr.Margin = 20;
            lr.FillColor = "000000";
            lr.FillAlpha = 7;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }

        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 50;
            sg.SetGap = 50;
            return sg;
        }
        #endregion
    }
}
