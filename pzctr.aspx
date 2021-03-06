﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzctr.aspx.cs" Inherits="ZYNLPJPT.ct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>配置课程出题人</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="north" border="true" style="height:40px; overflow:hidden;">
<form action="pzctr.aspx" method="post">
    <div id="content" name="content" style="padding-top:10px; text-align:center;">
        <label for="choosedMajor" style="width:200px;">选择需要配置出题人的专业:</label>
        <select  id="choosedMajor" name="choosedMajor" style="width:200px;"   onchange="return submit()" >
            <% for (int i = 0; i < this.allZyms.Length; i++) {
                   Response.Write("<option>"+allZyms[i].ToString().Trim()+"</option>");
               } %>
        </select>
    </div>
    </form>
</div>
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="配置课程出题人" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
 </div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'kcmc'" width="50">课程名称</th>
                <th data-options="field:'zym'" width="50">所属专业</th>
                 <th data-options="field:'xkmc'" width="50">所属学科</th>
                <th data-options="field:'kcxzmc'" width="35">课程性质</th>
                <th data-options="field:'zyfzr'" width="50">专业负责人</th>
                <th data-options="field:'button'" width="45">配置出题人</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.zykcViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + zykcViews[i].KCMC + "</td>");
                       Response.Write("	<td >" + zykcViews[i].ZYM + "</td>");
                       Response.Write("  <td >" + zykcViews[i].XKMC + "</td>");
                       Response.Write("	<td >" + zykcViews[i].KCXZMC + "</td>");
                       Response.Write("	<td >" + zykcViews[i].ZYFZR + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/ctrData.aspx?kcbh=" + zykcViews[i].KCBH+"&zybh="+zykcViews[i].ZYBH+"&xkbh="+zykcViews[i].XKBH +"&kcmc="+ zykcViews[i].KCMC.Trim()+"&zym="+zykcViews[i].ZYM+"&xkmc=" +zykcViews[i].XKMC + "'\" >配置出题人</a></td>");
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
