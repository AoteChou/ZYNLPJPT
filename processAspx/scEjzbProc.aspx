<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scEjzbProc.aspx.cs" Inherits="ZYNLPJPT.processAspx.scEjzbProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除单个专业二级指标</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function deleteSingleEjzb(zybh, xkbh, ejzbbh) {
            $.post("DelSingleZyZjzb.aspx", { 'zybh': zybh, 'xkbh': xkbh, 'ejzbbh': ejzbbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,请重试!', 'info', function () {
                        //do  nothing
                    });
                } else if (result == 'True') {
                    window.location.reload();
                }
            });
        }
        function returnUpPage() {
            window.location = "../sczyejzb.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true" style="overflow:hidden;"  >
        <div style="padding-top:10px; padding-bottom:10px; text-align:center;" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnUpPage()">返回上页</a>
        </div>
    </div>

    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'yjzbbh'" width="10">一级指标编号</th>
                <th data-options="field:'yjzbmc'" width="50">一级指标名称</th>
                <th data-options="field:'ejzbbh'" width="10">二级指标编号</th>
                <th data-options="field:'ejzbmc'" width="50">二级指标名称</th>
                <th data-options="field:'nlzbz'" width="10">指标要求值</th>
                <th data-options="field:'scButton',align:'center'" width="35">删除该二级指标</th>
    		</tr>
    	</thead>
   		<tbody >
               <%
                   for (int i = 0; i < this.NLZBViewWrappers.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + NLZBViewWrappers[i].NlzbView.YJZBBH+ "</td>");
                       Response.Write("	<td >" + NLZBViewWrappers[i].NlzbView.YJZBMC + "</td>");
                       Response.Write("  <td >" + NLZBViewWrappers[i].NlzbView.EJZBBH + "</td>");
                       Response.Write("  <td >" + NLZBViewWrappers[i].NlzbView.EJZBMC + "</td>");
                       Response.Write("	<td >" + NLZBViewWrappers[i].Nlyq+ "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteSingleEjzb(" + zybh + "," + xkbh +","+NLZBViewWrappers[i].NlzbView.EJZBBH+ ") \" >删除该二级指标</a></td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    </div>
    </form>
</body>
</html>