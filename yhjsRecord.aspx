<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="yhjsRecord.aspx.cs" Inherits="ZYNLPJPT.yhjsRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title></title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" >

        //为用户添加角色
        function newJS(yhbh) {

            window.location.href = "addYHJs.aspx?yhbh=" + yhbh.toString();
        }

        //删除选中角色
        function getSelected(yhbh) {
            var jsbh;

            var row = $('#mytable').datagrid('getSelected');
            jsbh = row.jsbh;                    //功能编号

            $.post("processAspx/DelyhjsProc.aspx", { 'jsbh': jsbh, 'yhbh': yhbh }, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '无法删除!');
                }

                else {
                    $.messager.confirm('信息', '删除成功!', function (r) {
                        if (r) {
                            //刷新当前页面
                            location.reload(false);
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

<body class="easyui-layout">
 <form id="form1" runat="server">

    <div region="center" border="false">
       
      <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='pzYhJs.aspx'">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="newJS(<%=this.yhbh%>)">配置新角色</a>
      </div>
    </div>
     <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'jsbh'" width="50" align=center>已有角色编号</th>
                <th data-options="field:'jsmc'" width="50" align=center>已有角色名称</th>
                <th data-options="field:'sc'" width="50" align=center>操作</th>
        	</tr>
    	</thead>
   		<tbody >
  
   <%
       for (int i = 0; i < this.length; i++)
       {

           Response.Write("<tr >");
           Response.Write("	<td >" + this.js_list[i].JSBH.ToString() + "</td>");                                  //角色编号
           Response.Write("	<td >" + this.js_list[i].JSM.ToString() + "</td>");                                   //角色名  
           Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected(" + this.yhbh.ToString() + ")\" >删除</a></td>");
          Response.Write("</tr>");
       }

   %>
   </tbody>
   	</table>     
     
    </div>
    </form>
</body>
</html>