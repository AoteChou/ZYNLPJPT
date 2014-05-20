<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Export_Result_Excel.aspx.cs" Inherits="ZYNLPJPT.Export_Result_Excel" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="Styles/bootstrap.min.css" /> 
    <link rel="Stylesheet" type="text/css" href="Styles/exp_rel_excel.css" /> 
     <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/bootstrap.min.js"></script>   
</head>
<body >
    <form id="form1" action="processAspx/export_Result.aspx" method="post" runat="server">
    <div id="cc">
    <div class="page-header">
        <h1> 选择需要导出的分数列表</h1>
    </div>
    <div class="span4">
    	<h3>知识体系分数</h3>
        <label class="checkbox">
            <input type="checkbox" value="1" name="item1" checked="checked"/>
            知识领域分数
        </label>
        <label class="checkbox">
            <input type="checkbox" value="2" name="item2" checked="checked"/>
            知识单元分数
        </label>
        <label class="checkbox">
            <input type="checkbox" value="3" name="item3" checked="checked"/>
            知识点分数
        </label>
    </div>
    <div class="span4">
    	<h3>专业能力分数</h3>
        <label class="checkbox">
            <input type="checkbox" value="4" name="item4" checked="checked"/>
            一级指标分数
        </label>
        <label class="checkbox">
            <input type="checkbox" value="5" name="item5" checked="checked"/>
            二级指标分数
        </label>
    </div>
    <div class="span4">
    	<p>请选择需要导出的项目，系统将为您生成相应的Excel文件</p>
        <button id="download" class="btn btn-primary" >导出</button>
        <img id="loading" src="Styles/Preloader_2.gif" alt="" style=" display:none;"/>
    </div>
    </div>
    </form>
</body>
<script type="text/javascript">
    function getExportState() {
        $.ajax({ url: "processAspx/getExportState.aspx",
            type: "post",
            async: false,
            success: function (data) {
                if (data != "True") {
                    setTimeout("getExportState()", 1000);
                } else {
                    $('#download').attr("class", "btn btn-primary");
                    $('#download').removeAttr("disabled");
                    $('#download').html("导出");
                    $('#loading').css("display","none"); 
                }
            },
            error: function () {
                setTimeout("getExportState()", 1000);
            }
        });
        
    }
    $(function () {

        $("input:checked").click(function () {
            var checkedNum = $("input:checked").length;
            if (checkedNum == "0") {
                $('#download').attr("class", "btn btn-primary disabled");
                $('#download').attr("disabled", "disabled");
            } else {
                $('#download').attr("class", "btn btn-primary");
                $('#download').removeAttr("disabled");
            }
        });

        //var checkedArray = new Array();

        $('#download').click(function () {
           
            getExportState();
            $('#download').attr("class", "btn btn-primary disabled");
            $('#download').attr("disabled", "disabled");
            $('#download').html("导出中....系统需要一段时间为您统计分数，请等待");
            $('#loading').css("display", "block");
            $('#form1').submit();
        });

        /*$('#download').click(function () {
        $.ajax({ url: "processAspx/export_Result.aspx",
        type: "post",
        data:checked=checkedArray,
        success: function (data) {
                    
        },
        error: function () { 
        }
        });

        });
        $('#download').click(function () {
        var form = $("<form>");
        form.attr('style', 'display:none');
        form.attr('target', '');
        form.attr('method', 'post');
        form.attr('action', 'processAspx/export_Result.aspx');

        var input1 = $('<input>');
        input1.attr('type', 'hidden');
        input1.attr('name', 'checked');
        var valueTemp;
        $("input:checked").each(function (i, obj) {
        valueTemp += obj.value + ",";
        });
        input1.attr('value', valueTemp);

        $('body').append(form);
        form.append(input1);

        form.submit().remove();

        });*/



    });

</script>
</html>
