<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgzslyData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgzslyData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改知识领域</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">  
  <div data-options="region:'center',border:false">
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改知识领域" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>知识领域名称:</td>
                    <td><input class="easyui-validatebox textbox" value="<%=zslymc %>" type="text" id="zslyMc" name="zslyMc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>知识领域简介:</td>
                    <td><textarea rows="4" id="zslyJj" name="zslyJj" cols="1" style="width:152px;"><%=bz %></textarea></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=xkbh %>,<%=zslybh %>)">提交</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(xkbh,zslybh) {

            if ($('#zslyMc').attr('value') == undefined || $('#zslyMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写知识领域名称！', 'info');
            } else {
            $.post("xgZslyProc.aspx", { 'zslybh': zslybh, 'zslyMc': $('#zslyMc').attr('value'), 'zslyJj': $('#zslyJj').attr('value'), 'xkbh': xkbh }, function (data) {
                if (data == 'True') {
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgzsly.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败，不能插入相同的知识领域名称!', 'info', function () {
                        //do nothing
                    });
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgzsly.aspx";
        }
    </script>
</body>
</html>