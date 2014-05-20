<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgzsdyData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgzsdyData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>修改知识单元</title>
     <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">  
  <div data-options="region:'center',border:false">
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改知识单元" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="4" >
                <tr style=" margin-top:10px;">
                    <td>知识领域名称:</td>
                    <td><input class="easyui-validatebox textbox" value="<%=zslymc %>" disabled="disabled" type="text" id="Text1" name="zsdyMc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>知识单元名称:</td>
                    <td><input class="easyui-validatebox textbox" value="<%=zsdymc %>" type="text" id="zsdyMc" name="zsdyMc" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>知识单元权重值(0~10):</td>
                    <td><input class="easyui-numberbox" type="text" value="<%=zsdyqz %>" id="sZsdyQz" name="sZsdyQz" data-options="required:true,min:0,max:10"></input></td>
                </tr>
                <tr>
                    <td>知识单元备注：</td>
                    <td><textarea rows="4" cols="1" id="zsdyBz" name="zsdyBz" style= "width:152px;" ><%=bz %></textarea></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=zsdybh %>,'<%=zslymc %>')">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    </div>
    <script type="text/javascript">
        function submitForm(zsdybh,zslymc) {

            if ($('#zsdyMc').attr('value') == undefined || $('#zsdyMc').attr('value') == '') {
                $.messager.alert('结果', '必须填写知识单元名称！', 'info');
            } else {
                $.post("xgZsdyProc.aspx", { 'zsdybh': zsdybh, 'zsdyMc': $('#zsdyMc').attr('value'), 'zslyName': zslymc, 'zsdyBz': $('#zsdyBz').attr('value'), 'sZsdyQz': $('#sZsdyQz').attr('value') }, function (data) {
                if (data == 'True') {
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgzsdy.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败,不能将该数据修改为已经存在值！', 'info', function () {
                        //do nothing
                    });
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgzsdy.aspx";
        }
    </script>
</body>
</html>
