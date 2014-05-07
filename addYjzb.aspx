<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addYjzb.aspx.cs" Inherits="ZYNLPJPT.addYjzb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>添加一级指标</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加一级指标" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>一级指标名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="yjzbMc" name="yjzbMc" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>一级指标权重值:</td>
                    <td><input class="easyui-numberbox" type="text" id="sYjzbqz" name="sYjzbqz" data-options="required:true,min:0"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>一级指标简介:</td>
                    <td><textarea rows="4" id="yjzbJj" name="yjzbJj" cols="1" style="width:152px;"></textarea></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=xkbh %>)">提交</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()">取消</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(data) {

            if ($('#yjzbMc').attr('value') == undefined || $('#yjzbMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写一级指标名称！', 'info');
            } else {
                $.post("processAspx/addYjzbProc.aspx", { 'yjzbMc': $('#yjzbMc').attr('value'), 'yjzbJj': $('#yjzbJj').attr('value'), 'sYjzbqz': $('#sYjzbqz').attr('value'), 'xkbh': data }, function (data) {
                    if (data == 'True') {
                        $('#ff').form('clear');
                        $.messager.alert('结果', '添加成功！', 'info');

                    } else if (data == 'False') {
                        $('#ff').form('clear');
                        $.messager.alert('结果', '添加失败，一级指标名称不能为空或者存在该一级指标名称！', 'info');
                    }
                });
            }
        }
        function clearForm() {
            $('#ff').form('clear');
        }
    </script>
</body>
</html>
