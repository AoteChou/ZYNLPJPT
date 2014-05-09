<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="zykcData.aspx.cs" Inherits="ZYNLPJPT.processAspx.zykcData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(zybh) {
            var flag = true;
            var kcbh = [];
            var kkxqbh=[];
            var kcxzbh=[];
            var llxf=[];
            var sjxf = [];
            var rows = $('#mytable').datagrid('getSelections');
            /*for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                console.log(row.kkxqbh);
            }*/
           
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                kcbh[i] = row.kcbh;
                kkxqbh[i] = row.kkxqbh;
                kcxzbh[i] = row.kcxzbh;
                llxf[i] = row.llxf;
                sjxf[i] = row.sjxf;
                if (llxf <= 0 || sjxf <= 0) {
                    $.messager.alert('警告', '理论学分和实际学分要大于零', '请修改');
                    flag = false;
                    break;
                } else if (kkxqbh == null || kkxqbh == "请点击设置" || kcxzbh == null || kcxzbh == "请点击设置") {
                    $.messager.alert('警告', '开课学期编号和课程性质编号不能为空', '请修改');
                    flag = false;
                    break;
                }
            }
            if (flag) {
                if (kcbh.length > 0) {
                    $.post("addZyKc.aspx", { 'kcbh': kcbh, 'zybh': zybh, 'kkxqbh': kkxqbh, 'kcxzbh': kcxzbh, 'llxf': llxf, 'sjxf': sjxf }, function (result) {
                        if (result == 'False') {
                            $.messager.alert('警告', '配置失败，请检查是否存在理论学分和实际学分小于零的或是开课学期编号和课程性质编号为空的行存在');
                        } else if(result=='True'){
                            $.messager.confirm('信息', '配置成功，单击确认返回上层界面，取消则停留在本界面!', function (r) {
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
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=zybh %>)">提交</a>
        </div>
    </div>
     <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true,onClickCell: onClickCell" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50">是否提交</th>
                 <th data-options="field:'kcbh',align:'center'" width="12">课程编号 </th>
                 <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                 <th data-options="field:'ssxk',align:'center'" width="55">所属学科</th>
                 <th data-options="field:'kkxqbh',align:'center', 
                        editor:{
                            type:'combobox',
                            options:{
                                valueField:'kkxqbh',
                                textField:'kkxq',
                                data:[
                                    {kkxqbh:'1',kkxq:'第一学期'},
                                    {kkxqbh:'2',kkxq:'第二学期'},
                                    {kkxqbh:'3',kkxq:'第三学期'},
                                    {kkxqbh:'4',kkxq:'第四学期'},
                                    {kkxqbh:'5',kkxq:'第五学期'},
                                    {kkxqbh:'6',kkxq:'第六学期'},
                                    {kkxqbh:'7',kkxq:'第七学期 '},
                                    {kkxqbh:'8',kkxq:'第八学期 '}
                                ],
                                required:true
                            }
                        }" width="55">开课学期编号</th>              
                 <th data-options="field:'kcxzbh',align:'center',
                        editor:{
                            type:'combobox',
                            options:{
                                valueField:'kcxzbh',
                                textField:'kcxz',
                                url:'getKCXZ.aspx',
                                required:true
                            }
                        }" width="50">课程性质编号</th>          
                <th data-options="field:'llxf',editor:{type:'numberbox',options:{precision:2}}" width="30">理论学分(单击修改)</th>
                <th data-options="field:'sjxf',editor:{type:'numberbox',options:{precision:2}}" width="30">实践学分(单击修改)</th>
    		</tr>
            
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.kcbh.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td ></td>");
                       Response.Write("	<td >" + kcbh[i]+ "</td>");
                       Response.Write("	<td >" + kcmc[i] + "</td>");
                       Response.Write("  <td >" + ssxk[i] + "</td>");
                       Response.Write("	<td >请点击设置</td>");
                       Response.Write("	<td >请点击设置</td>");                       
                       Response.Write("	<td >" +1.00  + "</td>");
                       Response.Write("	<td >" +1.00 + "</td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    </div>
    </form>
</body>
<script type="text/javascript"> 
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
            $('#mytable').datagrid('selectRow', index)
                        .datagrid('editCell', { index: index, field: field });
            editIndex = index;
        }
    }
</script>
</html>
