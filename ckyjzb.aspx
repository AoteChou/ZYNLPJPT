<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckyjzb.aspx.cs" Inherits="ZYNLPJPT.ckyjzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>查看一级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看一级指标" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'yjzbbh',align:'center'" width="8">一级指标编号</th>
    			<th data-options="field:'yjzbmc',align:'center'" width="15">一级指标名称</th>
                <th data-options="field:'yjzbqz',align:'center'" width="8">一级指标重值</th>
                <th data-options="field:'bz',align:'center'" width="8">一级指标备注</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.yjzbWrappers.Length; i++)
                  {
                      Response.Write("<tr>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBBH + "</td>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBMC + "</td>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBQZ+ "</td>");
                      Response.Write("  <td >" + yjzbWrappers[i].Yjzb.BZ+ "</td>");
                      Response.Write("  <td >" + yjzbWrappers[i].XkName + "</td>");
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