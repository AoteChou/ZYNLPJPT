<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cpjdData.aspx.cs" Inherits="ZYNLPJPT.processAspx.cpjdData" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>配置测评阶段</title> 
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
        function getSelections(jdbh, zybh, njbh) {
            var ss = [];
            var rows = $('#mytable').datagrid('getSelections');
            for (var i = 0; i < rows.length; i++) {
                var row = rows[i];
                ss[i] = row.yhbh;
            }
            $.post("addCtr.aspx", { 'teaIds': ss, 'kcbh': kcbh, 'zybh': zybh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '必须选择至少一位教师,请选择要配置的教师名!');
                } else {
                    $.messager.confirm('信息', '教师出题配置成功，单击确认返回上层界面，取消则停留在本界面!', function (r) {
                        if (r) {
                            history.back(-1);
                        } else {
                            //do nothing
                        }
                    });
                }
            });
        }
    </script>
</head>
<body class="easyui-layout">
    <form id="form" action="../Default.htm" method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=jdbh %>,<%=zybh %>,<%=njbh %>)">提交修改</a>
        </div>
    </div>
    <div region="center" border="false">
         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			<th data-options="field:'ck',checkbox:true" width="50"> 是否为阶段课程</th>
                <th data-options="field:'kcbh'" width="12"><span class="easyui-tooltip" title="<%=tips %>" >课程编号</span> </th>
                 <th data-options="field:'kcmc',align:'center'" width="50">课程名称</th>
                 <th data-options="field:'sszy'" width="50">所属专业</th>
                 <th data-options="field:'ssxk'" width="50">所属学科</th>
                <th data-options="field:'kcxz'" width="50">课程性质</th>
                <th data-options="field:'llxf'" width="50">理论学分</th>
                <th data-options="field:'sjxf'" width="50">实践学分</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.zykcViews.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td></td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCBH+ "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCMC + "</td>");
                       Response.Write("  <td >" +this.zykcViews[i].ZYM+ "</td>");
                       Response.Write("  <td >" + this.zykcViews[i].XKMC + "</td>");
                       Response.Write("	<td >" + this.zykcViews[i].KCXZMC + "</td>");
                       Response.Write("	<td >" +this.zykcViews[i].SJXF + "</td>");
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    </div>
        <script type="text/javascript">
             $(function () {
                $('#mytable').datagrid({
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
