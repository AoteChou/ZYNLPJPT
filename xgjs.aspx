<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="xgjs.aspx.cs" Inherits="ZYNLPJPT.xgjs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>

    <script type="text/javascript">

        function getSelected(i) {
            var jsbh, jsmc;

            var row = $('#mytable').datagrid('getSelected');
            jsbh = row.jsbh;    //角色编号

            jsmc = $("#jsm" + i.toString()).val();

            $.post("processAspx/xgjsData.aspx", { 'jsbh': jsbh, 'jsmc': jsmc }, function (result) {

                if (result == 'False') {
                    $.messager.alert('警告', '角色名不能为空!');
                }

                else {
                    $.messager.confirm('保存成功！', '成功！点击确定返回！ ', function (r) {
                        if (r) {
                            //  history.back(-1);
                            location.reload();
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
    <form id="form1" runat="server">

    <div>
    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'jsbh'" width="50" align=center>角色编号</th>
    	        <th data-options="field:'jsmc'" width="50" align=center>角色名称</th>
                <th data-options="field:'bc'"width="50" align=center>角色修改</th>
                </tr>
    	     </thead>
   	
      <tbody>
              <%
                  
                  
                   for (int i = 0; i <this.length; i++)
                   {
             
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.js[i].JSBH.ToString() + "</td>");                                            //角色编号
                       string jsmc= js[i].JSM.ToString();
                       Response.Write(" <td ><input class= easyui-validatebox textbox  type=text  id=jsm" + i.ToString() + "  name= ctbz  data-options=required:true value="+jsmc+"></input></td>");//角色名

                       Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected(" + i + ")\" >保存</a></td>");                                                                                              
              
                       Response.Write("</tr>");
                   }
                  
                %>

    	</tbody>
   	</table>     
     
    </div>
    </form>
</body>
</html>
