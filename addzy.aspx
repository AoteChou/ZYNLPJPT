<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addZY.aspx.cs" Inherits="ZYNLPJPT.addZY" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>添加专业</title>
    <link rel="Stylesheet" type="text/css" href="Styles/default/easyui.css" />
    <link rel="Stylesheet" type="text/css" href="Styles/icon.css" />
    <script type="text/javascript" src="Scripts/jquery-1.8.0.min.js"></script>
    <script type="text/javascript" src="Scripts/jquery.easyui.min.js"></script>
    <script type="text/javascript" src="Scripts/locale/easyui-lang-zh_CN.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div style=" margin-left:auto; margin-right:auto; width:400px; margin-top:40px;" >
    <div class="easyui-panel" title="添加专业" style="width:400px;  ">
        <div style="padding:10px 60px 20px 60px">
        <form id="ff" > 
            <table cellpadding="5">
                <tr style=" margin-top:10px;">
                    <td>专业编号:</td>
                    <td> 
                        <select id="zybh" name="zybh" style="width:152px;" >
                            <% for (int i = 0; i < this.zybh.Length; i++)
                               {
                                   Response.Write("<option> " + this.zybh[i] + "</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
               <tr style=" margin-top:10px;">
                    <td>学科编号:</td>
                    <td> 
                        <select id="xkbh" name="xkbh" style="width:152px;" >
                            <% for (int i = 0; i < this.xkbh.Length; i++)
                               {
                                   Response.Write("<option> " + this.xkbh[i] + "</option>");  
                             } %>
                        </select>
                    </td>
                </tr>
                <tr style=" margin-top:10px;">
                    <td>专业名称:</td>
                    <td> 
                        <select id="zym" name="zym" style="width:152px;" >
                            <% for (int i = 0; i < this.zym.Length; i++)
                               {
                                   Response.Write("<option> " + this.zym[i] + "</option>");
                               } %>
                        </select>
                    </td>
                </tr>
               <tr style=" margin-top:10px;">
                    <td>专业负责人:</td>
                    <td><input id="zyfzr" name="zyfzr" style="width:152px;" >
                           
                        </input>
                        </td>
                        </tr>
               
                
            </table>
        </form>
        <div style="text-align:center;padding:5px; margin-top:50px;">
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="submitForm()">提交</a>
            <a href="javascript:void(0)" class="easyui-linkbutton" onclick="clearForm()">取消</a>
        </div>
        </div>    
    </div>
    </div>
    </form>
</body>
</html>
