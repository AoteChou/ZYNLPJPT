﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class ct : System.Web.UI.Page
    {
        protected ZYKCView[] zykcViews;

        protected string[] allZyms;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                YH yh = (YH)Session["yh"];
                string queryZym = null;
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                allZyms = new ZY_DAL().getArrayByXkbh(xkbh);
                if (Request["choosedMajor"] == null||Request["choosedMajor"].ToString()=="")
                {
                    queryZym = allZyms[0];
                }
                else {
                    queryZym = Request["choosedMajor"].ToString();
                    List<string> lists=allZyms.ToList();
                    lists.Remove(queryZym);
                    lists.Add(queryZym);
                    lists.Reverse();
                    allZyms = lists.ToArray();
                }
                zykcViews=new ZYKCView_DAL().GetArray("xkbh="+xkbh+" and zym='"+queryZym.Trim()+"'");
            }
        }
    }
}