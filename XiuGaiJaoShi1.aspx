<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiuGaiJaoShi1.aspx.cs" Inherits="ZYNLPJPT.XiuGaiJaoShi1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>修改教师用户</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form action="XiuGaiJaoShi1.aspx" method="post">
      <div region="center" border="false">

    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
         <thead>
            <tr>
               <th data-options="field:'xkbh'" width="32">学科编号</th>
               <th data-options="field:'xkmc'" width="32">学科名称</th>
               <th data-options="field:'xymc'" width="32">学院名称</th>            
               <th data-options="field:'button',align:'center'" width="20">修改</th>
            </tr>
         </thead>
         <tbody>
            <%
                for (int i = 0; i < this.xkbh.Length; i++)
                {
                    
                    Response.Write("<tr>");
                    Response.Write("<td>" + xkbh[i] + "</td>");
                    Response.Write("<td>" +xkmc[i] + "</td>");
                    Response.Write("<td>" + xymc[i] + "</td>");


                    Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/XiuGaiJiaoShi.aspx?xkbh=" + xkbh[i] + "'\" >进入修改</a></td>");
                    Response.Write("</tr>");
                }
                
                
                 %>
         </tbody>
    </table>

  </div>
  
  
</form>
</body>

</html>

