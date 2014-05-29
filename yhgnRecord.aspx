<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yhgnRecord.aspx.cs" Inherits="ZYNLPJPT.yhgnRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>用户功能记录</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
      <script type="text/javascript" >

          //为用户添加新功能
          function newGN(yhbh) {

              $.post("processAspx/ifPzJSProc.aspx", { 'yhbh': yhbh }, function (result) {
                  if (result == 'False') {
                      $.messager.alert('警告', '请先配置此用户的角色!');
                      setTimeout(function () { location.href = 'addYHJs.aspx?yhbh=' + yhbh.toString(); }, 2000);
                      //window.location.href = 'addYHJs.aspx?yhbh=' + yhbh.toString();

                  }
                  else {
                      window.location.href = "addYHGn.aspx?yhbh=" + yhbh.toString();
                  }
              });
             // window.location.href = "addYHGn.aspx?yhbh=" + yhbh.toString();
          }

          //删除选中功能
          function getSelected(yhbh,gnbh) {
            //  var jsbh;

            //  var row = $('#mytable').datagrid('getSelected');
          //   gnbh = row.gnbh;                    //功能编号
           
             $.post("processAspx/DelyhgnProc.aspx", { 'gnbh': gnbh, 'yhbh': yhbh }, function (result) {
                  if (result == 'False') {
                      $.messager.alert('警告', '无法删除!');
                  }
                  else
                   {
                       location.reload(false); 
                  }
              });
          }

    </script>
</head>

<body class="easyui-layout">
    <div region="center" border="false">
       
      <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='pzYhGn.aspx'">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="newGN('<%=this.yhbh%>')">配置新功能点</a>
      </div>
   <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'gnbh'" width="50" align=center>功能编号</th>
                <th data-options="field:'gnmc'" width="50" align=center>功能名称</th>
                <th data-options="field:'gnlj'" width="50" align=center>功能链接</th>
                <th data-options="field:'ssml'" width="50" align=center>所属目录</th>
                <th data-options="field:'sc'" width="50" align=center>删除</th>
        	</tr>
    	</thead>
   		<tbody >
  
   <%
       for (int i = 0; i < this.length; i++)
       {

           Response.Write("<tr >");
           Response.Write("	<td >" + this.gnd_list[i].GNBH.ToString() + "</td>");                              //功能编号
           Response.Write("	<td >" + this.gnd_list[i].GNM.ToString() + "</td>");                               //功能名  
           Response.Write("	<td >" + this.gnd_list[i].GNLJ.ToString() + "</td>");                               //功能链接
           Response.Write("	<td >" + this.gnd_list[i].SSML.ToString() + "</td>");                              //所属目录
           Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected(" +"'"+ this.yhbh.ToString() +"'"+ "," + this.gnd_list[i].GNBH.ToString() + ")\" >删除</a></td>");
          Response.Write("</tr>");
       }

   %>
   </tbody>
   	</table>     
     </div>
    </div>
   
</body>
</html>

