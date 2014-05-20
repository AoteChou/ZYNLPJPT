<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Guanlixsyh.aspx.cs" Inherits="ZYNLPJPT.Guanlixsyh" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>管理学生用户</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form action="Guanlixsyh.aspx" method="post">
    <div region="center" border="false">

    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
         <thead>
            <tr>
               <th data-options="field:'zybh'" width="32">班级编号</th>
               <th data-options="field:'bjmc'" width="32">班级名称</th>
               <th data-options="field:'zymc'" width="32">专业名称</th>
               <th data-options="field:'rxnf'" width="32">入学年份</th>
               <th data-options="field:'button',align:'center'" width="20">查看</th>
            </tr>
         </thead>
         <tbody>
            <%
                for (int i = 0; i < this.bjbh.Length; i++)
                {
                    DateTime rxDate = (DateTime)DateTime.Parse(rxnf[i]);
                    Response.Write("<tr>");
                    Response.Write("<td>" + bjbh[i] + "</td>");
                    Response.Write("<td>" +rxDate.Year+"级"+ bjmc[i] + "</td>");
                    Response.Write("<td>" + zymc[i] + "</td>");
                    Response.Write("<td>" + rxnf[i] + "</td>");

                    Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/Guanlixsyh1.aspx?bjbh=" + bjbh[i] + "'\" >查看</a></td>");
                    Response.Write("</tr>");
                }
                
                
                 %>
         </tbody>
    </table>

  </div>
</form>
</body>
</html>