using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LegendLabel : ChartSettingBase
    {
        #region Constructors
        public LegendLabel()
        {
            this.ValueTypes.Add("layout", typeof(LegendLabelLayout));
            this.ValueTypes.Add("bullet", typeof(LegendLabelBullet));
            this.ValueTypes.Add("font", typeof(string));
            this.ValueTypes.Add("bold", typeof(bool));
            this.ValueTypes.Add("size", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
        }
        #endregion

        #region Properties
        public LegendLabelLayout Layout
        {
            get { return (LegendLabelLayout)Enum.Parse(typeof(LegendLabelLayout), this.Values["layout"]); }
            set { this.AddValue("layout", value); }
        }

        public LegendLabelBullet Bullet
        {
            get { return (LegendLabelBullet)Enum.Parse(typeof(LegendLabelBullet), this.Values["bullet"]); }
            set { this.AddValue("bullet", value); }
        }

        public string Font
        {
            get { return this.Values["font"]; }
            set { this.AddValue("font", value); }
        }

        public bool Bold
        {
            get { return Convert.ToBoolean(this.Values["bold"]); }
            set { this.AddValue("bold", value); }
        }

        public int Size
        {
            get { return Convert.ToInt32(this.Values["size"]); }
            set { this.AddValue("size", value); }
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

        public override string ElementName
        {
            get { return "legend_label"; }
        }
        #endregion
    }
}
