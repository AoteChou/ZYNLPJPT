<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzEjzbProc.aspx.cs" Inherits="ZYNLPJPT.processAspx.pzEjzbProc" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置专业二级指标</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(zybh) {
            var flag = true;
            var ejzbbh = [];
            var nlzbz = [];
            var rows = $('#mytable').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                ejzbbh[i] = row.ejzbbh;
                nlzbz[i] = row.nlzbz;
                if (nlzbz < 0) {
                    $.messager.alert('警告', '选择项的指标值不能小于零，请修改!');
                    flag = false;
                    break;
                }
            }
            if (flag) {
                if (ejzbbh.length > 0) {
                    $.post("addZyEjzb.aspx", { 'ejzbbh': ejzbbh,'nlzbz':nlzbz,'zybh': zybh }, function (result) {
                        if (result == 'False') {
                            $.messager.alert('警告', '配置失败，请检查是否存在指标值小于零的行存在');
                        } else if(result=='True'){
                            $.messager.confirm('信息', '专业能力指标配置成功，单击确认返回上层界面，取消则停留在本界面!', function (r) {
                                if (r) {
                                    history.back(-1);
                                } else {
                                    //do nothing
                                }
                            });
                        }
                    });
                } else {
                    $.messager.alert('警告', '选择的指标至少为一项，请选择!');
                }
               
            }

        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">

    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=zybh %>)">提交修改</a>
        </div>
    </div>

    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50"> 此指标与该课程是否关联</th>
                <th data-options="field:'yjzbbh'" width="10">一级指标编号</th>
                <th data-options="field:'yjzbmc'" width="50">一级指标名称</th>
                <th data-options="field:'ejzbbh'" width="10">二级指标编号</th>
                <th data-options="field:'ejzbmc'" width="50">二级指标名称</th>
                <th data-options="field:'nlzbz',editor:'numberbox'" width="30">指标在该专业要求值(单击修改)</th>
    		</tr>
    	</thead>
   		<tbody >
               <%
                   for (int i = 0; i < this.nlzbViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td><</td>");
                       Response.Write("	<td >" + nlzbViews[i].YJZBBH+ "</td>");
                       Response.Write("	<td >" + nlzbViews[i].YJZBMC + "</td>");
                       Response.Write("  <td >" + nlzbViews[i].EJZBBH + "</td>");
                       Response.Write("  <td >" + nlzbViews[i].EJZBMC + "</td>");
                       Response.Write("	<td >" + 5 + "</td>");
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
                 onClickCell: onClickCell
                });
         });

         $.extend($.fn.datagrid.methods, {
             editCell: function (jq, param) {
                 return jq.each(function () {
                     var opts = $(this).datagrid('options');
                     var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
                     for (var i = 0; i < fields.length; i++) {
                         var col = $(this).datagrid('getColumnOption', fields[i]);
                         col.editor1 = col.editor;
                         if (fields[i] != param.field) {
                             col.editor = null;
                         }
                     }
                     $(this).datagrid('beginEdit', param.index);
                     for (var i = 0; i < fields.length; i++) {
                         var col = $(this).datagrid('getColumnOption', fields[i]);
                         col.editor = col.editor1;
                     }
                 });
             }
         });

         var editIndex = undefined;
         function endEditing() {
             if (editIndex == undefined) { return true }
             if ($('#mytable').datagrid('validateRow', editIndex)) {
                 $('#mytable').datagrid('endEdit', editIndex);
                 editIndex = undefined;
                 return true;
             } else {
                 return false;
             }
         }
         function onClickCell(index, field) {
             if (endEditing()) {
                 $('#mytable').datagrid('selectRow', index).datagrid('editCell', { index: index, field: field });
                 editIndex = index;
             }
         }
        </script>
    </form>
</body>
</html>
