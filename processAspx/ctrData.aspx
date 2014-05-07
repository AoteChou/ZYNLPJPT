<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ctrData.aspx.cs" Inherits="ZYNLPJPT.processAspx.ctrData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置出题人</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(kcbh,zybh) {
            var ss = [];
            var rows = $('#mytable').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                ss[i] = row.yhbh;
            }
            $.post("addCtr.aspx", { 'teaIds': ss, 'kcbh': kcbh, 'zybh': zybh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '必须选择至少一位教师,请选择要配置的教师名!');
                } else if(result=='True') {
                    $.messager.alert('信息', '出题人配置成功!', 'info', function () {
                        window.location = "../pzctr.aspx";
                    });
                }
            });
        }
        function returnToUpPage() {
            window.location = "../pzctr.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=kcbh %>,<%=zybh %>)">提交修改</a>
        </div>
    </div>

    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50"> 是否为出题人</th>
                <th data-options="field:'yhbh'" width="50"><span class="easyui-tooltip" title="<%=tips %>" >教师编号</span> </th>
                 <th data-options="field:'xm'" width="50">姓名</th>
                 <th data-options="field:'xb'" width="50">性别</th>
                <th data-options="field:'sfsxkfzr'" width="50">是否是学科负责人</th>
                <th data-options="field:'sfskcfzr'" width="50">是否是课程负责人</th>
                <th data-options="field:'ssxk'" width="30">所属学科</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.jsRoleYhView.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td>true</td>");
                       Response.Write("	<td >" + jsRoleYhView[i].YHBH+ "</td>");
                       Response.Write("	<td >" + jsRoleYhView[i].XM + "</td>");
                       Response.Write("  <td >" + (jsRoleYhView[i].XB == true ? "男" : "女") + "</td>");
                       Response.Write("  <td >" + (jsRoleYhView[i].SFSXKFZR==true?"是":"否") + "</td>");
                       Response.Write("	<td >" + (jsRoleYhView[i].SFSKCFZR==true?"是":"否") + "</td>");
                       Response.Write("	<td >" +jsRoleYhView[i].XKMC  + "</td>");
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
