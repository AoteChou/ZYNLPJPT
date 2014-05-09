<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="getResult_ZSD.aspx.cs" Inherits="ZYNLPJPT.getResult_ZSD" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>获取知识点分数</title>
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
            
                <th data-options="field:'zslymc'" width="50">知识领域名称</th>
    			<th data-options="field:'zsdymc'" width="50">知识单元名称</th>
                <th data-options="field:'zsdmc'" width="50">知识点名称</th>
                <th data-options="field:'zsdfs'" width="20">知识点分数</th>
    			
    		</tr>
    	</thead>
   		<tbody >
           
    		
              
          
            
            
    	</tbody>
   	</table>     
</div>

 
</form>               
<script type="text/javascript">
    function mergeGridColCells(grid, rowFildName) {
        var rows = grid.datagrid('getRows');
        //alert(rows.length);  
        //alert(rows[1][rowFildName]);  
        var startIndex = 0;
        var endIndex = 0;
        if (rows.length < 1) {
            return;
        }
        $.each(rows, function (i, row) {
            if (row[rowFildName] == rows[startIndex][rowFildName]) {
                endIndex = i;
            }
            else {
                grid.datagrid('mergeCells', {
                    index: startIndex,
                    field: rowFildName,
                    rowspan: endIndex - startIndex + 1
                });
                startIndex = i;
                endIndex = i;
            }

        });
        grid.datagrid('mergeCells', {
            index: startIndex,
            field: rowFildName,
            rowspan: endIndex - startIndex + 1
           
        });
    }
    $(function () {
       

       
        $('#mytable').datagrid({
            pagination: true,
            singleSelect: true,
            rownumbers: true,
            url: 'processAspx/getZSDByYHBH.aspx',
            queryParams:{
            xsbh:<%=xsbh %>
            },
            method:"post",
            onLoadSuccess:function(data){
                mergeGridColCells($('#mytable'), 'zslymc');
                mergeGridColCells($('#mytable'), 'zsdymc');
            },
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