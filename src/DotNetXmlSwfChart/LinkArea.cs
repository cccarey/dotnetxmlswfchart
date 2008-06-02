using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class LinkArea : ChartSettingBase
    {
        #region Constructors
        public LinkArea()
        {
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("width", typeof(int));
            this.ValueTypes.Add("height", typeof(int));
            this.ValueTypes.Add("url", typeof(string));
            this.ValueTypes.Add("priority", typeof(int));
            this.ValueTypes.Add("target", typeof(string));
            this.ValueTypes.Add("text", typeof(string));
            this.ValueTypes.Add("font", typeof(string));
            this.ValueTypes.Add("bold", typeof(bool));
            this.ValueTypes.Add("size", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("background_color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
        }
        #endregion

        #region Properties
        public int X
        {
            get { return Convert.ToInt32(this.Values["x"]); }
            set { this.AddValue("x", value); }
        }

        public int Y
        {
            get { return Convert.ToInt32(this.Values["y"]); }
            set { this.AddValue("y", value); }
        }

        public int Width
        {
            get { return Convert.ToInt32(this.Values["width"]); }
            set { this.AddValue("width", value); }
        }

        public int Height
        {
            get { return Convert.ToInt32(this.Values["height"]); }
            set { this.AddValue("height", value); }
        }

        public string Url
        {
            get { return this.Values["url"]; }
            set { this.AddValue("url", value); }
        }

        public int Priority
        {
            get { return Convert.ToInt32(this.Values["priority"]); }
            set { this.AddValue("priority", value); }
        }

        public string Target
        {
            get { return this.Values["target"]; }
            set { this.AddValue("target", value); }
        }

        public string Text
        {
            get { return this.Values["text"]; }
            set { this.AddValue("text", value); }
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

        public string BackgroundColor
        {
            get { return this.Values["background_color"]; }
            set { this.AddValue("background_color", value); }
        }

        public int Alpha
        {
            get { return Convert.ToInt32(this.Values["alpha"]); }
            set { this.AddValue("alpha", value); }
        }

        public override string ElementName
        {
            get { return "area"; }
        }
        #endregion
    }
}
