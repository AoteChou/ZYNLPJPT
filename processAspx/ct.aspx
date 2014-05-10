<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ct.aspx.cs" Inherits="ZYNLPJPT.processAspx.ct" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>选择知识点并设置比重</title>
   <link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>

   <script type="text/javascript">

       function getSelections(kcbh, ctr) {
            var zsdbhs=[];                                                            //选择的知识点编号(多个)    
            var zsdbz=[];                                                             //选择的知识点比重
            var rows = $('#mytable').datagrid('getSelections');

            var flag1 = true;                                                         //出题比重是否位于0~100标志位
            var flag2 = true;                                                        //出题比重是否不为空标志位 
            var flag3 = true;                                                        //出题比重是否和为100标志位
            var sum = 0;
            for (var i = 0; i < rows.length; i++) 
            {
                zsdbhs[i] = rows[i].zsdbh;
                var row = rows[i];
                var  index=$('#mytable').datagrid('getRowIndex',row);
                
                zsdbz[i] = $("#ctbz" + index.toString()).val();
               
                if (zsdbz[i] == null||zsdbz[i]==undefined)
                    flag2 = false;
                if (parseFloat(zsdbz[i]) > 100 || parseFloat(zsdbz[i]) < 0)
                 {
                     flag1 = false;
                 }

                 sum += parseFloat(zsdbz[i]);
            }

            if (sum != 100)
                flag3 = false;

            //知识点比重不合理
            if (flag1 == false || flag2 == false || flag3 == false)
             {
                 $.messager.alert('警告', '出题比重非法,请检查后重新设置!');
             }


            //知识点比重合理
            else
             {
                $.post("Set_st_ZSD.aspx", { 'kcbh': kcbh, 'ctr': ctr, 'zsds': zsdbhs, 'zsdbz': zsdbz }, function (result) {
                    if (result == 'False') {
                        $.messager.alert('警告', '必须选择至少选择一个知识点进行出题!');
                    }

                    else {
                        $.messager.confirm('信息', '出题知识点配置成功，单击确认进入出题界面，取消则停留界面!', function (r) {
                            if (r) {

                                // window.location.href = "uploadst.aspx?kcbh="+kcbh+"&zsds[]="+zsdbhs+"&ctr="+ctr+"&zsdbz[]="+zsdbz;
                                window.location.href = "uploadst.aspx?stbh=" + result;

                            }
                            else {
                                //do nothing
                            }
                        });
                    }
                });
            }
    }

     </script>

</head>

 
<body>

  <div region="center" border="false">
      <div style="padding:10px 10px 10px 400px" >
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="window.location.href='../ctRecord.aspx?kcbh=<%=kcbh %>'">返回上页</a>
            <a href="javascript:void(0)" style=" margin-left:50px;" class="easyui-linkbutton"  onclick="getSelections(<%=kcbh%>,'<%=ctr %>')">完成设置</a>
      </div>
 </div>

         <table id="mytable" class="easyui-datagrid"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	    <thead>
    		    <tr>
    			
                <th data-options="field:'sfxzzsd',checkbox:true" width="50" align=center> 是否选择知识点</th>
                <th data-options="field:'zsd'" width="50" align=center>知识点</th>
                 <th data-options="field:'zsdbh'" width="50" align=center>知识点编号</th>
                 <th data-options="field:'zsdy'" width="50" align=center>所属知识单元</th>
                 <th data-options="field:'ctbz'" width="50" align=center>出题比重</th>
                
    		</tr>
    	</thead>
   		
        <tbody >
              <%
                  
                   for (int i = 0; i <this.num_zsd_list; i++)
                   {
                       Response.Write("<tr >");
                       Response.Write("<td><</td>");
                       Response.Write("	<td >" + zsd_list_all[i].ZSDMC+ "</td>");                               //知识点
                       Response.Write("	<td >" + zsd_list_all[i].ZSDBH + "</td>");                               //知识点编号
                       Response.Write("  <td >"  +this.Get_ZSDYModel(zsd_list_all[i].ZSDYBH).ZSDYMC+ "</td>");  //所属知识单元
                       Response.Write(" <td ><input class= easyui-validatebox textbox  type=text  id=ctbz"+i.ToString()+"  name= ctbz  data-options=required:true></input></td>");//出题比重
                       Response.Write("</tr>");
                   } %>
    	</tbody>
   	</table>     
    
    </div>

        <script type="text/javascript">
             $(function () {
                $('#mytable').datagrid({
                 pagination: false,
                 rownumbers:true,
                 pageList: [30],
                 pageSize: 30,
                 singleSelect: false,
                });
            });
        </script>
</body>
</html>
