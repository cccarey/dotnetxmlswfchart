using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class Column3DTwo : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                xsc.ChartHTML chartHtml = new xsc.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "888888";
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
                c.AddChartType(xsc.XmlSwfChartType.Column3d);

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
                c.LegendTransition = SetLegendTransition();

                c.AddSeriesColor("ff8800");
                c.AddSeriesColor("88ff00");
                c.SeriesGap = SetSeriesGap();

                return c;
            }
        }
        #endregion

        #region Helpers
        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 0;
            sg.SetGap = 20;
            return sg;
        }
        #endregion

        #region SetLegendTransition()
        private xsc.LegendTransition SetLegendTransition()
        {
            xsc.LegendTransition lt = new xsc.LegendTransition();
            lt.Type = xsc.TransitionType.dissolve;
            lt.Delay = 0;
            lt.Duration = 1;
            return lt;
        }
        #endregion

        #region SetLegendRectangle()
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
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
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
            ll.Color = "000000";
            ll.Alpha = 50;
            return ll;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.HideZero = true;
            cv.Color = "000000";
            cv.Alpha = 80;
            cv.Size = 12;
            cv.Position = "cursor";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = true;
            return cv;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.slide_left;
            ct.Delay = 0;
            ct.Duration = 1;
            ct.Order = xsc.TransitionOrder.series;
            return ct;
        }
        #endregion

        #region SetChartPreferences(xsc.XmlSwfChartType type)
        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType type)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(type);
            cp.RotationX = 20;
            cp.RotationY = 50;
            return cp;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = -70;
            cr.Y = -35;
            cr.Width = 500;
            cr.Height = 250;
            cr.PositiveAlpha = 0;
            return cr;
        }
        #endregion

        #region SetChartGrid(xsc.ChartGridType type)
        private xsc.ChartGrid SetChartGrid(xsc.ChartGridType type)
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(type);
            cg.Thickness = 0;
            return cg;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("Region 1", "Su", 70);
            cd.AddDataPoint("Region 1", "M", 60);
            cd.AddDataPoint("Region 1", "Tu", 11);
            cd.AddDataPoint("Region 1", "W", 15);
            cd.AddDataPoint("Region 1", "Th", 20);
            cd.AddDataPoint("Region 1", "F", 22);
            cd.AddDataPoint("Region 1", "Sa", 11);

            cd.AddDataPoint("Region 2", "Su", 30);
            cd.AddDataPoint("Region 2", "M", 32);
            cd.AddDataPoint("Region 2", "Tu", 35);
            cd.AddDataPoint("Region 2", "W", 80);
            cd.AddDataPoint("Region 2", "Th", 84);
            cd.AddDataPoint("Region 2", "F", 70);
            cd.AddDataPoint("Region 2", "Sa", 36);
            return cd;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.TopThickness = 0;
            cb.BottomThickness = 0;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
            return cb;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Alpha = 0;
            return av;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.ValueTicks = false;
            at.CategoryTicks = false;
            return at;
        }
        #endregion

        #region SetAxisCategory(xsc.XmlSwfChartType type)
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Size = 10;
            ac.Color = "ffffff";
            ac.Alpha = 75;
            ac.Skip = 0;
            ac.Orientation = "diagonal_up";
            return ac;
        }
        #endregion
        #endregion
    }
}
