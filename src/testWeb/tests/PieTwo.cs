using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class PieTwo : ChartTestBase 
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

                c.AddDrawText(CreateDrawText(1));
                c.AddDrawText(CreateDrawText(2));
                c.AddDrawText(CreateDrawText(3));
                c.AddDrawText(CreateDrawText(4));

                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("88dd11");
                c.AddSeriesColor("ff8811");
                c.AddSeriesColor("7744dd");

                c.AddSeriesExplode(20);
                c.AddSeriesExplode(20);
                c.AddSeriesExplode(10);
                return c;
            }
        }

        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("Region A", "a", 75);
            cd.AddDataPoint("Region A", "b", 25);
            cd.AddDataPoint("Region A", "c", 10);
            return cd;
        }

        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 35;
            cg.Color = "000000";
            cg.Thickness = 2;
            cg.GridLineType = xsc.ChartGridLineType.dotted;
            return cg;
        }

        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
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

        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Alpha = 0;
            return cv;
        }

        private xsc.DrawText CreateDrawText(int p)
        {
            xsc.DrawText dt = new xsc.DrawText();
            dt.Font = "Arial";
            dt.Bold = true;
            dt.HAlign = xsc.TextHAlign.center;
            dt.VAlign = xsc.TextVAlign.middle;
            switch (p)
            {
                case 1:
                    dt.Color = "000000";
                    dt.Alpha = 20;
                    dt.Rotation = -24;
                    dt.Size = 18;
                    dt.X = 57;
                    dt.Y = 162;
                    dt.Width = 200;
                    dt.Height = 150;
                    dt.Text = "my slice";
                    break;
                case 2:
                    dt.Color = "ffffaa";
                    dt.Alpha = 90;
                    dt.Rotation = -24;
                    dt.Size = 18;
                    dt.X = 55;
                    dt.Y = 160;
                    dt.Width = 200;
                    dt.Height = 150;
                    dt.Text = "my slice";
                    break;
                case 3:
                    dt.Color = "000000";
                    dt.Alpha = 10;
                    dt.Rotation = -10;
                    dt.Size = 50;
                    dt.X = 3;
                    dt.Y = 33;
                    dt.Width = 320;
                    dt.Height = 230;
                    dt.Text = "our pie";
                    break;
                case 4:
                    dt.Color = "eeeedd";
                    dt.Alpha = 90;
                    dt.Rotation = -11;
                    dt.Size = 50;
                    dt.X = 0;
                    dt.Y = 30;
                    dt.Width = 320;
                    dt.Height = 230;
                    dt.Text = "our pie";
                    break;
            }
            return dt;
        }

        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = -100;
            lr.Y = -100;
            lr.Width = 10;
            lr.Height = 10;
            lr.Margin = 10;
            return lr;
        }
    }
}
