<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ckzyejzb.aspx.cs" Inherits="ZYNLPJPT.ckzyejzb" %>

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
          function showEjzbs(data) {
              $.messager.alert('所含二级指标', data, 'info');
          }
    </script>
</head>
<body  class="easyui-layout">
  <div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
                <th data-options="field:'xymc'" width="50">学院名称</th>
                 <th data-options="field:'xkmc'" width="50">学科名称</th>
                <th data-options="field:'xkfzr'" width="50">学科负责人</th>
                <th data-options="field:'zym'" width="50">专业名称</th>
                <th data-options="field:'button'" width="30">查看专业能力指标</th>
    		</tr>
    	</thead>
   		<tbody >
              <%
                   for (int i = 0; i < this.xyXkZyViewWrappers.Length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.xyXkZyViewWrappers[i].XyXkZyView.XYMC + "</td>");
                       Response.Write("	<td >" + this.xyXkZyViewWrappers[i].XyXkZyView.XKMC + "</td>");
                       Response.Write("  <td >" +this.xyXkZyViewWrappers[i].XyXkZyView.XKFZR + "</td>");
                       Response.Write("	<td >" + this.xyXkZyViewWrappers[i].XyXkZyView.ZYM + "</td>");
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\" showEjzbs('" + this.xyXkZyViewWrappers[i].Ejzbs.Trim() + "') \" >查看知识单元</a></td>");
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
