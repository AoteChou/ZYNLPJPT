<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="gt.aspx.cs" Inherits="ZYNLPJPT.processAspx.gt" %>
<%@ Register TagPrefix="Upload" Namespace="Brettle.Web.NeatUpload" Assembly="Brettle.Web.NeatUpload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="Styles/TestPage.css">
	<link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <style type="text/css">
        #goback
        {
            width: 86px;
        }
        #download
        {
            width: 75px;
        }
    </style>
</head>

<body class="easyui-layout">
<form runat="server" id="form1">
<div region="center" border="false">
 	<div id="content">
    	<div id="ZSDList" >
        	<h1><%=this.kcmc.ToString()%>•题<%=this.pcjl.STBH.ToString()%></h1>
        </div>
    	<h2 style="color:#888888">涉及的知识点</h2>
    	<ol style="color:#777777">
            <%for (int i = 0; i <this.length; i++)
              { %>
    		<li><%=stzsdb[i].ZSDBH%>&nbsp<%=new ZYNLPJPT.DAL.ZSD_DAL().GetModel(stzsdb[i].ZSDBH).ZSDMC.ToString()%>&nbsp比重：<%=stzsdb[i].ZSDBZ.ToString()+"%" %></li>
            <%} %>
    		
    	</ol>
        <input type="button" id="download" value="下载题目" onclick="window.location.href='processAspx/DownloadTest.aspx?stbh=<%=stbh%>'" />
       &nbsp&nbsp  
        <input type="button" id="goback" value="返回上页" onclick="window.location.href='markst.aspx'" />
        <br/>
        <br />
    <div id="dfdiv" name="df">
        得分:<asp:TextBox ID="score_TextBox" runat="server" Width="123px"></asp:TextBox>&nbsp&nbsp
        <asp:Button ID="Button1" runat="server" Text="打分" onclick="Button1_Click" 
            Width="87px" />  
    </div>
    </form>
</body>
</html>
