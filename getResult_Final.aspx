<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getResult_Final.aspx.cs" Inherits="ZYNLPJPT.getResult_Final" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>最终分数</title>
    <link rel="Stylesheet" type="text/css" href="Styles/getResult_Final.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/highcharts.js"></script>
    <script type="text/javascript" src="Scripts/drilldown.js"></script>
    <script type="text/javascript" src="Scripts/exporting.js"></script>
</head>
<body class="easyui-layout">
    <form id="form1" runat="server">
    <div id="left">
        <div id="resultDiv">
            <font id="score"><%=result %></font>
            <font >分</font><br />
            <font>专业能力综合得分</font>
        </div>
        <div id="sepDiv">
            <table  style="BORDER-LEFT:#C0C0C0 1px solid;" align=center height=500  borderColor=#C0C0C0 >
                <tbody><tr><td></td></tr></tbody>
            </table>
        </div>

    </div>
    <div id="right">
        <div id="container" style="width:90%; height:90%; top:15px;"></div>
    </div>
    </form>
 <script type="text/javascript">
     $(function () {
            var nowDate = new Date();
            var datestring=nowDate.toLocaleString()
         $('#container').highcharts({
             chart: {
                 type: 'column',
                 events:{
                     drilldown:function(e){
                        this.setTitle ({text:'指标:['+e.point.name +']下属二级指标得分情况'},{text:''});
                     },
                     drillup:function(e){
                        this.setTitle ({text:'一级指标得分情况,'+datestring},{text:'点击获取二级指标得分情况'});
                     }
                 }
                 
             },
             title: {
                 text: '一级指标得分情况,'+datestring
             },
            subtitle: {
                text: '点击获取二级指标得分情况'
            },
            xAxis: {
                 type:'category'
            },
             yAxis: {
                 title: {
                     text: '分 数'
                 }
             },
             series: [{
                 name: '一级指标得分',
                 colorByPoint: true,
                 data: <%=yjzbData %>
             }],
             tooltip:{
                 formatter: function() {
                    var point = this.point,
                        s = this.point.name+'<br/><b>'+ this.y +'分</b><br/>';
                    if (point.drilldown) {
                        s += '<font style="color:#C0C0C0">点击查看二级指标得分情况</font>';
                    } 
                    return s;
                }
            },
            drilldown: {
                series: <%=drilldownSeries %>
            },
            exporting:{
                enabled:true
            },
         });
     });
 
 </script>
</body>
</html>
