using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class pzkczsdy : System.Web.UI.Page
    {
        protected KCDetailView[] kcDetailViews;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)Session["yh"];
                //验证用户是否是教师角色,无则没有配置权限
                YHJSView yhjsView = new YHJSView_DAL().GetModel(yh.YHBH.Trim());
                if (yhjsView.JSM.Trim() != "教师")
                {
                    Response.Redirect("ErrorPage.aspx?msg=对不起，系统配置出错，你没有配置课程知识单元的权利&fh=false");
                }
                else
                {
                    int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                    //xyXkZyViews = new XyXkZyView_DAL().getArray(xkbh);
                    kcDetailViews = new KCDetailView_DAL().getArray(xkbh);
                }
            }
        }
    }
}