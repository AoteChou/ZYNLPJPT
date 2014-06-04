<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zsdyToEjzbData.aspx.cs" Inherits="ZYNLPJPT.processAspx.zsdyToEjzbData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置知识单元对应二级指标</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(zslybh, zsdybh) {

            var rows = $('#mytable').datagrid('getSelections');
            var ejzbbh;
            if (rows.length <= 0) {
                $.messager.alert('警告', '请选择至少一项!');
            } else {
                for (var i = 0; i < rows.length; i++) {
                    var row = rows[i];
                    ejzbbh = row.ejzbbh;
                }
                $.post("addZsdyToEjzbProc.aspx", { 'ejzbbh': ejzbbh, 'zslybh': zslybh, 'zsdybh': zsdybh }, function (result) {
                    if (result == 'False') {
                        $.messager.alert('警告', '知识单元对应二级指标配置失败!');
                    } else if (result == 'True') {
                        window.location = "../pzZsdyToEjzb.aspx";
                    }
                });
            }
        }
        function returnToUpPage() {
            window.location = "../pzZsdyToEjzb.aspx";
        }
    </script>
</head>
<body class="easyui-layout">     
<div region="north" border="true" style=" overflow:hidden;" >
            <div style="padding-top:10px; padding-bottom:10px; text-align:center;" >
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回上页</a>
                <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=zslybh %>,<%=zsdybh %>)">提交修改</a>
            </div>
        </div>    
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="配置知识单元对应二级指标" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
</div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'ck',checkbox:true" width="50">否与该二级指标关联</th>
                <th data-options="field:'yjzbbh',align:'center'" width="8">一级指标编号</th>
    			<th data-options="field:'yjzbmc',align:'center'" width="15">一级指标名称</th>
                <th data-options="field:'ejzbbh',align:'center'" width="8">二级指标编号</th>
    			<th data-options="field:'ejzbmc',align:'center'" width="15">二级指标名称</th>
                <th data-options="field:'xkmc',align:'center'" width="15">所属学科</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.nlzbViewWrappers.Length; i++)
                  {
                      Response.Write("<tr>");
                      Response.Write("<td></td>");
                      Response.Write("	<td >" + nlzbViewWrappers[i].NlzbView.YJZBBH + "</td>");
                      Response.Write("	<td >" + nlzbViewWrappers[i].NlzbView.YJZBMC + "</td>");
                      Response.Write("	<td >" + nlzbViewWrappers[i].NlzbView.EJZBBH + "</td>");
                      Response.Write("  <td >" + nlzbViewWrappers[i].NlzbView.EJZBMC + "</td>");
                      Response.Write("  <td >" + nlzbViewWrappers[i].Xkmc + "</td>");
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
</script>
</body>
</html>