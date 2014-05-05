<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgzsdData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgzsdData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>修改知识点</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
 <div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改知识点" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="4" >
                <tr style=" margin-top:10px;">
                    <td>所属知识领域:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="zslyName" value="<%=zslymc %>" disabled="disabled" name="zslyName" data-options="required:true"></input></td>
                </tr>
                <tr>
                    <td>所属知识单元:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="zsdyName" value="<%=zsdymc %>" name="zsdyName" disabled="disabled" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>知识点名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" value="<%=zsdmc %>" id="zsdMc" name="zsdMc" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>知识点权重值:</td>
                    <td><input class="easyui-numberbox" type="text" id="sZsdQz" value="<%=zsdqz %>" name="sZsdQz" data-options="required:true,min:0"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=zsdbh %>,<%=zslybh %>,<%=zsdybh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">

        function submitForm(zsdbh,zslybh,zsdybh) {

            if ($('#zsdMc').attr('value') == undefined || $('#zsdMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写知识点名称！', 'info');
            } else {
            $.post("xgZsdProc.aspx", { 'zslybh': zslybh, 'zsdybh': zsdybh, 'zsdbh': zsdbh, 'sZsdQz': $('#sZsdQz').attr('value'), 'zsdMc': $('#zsdMc').attr('value') }, function (data) {
                if (data == 'True') {
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgzsd.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败！', 'info', function () {
                        window.location = "../xgzsd.aspx";
                     });
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgzsd.aspx";
        }
    </script>
</body>
</html>
