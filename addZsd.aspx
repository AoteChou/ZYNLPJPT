<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addZsd.aspx.cs" Inherits="ZYNLPJPT.addZsd" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加知识点</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
 <div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加知识点" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="4" >
                <tr style=" margin-top:10px;">
                    <td>所属知识领域:</td>
                    <td> 
                        <select id="zslyName" name="zslyName" style="width:152px;" onchange="chooseZsdy(<%=xkbh %>)"  >
                            <% for (int i = 0; i < this.zslyNames.Length; i++) {
                                   Response.Write("<option> "+this.zslyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr>
                    <td>所属知识单元:</td>
                    <td>
                        <select id="zsdyName" name="zsdyName" style="width:152px;" onclick="return zsdyName_onclick()">
                            <% for (int i = 0; i < this.zsdyNames.Length; i++) {
                                   Response.Write("<option> "+this.zsdyNames[i]+"</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>知识点名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="zsdMc" name="zsdMc" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>知识点权重值:</td>
                    <td><input class="easyui-numberbox" type="text" id="sZsdQz" name="sZsdQz" data-options="required:true,min:0"></input></td>
                </tr>
                <tr>
                    <td>知识单元备注：</td>
                    <td><textarea rows="4" cols="1" id="zsdBz" name="zsdBz" style= "width:152px;" ></textarea></td>
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

        function chooseZsdy(xkbh) {
            $.post("processAspx/changeZsdyProc.aspx", { 'xkbh': xkbh, 'zslyName': $('#zslyName').attr('value') }, function (result) {
                if (result == 'False') {
                    //do nothing
                } else {
                    $('#zsdyName').html(result);
                 }
           });
        }
       
        function submitForm() {

            if ($('#zsdMc').attr('value') == undefined || $('#zsdMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写知识点名称！', 'info');
            } else {
                $.post("processAspx/addZsdProc.aspx", { 'sZsdQz': $('#sZsdQz').attr('value'), 'zsdMc': $('#zsdMc').attr('value'), 'zslyName': $('#zslyName').attr('value'), 'zsdyName': $('#zsdyName').attr('value'), 'zsdBz': $('#zsdBz').attr('value') }, function (data) {
                    if (data == 'True') {
                        document.getElementById('zsdMc').value = '';
                        document.getElementById('zsdBz').value = '';
                        $.messager.alert('结果', '添加成功！', 'info');

                    } else if (data == 'False') {
                        document.getElementById('zsdMc').value = '';
                        document.getElementById('zsdBz').value = '';
                        $.messager.alert('结果', '添加失败，知识点不能为空或者已经存在该知识点！', 'info');

                    }
                });
            }
        }
        function clearForm() {
            document.getElementById('zsdMc').value = '';
            document.getElementById('zsdBz').value = '';
        }
        function zsdyName_onclick() {

        }

    </script>
</body>
</html>