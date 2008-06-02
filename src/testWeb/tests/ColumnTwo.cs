using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class ColumnTwo : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "dddd88";
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
                xsc.Chart chart = new xsc.Chart();

                chart.AddChartType(xsc.XmlSwfChartType.Column);

                chart.AxisCategory = SetAxisCategory(chart.ChartType[0]);
                chart.AxisTicks = SetAxisTicks();
                chart.AxisValue = SetAxisValue();
                chart.ChartBorder = SetChartBorder();

                chart.Data = SetChartData();

                chart.ChartGridH = SetChartGridH();
                chart.ChartGridV = SetChartGridV();
                chart.ChartRectangle = SetChartRectangle();
                
                chart.DrawTexts = SetDrawTexts();

                chart.LegendRectangle = SetLegendRectangle();

                chart.SeriesColors = SetSeriesColors();
                chart.SeriesGap = SetSeriesGap();
                return chart;
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
            ac.Size = 11;
            ac.Color = "000000";
            ac.Alpha = 50;
            ac.Skip = 2;
            return ac;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.ValueTicks = false;
            at.CategoryTicks = true;
            at.MajorThickness = 2;
            at.MinorThickness = 1;
            at.MinorCount = 3;
            at.MajorColor = "000000";
            at.MinorColor = "888888";
            at.Position = "outside";
            return at;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "000000";
            av.Alpha = 50;
            av.Steps = 4;
            av.Suffix = "";
            av.Prefix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = true;
            return av;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.Color = "000000";
            cb.TopThickness = 1;
            cb.BottomThickness = 2;
            cb.LeftThickness = 0;
            cb.RightThickness = 0;
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
            cd.AddDataPoint(new xsc.ChartDataPoint("Region B", "31", 35));
            return cd;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 10;
            cg.Color = "0066ff";
            cg.Thickness = 28;
            return cg;
        }
        #endregion

        #region SetChartGridV()
        private xsc.ChartGrid SetChartGridV()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Vertical);
            cg.Alpha = 10;
            cg.Color = "0066ff";
            cg.Thickness = 1;
            return cg;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 20;
            cr.Y = 50;
            cr.Width = 370;
            cr.Height = 220;
            cr.PositiveColor = "ffffff";
            cr.PositiveAlpha = 40;
            return cr;
        }
        #endregion
        
        #region SetDrawTexts()
        private List<xsc.DrawText> SetDrawTexts()
        {
            List<xsc.DrawText> text = new List<xsc.DrawText>();
            xsc.DrawText dt = new xsc.DrawText();
            dt.Color = "ff6644";
            dt.Alpha = 70;
            dt.Font = "Arial";
            dt.Rotation = 2;
            dt.Bold = true;
            dt.Size = 53;
            dt.X = 5;
            dt.Y = 0;
            dt.Width = 400;
            dt.Height = 400;
            dt.HAlign = xsc.TextHAlign.center;
            dt.Text = "monthly report";
            text.Add(dt);

            dt = new xsc.DrawText();
            dt.Color = "000000";
            dt.Alpha = 60;
            dt.Font = "Arial";
            dt.Rotation = 0;
            dt.Bold = true;
            dt.Size = 16;
            dt.X = 25;
            dt.Y = 55;
            dt.Width = 300;
            dt.HAlign = xsc.TextHAlign.left;
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
            List<string> c = new List<string>();
            c.Add("dd6b66");
            c.Add("7e6cee");
            return c;
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