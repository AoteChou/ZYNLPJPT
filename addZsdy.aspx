<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addZsdy.aspx.cs" Inherits="ZYNLPJPT.addZsdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加知识单元</title>
     <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加知识单元" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="4" >
                <tr style=" margin-top:10px;">
                    <td>知识领域名称:</td>
                    <td> 
                        <select id="zslyName" name="zslyName" style="width:152px;" >
                            <% for (int i = 0; i < this.zslyNames.Length; i++) {
                                   Response.Write("<option> "+this.zslyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>知识单元名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="zsdyMc" name="zsdyMc" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>知识单元权重值:</td>
                    <td><input class="easyui-numberbox" type="text" id="sZsdyQz" name="sZsdyQz" data-options="required:true,min:0"></input></td>
                </tr>
                <tr>
                    <td>知识单元备注：</td>
                    <td><textarea rows="4" cols="1" id="zsdyBz" name="zsdyBz" style= "width:152px;" ></textarea></td>
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

            if ($('#zsdyMc').attr('value') == undefined || $('#zsdyMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写知识单元名称！', 'info');
            } else {
                $.post("processAspx/addZsdyProc.aspx", { 'zsdyMc': $('#zsdyMc').attr('value'), 'zslyName': $('#zslyName').attr('value'), 'zsdyBz': $('#zsdyBz').attr('value'), 'sZsdyQz': $('#sZsdyQz').attr('value') }, function (data) {
                    if (data == 'True') {
                        document.getElementById('zsdyMc').value = '';
                        document.getElementById('zsdyBz').value = '';
                        $.messager.alert('结果', '添加成功！', 'info');

                    } else if (data == 'False') {
                        document.getElementById('zsdyMc').value = '';
                        document.getElementById('zsdyBz').value = '';
                        $.messager.alert('结果', '添加失败，知识单元不能为空或者已经存在该知识单元！', 'info');

                    }
                });
            }
        }
        function clearForm() {
            document.getElementById('zsdyMc').value = '';
            document.getElementById('zsdyBz').value = '';
        }
    </script>
</body>
</html>
