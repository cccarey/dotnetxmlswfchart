using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public enum TextHAlign
    {
        left,
        center,
        right
    }

    public enum TextVAlign
    {
        top,
        middle,
        bottom
    }

    public enum DrawLayer
    {
        background,
        foreground
    }

    public enum TransitionType
    {
        dissolve,
        drop,
        spin,
        scale,
        zoom,
        blink,
        slide_right,
        slide_left,
        slide_up,
        slide_down,
        none
    }

    public enum TransitionOrder
    {
        series,
        category,
        all
    }

    public enum ChartGridType
    {
        Horizontal,
        Vertical
    }

    public enum ChartGridLineType
    {
        solid,
        dotted,
        dashed
    }

    public enum LegendLabelLayout
    {
        horizontal,
        vertical
    }

    public enum LegendLabelBullet
    {
        square,
        circle,
        line
    }

    public enum XmlSwfChartType
    {
        Line,
        Column,
        ColumnStacked,
        ColumnFloating,
        Column3d,
        ColumnStacked3d,
        ColumnParallel3d,
        Pie,
        Pie3d,
        Bar,
        BarStacked,
        BarFloating,
        Area,
        AreaStacked,
        Candlestick,
        Scatter,
        Polar
    }
}
