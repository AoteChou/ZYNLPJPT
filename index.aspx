<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="ZYNLPJPT.index" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta http-equiv="content-type" content="text/html; charset=UTF-8" />
    <title>专业能力评价系统</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <link rel="Stylesheet" type="text/css" href="Styles/index.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
   </head>
<body class="easyui-layout">

	<div data-options="region:'north',border:false" style="height:80px;background:url('./Styles/bar4.jpg');padding:10px;overflow:hidden;">
      		<h1 style="color:#ECFEFF;display:inline-block; font-family: '华文细黑','微软雅黑', '造字工房悦黑体验版纤细体', 'Times New Roman'; float:left;"></h1>
         	<h3 style="float:right;color:white;"><%= ((ZYNLPJPT.Model.YH)Session["yh"]).XM.Trim() %> 欢迎登陆! 当前时间：<span id="time">2013/3/3 12:00:21 </span> <a href="processAspx/logout.aspx" class="easyui-linkbutton" >退出</a></h3>
    </div>

	<div data-options="region:'west',split:true,noheader:true" style="width:200px">
    	    <div id="aa" class="easyui-accordion" data-options="fit:true,border:false">
            <%  for (int i = 0; i < this.menus.Length; i++) {

                    if (i == 0)
                    {
                        Response.Write("<div title=\"" + menus[i].MenuName + "\" style=\"overflow:auto;padding:10px;\"> ");
                    }
                    else {
                        Response.Write("<div title=\"" + menus[i].MenuName + "\" style=\"padding:10px;\"> ");
                    }

                    for (int j = 0; j < menus[i].ItemMenu.Length; j++) {
                        Response.Write("<li><a href=\"javascript:void(0)\" onclick=\"addTab('" + menus[i].ItemMenu[j].MenuName + "','" + "./" + menus[i].ItemMenu[j].MenuContent + "')\">" + menus[i].ItemMenu[j].MenuName + "</a></li>");
                    }

                    Response.Write("</div>");
           }  %>

         </div>
    </div>
    
	<div data-options="region:'south',border:false" style="height:20px;background:#E6EEF8;padding:10px;">
    </div>

	<div data-options="region:'center',title:'Center',noheader:true,border:'false'">
    	<div id="tabs" class="easyui-tabs" data-options="fit:true,plain:true,border:false">
        	<div title="Tab1" style="padding:20px;display:none;">
			tab1
			</div>
    	</div>
    </div>
<script type="text/javascript">
    var index = 0
    function addTab(title, url) {
        var tab = $('#tabs').tabs('exists', title);
        if (tab) {
            //存在的话 打开
            //$('#tabs').tabs('select', title);
            $('#tabs').tabs('close', title);
            openTab(title,url);
        } else {
            //不存在的话 新建一个
            index++;
            $("#tabs").tabs('add', {
                title: title,
                content: "<iframe width='100%' height='100%' style='_border:none;'  class='myIframe' frameborder='0' scrolling='no'  src='" + url + "' name='" + title + "'></iframe>",
                closable: true
            });
        }
    }

    function openTab(title,url) {
        $("#tabs").tabs('add', {
            title: title,
            content: "<iframe width='100%' height='100%' style='_border:none;'  class='myIframe' frameborder='0' scrolling='no'  src='" + url + "'></iframe>",
            closable: true
        });
    }
    function closeTab(title) {
        $('#tabs').tabs('close', title);
    }

    // (new Date()).Format("yyyy-MM-dd hh:mm:ss.S") ==> 2006-07-02 08:09:04.423 
    // (new Date()).Format("yyyy-M-d h:m:s.S")      ==> 2006-7-2 8:9:4.18 
    Date.prototype.format = function (fmt) { 
        var o = {
            "M+": this.getMonth() + 1,                 //月份 
            "d+": this.getDate(),                    //日 
            "h+": this.getHours(),                   //小时 
            "m+": this.getMinutes(),                 //分 
            "s+": this.getSeconds(),                 //秒 
            "q+": Math.floor((this.getMonth() + 3) / 3), //季度 
            "S": this.getMilliseconds()             //毫秒 
        };
        if (/(y+)/.test(fmt))
            fmt = fmt.replace(RegExp.$1, (this.getFullYear() + "").substr(4 - RegExp.$1.length));
        for (var k in o)
            if (new RegExp("(" + k + ")").test(fmt))
                fmt = fmt.replace(RegExp.$1, (RegExp.$1.length == 1) ? (o[k]) : (("00" + o[k]).substr(("" + o[k]).length)));
        return fmt;
    }

    function tickTock(time) {
        var date = new Date().format("yyyy/MM/dd hh:mm:ss"); 
        $("#time").html(date);
        setTimeout("tickTock()", 1000);
    }

    $(function () {

        tickTock();
        $('body').layout({ resize: function () { alert("!!")} });
        //$('#aa').accordion('getSelected');
    });
</script>
</body>
</html>
