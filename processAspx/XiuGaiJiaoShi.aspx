<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XiuGaiJiaoShi.aspx.cs" Inherits="ZYNLPJPT.processAspx.XiuGaiJiaoShi" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<head id="Head1" runat="server">
    <title>管理教师用户</title>
    <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
    <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body class="easyui-layout">
    <form id="form" action="JiaoShiXiuGai.ashx"  method="post">
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
                 <th data-options="field:'llxf',editor:{type:'numberbox',options:{precision:2}}" width="50">密码</th>
                 <th data-options="field:'xm',align:'center'" width="55">姓名</th>
                 <th data-options="field:'xb',align:'center'" width="50">性别</th>
                 <th data-options="field:'sfsxkfzr',align:'center'" width="55">是否是学科负责人</th>  
                 <th data-options="field:'sfskcfzr',align:'center'" width="55">是否是课程负责人</th> 
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
                      Response.Write("	<td >" + mm[i] + "</td>");
                      Response.Write("  <td >" + xm[i] + "</td>");
                      Response.Write("	<td >" + xb[i] + "</td>");
                      Response.Write("	<td >" + sfsxkfzr[i] + "</td>");
                      Response.Write("	<td >" + sfskcfzr[i] + "</td>");
                      Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"xgButtonClick('" + yhbh[i] + "')\" >修改</a></td>");                                           
                      Response.Write("</tr>");
                      
                  }
                   %>
    	</tbody>
    </div>
     <div id="win" class="easyui-window" data-options="title: ' 修改密码',width:'600',
            height: '400',
            modal:' true',
            collapsible:' false',
            minimizable:' false'" style="text-align:center;">
  
            输入新密码<input id="newpassword1" type="password" /><br/>
            确认新密码 <input id="newpassword2" type="password" /><br/>
            <input type="button" value="提交" onclick="contrast()" /><br/>
            <input id="jsID" type="hidden" />

    </div>
    </form>

   
</body>
<script type="text/javascript">
    function contrast() {
        newpassword1 = document.getElementById("newpassword1").value.toString().trim();
        newpassword2 = document.getElementById("newpassword2").value.toString().trim();
        if (newpassword1 == null || newpassword1 == "" ) { 
            $.messager.alert('警告', "密码不能为空！");
        }else if(newpassword1 == newpassword2) {
            var dd=document.getElementById("jsID").value.toString();
            $.post("XiuGaiJiaoShiMiMa.aspx", { 'option': "xiuMIMA", 'JsID': dd, 'password': newpassword1 }, function (result) {
                if (result == "SaveOK") {
                    alert("保存成功！");
                    window.location.reload();
                }
                else {
                    alert("保存失败！");
                }
            }
            );




        }else {
            alert("密码不一致！");
            return false;
        }
    }
    function xgButtonClick(objValue) {
        //$('#win').html("<iframe width='100%' height='100%' style='_border:none;'  class='myUploadIframe' frameborder='0' src='Importjs1.aspx?xkbh=" + objValue + "' ></iframe>")
        //  $('#win').html(objValue);
        $('#win').window("open");
        document.getElementById("jsID").value=objValue;
    }
    $(function () {
        $('#win').window("close");
       // $('#win').window({ onBeforeClose: function () { window.location.reload() } });
    });




    function getSelections() {
        var str = "";
        var rows = $('#mytable').datagrid('getSelections');
        if (rows.length < 1)
            alert("木有");
      for (var i = 0; i < rows.length; i++) {
          var row = rows[i];
          str += row.yhbh + ",";
      }
      $.post("XiuGaiJiaoShiMiMa.aspx", { 'option': "shanchu", 'idlist': str }, function (result) {
          if (result == "DeleteOK") {
              alert("删除成功！");
              window.location.reload();
          }
          else {
              alert("删除操作失败！（全部或部分操作未成功）");
          }
      }
            );

    }
</script>
</html>

