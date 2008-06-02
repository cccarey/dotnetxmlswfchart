using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class ParallelColumn3DOne : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ffaa88";
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
                c.ChartGridH = SetChartGridH();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawImage(CreateDrawImage());

                c.LegendRectangle = SetLegendRectangle();

                c.LinkAreas = SetLinkAreas();

                c.AddSeriesColor("666666");
                c.AddSeriesColor("768bb3");
                c.AddSeriesColor("884400");
                c.SeriesGap = SetSeriesGap();
                return c;
            }
        }

        #endregion

        #region Helpers
        #region  SetAxisCategory(xsc.XmlSwfChartType xmlSwfChartType)
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType xmlSwfChartType)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(xmlSwfChartType);
            ac.Size = 10;
            ac.Color = "000000";
            ac.Alpha = 75;
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
            av.Max = 220;
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
            cd.AddDataPoint("region 1", "2005", 90);
            cd.AddDataPoint("region 1", "2006", 50);
            cd.AddDataPoint("region 1", "2007", 40);

            cd.AddDataPoint("region 2", "2005", 150);
            cd.AddDataPoint("region 2", "2006", 100);
            cd.AddDataPoint("region 2", "2007", 70);

            cd.AddDataPoint("region 3", "2005", 200);
            cd.AddDataPoint("region 3", "2006", 160);
            cd.AddDataPoint("region 3", "2007", 90);
            return cd;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Color = "000000";
            cg.Thickness = 0;
            cg.Alpha = 5;
            return cg;
        }
        #endregion

        #region SetChartPreferences(xsc.XmlSwfChartType xmlSwfChartType)
        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType xmlSwfChartType)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(xmlSwfChartType);
            cp.RotationX = 30;
            cp.RotationY = 30;
            return cp;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 200;
            cr.PositiveColor = "888888";
            cr.PositiveAlpha = 10;
            return cr;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.HideZero = true;
            cv.Color = "ffffff";
            cv.Alpha = 90;
            cv.Font = "Arial";
            cv.Bold = true;
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

        #region CreateDrawImage()
        private xsc.DrawImage CreateDrawImage()
        {
            xsc.DrawImage di = new xsc.DrawImage();
            di.Url = "images/cursor.swf";
            di.X = 0;
            di.Y = 0;
            di.Width = 401;
            di.Height = 301;
            di.Rotation = 0;
            return di;
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
            return lr;
        }
        #endregion

        #region SetLinkAreas()
        private List<xsc.LinkArea> SetLinkAreas()
        {
            List<xsc.LinkArea> list = new List<xsc.LinkArea>();
            xsc.LinkArea la = new xsc.LinkArea();
            la.X = 180;
            la.Y = 0;
            la.Width = 40;
            la.Height = 35;
            la.Url = "xmlData.aspx?test=parallelcolumn3d1";
            la.Target = "live_update";
            list.Add(la);

            la = new xsc.LinkArea();
            la.X = 180;
            la.Y = 265;
            la.Width = 40;
            la.Height = 35;
            la.Url = "xmlData.aspx?test=parallelcolumn3d1";
            la.Target = "live_update";
            list.Add(la);

            la = new xsc.LinkArea();
            la.X = 0;
            la.Y = 130;
            la.Width = 35;
            la.Height = 40;
            la.Url = "xmlData.aspx?test=parallelcolumn3d1";
            la.Target = "live_update";
            list.Add(la);

            la = new xsc.LinkArea();
            la.X = 365;
            la.Y = 130;
            la.Width = 35;
            la.Height = 40;
            la.Url = "xmlData.aspx?test=parallelcolumn3d1";
            la.Target = "live_update";
            list.Add(la);
            return list;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 30;
            sg.SetGap = 30;
            return sg;
        }
        #endregion
        #endregion
    }
}
