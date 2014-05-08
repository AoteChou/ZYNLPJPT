<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getResult_YJZB.aspx.cs" Inherits="ZYNLPJPT.getResult_YJZB" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>


<body class="easyui-layout">
<form id="form1" runat="server">

<div region="center" border="false">
  <table id="mytable"  fit="true" data-options="fitColumns:true" style="border:none;" border="false">
    	<thead>
    		<tr>
            
                <th data-options="field:'yjzbmc'" width="50">一级指标名称</th>
                <th data-options="field:'yjzbfs'" width="20">一级指标分数</th>
    			
    		</tr>
    	</thead>
   	</table>     
</div>

 
</form>               
<script type="text/javascript">
    $(function () {
       

       
        $('#mytable').datagrid({
            pagination: true,
            singleSelect: true,
            rownumbers: true,
            url: 'processAspx/getYJZBByYHBH.aspx',
            queryParams:{
            xsbh:<%=xsbh %>
            },
            method:"post",
            onLoadError:function(){
                $.messager.show({
                    title:'加载失败',
                    msg:'加载失败，请重试'
                    });
            }
        });
       
        



    });

</script>

</body>

</html>