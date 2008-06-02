using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetXmlSwfChart
{
    public abstract class ChartSettingBase
    {
        #region Private Members
        private Dictionary<string, Type> _valueTypes;
        private Dictionary<string, string> _values;
        #endregion

        #region Properties
        protected Dictionary<string, Type> ValueTypes
        {
            get
            {
                if (_valueTypes == null) _valueTypes = new Dictionary<string, Type>();
                return _valueTypes;
            }
            set { _valueTypes = value; }
        }

        protected Dictionary<string, string> Values
        {
            get { return _values; }
        }

        public abstract string ElementName { get; }
        #endregion

        #region Methods
        protected void AddValue(string key, object value)
        {
            if (!this.ValueTypes.ContainsKey(key)) 
                throw new Exception(string.Format("Key {0} is not valid", key));
            if (value.GetType() != this.ValueTypes[key]) 
                throw new Exception(string.Format("Value is not the correct type.  Expected {0}", this.ValueTypes[key].Name));
            if (_values == null) _values = new Dictionary<string, string>();
            if (_values.ContainsKey(key))
            {
                _values[key] = value.ToString();
            }
            else
            {
                _values.Add(key, value.ToString());
            }
        }

        protected bool RemoveValue(string key)
        {
            return this.Values.Remove(key);
        }

        public virtual string ToSourceXML()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("<{0} ", this.ElementName);
            foreach (string key in this.Values.Keys)
            {
                if (this.Values[key] != null) sb.AppendFormat("{0}='{1}' ", key, this.Values[key]);
            }
            sb.Append("/>");
            return sb.ToString();
        }
        #endregion
    }
}
