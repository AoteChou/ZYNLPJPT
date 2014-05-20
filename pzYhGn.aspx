<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="pzYhGn.aspx.cs" Inherits="ZYNLPJPT.pzYhGn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>配置用户功能</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>
<body class="easyui-layout">
      
    <div  region="center" border="false">
   <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'yhbh'" width="50" align=center>用户编号</th>
    	        <th data-options="field:'yhxm'" width="50" align=center>用户姓名</th>
                <th data-options="field:'pzjs'"width="50" align=center>配置功能</th>
                </tr>
    	     </thead>
   	
      <tbody>
              <%
                  
                  
                   for (int i = 0; i <this.length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.yh_list[i].YHBH.ToString() + "</td>");                                    //用户编号
                       Response.Write("	<td >" +this.yh_list[i].XM.ToString()+ "</td>");                                          //用户姓名
                       Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='yhgnRecord.aspx?yhbh="+yh_list[i].YHBH.ToString()+"'\" >配置功能</a></td>");                                                                                              
                       Response.Write("</tr>");
                   }
                  
                %>

    	</tbody>
   	</table>     
     
    </div>
     
</body>
</html>
