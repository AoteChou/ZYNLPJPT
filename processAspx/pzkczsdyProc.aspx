<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzkczsdyProc.aspx.cs" Inherits="ZYNLPJPT.processAspx.pzkczsdyProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置课程知识单元</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(kcbh) {
            var zslybh = [];
            var zsdybh = [];
            var rows = $('#mytable').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                zslybh[i] = row.zslybh;
                zsdybh[i] = row.zsdybh;
            }

            if (zslybh.length > 0) {
                $.post("addKcZsdy.aspx", { 'zslybh': zslybh, 'zsdybh': zsdybh, 'kcbh': kcbh }, function (result) {
                        if (result == 'False') {
                            $.messager.alert('警告', '配置失败，请选择至少一项');
                        } else if (result == 'True') {
                            $.messager.alert('信息', '知识单元指标配置成功!', 'info', function () {
                                window.location = "../pzkczsdy.aspx";
                            });
                        }
                    });
                } else {
                    $.messager.alert('警告', '选择的指标至少为一项，请选择!');
                }

            }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">

    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=kcbh %>)">提交修改</a>
        </div>
    </div>

    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50">否与该知识单元关联</th>
                <th data-options="field:'zslybh'" width="12">知识领域编号</th>
                <th data-options="field:'zslymc',align:'center'" width="50">知识领域名称</th>
                <th data-options="field:'zsdybh'" width="12">知识单元编号</th>
                <th data-options="field:'zsdymc',align:'center'" width="50">知识单元名称</th>
                <th data-options="field:'zsdybz'" width="80">知识单元备注</th>
    		</tr>
    	</thead>
   		<tbody >
               <%
                   for (int i = 0; i < this.zsnlViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td></td>");
                       Response.Write("	<td >" + zsnlViews[i].ZSLYBH+ "</td>");
                       Response.Write("	<td >" + zsnlViews[i].ZSLYMC + "</td>");
                       Response.Write("  <td >" + zsnlViews[i].ZSDYBH + "</td>");
                       Response.Write("  <td >" + zsnlViews[i].ZSDYMC + "</td>");
                       Response.Write("	<td >" + zsnlViews[i].BZ+ "</td>");
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
                    singleSelect: false,
                });
            });
        </script>
    </form>
</body>
</html>
