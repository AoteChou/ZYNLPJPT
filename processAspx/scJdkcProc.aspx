<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scJdkcProc.aspx.cs" Inherits="ZYNLPJPT.scJdkcProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除单个测评阶段</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function deleteSingleJdkc(zybh, njbh, jdbh, kcbh) {
            $.post("DelSingleJdkc.aspx", { 'zybh': zybh, 'njbh': njbh, 'jdbh': jdbh,'kcbh':kcbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,该阶段课程已配置改题人，请先产出改题人，再进行此操作！', 'info', function () {
                        window.location.reload();
                    });
                } else if (result == 'True') {
                    window.location.reload();
                }
            });
        }
        function returnUpPage() {
            window.location = "../scjdkc.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnUpPage()">返回上页</a>
        </div>
    </div>
    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'kcbh'" width="12">课程编号</th>
                 <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                 <th data-options="field:'sszy',align:'center'" width="55">所属专业</th>
                 <th data-options="field:'ssxk',align:'center'" width="55">所属学科</th>
                <th data-options="field:'kcxz'" width="50">课程性质</th>
                <th data-options="field:'llxf'" width="30">理论学分</th>
                <th data-options="field:'sjxf'" width="30">实践学分</th>
                <th data-options="field:'scButton',align:'center'" width="40">删除该阶段课程</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.zykcViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.zykcViews[i].KCBH+ "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCMC + "</td>");
                       Response.Write("  <td >" +this.zykcViews[i].ZYM+ "</td>");
                       Response.Write("  <td >" + this.zykcViews[i].XKMC + "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCXZMC + "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].LLXF + "</td>");
                       Response.Write("	<td >" +this.zykcViews[i].SJXF + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteSingleJdkc(" + zybh + "," + njbh + "," + jdbh +","+ zykcViews[i].KCBH + ") \" >删除该阶段课程</a></td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    </div>
        <script type="text/javascript">
             $(function () {
                $('#mytable').datagrid({
                 pagination: false,
                 pageList: [30],
                 pageSize: 30,
                 singleSelect: false,
                });
            });
        </script>
    </form>
</body>
</html>
