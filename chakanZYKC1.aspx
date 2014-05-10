<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="chakanZYKC1.aspx.cs" Inherits="ZYNLPJPT.chakanZYKC1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <<title>查看专业课程</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">   
    <form action="chakanZYKC1.aspx" method="post">
    <div  region="center" border="false">
    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
         <thead>
            <tr>
               <th data-options="field:'zybh'" width="32">专业编号</th>
               <th data-options="field:'ssxk'" width="32">所属学科</th>
               <th data-options="field:'zymc'" width="32">专业名称</th>
               <th data-options="field:'button',align:'center'" width="20">配置专业课程</th>
            </tr>
         </thead>
         <tbody>
            <%
                for (int i = 0; i < this.zykcViews.Length; i++)
                {
                    Response.Write("<tr>");
                    Response.Write("<td>" + this.zykcViews[i].ZYBH + "</td>");
                    Response.Write("<td>" + this.zykcViews[i].XKMC + "</td>");
                    Response.Write("<td>" + this.zykcViews[i].ZYM + "</td>");
                    Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='chakanZYKC.aspx?zybh=" + this.zykcViews[i].ZYBH + "'\" >配置专业课程</a></td>");
                    Response.Write("</tr>");
                }
                
                
                 %>
         </tbody>
    </table>
    </div>
    </form>
    
</body>
</html>

