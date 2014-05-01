<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckbj.aspx.cs" Inherits="ZYNLPJPT.ckbj" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看班级信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">         
<div region="north" border="true" style="height:40px;">
<form action="ckbj.aspx" method="post">
    <div id="content" name="content" style="padding:10px 10px 10px 400px">
        <label for="choosedNjName" style="width:200px;">选择待产看班级所属年级:</label>
        <select  id="choosedNjName" name="choosedNjName" style="width:200px;"   onchange="return submit()" >
            <% for (int i = 0; i < this.allNjNames.Length; i++) {
                   Response.Write("<option>"+allNjNames[i].ToString().Trim()+"</option>");
               } %>
        </select>
    </div>
    </form>
</div>
<div region="center" border="false">
 <div id="ctTea" class="easyui-window" title="查看班级信息" data-options="modal:true,closed:true,iconCls:'icon-save'" style="width:500px;height:200px;padding:10px;">
 </div>
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'bjbh'" width="11">班级编号</th>
                <th data-options="field:'bjmc',align:'center'" width="50">班级名称</th>
                 <th data-options="field:'bjrxnf'" width="11">班级入学年份</th>
                <th data-options="field:'sszy',align:'center'" width="30">所属专业</th>
                <th data-options="field:'ssxk',align:'center'" width="30">所属学科</th>
                <th data-options="field:'ssxy',align:'center'" width="30">所属学院</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                  for (int i = 0; i < this.bjDetailViews.Length; i++)
                  {
                      Response.Write("<tr >");
                      Response.Write("	<td >" + bjDetailViews[i].BJBH + "</td>");
                      Response.Write("	<td >" + bjDetailViews[i].BJMC + "</td>");
                      Response.Write("  <td >" + bjDetailViews[i].RXNF.ToShortDateString()+ "</td>");
                      Response.Write("	<td >" + bjDetailViews[i].ZYM+ "</td>");
                      Response.Write("	<td >" + bjDetailViews[i].XKMC + "</td>");
                      Response.Write("	<td >" + bjDetailViews[i].XYMC + "</td>");
                      Response.Write("</tr>");
                   }
                 %>
    	</tbody>
   	</table>     
</div>                
<script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            pagination: false,
            pageList: [30],
            pageSize: 30,
            singleSelect: true,
        });
    });
</script>
</body>
</html>
