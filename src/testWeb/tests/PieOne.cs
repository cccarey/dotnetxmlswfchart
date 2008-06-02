using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class PieOne : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                xsc.ChartHTML chartHtml = new xsc.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "666666";
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
                c.AddChartType(xsc.XmlSwfChartType.Pie);

                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawText(CreateDrawText());

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("ddaa41");
                c.AddSeriesColor("88dd11");
                c.AddSeriesColor("4e62dd");
                c.AddSeriesColor("ff8811");
                c.AddSeriesColor("4d4d4d");
                c.AddSeriesColor("5a4b6e");
                c.AddSeriesExplode(20);
                c.AddSeriesExplode(0);
                c.AddSeriesExplode(50);
                return c;
            }
        }
        #endregion

        #region Helpers
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("", "2003", 20);
            cd.AddDataPoint("", "2004", 10);
            cd.AddDataPoint("", "2005", 30);
            cd.AddDataPoint("", "2006", 50);
            cd.AddDataPoint("", "2007", 40);
            return cd;
        }

        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 20;
            cg.Color = "000000";
            cg.Thickness = 1;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }

        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.PositiveColor = "ffffff";
            cr.PositiveAlpha = 20;
            cr.NegativeColor = "ff0000";
            cr.NegativeAlpha = 10;
            return cr;
        }

        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "ffffff";
            cv.Alpha = 90;
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
            dt.Alpha = 10;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 30;
            dt.X = 0;
            dt.Y = 140;
            dt.Width = 400;
            dt.Height = 150;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.bottom;
            dt.Text = "|||||||||||||||||||||||||||||||||||||||||||||||";
            return dt;
        }

        private xsc.LegendLabel SetLegendLabel()
        {
            xsc.LegendLabel ll = new xsc.LegendLabel();
            ll.Layout = xsc.LegendLabelLayout.horizontal;
            ll.Bullet = xsc.LegendLabelBullet.circle;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 13;
            ll.Color = "ffffff";
            ll.Alpha = 85;
            return ll;
        }

        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.FillColor = "ffffff";
            lr.FillAlpha = 10;
            lr.LineColor = "000000";
            lr.LineAlpha = 0;
            lr.LineThickness = 0;
            return lr;
        }
        #endregion
    }
}
