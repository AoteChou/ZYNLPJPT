<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="uploadst.aspx.cs" Inherits="ZYNLPJPT.processAspx.uploadst"  validateRequest="false" %>
<%@ Register TagPrefix="Upload" Namespace="Brettle.Web.NeatUpload" Assembly="Brettle.Web.NeatUpload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
   <link rel="stylesheet" type="text/css" href="../Styles/TestPage.css" />
	<link rel="Stylesheet" type="text/css" href="../Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="../Styles/icon.css" /> 
     <script type="text/javascript" src="../Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="../Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="../Scripts/locale/easyui-lang-zh_CN.js"></script>

</head>

<body class="easyui-layout">
<form id="form1" runat="server">
<asp:ScriptManager ID="ScriptManager1" runat="server">
         </asp:ScriptManager>
<div region="center" border="false">
    
 	<div id="content">
    	<div id="ZSDList" >
        	<h1><%=this.kcmc%></h1>
        </div>

    	<h2 style="color:#888888">出题知识点</h2>
    	<ol style="color:#777777">

            <%for (int i = 0; i < this.zsdbh.Length; i++)
              { %>
    		<li><%=zsdbh[i].ToString()%>&nbsp<%=zsdmc[i].ToString()%>&nbsp 比重：<%=ctbz[i].ToString("p") %>%</li>
            <%} %>
    		
    	</ol>
         
  
        <div id="uploadDiv">
             <Upload:InputFile id="inputFileId" runat="server" />
              
     <asp:Button id="submitButtonId" runat="server" Text="上传题目" 
                 OnClientClick="return getFileExt(document.getElementById('inputFileId'))" 
                 onclick="submitButtonId_Click"  /> 
                  
                
             <asp:Button id="submitAnswer" runat="server" Text="上传答案" 
                 OnClientClick="return getFileExt(document.getElementById('inputFileId'))" onclick="submitAnswer_Click" 
               />

               <input type="button" id="download" value="下载题目" onclick="window.location.href='DownloadTest.aspx?stbh=<%=stbh%>'" />   
               
               <br />
            <Upload:ProgressBar id="progressBarId"   runat="server" inline="true" Width="500" Height="50" />
            <Upload:UnloadConfirmer ID="UnloadConfirmer1" runat="server" Text="正在上传文件,确定要离开吗?"> </Upload:UnloadConfirmer>
        </div>
       
         <div id="completeDiv">
           
         <asp:Button id="finishupload" runat="server" Text="完成上传" 
                 onclick="finishupload_Click"/>
               &nbsp; &nbsp;&nbsp; <asp:Button id="goback" runat="server" Text="返回" 
                 onclick="goback_Click" Width="79px" /> 
       </div>
         <p id='opMsg'></p>
    </div>
   
    
</div>
</form>

<script type="text/javascript">
function compare(var1, var2) {
   var array = var1.split(",")
    for (x in array) {
        if (array[x] == var2) {
            return true;
        }
    }
    return false;
  }

function loadXML(filePath) {
    var xmlDoc = '';
    if (window.ActiveXObject) { // IE     
        var activeXNameList = new Array("MSXML2.DOMDocument.6.0", "MSXML2.DOMDocument.5.0", "MSXML2.DOMDocument.4.0", "MSXML2.DOMDocument.3.0", "MSXML2.DOMDocument", "Microsoft.XMLDOM", "MSXML.DOMDocument");
        for (var h = 0; h < activeXNameList.length; h++) {
            try {
         xmlDoc = new ActiveXObject(activeXNameList[h]);
             } catch (e) {
                 continue;
             }
             if (xmlDoc) break;
         }
     } else if (document.implementation && document.implementation.createDocument) { //非 IE  
         xmlDoc = document.implementation.createDocument("", "", null);
     } else {
         alert('can not create XML DOM object, update your browser please...');
     }
     xmlDoc.async = false;  //同步,防止后面程序处理时遇到文件还没加载完成出现的错误,故同步等XML文件加载完再做后面处理  
     xmlDoc.load(filePath); //加载XML
     return xmlDoc
     
 }
 function getSuffixString(filePath) {
     var xmlDoc = loadXML(filePath);
     if (window.ActiveXObject) {
             var nodeList = xmlDoc.documentElement.getElementsByTagName("typestring") // IE
             var num = 1;
             return nodeList[num].childNodes[0].text
         } else {
             var nodeList = xmlDoc.getElementsByTagName("typestring")  // 非IE
             var num = 1;
             return nodeList[num].childNodes[0].nodeValue
         }

 }

  function getFileExt(obj) {
      fileExt = obj.value.substr(obj.value.lastIndexOf(".")).toLowerCase(); //获得文件后缀名
      compString=getSuffixString("./Utility/validatedFileSuffix.xml")
      if (!compare(compString,fileExt) ) {
          alert("请上传后缀名为： "+compString+"  的文件!");
          return false;
      }else{
          $('#opMsg').text('正在上传...请勿关闭本窗口...');
          return true;
      }

  }
 
</script>
</body>
</html>
