<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiuGaiKC1.aspx.cs" Inherits="ZYNLPJPT.processAspx.XiuGaiKC1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改课程</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" />
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body >
    <form id="form1" runat="server">
    <div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="修改课程" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                
                <tr style=" margin-top:10px;">
                    <td>课程名称:</td>
                    <td><input class="easyui-validatebox textbox" type="text" id="kcmc" value="<%=kcmc %>" name="kcmc" data-options="required:true"></input></td>
                </tr>
                <tr style=" margin-top:10px;">
                   <td>开课学科：</td>
                   <td><select id="kkxk" name="kkxk" onchange="sselectchange()" style="width:152px;" >
                           <% for (int i = 0; i < this.xkmc.Length; i++)
                              {
                                  Response.Write("<option value='"+xkbh[i]+"'>" + this.xkmc[i] + "</option>");
                              } %>
                   </select>
                   </td>
                </tr>
               <tr style=" margin-top:10px;">
                    <td>课程负责人:</td>
                    <td>
                        <select id="kcfzr" name="kcfzr" onchange="krselectchange()" style="width:152px;" >
                            
                        </select>
                        </td>

                </tr>
                <tr style=" margin-top:10px;">
                  <td>课程简介：</td>
                  <td><textarea rows="4" id="kcjj" name="kcJj" cols="1" style="width:152px;"><%=kcjj %></textarea></td>
                 
                </tr>
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm(<%=kcbh %>)">修改</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()">返回</a>
        </div>
        </div>    
    </div>
    </div>
    </form>
    <script type="text/javascript">
        //开课学科选择事件
        function sselectchange() {
            var checkValue = $("#kkxk").val();  //获取Select选择的Value
            $.post("selectKCFZR.aspx",
                  { 'kkxkid': checkValue },
                  function (data) {
                      $("#kcfzr").text("");

                      for (var i = 0; i < data.length; i++) {
                          $("#kcfzr").append("<option value='" + data[i].JSBH + "'>" + data[i].XM + "</option>");  //为Select追加一个Option(下拉项)

                      }
                      $("#kcfzr").append("<option value=\"-1\">暂无</option>");
                      

                  }, "json");
        }
        //课程负责人选择事件
        function krselectchange() {
            var checkValue = $("#kcfzr").val();  //获取Select选择的Value
        }

        function submitForm(kcbh) {
            if ($('#kcmc').attr('value') == undefined || $('#kcmc').attr('value') == '') {
                $.messager.alert('结果', '必须填写课程名称！', 'info');
            } else {
                $.post("XiuGaiKC2.aspx", { 'kcbh':<%=kcbh %>, 'kcmc': $('#kcmc').attr('value'), 'kcfzr': $('#kcfzr').attr('value'), 'kkxk': $('#kkxk').attr('value'), 'kcjj': $('#kcjj').attr('value') }, function (data) {
                    if (data == 'True') {
                        
                        $.messager.alert('结果', '修改成功！', 'info',function () {
                        window.location = "../XiuGaiKC.aspx";
                        });
                        
                    }
                    else if (data == 'False') {
                       
                        $.messager.alert('结果', '修改失败', 'info');

                    }
                });
            }
        }
        function clearForm() {
            window.location = "../XiuGaiKC.aspx";
        }
        $(function () {

            //sselectchange();
            $('#kkxk').find("option[value='<%=kkxk %>']").attr("selected",true);
            var checkValue = $("#kkxk").val();  //获取Select选择的Value
            $.post("selectKCFZR.aspx",
                  { 'kkxkid': checkValue },
                  function (data) {
                      $("#kcfzr").text("");

                      for (var i = 0; i < data.length; i++) {
                          $("#kcfzr").append("<option value='" + data[i].JSBH + "'>" + data[i].XM + "</option>");  //为Select追加一个Option(下拉项)

                      }
                      $("#kcfzr").append("<option value=\"-1\">暂无</option>");
                      $('#kcfzr').find("option[value='<%=kcfzr %>']").attr("selected", true);

                  }, "json");
            
            
        })
    </script>
</body>
</html>
