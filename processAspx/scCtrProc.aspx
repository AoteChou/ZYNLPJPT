<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scCtrProc.aspx.cs" Inherits="ZYNLPJPT.processAspx.scCtrProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除出题人</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function deleteSingleCtr(zybh, kcbh, yhbh) {
            $.post("DelSingleCtr.aspx", { 'zybh': zybh, 'kcbh':kcbh, 'yhbh': yhbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,请重试!', 'info', function () {
                        window.location.reload();
                    });
                } else if (result == 'True') {
                    window.location.reload();
                }
            });
        }
        function returnUpPage() {
            window.location = "../scctr.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnUpPage()">返回上页</a>
        </div>
    </div>

    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'yhbh'" width="50">教师编号</th>
                 <th data-options="field:'xm'" width="50">姓名</th>
                 <th data-options="field:'xb'" width="20">性别</th>
                <th data-options="field:'sfsxkfzr'" width="50">是否是学科负责人</th>
                <th data-options="field:'sfskcfzr'" width="50">是否是课程负责人</th>
                <th data-options="field:'ssxk'" width="30">所属学科</th>
                 <th data-options="field:'scButton',align:'center'" width="40">删除该出题人</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.jsRoleYhView.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + jsRoleYhView[i].YHBH+ "</td>");
                       Response.Write("	<td >" + jsRoleYhView[i].XM + "</td>");
                       Response.Write("  <td >" + (jsRoleYhView[i].XB == true ? "男" : "女") + "</td>");
                       Response.Write("  <td >" + (jsRoleYhView[i].SFSXKFZR==true?"是":"否") + "</td>");
                       Response.Write("	<td >" + (jsRoleYhView[i].SFSKCFZR==true?"是":"否") + "</td>");
                       Response.Write("	<td >" +jsRoleYhView[i].XKMC  + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteSingleCtr(" + zybh+ "," + kcbh + ",'" +jsRoleYhView[i].YHBH+ "') \" >删除该出题人</a></td>");
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