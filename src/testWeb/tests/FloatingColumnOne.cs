using System;
using System.Collections.Generic;
using xsc = DotNetXmlSwfChart;

namespace testWeb.tests
{
    public class FloatingColumnOne : ChartTestBase
    {
        //TODO: Update test so the links work
        //Note: the reference chart on the gallery page at
        //http://www.maani.us/xml_charts/index.php?menu=Gallery&submenu=Floating_Column
        //contains a link.  Need a license in order to make the links work. Fix it
        //once a license is available
        #region ChartInclude
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get
            {
                DotNetXmlSwfChart.ChartHTML chartHtml = new DotNetXmlSwfChart.ChartHTML();
                chartHtml.height = 300;
                chartHtml.bgColor = "ccaaff";
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
                c.ChartGridH = SetChartGridH();
                c.ChartGridV = SetChartGridV();
                c.ChartRectangle = SetChartRectangle();
                c.ChartTransition = SetChartTransition();
                c.ChartValue = SetChartValue();

                c.Data = SetChartData();

                c.DrawImages = SetDrawImages();
                c.DrawTexts = SetDrawTexts();
                c.DrawRectangles = SetDrawRectangles();
                c.DrawCircles = SetDrawCircles();

                c.LinkAreas = SetLinkAreas();

                c.LegendRectangle = SetLegendRectangle();
                c.SeriesColors = new List<string>();
                c.SeriesColors.Add("ffaa22");
                c.SeriesGap = SetSeriesGap();
                return c;
            }
        }
        #endregion

        #region Helpers
        #region SetAxisCategory()
        private xsc.AxisCategory SetAxisCategory(xsc.XmlSwfChartType type)
        {
            xsc.AxisCategory ac = new xsc.AxisCategory(type);
            ac.Size = 14;
            ac.Color = "000000";
            ac.Alpha = 50;
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
            at.MinorThickness = 0;
            at.MinorCount = 0;
            at.MajorColor = "888888";
            at.Position = "centered";
            return at;
        }
        #endregion

        #region SetAxisValue()
        private xsc.AxisValue SetAxisValue()
        {
            xsc.AxisValue av = new xsc.AxisValue();
            av.Size = 12;
            av.Color = "000000";
            av.Alpha = 50;
            av.Steps = 4;
            av.Prefix = "";
            av.Suffix = "F";
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
            cb.TopThickness = 0;
            cb.BottomThickness = 2;
            cb.LeftThickness = 1;
            cb.RightThickness = 0;
            return cb;
        }
        #endregion

        #region SetChartGridH()
        private xsc.ChartGrid SetChartGridH()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Horizontal);
            cg.Alpha = 20;
            cg.Color = "000000";
            cg.Thickness = 0;
            cg.GridLineType = xsc.ChartGridLineType.dashed;
            return cg;
        }
        #endregion

        #region SetChartGridV()
        private xsc.ChartGrid SetChartGridV()
        {
            xsc.ChartGrid cg = new xsc.ChartGrid(xsc.ChartGridType.Vertical);
            cg.Alpha = 20;
            cg.Color = "ffffff";
            cg.Thickness = 5;
            cg.GridLineType = xsc.ChartGridLineType.solid;
            return cg;
        }
        #endregion

        #region SetChartRectangle()
        private xsc.ChartRectangle SetChartRectangle()
        {
            xsc.ChartRectangle cr = new xsc.ChartRectangle();
            cr.X = 75;
            cr.Y = 50;
            cr.Width = 300;
            cr.Height = 150;
            cr.PositiveColor = "ffff00";
            cr.PositiveAlpha = 80;
            return cr;
        }
        #endregion

        #region SetChartTransition()
        private xsc.ChartTransition SetChartTransition()
        {
            xsc.ChartTransition ct = new xsc.ChartTransition();
            ct.TransitionType = xsc.TransitionType.dissolve;
            ct.Delay = 0.5;
            ct.Duration = 0.5;
            ct.Order = xsc.TransitionOrder.all;
            return ct;
        }
        #endregion

        #region SetChartValue()
        private xsc.ChartValue SetChartValue()
        {
            xsc.ChartValue cv = new xsc.ChartValue();
            cv.Color = "ffffff";
            cv.Alpha = 85;
            cv.Font = "Arial";
            cv.Bold = true;
            cv.Size = 10;
            cv.Position = "inside";
            cv.Prefix = "";
            cv.Suffix = "";
            cv.Decimals = 0;
            cv.Separator = "";
            cv.AsPercentage = false;
            return cv;
        }
        #endregion

        #region SetChartData()
        private xsc.ChartData SetChartData()
        {
            xsc.ChartData cd = new xsc.ChartData();
            cd.AddDataPoint("hi", "MON", 54);
            cd.AddDataPoint("hi", "TUE", 60);
            cd.AddDataPoint("hi", "WED", 62);
            cd.AddDataPoint("hi", "THU", 63);
            cd.AddDataPoint("hi", "FRI", 64);
            cd.AddDataPoint("hi", "SAT", 63);
            cd.AddDataPoint("hi", "SUN", 62);

            cd.AddDataPoint("lo", "MON", 45);
            cd.AddDataPoint("lo", "TUE", 51);
            cd.AddDataPoint("lo", "WED", 55);
            cd.AddDataPoint("lo", "THU", 53);
            cd.AddDataPoint("lo", "FRI", 51);
            cd.AddDataPoint("lo", "SAT", 50);
            cd.AddDataPoint("lo", "SUN", 53);

            return cd;
        }
        #endregion

        #region SetDrawImages()
        private List<xsc.DrawImage> SetDrawImages()
        {
            List<xsc.DrawImage> img = new List<xsc.DrawImage>();
            xsc.DrawImage i = new xsc.DrawImage();
            i.Transition = xsc.TransitionType.dissolve;
            i.Delay = 0;
            i.Duration = 0.5;
            i.Layer = xsc.DrawLayer.background;
            i.Alpha = 10;
            i.Url = "images/pattern.swf";
            i.X = 0;
            i.Y = 0;
            i.Width = 550;
            i.Height = 400;
            img.Add(i);
            return img;
        }
        #endregion

        #region SetDrawTexts()
        private List<xsc.DrawText> SetDrawTexts()
        {
            List<xsc.DrawText> txt = new List<xsc.DrawText>();
            xsc.DrawText t = new xsc.DrawText();
            t.Color = "ffffee";
            t.Alpha = 75;
            t.Rotation = 0;
            t.Size = 50;
            t.X = 0;
            t.Y = -10;
            t.Width = 400;
            t.Height = 200;
            t.HAlign = xsc.TextHAlign.left;
            t.VAlign = xsc.TextVAlign.top;
            t.Text = "temperatures";
            txt.Add(t);

            t = new xsc.DrawText();
            t.Color = "000000";
            t.Alpha = 35;
            t.Rotation = 0;
            t.Size = 25;
            t.X = 317;
            t.Y = 10;
            t.Width = 300;
            t.Height = 200;
            t.HAlign = xsc.TextHAlign.left;
            t.VAlign = xsc.TextVAlign.top;
            t.Text = "hi/low";
            txt.Add(t);

            t = new xsc.DrawText();
            t.Color = "ffff88";
            t.Alpha = 90;
            t.Size = 18;
            t.X = 95;
            t.Y = 240;
            t.Width = 300;
            t.Height = 200;
            t.Text = "Fahrenheit                 Celsius";
            txt.Add(t);

            t = new xsc.DrawText();
            t.Transition = xsc.TransitionType.drop;
            t.Duration = 2;
            t.Color = "000000";
            t.Alpha = 40;
            t.Rotation = -90;
            t.Size = 30;
            t.X = 20;
            t.Y = 210;
            t.Width = 300;
            t.Height = 200;
            t.HAlign = xsc.TextHAlign.left;
            t.VAlign = xsc.TextVAlign.top;
            t.Text = "fahrenheit";
            txt.Add(t);

            return txt;
        }
        #endregion

        #region SetDrawRectangles()
        private List<xsc.DrawRectangle> SetDrawRectangles()
        {
            List<xsc.DrawRectangle> dr = new List<xsc.DrawRectangle>();
            xsc.DrawRectangle r = new xsc.DrawRectangle();
            r.X = 0;
            r.Y = 230;
            r.Width = 400;
            r.Height = 400;
            r.FillColor = "440088";
            r.FillAlpha = 40;
            r.LineColor = "000000";
            r.LineAlpha = 0;
            r.LineThickness = 0;
            dr.Add(r);
            return dr;
        }
        #endregion

        #region SetDrawCircles()
        private List<xsc.DrawCircle> SetDrawCircles()
        {
            List<xsc.DrawCircle> cir = new List<xsc.DrawCircle>();
            xsc.DrawCircle c = new xsc.DrawCircle();
            c.X = 85;
            c.Y = 252;
            c.Radius = 8;
            c.FillColor = "000000";
            c.FillAlpha = 0;
            c.LineColor = "000000";
            c.LineAlpha = 60;
            c.LineThickness = 2;
            cir.Add(c);

            c = new xsc.DrawCircle();
            c.X = 260;
            c.Y = 252;
            c.Radius = 8;
            c.FillColor = "000000";
            c.FillAlpha = 0;
            c.LineColor = "000000";
            c.LineAlpha = 60;
            c.LineThickness = 2;
            cir.Add(c);

            c = new xsc.DrawCircle();
            c.X = 85;
            c.Y = 252;
            c.Radius = 5;
            c.FillColor = "000000";
            c.FillAlpha = 90;
            c.LineColor = "000000";
            c.LineAlpha = 0;
            c.LineThickness = 0;
            cir.Add(c);

            return cir;
        }
        #endregion

        #region SetLinkAreas()
        private List<xsc.LinkArea> SetLinkAreas()
        {
            List<xsc.LinkArea> la = new List<xsc.LinkArea>();
            xsc.LinkArea l = new xsc.LinkArea();
            l.X = 250;
            l.Y = 240;
            l.Width = 130;
            l.Height = 25;
            l.Url = "chartView.aspx?test=floatingcolumn1";
            l.Target = "live_update";
            la.Add(l);
            return la;
        }
        #endregion

        #region SetLegendRectangle()
        private xsc.LegendRectangle SetLegendRectangle()
        {
            xsc.LegendRectangle lr = new xsc.LegendRectangle();
            lr.X = -1000;
            lr.Y = -1000;
            lr.Width = 0;
            lr.Height = 0;
            return lr;
        }
        #endregion

        #region SetSeriesGap()
        private xsc.SeriesGap SetSeriesGap()
        {
            xsc.SeriesGap sg = new xsc.SeriesGap();
            sg.BarGap = 0;
            sg.SetGap = 25;
            return sg;
        }
        #endregion
        #endregion
    }
}
