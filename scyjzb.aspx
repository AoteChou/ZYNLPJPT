<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="scyjzb.aspx.cs" Inherits="ZYNLPJPT.scyjzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>删除一级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="删除一级指标" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'yjzbbh',align:'center'" width="8">一级指标编号</th>
    			<th data-options="field:'yjzbmc',align:'center'" width="15">一级指标名称</th>
                <th data-options="field:'yjzbqz',align:'center'" width="8">一级指标重值</th>
                <th data-options="field:'bz',align:'center'" width="8">一级指标备注</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
                <th data-options="field:'button',align:'center'" width="20">删除一级指标</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.yjzbWrappers.Length; i++)
                  {
                      Response.Write("<tr>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBBH + "</td>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBMC + "</td>");
                      Response.Write("	<td >" + yjzbWrappers[i].Yjzb.YJZBQZ+ "</td>");
                      Response.Write("  <td >" + yjzbWrappers[i].Yjzb.BZ+ "</td>");
                      Response.Write("  <td >" + yjzbWrappers[i].XkName + "</td>");
                      Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"deleteYjzb(" + yjzbWrappers[i].Yjzb.YJZBBH + "," + yjzbWrappers[i].Yjzb.XKBH + ")\" >删除一级指标</a></td>");
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

    function deleteYjzb(yjzbbh, xkbh) {
            $.post("processAspx/scYjzbProc.aspx", { 'yjzbbh': yjzbbh, 'xkbh': xkbh}, function (result) {
                if (result == 'False') {
                    $.messager.alert('信息', '删除失败,该一级指标已被使用!', 'info', function () {
                        //do thing
                    });
                } else if (result == 'True') {
                    window.location="scyjzb.aspx";
                }
            });
        }
</script>
</body>
</html>

