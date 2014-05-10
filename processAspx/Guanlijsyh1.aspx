<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guanlijsyh1.aspx.cs" Inherits="ZYNLPJPT.processAspx.Guanlijsyh1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理教师用户</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function xiugai() { 
        }
    
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="Guanlijsyh1.aspx" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回</a>          
        </div>
    </div>
    <div region="center" border="false">
        <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                 <th data-options="field:'yhbh',align:'center'" width="30">用户编号 </th>
                 <th data-options="field:'mm',align:'center'" width="50">密码</th>
                 <th data-options="field:'xm',align:'center'" width="55">姓名</th>
                 <th data-options="field:'xb',align:'center'" width="50">性别</th>
                 <th data-options="field:'sfsxkfzr',align:'center'" width="55">是否是学科负责人</th>  
                 <th data-options="field:'sfskcfzr',align:'center'" width="55">是否是课程负责人</th>
                            
    		</tr>
            
    	</thead>
        <tbody >
              <%
                   for (int i = 0; i < this.yhbh.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + yhbh[i]+ "</td>");
                       Response.Write("	<td >" + mm[i] + "</td>");
                       Response.Write("  <td >" +xm[i] + "</td>");
                       Response.Write("	<td >"+xb[i]+"</td>");
                       Response.Write("	<td >"+sfsxkfzr[i]+"</td>");
                       Response.Write("	<td >" + sfskcfzr[i] + "</td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
    </div>
    </form>
</body>
</html>

