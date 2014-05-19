<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiuGaiKC.aspx.cs" Inherits="ZYNLPJPT.XiuGaiKC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>修改课程</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form method="post">
      <div region="center" border="false">

    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true,onClickCell: onClickCell" style="border:none;" border="false">
         <thead>
            <tr>
               <th data-options="field:'kcmc'" width="32">课程名称</th>
               <th data-options="field:'kkxk'" width="32">开课学科</th>
               <th data-options="field:'kxfzr'" width="32">课程负责人</th> 
                <th data-options="field:'kcjj'" width="32">课程简介</th>   
                <th data-options="field:'button',align:'center'" width="30">修改课程</th>        
    
            </tr>
         </thead>
         <tbody>
            <%
                for (int i = 0; i < this.kcmc.Length; i++)
                {
                    
                    Response.Write("<tr>");
                    Response.Write("<td>" + kcmc[i] + "</td>");
                    Response.Write("<td>" +kkxk[i] + "</td>");
                    Response.Write("<td> 暂无  </td>");
                    Response.Write("<td>暂无</td>");

                    Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/XiuGaiKC1.aspx?kcbh=" + kcbh[i] + "'\" >进入修改</a></td>");
                    Response.Write("</tr>");
                }
                
                
                 %>
         </tbody>
    </table>

  </div>
  
  
</form>
</body>
<script type="text/javascript">
    $.extend($.fn.datagrid.methods, {
        editCell: function (jq, param) {
            return jq.each(function () {
                var opts = $(this).datagrid('options');
                var fields = $(this).datagrid('getColumnFields', true).concat($(this).datagrid('getColumnFields'));
                for (var i = 0; i < fields.length; i++) {
                    var col = $(this).datagrid('getColumnOption', fields[i]);
                    col.editor1 = col.editor;
                    if (fields[i] != param.field) {
                        col.editor = null;
                    }
                }
                $(this).datagrid('beginEdit', param.index);
                for (var i = 0; i < fields.length; i++) {
                    var col = $(this).datagrid('getColumnOption', fields[i]);
                    col.editor = col.editor1;
                }
            });
        }
    });
    var editIndex = undefined;
    function endEditing() {
        if (editIndex == undefined) { return true }
        if ($('#mytable').datagrid('validateRow', editIndex)) {
            $('#mytable').datagrid('endEdit', editIndex);
            editIndex = undefined;
            return true;
        } else {
            return false;
        }
    }
    function onClickCell(index, field) {
        if (endEditing()) {
            $('#mytable').datagrid('selectRow', index)
                        .datagrid('editCell', { index: index, field: field });
            editIndex = index;
        }
    }
</script>
</html>
