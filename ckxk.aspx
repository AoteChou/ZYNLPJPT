<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckxk.aspx.cs" Inherits="ZYNLPJPT.ckxk" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>查看学科信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
    </head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看学科信息" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'xkbh'" width="50">学科编号</th>
                <th data-options="field:'xkmc'" width="50">学科名称</th>
                <th data-options="field:'xkfzr'" width="50">学科负责人</th>
                <th data-options="field:'xymc'" width="50">所属学院</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.xks.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + xks[i].XKBH + "</td>");
                       Response.Write("	<td >" + xks[i].XKMC + "</td>");
                       Response.Write("	<td >" + xks[i].XKFZR + "</td>");
                       Response.Write("	<td >" + xks[i].XYMC + "</td>");
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
            singleSelect: true,
        });
    });
</script>
</body>
</html>