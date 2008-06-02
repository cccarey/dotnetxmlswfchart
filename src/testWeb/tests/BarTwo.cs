using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class BarTwo : ChartTestBase
    {
        #region ChartInclude
        public override ChartHTML ChartInclude
        {
            get
            {
                ChartHTML chartHtml = new ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "4c5e6f";
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
                c.ChartGridH = SetChartGridH();
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawText(CreateDrawText(1));
                c.AddDrawText(CreateDrawText(2));
                c.AddDrawText(CreateDrawText(3));
                c.AddDrawText(CreateDrawText(4));

                c.LegendRectangle = SetLegendRectangle();
                
                c.AddSeriesColor("5a4b6e");
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
            ac.Size = 14;
            ac.Color = "86ab71";
            ac.Alpha = 100;
            ac.Skip = 0;
            ac.Orientation = "vertical_up";
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = false;
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
            av.Min = 0;
            av.Max = 100;
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "ffffff";
            av.Alpha = 0;
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
            cd.AddDataPoint("region A", "maybe", 14);
            cd.AddDataPoint("region A", "no", 21);
            cd.AddDataPoint("region A", "yes", 65);
            return cd;
        }

        private ChartGrid SetChartGridH()
        {
            ChartGrid cg = new ChartGrid(ChartGridType.Horizontal);
            cg.Alpha = 10;
            cg.Color = "000000";
            cg.Thickness = 4;
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 105;
            cr.Width = 320;
            cr.Height = 160;
            cr.PositiveColor = "dba34c";
            cr.NegativeColor = "ff0000";
            cr.PositiveAlpha = 50;
            cr.NegativeAlpha = 25;
            return cr;
        }

        private ChartValue SetChartValue()
        {
            ChartValue cv = new ChartValue();
            cv.Color = "000000";
            cv.Alpha = 75;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 12;
            cv.Position = "center";
            cv.Prefix = "";
            cv.Suffix = "%";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = false;
            return cv;
        }

        private DrawText CreateDrawText(int p)
        {
            DrawText dt = new DrawText();
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            switch (p)
            {
                case 1:
                    dt.Color = "88ff00";
                    dt.Alpha = 15;
                    dt.Size = 100;
                    dt.X = 5;
                    dt.Y = 11;
                    dt.Width = 300;
                    dt.Height = 240;
                    dt.HAlign = TextHAlign.left;
                    dt.VAlign = TextVAlign.top;
                    dt.Text = "poll";
                    break;
                case 2:
                    dt.Color = "ff8800";
                    dt.Alpha = 100;
                    dt.Size = 20;
                    dt.X = 35;
                    dt.Y = 65;
                    dt.Width = 400;
                    dt.Height = 200;
                    dt.HAlign = TextHAlign.left;
                    dt.VAlign = TextVAlign.top;
                    dt.Text = "Is the economy recovering?";
                    break;
                case 3:
                    dt.Color = "000000";
                    dt.Alpha = 10;
                    dt.Size = 25;
                    dt.X = 0;
                    dt.Y = 0;
                    dt.Width = 400;
                    dt.Height = 290;
                    dt.HAlign = TextHAlign.center;
                    dt.VAlign = TextVAlign.bottom;
                    dt.Text = "poll poll poll poll poll poll poll poll poll poll poll";
                    break;
                case 4:
                    dt.Color = "000000";
                    dt.Alpha = 10;
                    dt.Size = 25;
                    dt.X = 0;
                    dt.Y = 0;
                    dt.Width = 400;
                    dt.Height = 290;
                    dt.HAlign = TextHAlign.center;
                    dt.VAlign = TextVAlign.top;
                    dt.Text = "poll poll poll poll poll poll poll poll poll poll poll";
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
