<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiuGaiXS1.aspx.cs" Inherits="ZYNLPJPT.processAspx.XiuGaiXS1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>修改学生信息</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form id="form" action="XiuGaiXS1.aspx"  method="post">
    <div region="north" border="true"  >
        <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="history.back(-1)">返回</a>
             <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections()">删除</a>       
        </div>
    </div>
    <div region="center" border="false">
        <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                 <th data-options="field:'ck',checkbox:true" width="50">是否提交</th>
                 <th data-options="field:'yhbh',align:'center'" width="50">用户编号 </th>
                 <th data-options="field:'xm',align:'center'" width="55">姓名</th>
                 <th data-options="field:'xb',align:'center'" width="50">性别</th>
                 <th data-options="field:'rxnf',align:'center'" width="55">入学年份</th>  
                 <th data-options="field:'xgBUtton',align:'center'" width="30"></th>                
    		</tr>
            
    	</thead>
        <tbody >
              <%
                  for (int i = 0; i < this.yhbh.Length; i++)
                  {
                      Response.Write("<tr >");
                      Response.Write("	<td ></td>");
                      Response.Write("	<td >" + yhbh[i] + "</td>");
                      Response.Write("  <td >" + xm[i] + "</td>");
                      Response.Write("	<td >" + xb[i] + "</td>");
                      Response.Write("	<td >" + rxnf[i] + "</td>");
                      
                      Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"xgButtonClick('" + yhbh[i] + "')\" >重置密码</a></td>");                                           
                      Response.Write("</tr>");
                      
                  }
                   %>
    	</tbody>
    </div>
     
    </form>

   
</body>
<script type="text/javascript">
    function xgButtonClick(objValue) {
        //$('#win').html("<iframe width='100%' height='100%' style='_border:none;'  class='myUploadIframe' frameborder='0' src='Importjs1.aspx?xkbh=" + objValue + "' ></iframe>")
        //  $('#win').html(objValue);

        $.post("XiuGaiXSMiMa.aspx", { 'option': "xiuMIMA", 'XsID': objValue }, function (result) {
                if (result == "SaveOK") {
                    alert("保存成功！");
                    window.location.reload();
                }
                else {
                    alert("保存失败！");
                }
            }
            );
        } 
    
    
    $(function () {
        $('#win').window("close");
        // $('#win').window({ onBeforeClose: function () { window.location.reload() } });
    });




    function getSelections() {
        var str = "";
        var rows = $('#mytable').datagrid('getSelections');
        if (rows.length < 1)
            alert("请选择要删除项");
        for (var i = 0; i < rows.length; i++) {
            var row = rows[i];
            str += row.yhbh + ",";
        }
        $.post("XiuGaiXSMiMa.aspx", { 'option': "shanchu", 'idlist': str }, function (result) {
            if (result == "DeleteOK") {
                alert("删除成功！");
                window.location.reload();
            }
            else {
                alert("删除失败！");
            }
        }
            );

    }
</script>
</html>

