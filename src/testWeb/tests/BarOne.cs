using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class BarOne : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "4d4d4d";
                chartHtml.flashFile = "charts/charts.swf";
                chartHtml.libraryPath = "charts/charts_library";
                chartHtml.xmlSource = "xmlData.aspx";
                return chartHtml;
            }
        }
        #endregion

        #region Chart
        public override Chart Chart
        {
            get
            {
                Chart c = new Chart();
                c.AddChartType(XmlSwfChartType.Bar);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartTransition = SetChartTransition();
                c.ChartValue = SetChartValue();

                c.AddDrawText(CreateDrawText(1));
                c.AddDrawText(CreateDrawText(2));

                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("4e627c");
                c.AddSeriesColor("c89341");
                c.AddSeriesColor("4c6b41");

                return c;
            }
        }
        #endregion

        #region Helpers
        private AxisCategory SetAxisCategory(XmlSwfChartType xmlSwfChartType)
        {
            AxisCategory ac = new AxisCategory(xmlSwfChartType);
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Size = 12;
            ac.Color = "ff8844";
            ac.Alpha = 85;
            ac.Skip = 0;
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = true;
            at.CategoryTicks = true;
            at.MajorThickness = 2;
            at.MinorThickness = 1;
            at.MinorCount = 1;
            at.MajorColor = "222222";
            at.MinorColor = "222222";
            at.Position = "centered";
            return at;
        }

        private AxisValue SetAxisValue()
        {
            AxisValue av = new AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "ffffff";
            av.Alpha = 30;
            av.Steps = 6;
            av.Prefix = "";
            av.Suffix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = true;
            return av;
        }

        private ChartBorder SetChartBorder()
        {
            ChartBorder cb = new ChartBorder();
            cb.Color = "000000";
            cb.TopThickness = 1;
            cb.BottomThickness = 1;
            cb.LeftThickness = 3;
            cb.RightThickness = 1;
            return cb;
        }

        private ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("region A", "2005", -25);
            cd.AddDataPoint("region A", "2006", 45);
            cd.AddDataPoint("region A", "2007", 100);

            cd.AddDataPoint("region B", "2005", -35);
            cd.AddDataPoint("region B", "2006", 65);
            cd.AddDataPoint("region B", "2007", 80);

            cd.AddDataPoint("region C", "2005", 10);
            cd.AddDataPoint("region C", "2006", 30);
            cd.AddDataPoint("region C", "2007", 55);
            return cd;
        }

        private ChartGrid SetChartGrid(ChartGridType chartGridType)
        {
            ChartGrid cg = new ChartGrid(chartGridType);
            cg.Alpha = 20;
            cg.Color = "000000";
            cg.Thickness = 1;
            if (chartGridType == ChartGridType.Horizontal) 
                cg.GridLineType = ChartGridLineType.dashed;
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 30;
            cr.Width = 320;
            cr.Height = 230;
            cr.PositiveColor = "ffffff";
            cr.NegativeColor = "ff0000";
            cr.PositiveAlpha = 35;
            cr.NegativeAlpha = 10;
            return cr;
        }

        private ChartTransition SetChartTransition()
        {
            ChartTransition ct = new ChartTransition();
            ct.TransitionType = TransitionType.scale;
            ct.Delay = 0.5;
            ct.Duration = 0.5;
            ct.Order = TransitionOrder.category;
            return ct;
        }

        private ChartValue SetChartValue()
        {
            ChartValue cv = new ChartValue();
            cv.Color = "ffffff";
            cv.Alpha = 50;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 10;
            cv.Position = "center";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = false;
            return cv;
        }

        private DrawText CreateDrawText(int p)
        {
            DrawText dt = new DrawText();
            dt.Alpha = 35;
            dt.Width = 300;
            dt.HAlign = TextHAlign.left;
            dt.VAlign = TextVAlign.bottom;
            switch (p)
            {
                case 1:
                    dt.Color = "eeeeff";
                    dt.Size = 45;
                    dt.X = 220;
                    dt.Y = 18;
                    dt.Height = 240;
                    dt.Text = "growth";
                    break;
                case 2:
                    dt.Color = "000044";
                    dt.Rotation = -90;
                    dt.Size = 60;
                    dt.X = -41;
                    dt.Y = 270;
                    dt.Height = 100;
                    dt.Text = "y  e  a   r";
                    break;
            }
            return dt;
        }

        private LegendRectangle SetLegendRectangle()
        {
            LegendRectangle lr = new LegendRectangle();
            lr.X = -100;
            lr.Y = -100;
            lr.Width = 10;
            lr.Height = 10;
            return lr;
        }
        #endregion
    }
}
