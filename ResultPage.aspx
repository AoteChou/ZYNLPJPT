<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="ZYNLPJPT.ResultPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>


<body class="easyui-layout">
<form id="form1" runat="server">

<div region="center" border="false">
  <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'cpjlbh'" width="50">测评记录编号</th>
                <th data-options="field:'stbh'" width="50">试题编号</th>
                <th data-options="field:'xzrq'" width="50">下载日期</th>
                <th data-options="field:'scrq'" width="50">上传日期</th>
                <th data-options="field:'gtr'" width="50">改题人</th>
                <th data-options="field:'pfcs'" width="20">评测分数</th>
                <th data-options="field:'xzst'" width="40"></th>
                <th data-options="field:'xzwdda'" width="50"></th>
    			
    		</tr>
    	</thead>
   		<tbody >
           
    		
              <%
              for (int i = 0; i <this.pcjls.Length; i++)
              {  
                  Response.Write("<tr >");
                  Response.Write("	<td >" + pcjls[i].PCJLBH  + "</td>");
    		      Response.Write("	<td >"+pcjls[i].STBH+"</td>");
    		      Response.Write("	<td >"+pcjls[i].XZRQ+"</td>");
                  Response.Write("	<td >" + pcjls[i].SCRQ  + "</td>");
    		      Response.Write("	<td >"+yhxm[i]+"</td>");
    		      Response.Write("	<td >"+pcjls[i].PCFS+"</td>");
                  Response.Write("  <td><a  href=\"#\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\"onclick=\"window.location.href='processAspx/DownloadTest.aspx?stbh=" + pcjls[i].STBH + "'\" >下载题目</a></td>");
                  Response.Write("  <td><a  href=\"#\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/DownloadMyAnswer.aspx?pcjlbh=" + pcjls[i].PCJLBH + "'\" >下载我的答案</a></td>");
                  Response.Write("</tr>");
                 
              } %>
               
          
            
            
    	</tbody>
   	</table>     
</div>
<div id="win">
</div>
 
</form>               
<script type="text/javascript">
    function uploadClick(objValue) {
        $('#win').html("<iframe width='100%' height='100%' style='_border:none;'  class='myUploadIframe' frameborder='0' scrolling='no' src='UploadPage_Detail.aspx?" + objValue + "' ></iframe>")
        //.attr('src', 'TestPage.aspx?teststate=2&pcjlbh=24&stbh=3')
        $('#win').window({
            title: '  请上传答案',
            width: 600,
            height: 400,
            modal: true,
            collapsible: false,
            minimizable: false
        });
        $('#win').window({
            onBeforeClose: function () {
                window.location.reload();
            }
        });
    }
    $(function () {
        $('#mytable').datagrid({
            pagination: true,
            singleSelect: true
        });


    });

</script>

</body>

</html>