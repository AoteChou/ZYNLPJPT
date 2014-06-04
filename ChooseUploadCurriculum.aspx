﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseUploadCurriculum.aspx.cs" Inherits="ZYNLPJPT.ChooseUploadCurriculum" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选择上传试题的课程</title>
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>


<body class="easyui-layout">


<div region="center" border="false">
  <table id="mytable"   fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'kcmc'" width="50">课程名称</th>
                <th data-options="field:'kcxzmc'" width="50">课程性质</th>
                <th data-options="field:'jzxq'" width="50">截止学期</th>
                <th data-options="field:'ywcts'" width="50">已完成题数</th>
                <th data-options="field:'wwcts'" width="50">未完成题数</th>
    			<th data-options="field:'kcjj'" width="50">课程简介</th>
                <th data-options="field:'button',align:'center'" width="40"></th>
    			
    		</tr>
    	</thead>
   		<tbody >
           
    		
              <%
              for (int i = 0; i <this.jdkcxsviews.Length; i++)
              {
              Response.Write("<tr >");
              Response.Write("	<td >" + jdkcxsviews[i].KCMC  + "</td>");
    		  Response.Write("	<td >"+jdkcxsviews[i].KCXZMC+"</td>");
    		  Response.Write("	<td >"+jdkcxsviews[i].JZXQ+"</td>");
              int testNum_done = testNum[i] - testNum_undone[i];
              Response.Write("  <td >"+testNum_done+"</td>");
              Response.Write("  <td >" + testNum_undone[i] + "</td>");
              Response.Write("  <td >"+jdkcxsviews[i].KCJJ+"</td>");
              Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.parent.addTab('" + jdkcxsviews[i].KCMC + "-上传答案','UploadPage.aspx?kcbh=" + jdkcxsviews[i].KCBH + "')\" >上传答案</a></td>");
              Response.Write("</tr>");
                 
              } %>
               
          
            
            
    	</tbody>
   	</table>     
</div>                
<script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            //pagination: true,
            //data:[{code:'1',price:'2',name:'dd'}],
            //url:'data.json',
            singleSelect: true
        });
    });
</script>
</body>
</html>