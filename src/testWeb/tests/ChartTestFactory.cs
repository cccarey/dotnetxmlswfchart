using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

namespace testWeb.tests
{
    public class ChartTestFactory
    {
        public static ChartTestBase GetTest(string test)
        {
            switch (test)
            {
                case "line1":
                    return new LineOne();
                case "line2":
                    return new LineTwo();
                case "column1":
                    return new ColumnOne();
                case "column2":
                    return new ColumnTwo();
                case "stackedcolumn1":
                    return new StackedColumnOne();
                case "stackedcolumn2":
                    return new StackedColumnTwo();
                case "floatingcolumn1":
                    return new FloatingColumnOne();
                case "floatingcolumn2":
                    return new FloatingColumnTwo();
                case "column3d1":
                    return new Column3DOne();
                case "column3d2":
                    return new Column3DTwo();
                case "stackedcolumn3d1":
                    return new StackedColumn3dOne();
                case "stackedcolumn3d2":
                    return new StackedColumn3dTwo();
                case "parallelcolumn3d1":
                    return new ParallelColumn3DOne();
                case "parallelcolumn3d2":
                    return new ParallelColumn3DTwo();
                case "pie1":
                    return new PieOne();
                case "pie2":
                    return new PieTwo();
                case "3dpie1":
                    return new Pie3DOne();
                case "3dpie2":
                    return new Pie3DTwo();
                case "bar1":
                    return new BarOne();
                case "bar2":
                    return new BarTwo();
                case "barstacked1":
                    return new BarStackedOne();
                case "barstacked2":
                    return new BarStackedTwo();
                case "barfloat1":
                    return new FloatingBarOne();
                case "barfloat2":
                    return new FloatingBarTwo();
            }
            return new NullTest();
        }
    }
}
