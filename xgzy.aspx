<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgzy.aspx.cs" Inherits="ZYNLPJPT.xgzy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改专业信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="north" border="true" style="height:40px;">
<form action="xgzy.aspx" method="post">
    <div id="content" name="content" style="padding:10px 10px 10px 400px">
        <label for="choosedXy" style="width:200px;">选择需要修改信息的学院:</label>
        <select  id="choosedXy" name="choosedXy" style="width:200px;"   onchange="return submit()" >
            <% for (int i = 0; i < this.allXyNames.Length; i++) {
                   Response.Write("<option>" + allXyNames[i].ToString().Trim() + "</option>");
               } %>
        </select>
    </div>
    </form>
</div>
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="修改专业信息" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
 </div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'zybh'" width="12">专业编号</th>
                <th data-options="field:'zymc',align:'center'" width="30">专业名称</th>
                 <th data-options="field:'zyfzr'" width="30">专业负责人</th>
                <th data-options="field:'xkbh',align:'center'" width="12">学科编号</th>
                <th data-options="field:'xkmc',align:'center'" width="40">学科名字</th>
                <th data-options="field:'xkfzr',align:'center'" width="30">学科负责人</th>
                <th data-options="field:'button',align:'center'" width="30">修改专业信息</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.xyXkZyViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.xyXkZyViews[i].ZYBH + "</td>");
                       Response.Write("	<td >" + this.xyXkZyViews[i].ZYM+ "</td>");
                       Response.Write("  <td >" +this.xyXkZyViews[i].ZYFZR + "</td>");
                       Response.Write("	<td >" + this.xyXkZyViews[i].XKBH+ "</td>");
                       Response.Write("	<td >" + this.xyXkZyViews[i].XKMC + "</td>");
                       Response.Write("	<td >" + this.xyXkZyViews[i].XKFZR+ "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/xgzyData.aspx?xybh=" + xyXkZyViews[i].XYBH + "&xymc=" + xyXkZyViews[i].XYMC + "&xkbh=" + xyXkZyViews[i].XKBH + "&xkmc=" + xyXkZyViews[i].XKMC + "&zybh=" + xyXkZyViews[i].ZYBH + "&zym=" + xyXkZyViews[i].ZYM + "'\" >修改专业信息</a></td>");
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
