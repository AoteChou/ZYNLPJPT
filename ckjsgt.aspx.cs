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
    public partial class ckjsgt : System.Web.UI.Page
    {
        protected string[] allNjNames;

        protected JDKCView[] jdkcViews;

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
                    Response.Redirect("ErrorPage.aspx?msg=对不起，系统配置出错，你没有配置改题人的权利&fh=false");
                }
                else
                {
                    string queryNjName = null;

                    int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                    //指定义显示年级的范围，如2010年只显示2010级到2014年级的所有阶段及阶段课程
                    allNjNames = new NJ_DAL().getArray();
                    if (Request["choosedNjName"] == null || Request["choosedNjName"].ToString() == "")
                    {
                        queryNjName = allNjNames[0];
                    }
                    else
                    {
                        queryNjName = Request["choosedNjName"].ToString();
                        List<string> lists = allNjNames.ToList();
                        lists.Remove(queryNjName);
                        lists.Add(queryNjName);
                        lists.Reverse();
                        allNjNames = lists.ToArray();
                    }
                    jdkcViews = new JDKCView_DAL().getCKAndSCArrayByNjNameAndXkbh(xkbh, queryNjName);
                }
            }
        }
    }
}