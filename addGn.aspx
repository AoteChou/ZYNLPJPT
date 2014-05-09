<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addGn.aspx.cs" Inherits="ZYNLPJPT.addGn" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选择功能点新增</title>
   <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
   <script type="text/javascript">

       function getSelections(jsbh) {
           var gnbh = [];                                                            //选择的功能点编号(多个)    
           var rows = $('#mytable').datagrid('getSelections');
           for (var i = 0; i < rows.length; i++) {
               gnbh[i] = rows[i].gnbh;
        }

            $.post("processAspx/addGnProc.aspx", { 'gnbh': gnbh, 'jsbh': jsbh}, function (result) {
                if (result == 'False') {
                    $.messager.alert('警告', '必须选择至少选择一个功能点!');
                }

                else {
                    $.messager.confirm('信息', '为此角色新增功能点配置成功!', function (r) {
                        if (r)
                         {
                            //刷新页面
                            location.reload(false);
                         }
                       else
                       {
                            //do nothing
                        }
                    });
                }
            });

       }

     </script>

</head>

 
<body>

  <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='JsGn.aspx?jsbh=<%=this.jsbh %>'">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=jsbh%>)">完成选择</a>
      </div>
 </div>

         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			
                <th data-options="field:'sfxzgnd',checkbox:true" width="50" align=center> 是否选择功能点</th>
                <th data-options="field:'gnbh'" width="50" align=center>功能点编号</th>
                 <th data-options="field:'gnm'" width="50" align=center>功能点</th>
                 <th data-options="field:'gnlj'" width="50" align=center>功能点链接</th>
                 <th data-options="field:'ssml'" width="50" align=center>所属目录</th>
                
    		</tr>
    	</thead>
   		
        <tbody >
              <%
                   for (int i = 0; i <this.length; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td><</td>");
                       Response.Write("	<td >" +this.gn_list[i].GNBH.ToString()+ "</td>");                                         //功能点编号
                       Response.Write("	<td >" +this.gn_list[i].GNM.ToString() + "</td>");                                        //功能点名
                       Response.Write("  <td >"  +this.gn_list[i].GNLJ.ToString()+ "</td>");                                          //功能链接
                       Response.Write("<td>"+this.gn_list[i].SSML.ToString()+"</td>");                                              //所属目录
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    
    </div>

        <script type="text/javascript">
             $(function () {
                $('#mytable').datagrid({
                 pagination: false,
                 pageList: [30],
                 pageSize: 30,
                 singleSelect: false,
                });
            });
        </script>
</body>
</html>