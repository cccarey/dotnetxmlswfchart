<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chartView.aspx.cs" Inherits="testWeb.chartView" %>
<%@ Register Assembly="DotNetXmlSwfChart" Namespace="DotNetXmlSwfChart" TagPrefix="dnxsc" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DotNetXmlSwfChart - Chart View - Test: {0}</title>
</head>
<body>
    <div id="chartDiv">
        <dnxsc:ChartHTML ID="chartHtml" runat="server" />
    </div>
    <p><a href="xmlData.aspx">Show Data</a></p>
    <p><a href="index.htm">Return to Tests</a></p>
</body>
</html>
