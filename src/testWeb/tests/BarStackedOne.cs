using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class BarStackedOne : ChartTestBase
    {
        #region ChartInclude
        public override ChartHTML ChartInclude
        {
            get
            {
                ChartHTML chartHtml = new ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "677b75";
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
                c.AddChartType(XmlSwfChartType.BarStacked);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();

                c.AddDrawText(CreateDrawText());

                c.LegendLabel = SetLegendLabel();
                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("3b5743");
                c.AddSeriesColor("303d3d");
                c.AddSeriesColor("4c5e6f");
                c.AddSeriesColor("564546");
                c.AddSeriesColor("784e3a");
                c.AddSeriesColor("677b75");
                return c;
            }
        }
        #endregion

        #region Helpers
        private AxisCategory SetAxisCategory(XmlSwfChartType type)
        {
            AxisCategory ac = new AxisCategory(type);
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Size = 16;
            ac.Color = "000000";
            ac.Alpha = 60;
            ac.Skip = 0;
            ac.Orientation = "vertical_up";
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = false;
            at.CategoryTicks = false;
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
            av.Alpha = 50;
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
            cb.TopThickness = 0;
            cb.BottomThickness = 0;
            cb.LeftThickness = 5;
            cb.RightThickness = 0;
            return cb;
        }

        private ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("region A", "2005", 100);
            cd.AddDataPoint("region A", "2006", 45);
            cd.AddDataPoint("region A", "2007", 25);

            cd.AddDataPoint("region B", "2005", 80);
            cd.AddDataPoint("region B", "2006", 65);
            cd.AddDataPoint("region B", "2007", 35);

            cd.AddDataPoint("region C", "2005", 55);
            cd.AddDataPoint("region C", "2006", 30);
            cd.AddDataPoint("region C", "2007", 10);
            return cd;
        }

        private ChartGrid SetChartGrid(ChartGridType chartGridType)
        {
            ChartGrid cg = new ChartGrid(chartGridType);
            cg.Alpha = 10;
            cg.Color = "000000";
            switch (chartGridType)
            {
                case ChartGridType.Horizontal:
                    cg.Thickness = 0;
                    break;
                case ChartGridType.Vertical:
                    cg.Thickness = 20;
                    break;
            }
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 320;
            cr.Height = 200;
            cr.PositiveColor = "ffffff";
            cr.PositiveAlpha = 30;
            cr.NegativeColor = "ff0000";
            cr.NegativeAlpha = 10;
            return cr;
        }

        private ChartValue SetChartValue()
        {
            ChartValue cv = new ChartValue();
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.Position = "cursor";
            cv.HideZero = true;
            cv.AsPercentage = false;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 12;
            cv.Color = "ff8888";
            cv.Alpha = 100;
            return cv;
        }

        private DrawText CreateDrawText()
        {
            DrawText dt = new DrawText();
            dt.Color = "000033";
            dt.Alpha = 25;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 30;
            dt.X = 0;
            dt.Y = 0;
            dt.Width = 380;
            dt.Height = 295;
            dt.HAlign = TextHAlign.right;
            dt.VAlign = TextVAlign.bottom;
            dt.Text = "regional report";
            return dt;
        }

        private LegendLabel SetLegendLabel()
        {
            LegendLabel ll = new LegendLabel();
            ll.Layout = LegendLabelLayout.horizontal;
            ll.Font = "Arial";
            ll.Bold = true;
            ll.Size = 13;
            ll.Color = "ffffff";
            ll.Alpha = 50;
            return ll;
        }

        private LegendRectangle SetLegendRectangle()
        {
            LegendRectangle lr = new LegendRectangle();
            lr.X = 25;
            lr.Y = 15;
            lr.Width = 350;
            lr.Height = 5;
            lr.Margin = 3;
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
