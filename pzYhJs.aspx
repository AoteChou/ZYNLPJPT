<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzYhJs.aspx.cs" Inherits="ZYNLPJPT.pzYhJs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>

    <script type="text/javascript">

        function getSelected(yhbh) {
        //    var yhbh;
         //   var row = $('#mytable').datagrid('getSelected');
       
          //  yhbh = row.yhbh;    //用户编号

            window.location.href = "yhjsRecord.aspx?yhbh="+yhbh.toString();
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">

    <div>
    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'yhbh'" width="50" align=center>用户编号</th>
    	        <th data-options="field:'yhxm'" width="50" align=center>用户姓名</th>
                <th data-options="field:'pzjs'"width="50" align=center>配置角色</th>
                </tr>
    	     </thead>
   	
      <tbody>
              <%
                  
                  
                   for (int i = 0; i <this.length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.yh_list[i].YHBH.ToString() + "</td>");                                    //用户编号
                       Response.Write("	<td >" +this.yh_list[i].XM.ToString()+ "</td>");                                          //用户姓名
                       Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected('"+ this.yh_list[i].YHBH.ToString()+"')\" >配置角色</a></td>");                                                                                              
                       Response.Write("</tr>");
                   }
                  
                %>

    	</tbody>
   	</table>     
     
    </div>
    </form>
</body>
</html>
