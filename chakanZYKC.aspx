<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chakanZYKC.aspx.cs" Inherits="ZYNLPJPT.chakanZYKC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看专业课程</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回</a>          
        </div>
    </div>
     <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                 <th data-options="field:'kcbh',align:'center'" width="12">课程编号 </th>
                 <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                 <th data-options="field:'ssxk',align:'center'" width="55">所属学科</th>
                 <th data-options="field:'kkxq',align:'center'" width="55">开课学期</th>             
                 <th data-options="field:'kcxz'" width="50">课程性质</th>     
                 <th data-options="field:'llxf'" width="30">理论学分</th>
                 <th data-options="field:'sjxf'" width="30">实践学分</th>
    		</tr>
            
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.kcbh.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + kcbh[i]+ "</td>");
                       Response.Write("	<td >" + kcmc[i] + "</td>");
                       Response.Write("  <td >" + ssxk[i] + "</td>");
                       Response.Write("	<td >第"+kkxq[i]+"学期</td>");
                       Response.Write("	<td >"+kcxzmc[i]+"</td>");                       
                       Response.Write("	<td >" +llxf[i] + "</td>");
                       Response.Write("	<td >" +sjxf[i]+ "</td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    </div>
    </form>
</body>
</html>
