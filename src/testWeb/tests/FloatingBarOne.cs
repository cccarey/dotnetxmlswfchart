using System;
using System.Collections.Generic;
using DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class FloatingBarOne : ChartTestBase
    {
        #region ChartInclude
        public override ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ee7777";
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
                c.AddAxisValueText("JAN");
                c.AddAxisValueText("FEB");
                c.AddAxisValueText("MAR");
                c.AddAxisValueText("APR");
                c.AddAxisValueText("MAY");
                c.AddAxisValueText("JUN");
                c.AddAxisValueText("JUL");
                c.AddAxisValueText("AUG");
                c.AddAxisValueText("SEP");
                c.AddAxisValueText("OCT");
                c.AddAxisValueText("NOV");
                c.AddAxisValueText("DEC");
                c.AddAxisValueText("JAN");
                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGrid(ChartGridType.Horizontal);
                c.ChartGridV = SetChartGrid(ChartGridType.Vertical);
                c.ChartRectangle = SetChartRectangle();
                c.ChartTransition = SetChartTransition();

                c.AddDrawRectangle(CreateDrawRectangle());
                c.AddDrawText(CreateDrawText("production schedule", null));
                c.AddDrawText(CreateDrawText("Alpha", "7/1"));
                c.AddDrawText(CreateDrawText("Beta", "8/1"));
                c.AddDrawText(CreateDrawText("Shipping date\nSep 1", "9/1"));
                c.AddDrawLine(CreateDrawLine("7/1"));
                c.AddDrawLine(CreateDrawLine("8/1"));
                c.AddDrawLine(CreateDrawLine("9/1"));
                c.AddDrawCircle(CreateDrawCircle("7/1"));
                c.AddDrawCircle(CreateDrawCircle("8/1"));
                c.AddDrawCircle(CreateDrawCircle("9/1"));

                c.LegendRectangle = SetLegendRectangle();
                c.AddSeriesColor("ffffff");
                c.AddSeriesColor("aa88ff");
                c.AddSeriesColor("aaff88");
                c.AddSeriesColor("aaff88");
                c.AddSeriesColor("aa88ff");
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
            ac.Size = 11;
            ac.Color = "ffffff";
            ac.Alpha = 75;
            return ac;
        }

        private AxisTicks SetAxisTicks()
        {
            AxisTicks at = new AxisTicks();
            at.ValueTicks = true;
            at.CategoryTicks = true;
            at.MajorThickness = 1;
            at.MinorThickness = 0;
            at.MinorCount = 0;
            at.MajorColor = "222222";
            at.MinorColor = "222222";
            at.Position = "centered";
            return at;
        }

        private AxisValue SetAxisValue()
        {
            AxisValue av = new AxisValue();
            av.Size = 8;
            av.Color = "000000";
            av.Alpha = 60;
            av.Steps = 12;
            av.Min = 0;
            av.Max = 365;
            return av;
        }

        private ChartBorder SetChartBorder()
        {
            ChartBorder cb = new ChartBorder();
            cb.Color = "000088";
            cb.TopThickness = 0;
            cb.BottomThickness = 0;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
            return cb;
        }

        private ChartData SetChartData()
        {
            ChartData cd = new ChartData();
            cd.AddDataPoint("hi", "marketing", new DateTime(2008, 12, 1).DayOfYear);
            cd.AddDataPoint("hi", "QA", new DateTime(2008, 9, 1).DayOfYear);
            cd.AddDataPoint("hi", "engineering", new DateTime(2008, 9, 1).DayOfYear);
            cd.AddDataPoint("hi", "design", new DateTime(2008, 6, 1).DayOfYear);
            cd.AddDataPoint("hi", "concept", new DateTime(2008, 4, 15).DayOfYear);

            cd.AddDataPoint("lo", "marketing", new DateTime(2008, 6, 1).DayOfYear);
            cd.AddDataPoint("lo", "QA", new DateTime(2008, 5, 1).DayOfYear);
            cd.AddDataPoint("lo", "engineering", new DateTime(2008, 4, 1).DayOfYear);
            cd.AddDataPoint("lo", "design", new DateTime(2008, 2, 15).DayOfYear);
            cd.AddDataPoint("lo", "concept", new DateTime(2008, 2, 1).DayOfYear);
            return cd;
        }

        private ChartGrid SetChartGrid(ChartGridType chartGridType)
        {
            ChartGrid cg = new ChartGrid(chartGridType);
            cg.Alpha = 100;
            cg.Color = "ee6666";
            cg.Thickness = 1;
            if (chartGridType == ChartGridType.Horizontal)
            {
                cg.Alpha = 20;
                cg.Color = "000000";
                cg.GridLineType = ChartGridLineType.dashed;
            }
            return cg;
        }

        private ChartRectangle SetChartRectangle()
        {
            ChartRectangle cr = new ChartRectangle();
            cr.X = 100;
            cr.Y = 100;
            cr.Width = 275;
            cr.Height = 150;
            cr.PositiveColor = "000000";
            cr.PositiveAlpha = 10;
            return cr;
        }

        private ChartTransition SetChartTransition()
        {
            ChartTransition ct = new ChartTransition();
            ct.TransitionType = TransitionType.slide_right;
            ct.Delay = 0;
            ct.Duration = 0.6;
            ct.Order = TransitionOrder.all;
            return ct;
        }

        private DrawRectangle CreateDrawRectangle()
        {
            DrawRectangle dr = new DrawRectangle();
            dr.Layer = DrawLayer.background;
            dr.Transition = TransitionType.slide_right;
            dr.Delay = 0;
            dr.Duration = 0.5;
            dr.X = 25;
            dr.Y = 100;
            dr.Width = 75;
            dr.Height = 150;
            dr.FillColor = "000000";
            dr.FillAlpha = 20;
            dr.LineThickness = 0;
            return dr;
        }

        private DrawText CreateDrawText(string text, string date)
        {
            DrawText dt = new DrawText();
            dt.Transition = TransitionType.slide_right;
            dt.Delay = 0;
            dt.Duration = 0.5;
            dt.Color = "000000";
            dt.Alpha = 70;
            dt.Size = 9;
            dt.Text = text;
            if (date != null) dt.X = DateToPixels(date) + 7;
            switch (text)
            {
                case "production schedule":
                    dt.Transition = TransitionType.drop;
                    dt.Duration = 2;
                    dt.Color = "ffffaa";
                    dt.Alpha = 75;
                    dt.Size = 36;
                    dt.X = 0;
                    dt.Y = 65;
                    dt.Width = 400;
                    dt.Height = 240;
                    dt.HAlign = TextHAlign.center;
                    break;
                case "Alpha":
                    dt.Y = 108;
                    break;
                case "Beta":
                    dt.Y = 123;
                    break;
                case "Shipping date\nSep 1":
                    dt.Y = 138;
                    break;
            }
            return dt;
        }

        private int DateToPixels(string date)
        {
            DateTime dtdate = new DateTime(2008, Convert.ToInt32(date.Split('/')[0]), Convert.ToInt32(date.Split('/')[1]));
            double chartX = 100;
            double chartWidth = 275;
            double daysInYear = 366;
            double pixels = chartX + ((Convert.ToDouble(dtdate.DayOfYear) / daysInYear) * chartWidth);
            return Convert.ToInt32(pixels);
        }

        private DrawLine CreateDrawLine(string date)
        {
            DrawLine dl = new DrawLine();
            dl.Transition = TransitionType.slide_right;
            dl.Delay = 0;
            dl.Duration = 0.5;
            dl.X1 = DateToPixels(date);
            dl.X2 = DateToPixels(date);
            dl.Y2 = 250;
            dl.LineColor = "ffff00";
            dl.LineThickness = 1;
            dl.LineAlpha = 75;
            switch (date)
            {
                case "7/1":
                    dl.Y1 = 115;
                    break;
                case "8/1":
                    dl.Y1 = 130;
                    break;
                case "9/1":
                    dl.Y1 = 145;
                    break;
            }
            return dl;
        }

        private DrawCircle CreateDrawCircle(string date)
        {
            DrawCircle dc = new DrawCircle();
            dc.Transition = TransitionType.slide_right;
            dc.Delay = 0;
            dc.Duration = 0.5;
            dc.X = DateToPixels(date);
            dc.Radius = 4;
            dc.FillColor = "ffff00";
            dc.FillAlpha = 90;
            dc.LineThickness = 0;
            switch (date) {
                case "7/1":
                    dc.Y = 115;
                    break;
                case "8/1":
                    dc.Y = 130;
                    break;
                case "9/1":
                    dc.Y = 145;
                    break;
            }
            return dc;
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
            sg.SetGap = 50;
            sg.BarGap = 0;
            return sg;
        }
        #endregion
    }
}
