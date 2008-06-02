using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartData
    {
        #region Private Members
        private Dictionary<string, List<ChartDataPoint>> _category;
        private Dictionary<string, List<ChartDataPoint>> _series;
        private Dictionary<string, Dictionary<string, ChartDataPoint>> _dataPoints;
        #endregion

        #region Constructors
        public ChartData()
        {
            _category = new Dictionary<string, List<ChartDataPoint>>();
            _series = new Dictionary<string, List<ChartDataPoint>>();
            _dataPoints = new Dictionary<string, Dictionary<string, ChartDataPoint>>();
        }
        #endregion

        #region Properties
        public Dictionary<string, List<ChartDataPoint>> CategoryData
        {
            get { return _category; }
        }

        public Dictionary<string, List<ChartDataPoint>> SeriesData
        {
            get { return _series; }
        }

        public Dictionary<string, Dictionary<string, ChartDataPoint>> DataPoints
        {
            get { return _dataPoints; }
        }
        #endregion

        #region Public Methods
        public bool RemoveCategory(string category)
        {
            return _category.Remove(category);
        }

        public bool RemoveSeries(string series)
        {
            return _series.Remove(series);
        }

        public void AddDataPoint(ChartDataPoint dataPoint)
        {
            if (!this.CategoryData.ContainsKey(dataPoint.CategoryKey))
            {
                _category.Add(dataPoint.CategoryKey, new List<ChartDataPoint>());
            }
            if (!this.SeriesData.ContainsKey(dataPoint.SeriesKey))
            {
                _series.Add(dataPoint.SeriesKey, new List<ChartDataPoint>());
            }
            if (!this.DataPoints.ContainsKey(dataPoint.CategoryKey))
            {
                _dataPoints.Add(dataPoint.CategoryKey, new Dictionary<string, ChartDataPoint>());
            }                
            _category[dataPoint.CategoryKey].Add(dataPoint);
            _series[dataPoint.SeriesKey].Add(dataPoint);
            _dataPoints[dataPoint.CategoryKey].Add(dataPoint.SeriesKey, dataPoint);
        }

        public void AddDataPoint(string series, string category, object value)
        {
            AddDataPoint(new ChartDataPoint(series, category, value));
        }

        public bool RemoveDataPoint(ChartDataPoint dataPoint)
        {
            return (_category[dataPoint.CategoryKey].Remove(dataPoint)) && (_series[dataPoint.SeriesKey].Remove(dataPoint));
        }

        public string ToSourceXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("<chart_data>");
            sb.Append("<row><null/>");
            foreach (string category in this.CategoryData.Keys)
            {
                sb.AppendFormat("<string>{0}</string>", category);
            }
            sb.Append("</row>");
            foreach (string series in this.SeriesData.Keys)
            {
                sb.Append("<row>");
                sb.AppendFormat("<string>{0}</string>", series);
                foreach (string category in this.CategoryData.Keys)
                {
                    sb.AppendFormat("<number>{0}</number>", this.DataPoints[category][series].Value);
                }
                sb.Append("</row>");
            }
            sb.Append("</chart_data>");
            return sb.ToString();
        }
        #endregion
    }
}
