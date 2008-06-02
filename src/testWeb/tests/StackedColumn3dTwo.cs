using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class StackedColumn3dTwo : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "777788";
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
                c.AddChartType(xsc.XmlSwfChartType.ColumnStacked3d);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(xsc.ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(xsc.ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartValue = SetChartValue();

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("ff6600");
                c.AddSeriesColor("88ff00");
                c.AddSeriesColor("8866ff");
                c.SeriesGap = SetSeriesGap();
                return c;
            }
        }
        #endregion

        #region Helpers
        #region SetAxisCategory(xsc.XmlSwfChartType type)
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Size = 10;
            ac.Color = "ffffff";
            ac.Alpha = 75;
            return ac;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.CategoryTicks = true;
            at.ValueTicks = true;
            at.MinorCount = 1;
            return at;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Size = 10;
            av.Color = "ffffff";
            av.Alpha = 75;
            return av;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.TopThickness = 0;
            cb.BottomThickness = 2;
            cb.LeftThickness = 2;
            cb.RightThickness = 0;
            return cb;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("Region 1", "Su", 22);
            cd.AddDataPoint("Region 1", "M", 15);
            cd.AddDataPoint("Region 1", "Tu", 11);
            cd.AddDataPoint("Region 1", "W", 15);
            cd.AddDataPoint("Region 1", "Th", 20);
            cd.AddDataPoint("Region 1", "F", 22);
            cd.AddDataPoint("Region 1", "Sa", 21);

            cd.AddDataPoint("Region 2", "Su", 15);
            cd.AddDataPoint("Region 2", "M", 20);
            cd.AddDataPoint("Region 2", "Tu", 15);
            cd.AddDataPoint("Region 2", "W", 17);
            cd.AddDataPoint("Region 2", "Th", 25);
            cd.AddDataPoint("Region 2", "F", 12);
            cd.AddDataPoint("Region 2", "Sa", 11);

            cd.AddDataPoint("Region 3", "Su", 30);
            cd.AddDataPoint("Region 3", "M", 32);
            cd.AddDataPoint("Region 3", "Tu", 35);
            cd.AddDataPoint("Region 3", "W", 20);
            cd.AddDataPoint("Region 3", "Th", 30);
            cd.AddDataPoint("Region 3", "F", 30);
            cd.AddDataPoint("Region 3", "Sa", 36);
            return cd;
        }
        #endregion

        #region SetChartGrid(xsc.ChartGridType type)
        private xsc.ChartGrid SetChartGrid(xsc.ChartGridType type)
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(type);
            cg.Thickness = 1;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 60;
            cr.Y = 60;
            cr.Width = 300;
            cr.Height = 150;
            cr.PositiveColor = "888888";
            cr.PositiveAlpha = 50;
            return cr;
        }
        #endregion

        #region SetChartPreferences(xsc.XmlSwfChartType type)
        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType type)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(type);
            cp.RotationX = 15;
            cp.RotationY = 0;
            return cp;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "ffffcc";
            cv.BackgroundColor = "444488";
            cv.Alpha = 100;
            cv.Size = 12;
            cv.Position = "cursor";
            return cv;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Size = 12;
            ll.Color = "000000";
            ll.Alpha = 50;
            return ll;
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
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 0;
            sg.SetGap = 20;
            return sg;
        }
        #endregion
        #endregion
    }
}
