using System;

namespace testWeb.tests
{
    public class NullTest : ChartTestBase
    {
        public override DotNetXmlSwfChart.ChartHTML ChartInclude
        {
            get { return new DotNetXmlSwfChart.ChartHTML(); }
        }
        public override DotNetXmlSwfChart.Chart Chart
        {
            get { return new DotNetXmlSwfChart.Chart(); }
        }
    }
}
