<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addbj.aspx.cs" Inherits="ZYNLPJPT.addbj" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>添加班级信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加班级信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>年级名称:</td>
                    <td> 
                        <select id="njName" name="njName" style="width:152px;" >
                            <% for (int i = 0; i < njNames.Length; i++)
                               {
                                   Response.Write("<option> " + this.njNames[i] + "</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>所属学院:</td>
                    <td> 
                        <select id="xyName" name="xyName" style="width:152px;" onchange="chooseXy()"  >
                            <% for (int i = 0; i < this.xyNames.Length; i++) {
                                   Response.Write("<option> "+this.xyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>所属学科:</td>
                    <td>
                        <select id="xkName" name="xkName" style="width:152px;" onchange="chooseXk()" >
                            <% for (int i = 0; i < this.xkNames.Length; i++) {
                                   Response.Write("<option> "+this.xkNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>所属专业:</td>
                    <td>
                        <select id="zyName" name="zyName" style="width:152px;">
                            <% for (int i = 0; i < this.zyNames.Length; i++) {
                                   Response.Write("<option> "+this.zyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>班级名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="BjMc" name="BjMc" data-options="required:true"></input></td>
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

        function chooseXy() {
            $.post("processAspx/changeXkProc.aspx", { 'xyName': $('#xyName').attr('value') }, function (result) {
                if (result == 'False') {
                   
                } else {
                    $('#xkName').html(result);
                    chooseXk();
                }
            });
        }

        function chooseXk() {
            $.post("processAspx/changeZyProc.aspx", { 'xyName': $('#xyName').attr('value'), 'xkName': $('#xkName').attr('value') }, function (result) {
                if (result == 'False') {
                    $('#zyName').html('');
                } else {
                    $('#zyName').html(result);
                }
            });
        }

        function submitForm() {
            if ($('#njName').attr('value') == undefined || $('#njName').attr('value') == '' || $('#BjMc').attr('value') == undefined || $('#BjMc').attr('value') == ''  || $('#xyName').attr('value') == undefined || $('#xyName').attr('value') == '' || $('#xkName').attr('value') == undefined || $('#xkName').attr('value') == '' || $('#zyName').attr('value') == undefined || $('#zyName').attr('value') == '') {
                $.messager.alert('结果', '所有信息必须填写，不能为空！', 'info');
            } else {
                $.post("processAspx/addBjProc.aspx", { 'njName': $('#njName').attr('value'), 'BjMc': $('#BjMc').attr('value'), 'xyName': $('#xyName').attr('value'), 'xkName': $('#xkName').attr('value'), 'zyName': $('#zyName').attr('value') }, function (data) {
                    if (data == 'True') {
                        document.getElementById('BjMc').value = '';
                        $.messager.alert('结果', '添加成功！', 'info');
                    } else if (data == 'False') {
                        document.getElementById('BjMc').value = '';
                        $.messager.alert('结果', '添加失败，班级名称不能为空或者存在该班级信息！', 'info');
                    }
                });
            }
        }
        function clearForm() {
            document.getElementById('BjMc').value = '';
        }
    </script>
</body>
</html>
