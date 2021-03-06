﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;
using System.Threading;
namespace ZYNLPJPT
{
    public partial class addYHGn : System.Web.UI.Page
    {
        protected string yhbh;
        protected GND[] gn_list;
        protected YHGNB[] yhgn_list;
        protected int length;

        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh_str = Request["yhbh"] == null ? null : Request["yhbh"].ToString();

            if (yhbh_str == null || yhbh_str == "")
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();
            }
            else
            {
                yhbh = yhbh_str;
                string sql = " yhbh!=" + yhbh;
                length = new YHGN_BLL().get_GNcount(yhbh);
                if (length == 0)
                {

                  //  Response.Write("<script language=javascript>alert('请先为该用户配置角色！')</script>");
                  //  Thread.Sleep(10000);
                  //  Response.Redirect("addYHJs.aspx?yhbh="+yhbh.ToString().Trim());
                }
                else
                {
                    gn_list = new GND[length];
                    yhgn_list = new YHGNB[length];
                    gn_list = new YHGN_BLL().get_addGN(yhbh);
                }
                
            }
        }
    }
}