﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addKCXZ.aspx.cs" Inherits="ZYNLPJPT.addKCXZ" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加课程性质</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body style=" background: black;">
    <table id="dg" title="添加课程性质" class="easyui-datagrid" style=" width:700px; height:250px"
            toolbar="#toolbar"
            rownumbers="true" fitColumns="true" singleSelect="true"  fit="true">
            <thead>
                <tr>
                   <th field="kcxzbh" width="150">课程性质编号</th>
                   <th field="kcxzmc" width="150">课程性质名称</th>
                </tr>
                <tbody>
                    
                    <%for (int i = 0; i < kcxzmc.Length; i++) {

                          Response.Write("<tr> <td>" + kcxzbh[i] + "</td><td>" + kcxzmc[i] + "</td></tr>");

                    
                          }
                        
                        
                         %>
                        
                    
                </tbody>
            </thead>
        </table>
         <div id="toolbar">
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-add" plain="true" onclick="add()">添加</a>
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-edit" plain="true" onclick="edit()">编辑</a>
        <!-- <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-remove" plain="true" onclick="destroy()">删除</a>-->
         </div>  
         <div id="dlg" class="easyui-dialog" style="width:400px;height:280px;padding:10px 20px"
            closed="true" buttons="#dlg-buttons">
        
        <form id="fm" method="post" >
            
            <div class="fitem">
                <label>课程性质名称:</label>
                <input name="kcxzmc" id="kcxzmc" class="easyui-validatebox" required="true"/>
           </div>  
        </form>
        </div>
       
               
        <div id="dlg-buttons">
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-ok" onclick="save()">保存</a>
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-cancel" onclick="clearForm()">退出</a>
        </div>
        
         <div id="dlg2" class="easyui-dialog" style="width:400px;height:280px;padding:10px 20px"
            closed="true" buttons="#dlg-buttons2">
        
        <form id="fm2" method="post" >
            
            
                <label>课程性质编号:</label>
                <input name="kcxzbh" id="kcxzbh" disabled="disabled" class="easyui-validatebox" required="true"/><br/>
                <label>课程性质名称:</label>
                <input name="kcxzmc2" id="kcxzmc2" class="easyui-validatebox" required="true"/>
          
        </form>
        </div>
       
               
        <div id="dlg-buttons2">
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-ok" onclick="save_edit()">保存</a>
        <a href="javascript:void(0)" class="easyui-linkbutton" iconCls="icon-cancel" onclick="clearForm_edit()">退出</a>
        </div>
       
        
        
    <script type="text/javascript">
        
        function add() {
            $('#dlg').dialog('open').dialog('setTitle', '添加');
            $('#fm').form('clear');
          
        }
        function edit() {
            var row = $('#dg').datagrid('getSelected');
            if (row) {
                $('#dlg2').dialog('open').dialog('setTitle', '编辑');
                $('#kcxzbh').attr('value', row.kcxzbh);
                $('#kcxzmc2').attr('value', row.kcxzmc);
               
            } else {
                $.messager.alert('提示', '请选中编辑项！', 'info');
            }
        }
        function save() {
            if ($('#kcxzmc').attr('value') == undefined || $('#kcxzmc').attr('value') == "") {
                $.messager.alert('结果', '必须填写课程性质名称！', 'info');
            } else {
            $.post("processAspx/addKcxzproc.aspx", { 'kcxzmc': $('#kcxzmc').attr('value') }, function (data) {
                if (data == 'True') {
                    document.getElementById('kcxzmc').value = '';
                    $.messager.alert('结果', '保存成功！', 'info');
                    $('#dlg').dialog('close');
                    $('#dg').datagrid('reload');
                    window.location.reload();
                } else if (data == 'False') {
                    document.getElementById('kcxzmc').value = '';
                    $.messager.alert('结果', '保存失败！', 'info');
                }
            });
        }
        
    }
    function save_edit() {

        if ($('#kcxzmc2').attr('value') == undefined || $('#kcxzmc2').attr('value') == "") {
            $.messager.alert('结果', '必须填写课程性质名称！', 'info');
        } else {
            $.post("processAspx/updateKcxz.aspx", { 'kcxzmc2': $('#kcxzmc2').attr('value'), 'kcxzbh': $('#kcxzbh').attr('value') }, function (data) {
                if (data == 'True') {
                    document.getElementById('kcxzmc2').value = '';
                    $.messager.alert('结果', '修改成功！', 'info');
                    $('#dlg2').dialog('close');
                    $('#dg').datagrid('reload');
                    window.location.reload();
                } else if (data == 'False') {
                    document.getElementById('kcxzmc2').value = '';
                    $.messager.alert('结果', '修改失败！', 'info');
                }
            });
        }



    }
    function clearForm_edit() {
        $('#dlg2').dialog('close');        // close the dialog
        $('#dg').datagrid('reload');    // reload the user data
    }
    function clearForm() {
        $('#dlg').dialog('close');        // close the dialog
        $('#dg').datagrid('reload');    // reload the user data
    }

        function destroy() {
            var row = $('#dg').datagrid('getSelected');
            if (row) {
                $.messager.confirm('Confirm', '你确定要删除这个项?', function (r) {
                    if (r) {
                        $.post('destroy_user.php', { id: row.id }, function (result) {
                            if (result.success) {
                                $('#dg').datagrid('reload');    // reload the user data
                            } else {
                                $.messager.show({    // show error message
                                    title: 'Error',
                                    msg: result.errorMsg
                                });
                            }
                        }, 'json');
                    }
                });
            }
        }
        
    </script>
    <style type="text/css">
        #fm{
            margin:0;
            padding:10px 30px;
        }
        ftitle{
            font-size:14px;
            font-weight:bold;
            padding:5px 0;
            margin-bottom:10px;
            border-bottom:1px solid #ccc;
        }
        fitem{
            margin-bottom:5px;
        }
        fitem label{
            display:inline-block;
            width:80px;
        }
    </style>
</body>
</html>
