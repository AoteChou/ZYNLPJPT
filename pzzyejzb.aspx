<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzzyejzb.aspx.cs" Inherits="ZYNLPJPT.pzzyejzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置专业二级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body  class="easyui-layout">
  <div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'xymc'" width="50">学院名称</th>
                 <th data-options="field:'xkmc'" width="50">学科名称</th>
                <th data-options="field:'xkfzr'" width="40">学科负责人</th>
                <th data-options="field:'zym'" width="50">专业名称</th>
                <th data-options="field:'button'" width="40">配置专业能力指标</th>
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
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/pzEjzbProc.aspx?zybh=" + xyXkZyViews[i].ZYBH +"&xkbh="+xyXkZyViews[i].XKBH + "'\" >配置专业能力指标</a></td>");
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
