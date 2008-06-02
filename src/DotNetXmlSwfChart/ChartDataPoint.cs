using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartDataPoint
    {
        private string _seriesKey;
        private string _categoryKey;
        private object _value;

        public ChartDataPoint() { }

        public ChartDataPoint(string series, string category, object value)
        {
            this.SeriesKey = series;
            this.CategoryKey = category;
            this.Value = value;
        }

        public string SeriesKey
        {
            get { return _seriesKey; }
            set { _seriesKey = value; }
        }

        public string CategoryKey
        {
            get { return _categoryKey; }
            set { _categoryKey = value; }
        }

        public object Value
        {
            get { return _value; }
            set { _value = value; }
        }
    }
}
