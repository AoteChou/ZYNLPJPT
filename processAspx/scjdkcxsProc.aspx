<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scjdkcxsProc.aspx.cs" Inherits="ZYNLPJPT.processAspx.scjdkcxsProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>删除单个改题人</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function deleteSingleGtr(xkbh, njbh, jdbh, kcbh, zybh, jsbh, xsbh) {
            $.post("DelSingleGtr.aspx", { 'xkbh': xkbh, 'njbh': njbh, 'zybh': zybh, 'jdbh': jdbh, 'kcbh': kcbh,'jsbh':jsbh,'xsbh':xsbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,请重新操作！', 'info', function () {
                        window.location.reload();
                    });
                } else if (result == 'True') {
                    window.location.reload();
                }
            });
        }
        function returnUpPage() {
            window.location = "../scjsgt.aspx";
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true" style=" overflow:hidden;" >
        <div style="padding-top:10px; padding-bottom:10px; text-align:center;" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnUpPage()">返回上页</a>
        </div>
    </div>
    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'jsbh',align:'center'" width="20">教师编号</th>
                 <th data-options="field:'jsxm',align:'center'" width="50">教师姓名</th>
                 <th data-options="field:'xsbh',align:'center'" width="40">学生编号</th>
                 <th data-options="field:'xsxm',align:'center'" width="40">学生姓名</th>
                <th data-options="field:'scButton',align:'center'" width="40">删除该改题人</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.jdkcxsNewViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + jdkcxsNewViews[i].JSBH+ "</td>");
                       Response.Write("	<td >" + jdkcxsNewViews[i].JSXM + "</td>");
                       Response.Write("  <td >" +jdkcxsNewViews[i].XSBH+ "</td>");
                       Response.Write("  <td >" + jdkcxsNewViews[i].XSXM + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteSingleGtr(" + xkbh + "," + njbh + "," + jdbh + "," + kcbh + "," + zybh + ",'" + jdkcxsNewViews[i].JSBH + "','" + jdkcxsNewViews[i].XSBH + "') \" >删除该改题人</a></td>");
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