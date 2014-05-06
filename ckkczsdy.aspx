<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckkczsdy.aspx.cs" Inherits="ZYNLPJPT.ckkczsdy" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>查看课程知识单元</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">
          function showZsdys(data) {
              $.messager.alert('所含知识单元', data, 'info');
          }
    </script>
</head>
<body  class="easyui-layout">
  <div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'kcbh'" width="13">课程编号</th>
                 <th data-options="field:'kcmc'" width="50">课程名称</th>
                <th data-options="field:'kcfzr'" width="50">课程负责人</th>
                <th data-options="field:'kkxk'" width="50">开课学科</th>
                <th data-options="field:'kkxy'" width="50">开课学院</th>
                <th data-options="field:'button',align:'center'" width="50">查看课程知识单元</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.kczsdyWrappers.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.kczsdyWrappers[i].KcDetailView.KCBH + "</td>");
                       Response.Write("	<td >" + this.kczsdyWrappers[i].KcDetailView.KCMC + "</td>");
                       Response.Write("  <td >" + this.kczsdyWrappers[i].KcDetailView.KCFZR + "</td>");
                       Response.Write("	<td >" + this.kczsdyWrappers[i].KcDetailView.XKMC + "</td>");
                       Response.Write("	<td >" + this.kczsdyWrappers[i].KcDetailView.XYMC + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\" showZsdys('" + this.kczsdyWrappers[i].Zsdys.Trim() + "') \" >查看知识单元</a></td>");
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