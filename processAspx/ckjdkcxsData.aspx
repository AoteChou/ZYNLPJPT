<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckjdkcxsData.aspx.cs" Inherits="ZYNLPJPT.processAspx.ckjdkcxsData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看改题人</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
         <div region="north" border="true"  >
            <div style="padding:10px 10px 10px 400px" >
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回上页</a>
                 <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">确认</a>
            </div>
        </div>
        <div region="center" border="false">
    	      <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
               
    			<th data-options="field:'kcmc',align:'center'" width="15">出题教师姓名</th>
                <th data-options="field:'zym',rowspan:4" width="70">所有批改学生姓名</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.teaAndStusWrappers.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.teaAndStusWrappers[i].TeaName.Trim() + "</td>");
                       Response.Write("	<td >" + this.teaAndStusWrappers[i].StuNames.Trim() + "</td>");
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
</form>
</body>
</html>