<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzJsGn.aspx.cs" Inherits="ZYNLPJPT.pzJsGn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
    <script type="text/javascript">

        function getSelected(jsbh)
         {
          //  var jsbh, jsmc;

          //  var row = $('#mytable').datagrid('getSelected');
         //   jsbh = row.jsbh;                       //角色编号
       //     jsmc = row.jsmc;                     //角色名称

            window.location.href = "JsGn.aspx?jsbh="+jsbh.toString();
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
                <th data-options="field:'bc'"width="50"  align=center>配置角色功能</th>
                </tr>
    	     </thead>
   	
      <tbody>
              <%
                  
                  
                   for (int i = 0; i <this.length; i++)
                   {
             
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.js[i].JSBH.ToString() + "</td>");                                            //角色编号
                       Response.Write("	<td >" + this.js[i].JSM.ToString() + "</td>");                                            //角色名  
                       Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected("+this.js[i].JSBH+")\" >进入配置</a></td>");                                                                                              
              
                       Response.Write("</tr>");
                   }
                  
                %>

    	</tbody>
   	</table>     
     
    </div>
    </form>
</body>
</html>

