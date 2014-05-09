<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ctRecord.aspx.cs" Inherits="ZYNLPJPT.ctRecord" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" >
     function newST(kcbh)
      {
      
        window.location.href="processAspx/ct.aspx?kcbh="+kcbh;
      }
    </script>
</head>

<body class="easyui-layout">
    <div region="center" border="false">
       
      <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='addst.aspx'">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="newST(<%=this.kcbh%>)">新出试题</a>
      </div>
    </div>
     <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
    			<th data-options="field:'kcmc'" width="50" align=center>试题编号</th>
                <th data-options="field:'kcbh'" width="50" align=center>所属课程</th>
                <th data-options="field:'sszy'" width="50" align=center>是否自动阅卷</th>
                <th data-options="field:'kcxz'" width="50" align=center>是否已设比重</th>
                <th data-options="field:'ctr'" width="50" align=center>是否已上传</th>
    			<th data-options="field:'ct',align:'center'" width="50" align=center>开始出题</th>
        	</tr>
    	</thead>
   		<tbody >
  
   <%
       for (int i = 0; i < this.st_list_length; i++)
       {
           Response.Write("<tr >");
           Response.Write("	<td >" + st_list[i].STBH + "</td>");                          //试题编号
           Response.Write("	<td >" + this.get_kcmc(st_list[i].KCBH) + "</td>");  //课程名称

           if (st_list[i].SFZDYJ)
               Response.Write("<td>是</td>");
           else
               Response.Write("<td>否</td>");
           
           if (this.if_Set_ZSDBZ(st_list[i]))                                                                //已设比重
           {
               Response.Write("  <td >是</td>");
        
               if (this.st_list[i].SFSC==true)                                                                         //是否已经上传
               {
                   Response.Write("<td>是</td>");
               }
               else                                                                                                    //设置比重但还未上传试题
               {
                   Response.Write("  <td >否</td>");
                   Response.Write("  <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/uploadst.aspx?stbh=" + this.st_list[i].STBH + "'\" >上传试题</a></td>");
               }
           }
           
           else                                                                                                       //未设比重
           {
               Response.Write("  <td >否</td>");
               Response.Write(" <td><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"window.location.href='processAspx/ct.aspx?stbh='\" >设置比重</a></td>");
           }

              Response.Write("</tr>");
       
       }
       
   %>
            </tbody>
    </table>
     </div>

     <script type="text/javascript">
    $(function () {
        $('#mytable').datagrid({
            pagination: false,
            //data:[{code:'1',price:'2',name:'dd'}],
            pageList: [30],
            pageSize: 30,
            //url: 'processAspx/ctrData.aspx',
            singleSelect: true,
        });
    });
</script>
    </body>
</html>
