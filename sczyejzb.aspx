<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sczyejzb.aspx.cs" Inherits="ZYNLPJPT.sczyejzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除专业二级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">

        function deleteAllEjzb(zybh, xkbh) {
            $.post("processAspx/DelAllZyZjzb.aspx", { 'zybh': zybh, 'xkbh': xkbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,请重试!', 'info', function () {
                        window.location.reload();
                    });
                } else if (result == 'True') {
                    window.location.reload();
                }
            });
        }
    </script>
</head>
<body  class="easyui-layout">
  <div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'xymc'" width="50">学院名称</th>
                 <th data-options="field:'xkmc'" width="50">学科名称</th>
                <th data-options="field:'xkfzr'" width="20">学科负责人</th>
                <th data-options="field:'zym'" width="30">专业名称</th>
                <th data-options="field:'button1',align:'center'" width="50">删除所有能力指标</th>
                <th data-options="field:'button2',align:'center'" width="50">删除单个能力指标</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.xyXkZyViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + xyXkZyViews[i].XYMC + "</td>");
                       Response.Write("	<td >" + xyXkZyViews[i].XKMC + "</td>");
                       Response.Write("  <td >" + xyXkZyViews[i].XKFZR + "</td>");
                       Response.Write("	<td >" + xyXkZyViews[i].ZYM + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteAllEjzb(" + xyXkZyViews[i].ZYBH + "," + xyXkZyViews[i].XKBH + ") \" >删除所有能力指标</a></td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/scEjzbProc.aspx?zybh=" + xyXkZyViews[i].ZYBH + "&xkbh=" + xyXkZyViews[i].XKBH + "'\" >删除单个能力指标</a></td>");
                       Response.Write("</tr>");
                   }
                    %>
    	</tbody>
   	</table>     
</div>                
<script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            pagination: false,
            pageList: [30],
            pageSize: 30,
            singleSelect: true,
        });
    });
</script>
</body>
</html>
