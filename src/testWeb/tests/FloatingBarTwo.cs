using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class FloatingBarTwo : ChartTestBase
    {
        #region ChartInclude
        public override ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "666688";
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
                c.AddChartType(XmlSwfChartType.BarFloating);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();
                c.AddAxisValueText("12\ram");
                c.AddAxisValueText("1");
                c.AddAxisValueText("2");
                c.AddAxisValueText("3");
                c.AddAxisValueText("4");
                c.AddAxisValueText("5");
                c.AddAxisValueText("6");
                c.AddAxisValueText("7");
                c.AddAxisValueText("8");
                c.AddAxisValueText("9");
                c.AddAxisValueText("10");
                c.AddAxisValueText("11");
                c.AddAxisValueText("12\rpm");
                c.AddAxisValueText("1");
                c.AddAxisValueText("2");
                c.AddAxisValueText("3");
                c.AddAxisValueText("4");
                c.AddAxisValueText("5");
                c.AddAxisValueText("6");
                c.AddAxisValueText("7");
                c.AddAxisValueText("8");
                c.AddAxisValueText("9");
                c.AddAxisValueText("10");
                c.AddAxisValueText("11");
                c.AddAxisValueText("12\ram");

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartValue = SetChartValue();
                c.ChartValueText = SetChartValueText();

                c.AddDrawText(CreateDrawText());

                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("eebb66");
                c.AddSeriesColor("668899");
                c.AddSeriesColor("668866");
                c.AddSeriesColor("aa6688");
                c.AddSeriesColor("666666");
                c.SeriesGap = SetSeriesGap();
                c.SeriesSwitch = true;
                return c;
            }
        }
        #endregion

        #region Helpers
        private AxisCategory SetAxisCategory(XmlSwfChartType xmlSwfChartType)
        {
            AxisCategory ac = new AxisCategory(xmlSwfChartType);
            ac.Size = 10;
            ac.Color = "eebb66";
            ac.Alpha = 90;
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = false;
            at.CategoryTicks = true;
            at.MajorThickness = 1;
            at.MinorThickness = 0;
            at.MinorCount = 0;
            at.MinorColor = "222222";
            at.MajorColor = "222222";
            at.Position = "centered";
            return at;
        }

        private AxisValue SetAxisValue()
        {
            AxisValue av = new AxisValue();
            av.Min = 0;
            av.Max = 24;
            av.Steps = 24;
            av.Size = 8;
            av.Color = "ffffff";
            av.Alpha = 50;
            av.Orientation = "horizonatal";
            return av;
        }

        private ChartBorder SetChartBorder()
        {
            ChartBorder cb = new ChartBorder();
            cb.Color = "888888";
            cb.TopThickness = 1;
            cb.BottomThickness = 1;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
            return cb;
        }

        private ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("hi", "Bob", 24);
            cd.AddDataPoint("hi", "Kim", 16);
            cd.AddDataPoint("hi", "Joe", 16);
            cd.AddDataPoint("hi", "Mark", 16);
            cd.AddDataPoint("hi", "Sue", 8);

            cd.AddDataPoint("lo", "Bob", 16);
            cd.AddDataPoint("lo", "Kim", 8);
            cd.AddDataPoint("lo", "Joe", 8);
            cd.AddDataPoint("lo", "Mark", 8);
            cd.AddDataPoint("lo", "Sue", 0);
            return cd;
        }

        private ChartGrid SetChartGrid(ChartGridType chartGridType)
        {
            ChartGrid cg = new ChartGrid(chartGridType);
            cg.Color = "000000";
            if (chartGridType == ChartGridType.Horizontal)
            {
                cg.Alpha = 5;
                cg.Thickness = 10;
            }
            else
            {
                cg.Alpha = 20;
                cg.Thickness = 1;
            }
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 50;
            cr.Y = 50;
            cr.Width = 325;
            cr.Height = 200;
            cr.PositiveColor = "000000";
            cr.PositiveAlpha = 10;
            return cr;
        }

        private ChartValue SetChartValue()
        {
            ChartValue cv = new ChartValue();
            cv.Color = "ffffff";
            cv.Alpha = 75;
            cv.Size = 10;
            cv.Position = "inside";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 10;
            cv.Separator = "";
            cv.AsPercentage = false;
            return cv;
        }

        private List<List<string>> SetChartValueText()
        {
            List<List<string>> cvt = new List<List<string>>();
            List<string> items = new List<string>();
            items.Add(null);
            items.Add("");
            items.Add("");
            items.Add("");
            items.Add("");
            items.Add("");
            cvt.Add(items);

            items = new List<string>();
            items.Add("");
            items.Add("12:00 am");
            items.Add("4:00 pm");
            items.Add("4:00 pm");
            items.Add("4:00 pm");
            items.Add("8:00 am");
            cvt.Add(items);

            items = new List<string>();
            items.Add("");
            items.Add("4:00 pm");
            items.Add("8:00 am");
            items.Add("8:00 am");
            items.Add("8:00 am");
            items.Add("12:00 am");
            cvt.Add(items);
            return cvt;
        }

        private DrawText CreateDrawText()
        {
            DrawText dt = new DrawText();
            dt.Transition = TransitionType.none;
            dt.Delay = 0;
            dt.Duration = 1;
            dt.Color = "eeeeff";
            dt.Alpha = 35;
            dt.Size = 26;
            dt.X = 42;
            dt.Y = 16;
            dt.Width = 350;
            dt.Height = 240;
            dt.Text = "Work Shifts";
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

        private SeriesGap SetSeriesGap()
        {
            SeriesGap sg = new SeriesGap();
            sg.SetGap = 20;
            sg.BarGap = 0;
            return sg;
        }
        #endregion
    }
}
