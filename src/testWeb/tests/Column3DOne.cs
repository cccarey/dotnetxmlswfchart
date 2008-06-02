using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class Column3DOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "aaff88";
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
                xsc.Chart c = new xsc.Chart();
                c.AddChartType(xsc.XmlSwfChartType.Column3d);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.LiveUpdate = SetLiveUpdate();

                c.AddSeriesColor("666666");
                c.AddSeriesColor("768bb3");
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
            sg.SetGap = 20;
            sg.BarGap = 10;
            return sg;
        }
        #endregion

        #region SetLiveUpdate()
        private xsc.LiveUpdate SetLiveUpdate()
        {
            xsc.LiveUpdate lu = new xsc.LiveUpdate();
            lu.Url = string.Format("xmlData.aspx?test=column3d1");
            lu.Delay = 5;
            return lu;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 50;
            lr.Y = 35;
            lr.Width = 100;
            lr.Height = 40;
            lr.Margin = 5;
            lr.FillColor = "000066";
            lr.FillAlpha = 0;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.vertical;
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
            cv.Size = 10;
            cv.Position = "over";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = true;
            return cv;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = -60;
            cr.Y = 30;
            cr.Width = 480;
            cr.Height = 240;
            cr.PositiveAlpha = 0;
            cr.NegativeAlpha = 25;
            return cr;
        }
        #endregion

        #region SetChartPreferences(xsc.XmlSwfChartType type)
        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType type)
        {
            Random rand = new Random();
            xsc.ChartPreferences cp = new xsc.ChartPreferences(type);
            cp.RotationX = rand.Next(20, 40);
            cp.RotationY = rand.Next(20, 40);
            return cp;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Thickness = 0;
            return cg;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("region 1", "2005", 50);
            cd.AddDataPoint("region 1", "2006", 70);
            cd.AddDataPoint("region 1", "2007", 110);

            cd.AddDataPoint("region 2", "2005", 25);
            cd.AddDataPoint("region 2", "2006", 50);
            cd.AddDataPoint("region 2", "2007", 90);
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
            ac.Size = 12;
            ac.Color = "000000";
            ac.Alpha = 50;
            ac.Skip = 0;
            ac.Orientation = "horizontal";
            return ac;
        }
        #endregion
        #endregion
    }
}
