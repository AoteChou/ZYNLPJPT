<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Importjs1.aspx.cs" Inherits="ZYNLPJPT.Importjs1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>导入</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" /> 
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
    <form  method="post" runat="server">
    <div>
        <div id="ResultDiv">
        </div>
        <asp:FileUpload id="fileInput" runat="server" />
       <asp:Button id="import" runat="server" Text="导入" Height="21px" OnClick="Import_Clicked" />
    </div>
    </form>
</body>
<script type="text/javascript">

    $(function () {

        $("#import").click(function () {
            var fileName = $(fileInput).attr("value");
            var fileExt = fileName.substr(fileName.lastIndexOf(".")).toLowerCase(); //获得文件后缀名
            if (fileExt != '.xls' && fileExt != '.xlsx')//检查是否是Excel文件
            {
                $.messager.alert('', '请导入Excel文件', 'info');
                return false;
            }

        });
   });

</script>
</html>

