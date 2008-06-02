using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class StackedColumnTwo : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "a0b0bb";
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
                c.AddChartType(xsc.XmlSwfChartType.ColumnStacked);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartRectangle = SetChartRectangle();

                c.DrawTexts = SetDrawTexts();

                c.LegendRectangle = SetLegendRectangle();

                c.SeriesColors = SetSeriesColors();
                c.SeriesGap = SetSeriesGap();
                return c;
            }
        }
        #endregion

        #region Properties
        #region SetAxisCategory()
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Font = "Arial";
            ac.Bold = true;
            ac.Size = 12;
            ac.Color = "000022";
            ac.Alpha = 75;
            ac.Skip = 2;
            return ac;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "ffffee";
            av.Alpha = 75;
            av.Steps = 4;
            av.Prefix = "";
            av.Suffix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = false;
            return av;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.Color = "000000";
            cb.TopThickness = 1;
            cb.BottomThickness = 1;
            cb.LeftThickness = 1;
            cb.RightThickness = 1;
            return cb;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "1", 10));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "2", 12));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "3", 11));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "4", 15));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "5", 20));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "6", 22));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "7", 21));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "8", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "9", 31));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "10", 32));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "11", 28));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "12", 29));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "13", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "14", 41));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "15", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "16", 50));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "17", 65));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "18", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "19", 50));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "20", 51));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "21", 65));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "22", 60));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "23", 62));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "24", 65));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "25", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "26", 55));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "27", 59));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "28", 52));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "29", 53));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "30", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region A", "31", 45));

            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "1", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "2", 32));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "3", 35));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "4", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "5", 42));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "6", 35));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "7", 36));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "8", 31));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "9", 35));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "10", 36));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "11", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "12", 42));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "13", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "14", 41));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "15", 45));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "16", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "17", 38));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "18", 36));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "19", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "20", 29));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "21", 28));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "22", 25));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "23", 28));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "24", 29));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "25", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "26", 40));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "27", 32));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "28", 33));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "29", 34));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "30", 30));
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "31", 20));
            return cd;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 60;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 200;
            cr.PositiveColor = "448800";
            cr.NegativeColor = "ffeeaa";
            cr.PositiveAlpha = 20;
            cr.NegativeAlpha = 100;
            return cr;
        }
        #endregion

        #region SetDrawTexts()
        private List<xsc.DrawText> SetDrawTexts()
        {
            List<xsc.DrawText> text = new List<xsc.DrawText>();
            xsc.DrawText dt = new xsc.DrawText();
            dt.Color = "ffffee";
            dt.Alpha = 75;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 42;
            dt.X = 60;
            dt.Y = 6;
            dt.Width = 300;
            dt.Height = 50;
            dt.HAlign = xsc.TextHAlign.left;
            dt.VAlign = xsc.TextVAlign.bottom;
            dt.Text = "monthly report";
            text.Add(dt);

            dt = new xsc.DrawText();
            dt.Color = "663333";
            dt.Alpha = 75;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 14;
            dt.X = 60;
            dt.Y = 50;
            dt.Width = 300;
            dt.Height = 300;
            dt.HAlign = xsc.TextHAlign.right;
            dt.VAlign = xsc.TextVAlign.top;
            dt.Text = "May 2007";
            text.Add(dt);

            return text;
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
            lr.Margin = 0;
            return lr;
        }
        #endregion

        #region SetSeriesColors()
        private List<string> SetSeriesColors()
        {
            List<string> colors = new List<string>();
            colors.Add("4e627c");
            colors.Add("c89341");
            return colors;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.SetGap = 0;
            sg.BarGap = 0;
            return sg;
        }
        #endregion
        #endregion
    }
}
