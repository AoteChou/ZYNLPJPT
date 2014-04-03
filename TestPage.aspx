<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="ZYNLPJPT.TestPage" %>
<%@ Register TagPrefix="Upload" Namespace="Brettle.Web.NeatUpload" Assembly="Brettle.Web.NeatUpload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=this.stzsdviews[0].KCMC%>专业能力测评</title>
	<link rel="stylesheet" type="text/css" href="Styles/TestPage.css">
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>

</head>

<body class="easyui-layout">
<form id="form1" runat="server">

<div region="center" border="false">
 	<div id="content">
    	<div id="ZSDList" >
        	<h1><%=this.stzsdviews[0].KCMC%>•题<%=stbh %></h1>
        </div>
    	<h2 style="color:#888888">涉及的知识点</h2>
    	<ol style="color:#777777">
            <%for (int i = 0; i < stzsdviews.Length; i++)
              { %>
    		<li><%=stzsdviews[i].ZSDMC%>&nbsp<%=stzsdviews[i].ZSDBZ.ToString("p")%></li>
            <%} %>
    		
    	</ol>
        <asp:Button  runat="server" id="download" Text="下载题目" onclick="download_Click" />
        <input type="button"  id="skip"   value="暂且跳过，以后再做" onclick="window.location.href='processAspx/GetTest.aspx?kcbh=<%=stzsdviews[0].KCBH%>&SFZJT=false'"/><br />
        <div id="uploadDiv">
             <Upload:InputFile id="inputFileId" runat="server" />
            <asp:Button id="submitButtonId" runat="server" Text="上传题目" OnClientClick="return getPhotoExt(document.getElementById('inputFileId'))"  /><br />
            <Upload:ProgressBar id="progressBarId"   runat="server" inline="true" Width="600" Height="50" />
            <Upload:UnloadConfirmer ID="UnloadConfirmer1" runat="server" Text="正在上传文件,确定要离开吗?"> </Upload:UnloadConfirmer>
        </div>
       
         <p id='opMsg'></p><br/>
        <input type="button"  id="next" name="下一题" style="display:none" value="下一题" onclick="window.location.href='processAspx/GetTest.aspx?kcbh=<%=stzsdviews[0].KCBH%>'" />
    </div>
   
    
</div>
</form>

<script type="text/javascript">
   
  function getPhotoExt(obj) {
      photoExt = obj.value.substr(obj.value.lastIndexOf(".")).toLowerCase(); //获得文件后缀名
      console.log(photoExt);
      <%if(sfzdyj){
      Response.Write("自动阅卷");
      } %>
      if (photoExt != '.doc' && photoExt != '.docx' ) {
          alert("请上传word文档!");
          return false;
      }else{
          $('#opMsg').text('正在上传...请勿关闭本窗口...');
          return true;
      }

  }



$(function () {

    <%if (teststate == ZYNLPJPT.Utility.TestState.UNDONETEST)
      { %>
       
       $('#opMsg').text('您上次还未完成本题 请完成之后在继续做下一题');
    <%}else{ %>
       $('#uploadDiv').hide();
     <%} %>

        $('#download').click(function () {
             $('#uploadDiv').show();
             
        });
      
       
        
});

</script>

</body>

</html>
