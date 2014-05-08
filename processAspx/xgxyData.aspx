<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgxyData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgxyData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>修改学院信息</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改学院信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>学院名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" value="<%=xymc %>" id="xyMc" name="xyMc" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=xybh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(xybh) {

            if ($('#xyMc').attr('value') == undefined || $('#xyMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写学院名称！', 'info');
            } else {
            $.post("xgXyProc.aspx", {'xybh':xybh, 'xyMc': $('#xyMc').attr('value') }, function (data) {
                if (data == 'True') {
                    $('#ff').form('clear');
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgxy.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败，已经存在该学院名称！', 'info');
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgxy.aspx";
        }
    </script>
</body>
</html>
