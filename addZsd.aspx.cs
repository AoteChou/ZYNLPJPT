using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class addZsd : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] zslyNames;

        protected string[] zsdyNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                //验证用户是否是教师角色,无则没有添加知识点权限
                YHJSView yhjsView = new YHJSView_DAL().GetModel(yh.YHBH.Trim());
                if (yhjsView.JSM.Trim() != "教师")
                {
                    Response.Redirect("ErrorPage.aspx?msg=对不起，系统配置出错，你没有添加知识领域的权利&fh=false");
                }
                else
                {
                    xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                    zslyNames = new ZSLY_DAL().getArrayByXkbh(xkbh);
                    if (zslyNames.Length > 0)
                    {
                        zsdyNames = new ZSTXView_DAL().getArrayByXkbhAndYjzb(xkbh, zslyNames[0]);
                    }
                    else { 
                        zsdyNames=new string[0];
                    }
                    
                }
            }            
        }
    }
}