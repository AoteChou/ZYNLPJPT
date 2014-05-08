<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="markst.aspx.cs" Inherits="ZYNLPJPT.markst" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>

    <script type="text/javascript">

        function getSelected() {
            var pcjlbh,stbh, xsbh, gtr, scrq, xzrq;

            var row = $('#mytable').datagrid('getSelected');
            pcjlbh = row.pcjlbh;  //评测记录编号
            stbh = row.stbh;      //试题编号
            xsbh = row.xsbh;    //学生编号
            gtr = row.gtr;         //改题人
            scrq = row.scrq;    //上传日期
            xzrq = row.xzrq;   //下载日期

            $.post("processAspx/gtData.aspx", { 'pcjlbh': pcjlbh, 'stbh': stbh, 'xsbh': xsbh, 'gtr': gtr, 'scrq': scrq, 'xzrq': xzrq }, function (result) {

                if (result == 'False') {
                    $.messager.alert('警告', '必须选择至少选择一道题批改!');
                }

                else {
                    $.messager.confirm('选择成功！', '点击确认进入改题 页面，点击取消返回上一页 ', function (r) {
                        if (r) {
                            window.location.href = "gt.aspx?pcjlbh=" + pcjlbh.toString();

                        }
                        else {
                            history.back(-1);
                        }
                    });
                }
            });
        }

    </script>

</head>
<body>
    <form id="form1" runat="server">

    <div>
    <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
                <th data-options="field:'pcjlbh'" width="50" align=center>评测记录编号</th>
    	        <th data-options="field:'stbh'" width="50" align=center>试题编号</th>
                <th data-options="field:'kcbh'"width="50" align=center>所属课程</th>
                <th data-options="field:'xsbh'"width="50" align=center>做题学生</th>
                <th data-options="field:'xzrq'" width="50" align=center>下载日期</th>
                <th data-options="field:'scrq'" width="50" align=center>上传日期</th>
                <th data-options="field:'gtr'"   width="50" align=center>改题人</th>
                <th data-options="field:'fs'"     width="50" align=center>分数</th>  
                <th data-options="field:'gt'"    width="50" align=center>改题</th>
                </tr>
    	     </thead>
   	
      <tbody>
              <%
                  
                  
                   for (int i = 0; i <this.GTView_list.Length; i++)
                   {
                       
                       Session["GTView"] = GTView_list[i];
                       Response.Write("<tr >");
                       Response.Write("	<td >" + this.GTView_list[i].PCJLBH.ToString() + "</td>");                          //评测记录编号
                       Response.Write("	<td >" +this.GTView_list[i].STBH.ToString()+ "</td>");                               //试题编号
                       Response.Write("	<td >" + this.get_kcmc(GTView_list[i]).ToString()+ "</td>");                      //所属课程
                       Response.Write("  <td >"  +this.GTView_list[i].XSBH.ToString()+ "</td>");                              //做题学生
                       Response.Write("<td>"+this.GTView_list[i].XZRQ.ToShortDateString()+"</td>");                    //下载日期
                       Response.Write("<td>" + this.GTView_list[i].SCRQ.ToString()+"</td>");                                 //上传日期(可空)
                       Response.Write("<td>" + this.get_ctrxm(GTView_list[i]).ToString()+ "</td>");                       //改题人

                       if (GTView_list[i].PCFS != null)
                       {
                           Response.Write("<td>" + this.GTView_list[i].PCFS.ToString() + "</td>");                                    //分数
                           Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected()\" >重改</a></td>");
                       }
                       else
                       {
                           Response.Write("<td>未打分</td>");
                           Response.Write(" <td ><a id=\"A1\" href=\"javascript:void(0)\" class=\"easyui-linkbutton\" style=\"margin-top:10px; margin-bottom:10px;\" onclick=\"getSelected()\" >改题</a></td>");
                    
                       }
                       Response.Write("</tr>");
                       
                   }
                  
                %>

    	</tbody>
   	</table>     
     
    </div>
    </form>
</body>
</html>
