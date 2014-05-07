<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzZsdyToEjzb.aspx.cs" Inherits="ZYNLPJPT.pzZsdyToEjzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置知识单元对应二级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="配置知识单元对应二级指标" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'zslybh',align:'center'" width="8">知识领域编号</th>
    			<th data-options="field:'zslymc',align:'center'" width="15">知识领域名称</th>
                <th data-options="field:'zsdybh',align:'center'" width="8">知识单元编号</th>
    			<th data-options="field:'zsdymc',align:'center'" width="15">知识单元名称</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
                <th data-options="field:'button',align:'center'" width="40">配置知识单元对应二级指标</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.zsnlViewWrappers.Length; i++)
                   {
                       Response.Write("<tr>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSLYBH + "</td>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSLYMC + "</td>");
                       Response.Write("	<td >" + zsnlViewWrappers[i].ZsnlView.ZSDYBH + "</td>");
                       Response.Write("  <td >" + zsnlViewWrappers[i].ZsnlView.ZSDYMC + "</td>");
                       Response.Write("  <td >" + zsnlViewWrappers[i].Xkmc + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/zsdyToEjzbData.aspx?xkbh=" + this.zsnlViewWrappers[i].ZsnlView.XKBH + "&zslybh=" + zsnlViewWrappers[i].ZsnlView.ZSLYBH + "&zsdybh=" + zsnlViewWrappers[i].ZsnlView.ZSDYBH + "'\" >配置知识单元对应二级指标</a></td>");
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
