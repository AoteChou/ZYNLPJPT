﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class xgxkData : System.Web.UI.Page
    {
        protected int xybh;

        protected string xymc;

        protected int xkbh;

        protected string xkmc;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                xymc = Request["xymc"] == null ? "" : Request["xymc"].ToString();
                xybh = int.Parse(Request["xybh"]);
                xkmc = Request["xkmc"] == null ? "" : Request["xkmc"].ToString();
                xkbh = int.Parse(Request["xkbh"]);
            }
        }
    }
}