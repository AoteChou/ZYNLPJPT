<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="jdkcxsData.aspx.cs" Inherits="ZYNLPJPT.processAspx.jdkcxsData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>配置改题人</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(kcbh, zybh, njbh, jdbh) {

            var jsbh = [];
            var xsbh = [];
            var jsRows = $('#jsTable').datagrid('getSelections');
            var xsRows = $('#xsTable').datagrid('getSelections');
            for (var i = 0; i < jsRows.length; i++) {
                var jsRow = jsRows[i];
                jsbh[i] = jsRow.jsbh;
            }
            for (var j = 0; j < xsRows.length; j++) {
                var xsRow = xsRows[j];
                xsbh[j] = xsRow.xsbh;
            }
            if (jsbh.length != 1||xsbh.length<1) {
                $.messager.alert('信息', '请保证只有一位教师被选中同时有一到多位学生被选中!');
            } else {
            $.post("addJdkcxsProc.aspx", { 'jsbh': jsbh[0], 'xsbh': xsbh, 'kcbh': kcbh, 'zybh': zybh, 'njbh': njbh, 'jdbh': jdbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '请保证只有一位教师被选中同时有一到多位学生被选中!');
                } else if (result == 'True') {
                    $.messager.confirm('信息', '该教师改题配置成功，单击确认返回上层界面，取消则停留在本界面继续配置!', function (r) {
                        if (r) {
                            history.back(-1);
                        } else {
                            location.reload();
                        }
                    });
                }
            });
            }
    }

    function returnToUpPage() {
        window.location = "../pzjsgt.aspx";
    }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
         <div region="north" border="true"  >
            <div style="padding:10px 10px 10px 400px" >
                <a href="javascript:void(0)" class="easyui-linkbutton" onclick="returnToUpPage()">返回上页</a>
                <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=kcbh %>,<%=zybh %>,<%=njbh %>,<%=jdbh %>)">提交修改</a>
            </div>
        </div>
        <div region="center" border="false">
            <div class="easyui-layout" data-options="fit:true">
                <div data-options="region:'north',border:false" style=" height:30px;" >
                    请在左侧选择需要改题的教师，右侧选择需要被该教师改题的学生。其中，左侧同时只可以选择一位教师，右侧同时可以选择多位学生。
                </div>
                 <div  data-options="region:'west',border:true" style="width:450px;" >
                    <table id="jsTable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	                <thead>
    		                <tr>
    			            <th data-options="field:'ck',checkbox:true" width="5"> 是否为改题人</th>
                            <th data-options="field:'jsbh'" width="13"><span class="easyui-tooltip" title="<%="" %>" >教师编号</span> </th>
                             <th data-options="field:'xm'" width="13">姓名</th>
                             <th data-options="field:'xb'" width="9">性别</th>
                            <th data-options="field:'ssxk'" width="20">所属学科</th>
                            <th data-options="field:'sfsxkfzr',align:'center'" width="10">学科负责人</th>
    		            </tr>
    	            </thead>
   		            <tbody >
                      <%
                              for (int i = 0; i < this.jsTeaDetailViews.Length; i++)
                              {
                                  Response.Write("<tr >");
                                  Response.Write("<td></td>");
                                  Response.Write("<td>" + this.jsTeaDetailViews[i].JSBH + "</td>");
                                  Response.Write("<td>" + this.jsTeaDetailViews[i].XM + "</td>");
                                  Response.Write("<td>" + (this.jsTeaDetailViews[i].XB == true ? "男" : "女") + "</td>");
                                  Response.Write("<td>" + this.jsTeaDetailViews[i].XKMC + "</td>");
                                  Response.Write("<td>" + (this.jsTeaDetailViews[i].SFSXKFZR == true ? "是" : "否") + "</td>");
                                  Response.Write("</tr>");
                              }
                    %>
    	            </tbody>
                   </table>
                </div> 
                <div data-options="region:'center',border:true">
                    <table id="xsTable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	                <thead>
    		                <tr>
    			                <th data-options="field:'ck',checkbox:true" width="5"> 选择学生</th>
                                <th data-options="field:'xsbh'" width="15">学生学号</th>
                                 <th data-options="field:'xm'" width="12">姓名</th>
                                 <th data-options="field:'ssbj'" width="15">所属班级</th>
                                <th data-options="field:'sszy'" width="15">所属专业</th>
                                <th data-options="field:'sszy1'" width="15">所属学科</th>
    		                </tr>
    	                </thead>
   		                <tbody>
                            <%
                                bool isExistStus = true;
                                if (this.bjXsDetailViews.Length < 1)
                                {
                                    isExistStus = false;
                                }
                                    for (int i = 0; i < this.bjXsDetailViews.Length; i++)
                                    {
                                        Response.Write("<tr >");
                                        Response.Write("<td></td>");
                                        Response.Write("<td>" + this.bjXsDetailViews[i].XSBH + "</td>");
                                        Response.Write("<td>" + this.bjXsDetailViews[i].XM + "</td>");
                                        Response.Write("<td>" + this.bjXsDetailViews[i].BJMC + "</td>");
                                        Response.Write("<td>" + this.bjXsDetailViews[i].ZYM + "</td>");
                                        Response.Write("<td>" + this.bjXsDetailViews[i].XKMC + "</td>");
                                        Response.Write("</tr>");
                                    }
                          %>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
        <% if (isExistStus == false)
           { %>
           <script type="text/javascript">
               $(function () {
                   $.messager.show({
                       title: '通知',
                       msg: '该阶段课程下所有的学生已经配置有改题教师，请返回上页配置其它改题教师！',
                       showType: 'show'
                   });
               });
           </script>
        <%} %>
         <script type="text/javascript">
             $(function () {
                $('#jsTable').datagrid({
                 pagination: false,
                 pageList: [30],
                 pageSize: 30,
                 singleSelect: true,
                });

                 $('#xsTable').datagrid({
                 pagination: false,
                 pageList: [30],
                 pageSize: 30,
                 singleSelect: false,
                });
            });
        </script>
    </form>
</body>
</html>
