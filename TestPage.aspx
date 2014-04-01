<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="ZYNLPJPT.TestPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>XX课程专业能力测评</title>
	<link rel="stylesheet" type="text/css" href="Styles/TestPage.css">
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
</head>

<body class="easyui-layout">


<div region="center" border="false">
 	<div id="content">
    	<div id="ZSDList" >
        	<h1><%=this.stzsdviews[0].KCMC%>•题<%=stbh %></h1>
        </div>
    	<h2 style="color:#888888">涉及的知识点</h2>
    	<ol style="color:#777777">
            <%for (int i = 0; i < stzsdviews.Length; i++)
              { %>
    		<li><%=stzsdviews[i].ZSDMC%>&nbsp<%=stzsdviews[i].ZSDBZ.ToString("p") %></li>
            <%} %>
    		
    	</ol>
        <input type="button"  id="download" name="下载题目"  value="下载题目" /><br />
        <%if (teststate == ZYNLPJPT.Utility.TestState.UNDONETEST)
        { %>
        <input type="file" id="upload" name="提交答案"  value="提交答案" />
        <input type="button"  id="uploadEnsure"  name="上传题目"  value="上传题目" /><br/>
        <p>您还未完成本题 请完成之后在继续做下一题</p>
        <% }else { %> 
        <input type="file" id="upload" style="display:none"   name="提交答案"  value="提交答案" />
        <input type="button"  id="uploadEnsure" style="display:none" name="上传题目"  value="上传题目" /><br/>
        <%} %>
        
        <div id="p" class="easyui-progressbar" style="margin-top:20px; width:400px" ></div>
        <p id='opMsg'></p>
        <input type="button"  id="next" name="下一题" style="display:none" value="下一题" onclick="window.location.href='processAspx/GetTest.aspx?kcbh=<%=stzsdviews[0].Kcbh%>'" />
    </div>
   
    
</div>
<script type="text/javascript">


    $(function () {
        $('#p').hide();
        $('#mytable').datagrid({
            pagination: true,
            //data:[{code:'1',price:'2',name:'dd'}],
            //url:'data.json',
            singleSelect: true
        });
        $('#download').click(function () {
            $('#upload').css('display', 'inline');
            $('#uploadEnsure').css('display', 'inline');
            //$('#p').css('display','inline-block');
        });
        var progressValue = 0;
        var temp = 0;
        $('#uploadEnsure').click(function () {
            $('#p').css('display', 'inline-block');
            $('#p').show();
            while (progressValue <= 100) {
                $('#p').progressbar({
                    value: progressValue
                });
                progressValue++;
            }
            if (progressValue > 100) {
                $('#opMsg').text('已经成功提交答案，请做下一题~');
                $('#next').show();
            }





        });
    });

</script>

</body>

</html>
