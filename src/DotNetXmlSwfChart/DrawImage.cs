using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public class DrawImage : DrawBase
    {
        #region Constructors
        public DrawImage() : base()
        {
            this.ValueTypes.Add("url", typeof(string));
            this.ValueTypes.Add("x", typeof(int));
            this.ValueTypes.Add("y", typeof(int));
            this.ValueTypes.Add("width", typeof(int));
            this.ValueTypes.Add("height", typeof(int));
            this.ValueTypes.Add("rotation", typeof(int));
            this.ValueTypes.Add("alpha", typeof(int));
        }
        #endregion

        #region Properties
        public string Url
        {
            get { return this.Values["url"]; }
            set { this.AddValue("url", value); }
        }

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

        public int Rotation
        {
            get { return Convert.ToInt32(this.Values["rotation"]); }
            set { this.AddValue("rotation", value); }
        }

        public int Alpha
        {
            get { return Convert.ToInt32(this.Values["alpha"]); }
            set { this.AddValue("alpha", value); }
        }

        public override string ElementName
        {
            get { return "image"; }
        }
        #endregion
    }
}
