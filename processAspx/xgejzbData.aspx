<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgejzbData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgejzbData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改二级指标</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改二级指标" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>一级指标名称:</td>
                  <td><input class="easyui-validatebox textbox" type="text" disabled="disabled" id="yjzbName" value="<%=yjzbmc %>" name="yjzbName" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>二级指标名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="ejzbMc" value="<%=ejzbmc %>" name="ejzbMc" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=ejzbbh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(ejzbbh) {

            if ($('#ejzbMc').attr('value') == undefined || $('#ejzbMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写二级指标名称！', 'info');
            } else {
            $.post("xgEjzbProc.aspx", {'ejzbbh':ejzbbh,'ejzbMc': $('#ejzbMc').attr('value'), 'yjzbName': $('#yjzbName').attr('value') }, function (data) {
                if (data == 'True') {
                    $('#ff').form('clear');
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgejzb.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败,不能插入其他二级指标名称!', 'info', function () {
                        //do nothing
                    });
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgejzb.aspx";
        }
    </script>
</body>
</html>
