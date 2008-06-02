using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class StackedColumn3dOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "aa88ff";
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
                c.AddChartType(xsc.XmlSwfChartType.ColumnStacked3d);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartRectangle = SetChartRectangle();
                c.ChartTransition = SetChartTransition();
                c.ChartValue = SetChartValue();

                c.AddDrawImage(CreateDrawImage());

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.LinkAreas = SetLinkAreas();

                c.AddSeriesColor("666666");
                c.AddSeriesColor("768bb3");
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
            ac.Size = 12;
            ac.Color = "ffffff";
            ac.Alpha = 75;
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
            at.ValueTicks = false;
            at.CategoryTicks = false;
            return at;
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

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("Region 1", "2005", 50);
            cd.AddDataPoint("Region 1", "2006", 70);
            cd.AddDataPoint("Region 1", "2007", 110);

            cd.AddDataPoint("Region 2", "2005", 35);
            cd.AddDataPoint("Region 2", "2006", 50);
            cd.AddDataPoint("Region 2", "2007", 90);
            return cd;
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

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = -25;
            cr.Y = -10;
            cr.Width = 425;
            cr.Height = 245;
            cr.PositiveAlpha = 0;
            cr.NegativeAlpha = 25;
            return cr;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.slide_down;
            ct.Delay = 0;
            ct.Duration = 1;
            ct.Order = xsc.TransitionOrder.series;
            return ct;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.HideZero = true;
            cv.Color = "000000";
            cv.Alpha = 70;
            cv.Size = 9;
            cv.Position = "middle";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = true;
            return cv;
        }
        #endregion

        #region CreateDrawImage()
        private xsc.DrawImage CreateDrawImage()
        {
            xsc.DrawImage di = new xsc.DrawImage();
            di.Transition = xsc.TransitionType.dissolve;
            di.Delay = 1;
            di.Duration = 0.6;
            di.Url = "images/button.swf";
            di.X = 300;
            di.Y = 250;
            di.Width = 70;
            di.Height = 25;
            return di;
        }
        #endregion

        #region SetLegendLabel()
        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Size = 0;
            ll.Alpha = 0;
            return ll;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 0;
            lr.Y = 300;
            lr.Width = 0;
            lr.Height = 0;
            lr.Margin = 0;
            lr.FillAlpha = 0;
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion

        #region SetLinkAreas()
        private List<xsc.LinkArea> SetLinkAreas()
        {
            List<xsc.LinkArea> list = new List<xsc.LinkArea>();
            xsc.LinkArea la = new xsc.LinkArea();
            la.X = 300;
            la.Y = 250;
            la.Width = 70;
            la.Height = 25;
            la.Target = "print";
            list.Add(la);
            return list;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 10;
            sg.SetGap = 20;
            return sg;
        }
        #endregion
        #endregion
    }
}
