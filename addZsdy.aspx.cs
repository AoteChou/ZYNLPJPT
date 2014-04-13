using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class addZsdy : System.Web.UI.Page
    {
        protected int xkbh;

       // protected string[] yjzbNames;

        protected string[] zslyNames;

        //protected string[] ejzbNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                //验证用户是否是教师角色,无则没有添加知识领域权限
                YHJSView yhjsView = new YHJSView_DAL().GetModel(yh.YHBH.Trim());
                if (yhjsView.JSM.Trim() != "教师")
                {
                    Response.Redirect("ErrorPage.aspx?msg=对不起，系统配置出错，你没有添加知识领域的权利&fh=false");
                }
                else
                {
                    xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                  //  yjzbNames = new YJZB_DAL().getArrayByXkbh(xkbh);
                    zslyNames = new ZSLY_DAL().getArrayByXkbh(xkbh);
                    //ejzbNames=new NLZBView_DAL().getArrayByXkbhAndYjzb(xkbh,yjzbNames[0]);
                }
            }            
        }
    }
}