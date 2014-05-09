<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Importxs.aspx.cs" Inherits="ZYNLPJPT.Importxs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>导入学生信息</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form action="Importxs.aspx" method="post">
    <div region="center" border="false">

    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
         <thead>
            <tr>
               <th data-options="field:'zybh'" width="32">班级编号</th>
               <th data-options="field:'bjmc'" width="32">班级名称</th>
               <th data-options="field:'zymc'" width="32">专业名称</th>
               <th data-options="field:'rxnf'" width="32">入学年份</th>
               <th data-options="field:'button',align:'center'" width="20">导入</th>
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

                    Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"uploadClick(" + bjbh[i] + ")\" >导入</a></td>");
                    Response.Write("</tr>");
                }
                
                
                 %>
         </tbody>
    </table>

  </div>
  <div id="win">
</div>
</form>
</body>
<script type="text/javascript">
    function uploadClick(objValue) {
        $('#win').html("<iframe width='100%' height='100%' style='_border:none;'  class='myUploadIframe' frameborder='0' src='Importxs1.aspx?bjbh=" + objValue + "' ></iframe>")

        $('#win').window({
            title: '  请上传Excel文件',
            width: 600,
            height: 400,
            modal: true,
            collapsible: false,
            minimizable: false
        });
    }
</script>
</html>

