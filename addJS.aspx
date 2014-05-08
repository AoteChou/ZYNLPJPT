<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addJS.aspx.cs" Inherits="ZYNLPJPT.addJS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>新增角色</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加角色" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>新增角色名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="jsMc" name="jsMc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>新增角色简介:</td>
                    <td><textarea rows="4" id="yjzbJj" name="yjzbJj" cols="1" style="width:152px;"></textarea></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()">提交</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()">取消</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">
        function submitForm() {

            if ($('#jsMc').attr('value') == undefined || $('#jsMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写角色名称！', 'info');
            } else {
            $.post("processAspx/addJSProc.aspx", { 'jsMc': $('#jsMc').attr('value') }, function (data) {
                if (data == 'False') {
                    $.messager.alert('结果', '添加失败！角色名不能为空！', 'info');

                } else {
                    $.messager.alert('结果', '添加成功！', 'info');
                    window.location.href = 'xgjs.aspx';

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
