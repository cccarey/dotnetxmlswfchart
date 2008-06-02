using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class FloatingColumnTwo : ChartTestBase
    {
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ff9922";
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
                c.AddChartType(xsc.XmlSwfChartType.ColumnFloating);

                c.AxisCategory = SetAxisCategory(c.ChartType[0]);
                c.AxisTicks = SetAxisTicks();
                c.AxisValue = SetAxisValue();

                c.ChartBorder = SetChartBorder();
                c.Data = SetChartData();
                c.ChartGridH = SetChartGridH();
                c.ChartRectangle = SetChartRectangle();

                c.AddDrawImage(GetDrawImage());
                c.AddDrawText(GetDrawText(1));
                c.AddDrawText(GetDrawText(2));
                c.AddDrawText(GetDrawText(3));
                c.AddDrawText(GetDrawText(4));
                c.AddDrawText(GetDrawText(5));

                c.LegendRectangle = SetLegendRectangle();

                c.AddSeriesColor("666666");
                c.SeriesGap = SetSeriesGap();
                return c;
            }
        }

        #endregion

        #region Helpers
        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.SetGap = 20;
            sg.BarGap = 0;
            return sg;
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

        #region GetDrawText(int number)
        private xsc.DrawText GetDrawText(int number)
        {
            xsc.DrawText text = new xsc.DrawText();
            text.Width = 400;
            text.Height = 400;
            text.HAlign = xsc.TextHAlign.left;

            switch (number)
            {
                case 1:
                    text.Color = "ffffff";
                    text.Alpha = 20;
                    text.Rotation = -10;
                    text.Size = 200;
                    text.X = 290;
                    text.Y = -15;
                    text.Text = "&";
                    break;
                case 2:
                    text.Color = "000000";
                    text.Alpha = 5;
                    text.Rotation = 0;
                    text.Size = 90;
                    text.X = 69;
                    text.Y = -33;
                    text.Text = "music";
                    break;
                case 3:
                    text.Color = "88ff00";
                    text.Alpha = 50;
                    text.Rotation = 0;
                    text.Size = 90;
                    text.X = 66;
                    text.Y = -36;
                    text.Text = "music";
                    break;
                case 4:
                    text.Color = "000000";
                    text.Alpha = 3;
                    text.Rotation = 3;
                    text.Size = 150;
                    text.X = 22390;
                    text.Y = 153;
                    text.Text = "sound";
                    break;
                case 5:
                    text.Color = "ff6644";
                    text.Alpha = 40;
                    text.Rotation = 3;
                    text.Size = 150;
                    text.X = 20;
                    text.Y = 150;
                    text.Text = "sound";
                    break;
            }
            return text;
        }
        #endregion

        #region GetDrawImage()
        private DotNetXmlSwfChart.DrawImage GetDrawImage()
        {
            xsc.DrawImage di = new xsc.DrawImage();
            di.Alpha = 0;
            di.Url = "images/slow.swf";
            return di;
        }
        #endregion

        #region SetChartRectangle()
        private DotNetXmlSwfChart.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 75;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 180;
            cr.PositiveColor = "88ff00";
            cr.PositiveAlpha = 80;
            cr.NegativeColor = "88ff00";
            cr.NegativeAlpha = 80;
            return cr;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 10;
            cg.Color = "ffffff";
            cg.Thickness = 12;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData d = new xsc.ChartData();
            d.AddDataPoint("hi", "1", 59);
            d.AddDataPoint("hi", "2", 35);
            d.AddDataPoint("hi", "3", 81);
            d.AddDataPoint("hi", "4", 44);
            d.AddDataPoint("hi", "5", 74);
            d.AddDataPoint("hi", "6", 20);
            d.AddDataPoint("hi", "7", 51);
            d.AddDataPoint("hi", "8", 25);
            d.AddDataPoint("hi", "9", 58);
            d.AddDataPoint("hi", "10", 7);
            d.AddDataPoint("hi", "11", 60);
            d.AddDataPoint("hi", "12", 2);
            d.AddDataPoint("hi", "13", 4);
            d.AddDataPoint("hi", "14", 84);
            d.AddDataPoint("hi", "15", 51);
            d.AddDataPoint("hi", "16", 88);
            d.AddDataPoint("hi", "17", 8);
            d.AddDataPoint("hi", "18", 66);
            d.AddDataPoint("hi", "19", 4);
            d.AddDataPoint("hi", "20", 21);
            d.AddDataPoint("hi", "21", 89);
            d.AddDataPoint("hi", "22", 70);
            d.AddDataPoint("hi", "23", 25);
            d.AddDataPoint("hi", "24", 61);
            d.AddDataPoint("hi", "25", 56);
            d.AddDataPoint("hi", "26", 57);
            d.AddDataPoint("hi", "27", 31);
            d.AddDataPoint("hi", "28", 84);
            d.AddDataPoint("hi", "29", 77);
            d.AddDataPoint("hi", "30", 49);
            d.AddDataPoint("hi", "31", 35);
            d.AddDataPoint("hi", "32", 46);
            d.AddDataPoint("hi", "33", 83);
            d.AddDataPoint("hi", "34", 25);
            d.AddDataPoint("hi", "35", 89);
            d.AddDataPoint("hi", "36", 67);
            d.AddDataPoint("hi", "37", 45);
            d.AddDataPoint("hi", "38", 50);
            d.AddDataPoint("hi", "39", 1);
            d.AddDataPoint("hi", "40", 12);
            d.AddDataPoint("hi", "41", 57);
            d.AddDataPoint("hi", "42", 61);
            d.AddDataPoint("hi", "43", 13);
            d.AddDataPoint("hi", "44", 61);
            d.AddDataPoint("hi", "45", 54);
            d.AddDataPoint("hi", "46", 64);
            d.AddDataPoint("hi", "47", 58);
            d.AddDataPoint("hi", "48", 62);
            d.AddDataPoint("hi", "49", 39);
            d.AddDataPoint("hi", "50", 61);
            d.AddDataPoint("hi", "51", 82);
            d.AddDataPoint("hi", "52", 38);
            d.AddDataPoint("hi", "53", 41);
            d.AddDataPoint("hi", "54", 17);
            d.AddDataPoint("hi", "55", 8);
            d.AddDataPoint("hi", "56", 7);
            d.AddDataPoint("hi", "57", 74);
            d.AddDataPoint("hi", "58", 39);
            d.AddDataPoint("hi", "59", 1);
            d.AddDataPoint("hi", "60", 60);
            d.AddDataPoint("hi", "61", 87);
            d.AddDataPoint("hi", "62", 35);
            d.AddDataPoint("hi", "63", 15);
            d.AddDataPoint("hi", "64", 79);
            d.AddDataPoint("hi", "65", 59);
            d.AddDataPoint("hi", "66", 14);
            d.AddDataPoint("hi", "67", 55);
            d.AddDataPoint("hi", "68", 14);
            d.AddDataPoint("hi", "69", 64);
            d.AddDataPoint("hi", "70", 56);
            d.AddDataPoint("hi", "71", 25);
            d.AddDataPoint("hi", "72", 31);
            d.AddDataPoint("hi", "73", 26);
            d.AddDataPoint("hi", "74", 38);
            d.AddDataPoint("hi", "75", 1);
            d.AddDataPoint("hi", "76", 80);
            d.AddDataPoint("hi", "77", 12);
            d.AddDataPoint("hi", "78", 58);
            d.AddDataPoint("hi", "79", 51);
            d.AddDataPoint("hi", "80", 50);
            d.AddDataPoint("hi", "81", 29);
            d.AddDataPoint("hi", "82", 43);
            d.AddDataPoint("hi", "83", 87);
            d.AddDataPoint("hi", "84", 70);
            d.AddDataPoint("hi", "85", 59);
            d.AddDataPoint("hi", "86", 5);
            d.AddDataPoint("hi", "87", 76);
            d.AddDataPoint("hi", "88", 42);
            d.AddDataPoint("hi", "89", 43);
            d.AddDataPoint("hi", "90", 76);
            d.AddDataPoint("hi", "91", 12);
            d.AddDataPoint("hi", "92", 40);
            d.AddDataPoint("hi", "93", 20);
            d.AddDataPoint("hi", "94", 27);
            d.AddDataPoint("hi", "95", 29);
            d.AddDataPoint("hi", "96", 79);
            d.AddDataPoint("hi", "97", 41);
            d.AddDataPoint("hi", "98", 83);
            d.AddDataPoint("hi", "99", 2);

            d.AddDataPoint("lo", "1", -59);
            d.AddDataPoint("lo", "2", -35);
            d.AddDataPoint("lo", "3", -81);
            d.AddDataPoint("lo", "4", -44);
            d.AddDataPoint("lo", "5", -74);
            d.AddDataPoint("lo", "6", -20);
            d.AddDataPoint("lo", "7", -51);
            d.AddDataPoint("lo", "8", -25);
            d.AddDataPoint("lo", "9", -58);
            d.AddDataPoint("lo", "10", -7);
            d.AddDataPoint("lo", "11", -60);
            d.AddDataPoint("lo", "12", -2);
            d.AddDataPoint("lo", "13", -4);
            d.AddDataPoint("lo", "14", -84);
            d.AddDataPoint("lo", "15", -51);
            d.AddDataPoint("lo", "16", -88);
            d.AddDataPoint("lo", "17", -8);
            d.AddDataPoint("lo", "18", -66);
            d.AddDataPoint("lo", "19", -4);
            d.AddDataPoint("lo", "20", -21);
            d.AddDataPoint("lo", "21", -89);
            d.AddDataPoint("lo", "22", -70);
            d.AddDataPoint("lo", "23", -25);
            d.AddDataPoint("lo", "24", -61);
            d.AddDataPoint("lo", "25", -56);
            d.AddDataPoint("lo", "26", -57);
            d.AddDataPoint("lo", "27", -31);
            d.AddDataPoint("lo", "28", -84);
            d.AddDataPoint("lo", "29", -77);
            d.AddDataPoint("lo", "30", -49);
            d.AddDataPoint("lo", "31", -35);
            d.AddDataPoint("lo", "32", -46);
            d.AddDataPoint("lo", "33", -83);
            d.AddDataPoint("lo", "34", -25);
            d.AddDataPoint("lo", "35", -89);
            d.AddDataPoint("lo", "36", -67);
            d.AddDataPoint("lo", "37", -45);
            d.AddDataPoint("lo", "38", -50);
            d.AddDataPoint("lo", "39", -1);
            d.AddDataPoint("lo", "40", -12);
            d.AddDataPoint("lo", "41", -57);
            d.AddDataPoint("lo", "42", -61);
            d.AddDataPoint("lo", "43", -13);
            d.AddDataPoint("lo", "44", -61);
            d.AddDataPoint("lo", "45", -54);
            d.AddDataPoint("lo", "46", -64);
            d.AddDataPoint("lo", "47", -58);
            d.AddDataPoint("lo", "48", -62);
            d.AddDataPoint("lo", "49", -39);
            d.AddDataPoint("lo", "50", -61);
            d.AddDataPoint("lo", "51", -82);
            d.AddDataPoint("lo", "52", -38);
            d.AddDataPoint("lo", "53", -41);
            d.AddDataPoint("lo", "54", -17);
            d.AddDataPoint("lo", "55", -8);
            d.AddDataPoint("lo", "56", -7);
            d.AddDataPoint("lo", "57", -74);
            d.AddDataPoint("lo", "58", -39);
            d.AddDataPoint("lo", "59", -1);
            d.AddDataPoint("lo", "60", -60);
            d.AddDataPoint("lo", "61", -87);
            d.AddDataPoint("lo", "62", -35);
            d.AddDataPoint("lo", "63", -15);
            d.AddDataPoint("lo", "64", -79);
            d.AddDataPoint("lo", "65", -59);
            d.AddDataPoint("lo", "66", -14);
            d.AddDataPoint("lo", "67", -55);
            d.AddDataPoint("lo", "68", -14);
            d.AddDataPoint("lo", "69", -64);
            d.AddDataPoint("lo", "70", -56);
            d.AddDataPoint("lo", "71", -25);
            d.AddDataPoint("lo", "72", -31);
            d.AddDataPoint("lo", "73", -26);
            d.AddDataPoint("lo", "74", -38);
            d.AddDataPoint("lo", "75", -1);
            d.AddDataPoint("lo", "76", -80);
            d.AddDataPoint("lo", "77", -12);
            d.AddDataPoint("lo", "78", -58);
            d.AddDataPoint("lo", "79", -51);
            d.AddDataPoint("lo", "80", -50);
            d.AddDataPoint("lo", "81", -29);
            d.AddDataPoint("lo", "82", -43);
            d.AddDataPoint("lo", "83", -87);
            d.AddDataPoint("lo", "84", -70);
            d.AddDataPoint("lo", "85", -59);
            d.AddDataPoint("lo", "86", -5);
            d.AddDataPoint("lo", "87", -76);
            d.AddDataPoint("lo", "88", -42);
            d.AddDataPoint("lo", "89", -43);
            d.AddDataPoint("lo", "90", -76);
            d.AddDataPoint("lo", "91", -12);
            d.AddDataPoint("lo", "92", -40);
            d.AddDataPoint("lo", "93", -20);
            d.AddDataPoint("lo", "94", -27);
            d.AddDataPoint("lo", "95", -29);
            d.AddDataPoint("lo", "96", -79);
            d.AddDataPoint("lo", "97", -41);
            d.AddDataPoint("lo", "98", -83);
            d.AddDataPoint("lo", "99", -2);
            return d;
        }
        #endregion

        #region SetChartBorder()
        private xsc.ChartBorder SetChartBorder()
        {
            xsc.ChartBorder cb = new xsc.ChartBorder();
            cb.Color = "8888ff";
            cb.TopThickness = 2;
            cb.BottomThickness = 2;
            cb.LeftThickness = 2;
            cb.RightThickness = 2;
            return cb;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Font = "Arial";
            av.Bold = true;
            av.Size = 10;
            av.Color = "ffffff";
            av.Alpha = 75;
            av.Steps = 4;
            av.Prefix = "";
            av.Suffix = "";
            av.Decimals = 0;
            av.Separator = "";
            av.ShowMin = true;
            av.Max = 100;
            av.Min = -100;
            return av;
        }
        #endregion

        #region SetAxisTicks()
        private xsc.AxisTicks SetAxisTicks()
        {
            xsc.AxisTicks at = new xsc.AxisTicks();
            at.ValueTicks = true;
            at.CategoryTicks = false;
            at.MajorThickness = 2;
            at.MinorThickness = 1;
            at.MinorCount = 1;
            at.MajorColor = "8888ff";
            at.MinorColor = "ff4400";
            at.Position = "outside";
            return at;
        }
        #endregion

        #region SetAxisCategory()
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Alpha = 0;
            return ac;
        }
        #endregion
        #endregion
    }
}
