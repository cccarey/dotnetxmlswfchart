using System;

namespace testWeb.tests
{
    public abstract class ChartTestBase
    {
        public ChartTestBase() { }

        public abstract DotNetXmlSwfChart.ChartHTML ChartInclude { get; }
        public abstract DotNetXmlSwfChart.Chart Chart { get; }
    }
}
