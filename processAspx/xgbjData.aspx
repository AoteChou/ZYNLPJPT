<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgbjData.aspx.cs" Inherits="ZYNLPJPT.processAspx.xgbjData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <title>修改班级信息</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">  
  <div data-options="region:'center',border:false">
<div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改班级信息" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>年级名称:</td>
                    <td><input class="easyui-validatebox textbox" disabled="disabled" value="<%=njmc %>" type="text" id="njName" name="njName" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>所属学院:</td>
                    <td><input class="easyui-validatebox textbox" disabled="disabled" value="<%=xymc %>" type="text" id="xyName" name="xyName" data-options="required:true"></input></td>
                </tr>
                <tr>
                    <td>所属学科:</td>
                    <td><input class="easyui-validatebox textbox" disabled="disabled" value="<%=xkmc %>" type="text" id="xkName" name="xkName" data-options="required:true"></input></td>
                </tr>
                <tr>
                    <td>所属专业:</td>
              <td><input class="easyui-validatebox textbox" disabled="disabled" value="<%=zymc %>" type="text" id="zyName" name="zyName" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>班级名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="BjMc" name="BjMc" value="<%=bjmc %>" data-options="required:true"></input></td>
                </tr>
                 <tr style=" margin-top:10px;">
                    <td>班级入学年份:</td>
                    <td><input class="easyui-datebox"  type="text"  id="rxnf" value="<%=rxnf %>" name="rxnf" data-options="required:true"></input></td>
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=bjbh %>,<%=njbh %>,<%=zybh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    </div>
    <script type="text/javascript">

        function submitForm(bjbh,njbh,zybh) {
            if ($('#njName').attr('value') == undefined || $('#njName').attr('value') == '' || $('#BjMc').attr('value') == undefined || $('#BjMc').attr('value') == '' || $('#xyName').attr('value') == undefined || $('#xyName').attr('value') == '' || $('#xkName').attr('value') == undefined || $('#xkName').attr('value') == '' || $('#zyName').attr('value') == undefined || $('#zyName').attr('value') == '' || $('#rxnf').datetimebox('getValue') == undefined || $('#rxnf').datetimebox('getValue') == '') {
                $.messager.alert('结果', '所有信息必须填写，不能为空！', 'info');
            } else {
            $.post("xgBjProc.aspx", { 'bjbh': bjbh, 'BjMc': $('#BjMc').attr('value'), 'njbh': njbh, 'zybh':zybh, 'rxnf':  $('#rxnf').datetimebox('getValue') }, function (data) {
                if (data == 'True') {
                    document.getElementById('BjMc').value = '';
                    $.messager.alert('结果', '修改成功！', 'info', function () {
                        window.location = "../xgbj.aspx";
                    });
                } else if (data == 'False') {
                    $.messager.alert('结果', '修改失败，请检查是否班级名称为空，有重名班级信息或者时间格式出错！', 'info');
                }
            });
            }
        }
        function returnToUpPage() {
            window.location = "../xgbj.aspx";
        }
    </script>
</body>
</html>