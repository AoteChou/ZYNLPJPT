<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addst.aspx.cs" Inherits="ZYNLPJPT.addst" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1"  runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>选择课程出题</title>
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>
<body class="easyui-layout">
    <div region="center" border="false">
  
     <table id="cttable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'kcmc'" width="50" align=center>课程名称</th>
                <th data-options="field:'kcbh'" width="50" align=center>课程编号</th>
                <th data-options="field:'sszy'" width="50" align=center>所属专业</th>
                <th data-options="field:'kcxz'" width="50" align=center>课程性质</th>
                <th data-options="field:'ctr'" width="50" align=center>出题人</th>
    			<th data-options="field:'ct',align:'center'" width="50" align=center>出题记录</th>
              
    		</tr>
    	</thead>
   		<tbody >
  
   <%
                  for (int i = 0; i < this.num; i++)
                  {
                      Response.Write("<tr >");
                      Response.Write("	<td >" + ctview[i].KCMC + "</td>");           //课程名称
                      Response.Write("	<td >" + ctview[i].KCBH+ "</td>");             //课程编号
                      Response.Write("	<td >" + ctview[i].ZYM + "</td>");             //专业名
                      Response.Write("  <td >" +  ctview[i].KCXZMC + "</td>");       //课程性质名称
                      Response.Write("  <td >" + ctview[i].XM + "</td>");                //出题人姓名
                      Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='ctRecord.aspx?kcbh=" + ctview[i].KCBH + "'\" >开始出题</a></td>");
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
            //data:[{code:'1',price:'2',name:'dd'}],
            pageList: [30],
            pageSize: 30,
            //url: 'processAspx/ctrData.aspx',
            singleSelect: true,
        });
    });
</script>
    </body>
</html>
