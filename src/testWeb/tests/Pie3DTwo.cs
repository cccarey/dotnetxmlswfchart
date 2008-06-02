using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class Pie3DTwo : ChartTestBase
    {
        #region ChartInclude
        public override xsc.ChartHTML ChartInclude
        {
            get
            {
                xsc.ChartHTML chartHtml = new xsc.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "4c5577";
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
                c.AddChartType(xsc.XmlSwfChartType.Pie3d);

                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartPreferences = SetChartPreferences(c.ChartType[0]);
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawImage(CreateDrawImage());
                c.AddDrawCircle(CreateDrawCircle(1));
                c.AddDrawCircle(CreateDrawCircle(2));
                c.AddDrawCircle(CreateDrawCircle(3));
                c.AddDrawText(CreateDrawText());

                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesExplode(110);
                c.AddSeriesExplode(150);
                c.AddSeriesExplode(80);
                c.AddSeriesExplode(-140);
                c.AddSeriesExplode(20);
                c.AddSeriesExplode(150);
                return c;
            }
        }
        #endregion

        #region Helpers
        private DotNetXmlSwfChart.ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("", "1", 18);
            cd.AddDataPoint("", "2", 13);
            cd.AddDataPoint("", "3", 17);
            cd.AddDataPoint("", "4", 10);
            cd.AddDataPoint("", "5", 22);
            cd.AddDataPoint("", "6", 20);
            return cd;
        }

        private DotNetXmlSwfChart.ChartGrid SetChartGridH()
        {
            ChartGrid cg = new ChartGrid(ChartGridType.Horizontal);
            cg.Alpha = 35;
            cg.Color = "000000";
            cg.Thickness = 1;
            return cg;
        }

        private DotNetXmlSwfChart.ChartPreferences SetChartPreferences(DotNetXmlSwfChart.XmlSwfChartType type)
        {
            ChartPreferences cp = new ChartPreferences(type);
            cp.RotationX = 60;
            return cp;
        }

        private DotNetXmlSwfChart.ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 200;
            cr.PositiveColor = "000000";
            cr.PositiveAlpha = 0;
            cr.NegativeColor = "ff0000";
            cr.NegativeAlpha = 0;
            return cr;
        }

        private DotNetXmlSwfChart.ChartValue SetChartValue()
        {
            ChartValue cv = new ChartValue();
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

        private DotNetXmlSwfChart.DrawImage CreateDrawImage()
        {
            DrawImage di = new DrawImage();
            di.Layer = DrawLayer.background;
            di.Url = "images/pattern.jpg";
            di.Alpha = 100;
            di.X = 0;
            di.Y = 0;
            di.Width = 400;
            di.Height = 300;
            return di;
        }

        private DotNetXmlSwfChart.DrawCircle CreateDrawCircle(int p)
        {
            DrawCircle dc = new DrawCircle();
            dc.X = 70;
            dc.Y = 260;
            dc.FillColor = "ff0000";
            dc.LineColor = "ff0000";
            switch (p)
            {
                case 1:
                    dc.Radius = 30;
                    dc.FillAlpha = 50;
                    dc.LineAlpha = 0;
                    dc.LineThickness = 0;
                    break;
                case 2:
                    dc.Radius = 50;
                    dc.FillAlpha = 0;
                    dc.LineAlpha = 40;
                    dc.LineThickness = 15;
                    break;
                case 3:
                    dc.Radius = 75;
                    dc.FillAlpha = 0;
                    dc.LineAlpha = 30;
                    dc.LineThickness = 3;
                    break;
            }
            return dc;
        }

        private DotNetXmlSwfChart.DrawText CreateDrawText()
        {
            DrawText dt = new DrawText();
            dt.Color = "ffffff";
            dt.Alpha = 80;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 18;
            dt.X = 62;
            dt.Y = 183;
            dt.Width = 200;
            dt.Height = 150;
            dt.HAlign = TextHAlign.left;
            dt.VAlign = TextVAlign.middle;
            dt.Text = "uniter, not a divider";
            return dt;
        }

        private DotNetXmlSwfChart.LegendRectangle SetLegendRectangle()
        {
            LegendRectangle lr = new LegendRectangle();
            lr.X = -100;
            lr.Y = -100;
            lr.Width = 10;
            lr.Height = 10;
            lr.Margin = 10;
            return lr;
        }
        #endregion
    }
}
