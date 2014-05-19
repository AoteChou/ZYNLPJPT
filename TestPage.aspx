<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="ZYNLPJPT.TestPage" %>
<%@ Register TagPrefix="Upload" Namespace="Brettle.Web.NeatUpload" Assembly="Brettle.Web.NeatUpload" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
 <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title><%=this.stzsdviews[0].KCMC%>专业能力测评</title>
<% if(IsPostBack) {
      %>
   <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <link rel="Stylesheet" type="text/css" href="Styles/bootstrap.min.css" /> 
    <link rel="stylesheet" type="text/css" href="Styles/TestPage.css"/>
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/highcharts.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>    
    <%} %>
	

</head>

<body >
<form id="form1" runat="server">

<div id="cc">
    <div id="left">
        <div id="kcmc"><h1><%=this.stzsdviews[0].KCMC%></h1></div>
        <div id="resultDiv">
            <font style="font-size: 15px;">测试进度</font>
            <div id="container" style=" height: 300px; width: 100%; margin: 0 auto"></div>
        </div>
        <div id="sepDiv">
            <table  style="BORDER-LEFT:#C0C0C0 1px solid;" align=center height=500  borderColor=#C0C0C0 >
                <tbody><tr><td></td></tr></tbody>
            </table>
        </div>

    </div>
    <div id="right">
        <div id="content">
            <div id="container1" style=" height:300px; width: 100%; margin: 0 auto;z-index:-1"></div>
            <a  class="btn btn-info" id="download" value="下载题目" onclick="window.location.href='processAspx/DownloadTest.aspx?stbh=<%=stbh %>'" >查看题目</a>
            <a class="btn" id="skip"   value="暂且跳过，以后再做" onclick="window.location.href='processAspx/GetTest.aspx?kcbh=<%=stzsdviews[0].KCBH%>&SFZJT=false'">暂且跳过，以后再做（做新题）</a><br />
            <div id="uploadDiv">
                 <Upload:InputFile id="inputFileId" runat="server"  />
                
                <asp:Button id="submitButtonId" class="btn"  runat="server" Text="确认上传"  OnClientClick="return getFileExt(document.getElementById('inputFileId'))" /><br />
                <font style="position: relative; top: -20px;">上传进度：</font>
                <Upload:ProgressBar id="progressBarId"   runat="server" inline="true" Width="600" Height="50" />
             </div>
             <Upload:UnloadConfirmer ID="UnloadConfirmer1" runat="server" Text="正在上传文件,确定要离开吗?" EnableViewState="True" Visible="False"> </Upload:UnloadConfirmer>

              <p id='opMsg'class="badge badge-info" style="font-size: 13px; padding: 5px 20px; font-weight: normal;"></p>
              <a class="btn btn-success" id="next" name="下一题" style="display:none" value="下一题" onclick="window.location.href='processAspx/GetTest.aspx?kcbh=<%=stzsdviews[0].KCBH%>'" >下一题</a>

          </div>
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
             var num=<%=sfzdyj==true?1:0 %>
             return nodeList[num].childNodes[0].text
         } else {
             var nodeList = xmlDoc.getElementsByTagName("typestring")  // 非IE  
             var num=<%=sfzdyj==true?1:0 %>
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

  function uploadSuccess(){
    document.getElementById('opMsg').innerHTML= '已经成功提交答案，请做下一题~';
    document.getElementById('next').setAttribute('style','diaplay:inline'); 
    document.getElementById('skip').setAttribute('disabled','true');       
    
    }


 $(function () {
  
        $('input[id=inputFileId]').change(function() {  
            $('#fileName').val($(this).val());  
        });  

    <% if(!IsPostBack) {
       if (teststate == ZYNLPJPT.Utility.TestState.UNDONETEST)
      { %>
       $('#opMsg').text('您上次还未完成本题 请完成之后在继续做下一题');
    <%}else{ %>
     $('#uploadDiv').hide();
     <%} 
       }
       %>
        $('#download').click(function () {
            $('#uploadDiv').show()
        }); 

      $('#container').highcharts({
        chart: {
            plotBackgroundColor: null,
            plotBorderWidth: 0,
            plotShadow: false
        },
        title: {
            text: '<font style="font-size:110px;font-family: \'华文细黑\',\'微软雅黑\',\'细明体\',\'黑体\';"><%=(int)(Math.Round(finishratio*100))%></font><span style="font-size:20px;">%</span>',
            align:'center',
            verticalAlign: 'middle',
            y:30
        },
        tooltip:function(){
            return false;
        },
        plotOptions: {
            pie: {
                dataLabels:{
                    enabled:false
                },
                startAngle:-90,
                endAngle:90,
                animation:false
               }
        },
        series: [{
            type: 'pie',
            name: '测试进度',
            innerSize: '99%',
            data: [
                 ['',<%=finishratio*100%>],['',<%=100-finishratio*100%>]
                
            ]
        }]
    });



    $('#container1').highcharts({  
        title: {
            text: '题<%=stbh %>涉及的知识点及其组成'
        },
        tooltip: function(){
            return false;
        },
        plotOptions: {
            pie: {      
                dataLabels: {
                    enabled: true,
                    format: '<b>{point.name}</b>: {point.percentage:.2f} %'
                }
            }
        },
        series: [{
            type: 'pie',
            name: '知识点分布',
            data: [<%=zsdstring %>]
        }]
    });

       
});

</script>

</body>

</html>
