<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgxkData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgxkData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>修改学科信息</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改学科信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>所属学院名称:</td>
                    <td><input class="easyui-validatebox textbox" value="<%=xymc %>"  disabled="disabled" type="text" id="xyName" name="xyName" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>学科名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="xkMc" value="<%=xkmc %>" name="xkMc" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=xkbh %>,<%=xybh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(xkbh,xybh) {
            if ($('#xkMc').attr('value') == undefined || $('#xkMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写学科名称！', 'info');
            } else {
            $.post("xgXkProc.aspx", { 'xkMc': $('#xkMc').attr('value'), 'xkbh':xkbh,'xybh':xybh }, function (data) {
                if (data == 'True') {
                    document.getElementById('xkMc').value = '';
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgxk.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败，该学院下已存在该学科信息！', 'info');
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgxk.aspx";
        }
    </script>
</body>
</html>