<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addzy.aspx.cs" Inherits="ZYNLPJPT.addzy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>添加专业信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
 <div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加专业信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="4" >
                <tr style=" margin-top:10px;">
                    <td>所属学院:</td>
                    <td> 
                        <select id="xyName" name="xyName" style="width:152px;" onchange="chooseXk()"  >
                            <% for (int i = 0; i < this.xyNames.Length; i++) {
                                   Response.Write("<option> "+this.xyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>所属学科:</td>
                    <td>
                        <select id="xkName" name="xkName" style="width:152px;">
                            <% for (int i = 0; i < this.xkNames.Length; i++) {
                                   Response.Write("<option> "+this.xkNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>专业名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="zyMc" name="zyMc" data-options="required:true"></input></td>
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

        function chooseXk() {
            $.post("processAspx/changeXkProc.aspx", { 'xyName': $('#xyName').attr('value') }, function (result) {
                if (result == 'False') {
                    //do nothing
                } else {
                    $('#xkName').html(result);
                }
            });
        }

        function submitForm() {

            if ($('#zyMc').attr('value') == undefined || $('#zyMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写专业名称！', 'info');
            } else {
                $.post("processAspx/addZyProc.aspx", { 'zyMc': $('#zyMc').attr('value'), 'xkName': $('#xkName').attr('value'), 'xyName': $('#xyName').attr('value')}, function (data) {
                    if (data == 'True') {
                        document.getElementById('zyMc').value = '';
                        $.messager.alert('结果', '添加成功！', 'info');

                    } else if (data == 'False') {
                        document.getElementById('zyMc').value = '';
                        $.messager.alert('结果', '添加失败，已经存在该专业名称!', 'info');

                    }
                });
            }
        }
        function clearForm() {
            document.getElementById('zyMc').value = '';
        }
    </script>
</body>
</html>