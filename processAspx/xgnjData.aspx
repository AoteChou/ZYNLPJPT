<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgnjData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgnjData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>修改年级信息</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改年级信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>年级名称:</td>
                    <td><input class="easyui-validatebox textbox" value="<%=njmc %>" type="text" id="njMc" name="njMc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>年级入学年份:</td>
                    <td><input class="easyui-datebox"  type="text"  id="rxnf" value="<%=rxnf %>" name="rxnf" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=njbh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    <script type="text/javascript">

     
        function submitForm(njbh) {

            if ($('#njMc').attr('value') == undefined || $('#njMc').attr('value') == '' || $('#rxnf').datetimebox('getValue') == undefined || $('#rxnf').datetimebox('getValue') == '') {
                $.messager.alert('结果', '所有字段必须填写！', 'info');
            } else {
            $.post("xgNjProc.aspx", { 'njbh':njbh,'njMc': $('#njMc').attr('value'), 'rxnf': $('#rxnf').datetimebox('getValue') }, function (data) {
                if (data == 'True') {
                    $('#ff').form('clear');
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgnj.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败，已经存在该年级信息或者年份格式出错，请检查！', 'info');
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgnj.aspx";
        }
    </script>
</body>
</html>