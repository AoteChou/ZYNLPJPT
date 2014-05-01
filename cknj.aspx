<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cknj.aspx.cs" Inherits="ZYNLPJPT.cknj" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看年级信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看年级信息" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'xybh'" width="50">年级编号</th>
                <th data-options="field:'xymc'" width="50">年级名称</th>
                <th data-options="field:'rxnf'" width="50">入学年份</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.njs.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + njs[i].NJBH + "</td>");
                       Response.Write("	<td >" + njs[i].NJMC + "</td>");
                       Response.Write("	<td >" + njs[i].RXNF.ToShortDateString() + "</td>");
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
