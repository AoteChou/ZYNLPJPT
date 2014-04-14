<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addcpjd.aspx.cs" Inherits="ZYNLPJPT.addcpjd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加测评阶段</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加测评阶段" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>年级名称:</td>
                    <td> 
                        <select id="njName" name="njName" style="width:152px;" >
                            <% for (int i = 0; i < this.njNames.Length; i++) {
                                   Response.Write("<option> "+this.njNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>专业名称:</td>
                    <td> 
                        <select id="zyName" name="zyName" style="width:152px;" >
                            <% for (int i = 0; i < this.zyms.Length; i++) {
                                   Response.Write("<option> "+this.zyms[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
               <tr style=" margin-top:10px;">
                    <td>阶段名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="jdMc" name="jdMc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>起始学期：</td>
                    <td>
                        <select id="qsxq" name="qsxq" style="width:152px;">
                            <% for (int i = 1; i<=12; i++) {
                                   Response.Write("<option> "+i+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>截止学期：</td>
                    <td>
                        <select id="jzxq" name="jzxq" style="width:152px;">
                            <% for (int i = 1; i<=12; i++) {
                                   Response.Write("<option> "+i+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>测评阶段简介:</td>
                    <td><textarea rows="4" id="cpjdJj" name="cpjdJj" cols="1" style="width:152px;"></textarea></td>
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
            var qsxq = $('#qsxq').attr('value');
            var jzxq = $('#jzxq').attr('value');
            if ($('#jdMc').attr('value') == undefined || $('#jdMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写阶段名称！', 'info');
            } else if (jzxq < qsxq) {
                $.messager.alert('结果', '起始学期不能大于截止学期，请重新选择！', 'info');
            }else {
                $.post("processAspx/addCpjdProc.aspx", { 'njName': $('#njName').attr('value'), 'zyName': $('#zyName').attr('value'), 'jdMc': $('#jdMc').attr('value'), 'qsxq': $('#qsxq').attr('value'), 'jzxq': $('#jzxq').attr('value'), 'cpjdJj': $('#cpjdJj').attr('value') }, function (data) {
                    if (data == 'True') {
                        document.getElementById('jdMc').value = '';
                        document.getElementById('cpjdJj').value = '';
                        $.messager.alert('结果', '添加成功！', 'info');

                    } else if (data == 'False') {
                        document.getElementById('jdMc').value = '';
                        document.getElementById('cpjdJj').value = '';
                        $.messager.alert('结果', '添加失败，阶段名称不能为空或者存在该阶段名称或者是截止学期小于起始学期！', 'info');

                    }
                });
            }
        }
        function clearForm() {
            document.getElementById('jdMc').value = '';
            document.getElementById('cpjdJj').value = '';
        }
    </script>
</body>
</html>
