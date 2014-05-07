<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cpjdData.aspx.cs" Inherits="ZYNLPJPT.processAspx.cpjdData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>配置阶段课程</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(jdbh, zybh, njbh) {
            var kcbh = [];
            var rows = $('#mytable').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                kcbh[i] = row.kcbh;
            }
            $.post("addJdKc.aspx", { 'kcbhs': kcbh, 'jdbh': jdbh, 'zybh': zybh,'njbh':njbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '必须选择至少一门课程,请选择要配置的课程!');
                } else if(result=='True'){
                    $.messager.alert('信息', '阶段课程配置成功!', 'info', function () {
                        window.location = "../pzjdkc.aspx";
                    });
                }
            });
        }
        function returnToUpPage() {
            window.location = "../pzjdkc.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=jdbh %>,<%=zybh %>,<%=njbh %>)">提交修改</a>
        </div>
    </div>
    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50"> 是否为阶段课程</th>
                <th data-options="field:'kcbh'" width="12"><span class="easyui-tooltip" title="<%=tips %>" >课程编号</span> </th>
                 <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                 <th data-options="field:'sszy',align:'center'" width="55">所属专业</th>
                 <th data-options="field:'ssxk',align:'center'" width="55">所属学科</th>
                <th data-options="field:'kcxz'" width="50">课程性质</th>
                <th data-options="field:'llxf'" width="30">理论学分</th>
                <th data-options="field:'sjxf'" width="30">实践学分</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.zykcViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td></td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCBH+ "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCMC + "</td>");
                       Response.Write("  <td >" +this.zykcViews[i].ZYM+ "</td>");
                       Response.Write("  <td >" + this.zykcViews[i].XKMC + "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCXZMC + "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].LLXF + "</td>");
                       Response.Write("	<td >" +this.zykcViews[i].SJXF + "</td>");
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
                 singleSelect: false,
                });
            });
        </script>
    </form>
</body>
</html>
