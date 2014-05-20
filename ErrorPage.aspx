<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Errorpage.aspx.cs" Inherits="ZYNLPJPT.Errorpage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <hr />
    <% if (fh == true)
       { %>
    <span id="second"></span>秒之后自动返回，或者直接点击<a href="javascript:void(0)" onclick="history.back(-1)">返回</a>
    <%} %>
    <% if (gb == true)
       { %>
    <span id="second2"></span>秒之后自动关闭，或者直接关闭标签
    <%}%>
       
    </div>
    </form>

 <% if (fh == true)
     { %>
<script type="text/javascript">

    function timedown(time) {
        if (time == 'undefined')
            time = 5;
        $("#second").html(time);

        time = time - 1;
        if (time >= 0) {
            setTimeout("timedown(" + time + ")", 1000);
        } else { 
       
        history.back(-1)

        } 

    }
    $(function () {

       timedown(10)
    
    });
</script>
<%}else{%>


<script type="text/javascript">

    function timedown(time) {
        if (time == 'undefined')
            time = 5;
        $("#second2").html(time);

        time = time - 1;
        if (time >= 0) {
            setTimeout("timedown(" + time + ")", 1000);
        } else {

            var title = self.frameElement.getAttribute("name");
            window.parent.closeTab(title);
       
        } 

    }
    $(function () {

       timedown(10)
    
    });
</script>
        
 <%}%>
</body>
</html>
