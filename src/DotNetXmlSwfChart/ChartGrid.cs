using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class ChartGrid : ChartSettingBase
    {
        #region Constructors
        public ChartGrid(ChartGridType type)
        {
            this.Type = type;
            this.ValueTypes.Add("thickness", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
            this.ValueTypes.Add("type", typeof(ChartGridLineType));
        }
        #endregion

        #region Properties
        public int Thickness
        {
            get { return Convert.ToInt32(this.Values["thickness"]); }
            set { this.AddValue("thickness", value); }
        }

        public string Color
        {
            get { return this.Values["color"]; }
            set { this.AddValue("color", value); }
        }

        public int Alpha
        {
            get { return Convert.ToInt32(this.Values["alpha"]); }
            set { this.AddValue("alpha", value); }
        }

        public ChartGridLineType GridLineType
        {
            get { return (ChartGridLineType)Enum.Parse(typeof(ChartGridLineType), this.Values["type"]); }
            set { this.AddValue("type", value); }
        }

        public ChartGridType Type;

        public override string ElementName
        {
            get
            {
                switch (this.Type)
                {
                    case ChartGridType.Horizontal:
                        return "chart_grid_h";
                    case ChartGridType.Vertical:
                        return "chart_grid_v";
                }
                return "chart_grid_h";
            }
        }
        #endregion
    }
}
