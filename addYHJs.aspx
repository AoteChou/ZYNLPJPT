<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addYHJs.aspx.cs" Inherits="ZYNLPJPT.addYHJs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>为用户添加新角色</title>
   <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>

   <script type="text/javascript">

       function getSelected(yhbh) {
           var jsbh;                                                                     //选择的功能点编号(多个)    
           var rows = $('#mytable').datagrid('getSelected');
           jsbh = rows.jsbh;
           $.post("processAspx/addYHJsProc.aspx", { 'yhbh': yhbh, 'jsbh': jsbh }, function (result) {
               if (result == 'False') {
                   $.messager.alert('警告', '配置新角色失败!');
               }

               else {
                   $.messager.confirm('信息', '为此用户配置新角色成功!', function (r) {
                       if (r) {

                           //刷新页面
                           location.reload(false);
                           window.location.href = 'yhjsRecord.aspx?yhbh=' + yhbh.toString();

                       }
                       else {
                           //do nothing
                       }
                   });
               }
           });

       }

     </script>

</head>

 
<body>

  <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='yhjsRecord.aspx?yhbh=<%=yhbh %>'">返回上页</a>
       </div>
 </div>

         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    	
                <th data-options="field:'jsbh'" width="50" align=center>角色编号</th>
                 <th data-options="field:'jsm'" width="50" align=center>角色名称</th>
                 <th data-options="field:'tjyhjs'" width="50" align=center>添加用户角色</th>
                  
    		</tr>
    	</thead>
   		
        <tbody >
              <%
                   for (int i = 0; i <this.length; i++)
                   {
                       Response.Write("<tr >");
           
                       Response.Write("	<td >" +this.js_list[i].JSBH.ToString()+ "</td>");                                           //角色编号
                       Response.Write("	<td >" +this.js_list[i].JSM.ToString()+ "</td>");                                          //角色名
                       Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected(" + this.yhbh + ")\" >添加</a></td>");
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
</body>
</html>