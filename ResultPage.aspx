<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="ZYNLPJPT.ResultPage" %>

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
    			<th data-options="field:'cpjlbh'" width="50">测评记录编号</th>
                <th data-options="field:'stbh'" width="50">试题编号</th>
                <th data-options="field:'xzrq'" width="50">下载日期</th>
                <th data-options="field:'scrq'" width="50">上传日期</th>
                <th data-options="field:'gtr'" width="50">改题人</th>
                <th data-options="field:'pfcs'" width="20">评测分数</th>
                <th data-options="field:'xzst'" width="40"></th>
                <th data-options="field:'xzwdda'" width="50"></th>
    			
    		</tr>
    	</thead>
   		
   	</table>     
</div>
<div id="win">
</div>
 
</form>               
<script type="text/javascript">

    
    $(function () {
        $('#mytable').datagrid({
            pagination: true,
            singleSelect: true,
            url: 'processAspx/getPCFSByKcbhAndYhbh.aspx',
            queryParams:{
                xsbh:<%=xsbh %>,
                kcbh:<%=kcbh %>
            },
            method:"post",
            onLoadSuccess:function(data){
            if(data.total==0){
             window.location.href="./ErrorPage.aspx?msg=同学...该课程下还没有成绩,请关闭此标签页&gb=true";
            }
            $('.easyui-linkbutton').linkbutton({
                plain: false
            });
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