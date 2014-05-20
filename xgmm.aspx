<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgmm.aspx.cs" Inherits="ZYNLPJPT.xgmm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改密码</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">  
  <div data-options="region:'center',border:false">
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改密码" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>用户编号:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="yhbh" disabled="disabled" value="<%=yhbh %>" name="yhbh" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>原始密码:</td>
                    <td><input class="easyui-validatebox textbox" type="password" id="oldPassword" name="oldPassword" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>新密码:</td>
                    <td><input class="easyui-validatebox textbox" type="password" id="newPassword" name="newPassword" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()">取消</a>
        </div>
        </div>    
    </div>
    </div>
    </div>
    <script type="text/javascript">
        function submitForm() {

            if ($('#oldPassword').attr('value') == undefined || $('#oldPassword').attr('value') == '' || $('#newPassword').attr('value') == undefined || $('#newPassword').attr('value') == '') {
                $.messager.alert('结果', '必须填写原始密码和新密码！', 'info');
            } else {
            $.post("processAspx/addMmProc.aspx", { 'yhbh': $('#yhbh').attr('value'), 'oldPassword': $('#oldPassword').attr('value'), 'newPassword': $('#newPassword').attr('value') }, function (data) {
                if (data == 'True') {
                    clearForm();
                    $.messager.alert('结果', '修改成功！', 'info');
                } else if (data == 'False') {
                    clearForm();
                    $.messager.alert('结果', '修改失败，原始密码错误！', 'info');
                }
            });
            }
        }
        function clearForm() {
            document.getElementById('oldPassword').value = '';
            document.getElementById('newPassword').value = '';
        }
    </script>
</body>
</html>
