<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckjsgt.aspx.cs" Inherits="ZYNLPJPT.ckjsgt" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看阶段课程改题人</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="north" border="true" style="height:40px;">
<form action="ckjsgt.aspx" method="post">
    <div id="content" name="content" style="padding:10px 10px 10px 400px">
        <label for="choosedNjName" style="width:200px;">选择需要查看改题人的年级:</label>
        <select  id="choosedNjName" name="choosedNjName" style="width:200px;"   onchange="return submit()" >
            <% for (int i = 0; i < this.allNjNames.Length; i++) {
                   Response.Write("<option>"+allNjNames[i].ToString().Trim()+"</option>");
               } %>
        </select>
    </div>
    </form>
</div>
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看改题人" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
 </div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'jdbh'" width="11">阶段编号</th>
                <th data-options="field:'jdmc',align:'center'" width="50">阶段名称</th>
                 <th data-options="field:'kcbh'" width="11">课程编号</th>
                <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                <th data-options="field:'zybh'" width="11">专业编号</th>
                <th data-options="field:'zymc',align:'center'" width="50">专业名称</th>
                <th data-options="field:'kcxzmc',align:'center'" width="20">课程性质</th>
                <th data-options="field:'button',align:'center'" width="30">查看改题人</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.jdkcViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" +jdkcViews[i].JDBH + "</td>");
                       Response.Write("	<td >" +jdkcViews[i].JDMC + "</td>");
                       Response.Write("  <td >" +jdkcViews[i].KCBH + "</td>");
                       Response.Write("	<td >" + jdkcViews[i].KCMC + "</td>");
                       Response.Write("	<td >" + jdkcViews[i].ZYBH + "</td>");
                       Response.Write("	<td >" + jdkcViews[i].ZYM + "</td>");
                       Response.Write("	<td >" + jdkcViews[i].KCXZMC + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/ckjdkcxsData.aspx?njbh=" + this.jdkcViews[i].NJBH +"&jdbh="+this.jdkcViews[i].JDBH+"&kcbh="+jdkcViews[i].KCBH+"&zybh="+jdkcViews[i].ZYBH+"&xkbh="+jdkcViews[i].XKBH+ "'\" >查看改题人</a></td>");
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
