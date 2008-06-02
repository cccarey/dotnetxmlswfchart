using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class Pie3DOne : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                xsc.ChartHTML chartHtml = new xsc.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "6666aa";
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
                c.AddChartType(xsc.XmlSwfChartType.Pie3d);

                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartTransition = SetChartTransition();
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawText(CreateDrawText());

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();
                c.LegendTransition = SetLegendTransition();

                c.AddSeriesColor("00ff88");
                c.AddSeriesColor("ffaa00");
                c.AddSeriesColor("44aaff");
                c.AddSeriesColor("aa00ff");
                c.AddSeriesExplode(25);
                c.AddSeriesExplode(75);
                c.AddSeriesExplode(0);
                c.AddSeriesExplode(0);

                return c;
            }
        }
        #endregion

        #region Helpers
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("", "2004", 15);
            cd.AddDataPoint("", "2005", 27);
            cd.AddDataPoint("", "2006", 45);
            cd.AddDataPoint("", "2007", 60);
            return cd;
        }

        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 200;
            cr.PositiveAlpha = 0;
            return cr;
        }

        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Thickness = 0;
            return cg;
        }

        private xsc.ChartPreferences SetChartPreferences(xsc.XmlSwfChartType chartType)
        {
            xsc.ChartPreferences cp = new xsc.ChartPreferences(chartType);
            cp.RotationX = 60;
            return cp;
        }

        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.spin;
            ct.Delay = 0.5;
            ct.Duration = 0.75;
            ct.Order = xsc.TransitionOrder.category;
            return ct;
        }

        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "000000";
            cv.Alpha = 65;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 10;
            cv.Position = "inside";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = true;
            return cv;
        }

        private xsc.DrawText CreateDrawText()
        {
            xsc.DrawText dt = new xsc.DrawText();
            dt.Color = "000000";
            dt.Alpha = 4;
            dt.Size = 40;
            dt.X = -50;
            dt.Y = 260;
            dt.Width = 500;
            dt.Height = 50;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.middle;
            dt.Text = "56789012345678901234";
            return dt;
        }

        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Bullet = xsc.LegendLabelBullet.circle;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 12;
            ll.Color = "ffffff";
            ll.Alpha = 85;
            return ll;
        }

        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = 0;
            lr.Y = 45;
            lr.Width = 50;
            lr.Height = 210;
            lr.Margin = 10;
            lr.FillColor = "ffffff";
            lr.FillAlpha = 10;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }

        private xsc.LegendTransition SetLegendTransition()
        {
            xsc.LegendTransition lt = new xsc.LegendTransition();
            lt.Type = xsc.TransitionType.dissolve;
            lt.Delay = 0;
            lt.Duration = 1;
            return lt;
        }
        #endregion
    }
}
