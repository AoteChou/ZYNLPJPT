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
    public partial class pzjdkc : System.Web.UI.Page
    {
        protected CpjdView[] cpjdViews;

        protected string[] allZyms;

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
                    Response.Redirect("ErrorPage.aspx?msg=对不起，系统配置出错，你没有配置阶段课程的权限&fh=false");
                }
                else
                {
                    string queryZym = null;

                    int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                    allZyms = new ZY_DAL().getArrayByXkbh(xkbh);

                    if (Request["choosedMajor"] == null || Request["choosedMajor"].ToString() == "")
                    {
                        queryZym = allZyms[0];
                    }
                    else
                    {
                        queryZym = Request["choosedMajor"].ToString();
                        List<string> lists = allZyms.ToList();
                        lists.Remove(queryZym);
                        lists.Add(queryZym);
                        lists.Reverse();
                        allZyms = lists.ToArray();
                    }
                   // cpjdViews = new CPJD_DAL().getArray(xkbh,queryZym.Trim());
                    cpjdViews = new CpjdView_DAL().getArray(xkbh, queryZym.Trim());
                }


            }
        }
    }
}