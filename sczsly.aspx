<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="sczsly.aspx.cs" Inherits="ZYNLPJPT.sczsly" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>删除知识领域</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="删除知识领域" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'zslybh',align:'center'" width="8">知识领域编号</th>
    			<th data-options="field:'zslymc',align:'center'" width="15">知识领域名称</th>
                <th data-options="field:'zslybz'" width="50">知识领域备注</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
                <th data-options="field:'button',align:'center'" width="30">删除知识领域</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.zslyDetails.Length; i++)
                   {
                       Response.Write("<tr>");
                       Response.Write("	<td >" + zslyDetails[i].Zsly.ZSLYBH + "</td>");
                       Response.Write("	<td >" + zslyDetails[i].Zsly.ZSLYMC + "</td>");
                       Response.Write("	<td >" + zslyDetails[i].Zsly.BZ + "</td>");
                       Response.Write("  <td >" +zslyDetails[i].XkName + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteZsly(" + this.zslyDetails[i].Zsly.ZSLYBH + "," + zslyDetails[i].Zsly.XKBH + ")\" >删除知识领域</a></td>");
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
            singleSelect: true,
        });
    });

    function deleteZsly(zslybh, xkbh) {
            $.post("processAspx/scZslyProc.aspx", { 'zslybh': zslybh, 'xkbh': xkbh}, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,该知识领域已被使用!', 'info', function () {
                        //window.location.reload();
                    });
                } else if (result == 'True') {
                    window.location="sczsly.aspx";
                }
            });
        }
</script>
</body>
</html>