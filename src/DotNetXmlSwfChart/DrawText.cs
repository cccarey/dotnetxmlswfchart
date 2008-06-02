using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class DrawText : DrawBase
    {
        #region Constructors
        public DrawText()
            : base()
        {
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("width", typeof(int));
            this.ValueTypes.Add("height", typeof(int));
            this.ValueTypes.Add("h_align", typeof(TextHAlign));
            this.ValueTypes.Add("v_align", typeof(TextVAlign));
            this.ValueTypes.Add("rotation", typeof(int));
            this.ValueTypes.Add("font", typeof(string));
            this.ValueTypes.Add("bold", typeof(bool));
            this.ValueTypes.Add("size", typeof(int));
            this.ValueTypes.Add("color", typeof(string));
            this.ValueTypes.Add("alpha", typeof(int));
        }
        #endregion

        #region Properties
        public string Text;

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

        public TextHAlign HAlign
        {
            get { return (TextHAlign)Enum.Parse(typeof(TextHAlign), this.Values["h_align"]); }
            set { this.AddValue("h_align", value); }
        }

        public TextVAlign VAlign
        {
            get { return (TextVAlign)Enum.Parse(typeof(TextVAlign), this.Values["v_align"]); }
            set { this.AddValue("v_align", value); }
        }

        public int Rotation
        {
            get { return Convert.ToInt32(this.Values["rotation"]); }
            set { this.AddValue("rotation", value); }
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
            get { return "text"; }
        }
        #endregion

        #region ToSourceXml()
        public override string ToSourceXML()
        {
            StringBuilder sb = new StringBuilder();
            string baseXml = base.ToSourceXML();
            sb.Append(baseXml.Substring(0,baseXml.Length - 3));
            sb.AppendFormat(">{0}</{1}>", this.Text, this.ElementName);
            return sb.ToString();
        }
        #endregion
    }
}
