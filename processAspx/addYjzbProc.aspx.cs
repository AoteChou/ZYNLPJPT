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
    public partial class addYjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string yjzbMc = Request["yjzbMc"] == null ? "" : Request["yjzbMc"].ToString().Trim();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            string sYjzbqz = Request["sYjzbqz"] == null ? "" : Request["sYjzbqz"].ToString().Trim();
            if (yjzbMc == null || yjzbMc == "" || sXkbh == null || sXkbh == ""||sYjzbqz==null||sYjzbqz=="")
            {
                result = false;
            }
            else
            {
                string yjzbJj = Request["yjzbJj"] == null ? "" : Request["yjzbJj"].ToString().Trim();
                int iYjzbqz = int.Parse(sYjzbqz);
                int iXkbh = int.Parse(sXkbh);
                YJZB yjzb = new YJZB();
                yjzb.YJZBMC = yjzbMc;
                yjzb.BZ = yjzbJj;
                yjzb.XKBH = iXkbh;
                yjzb.YJZBQZ = iYjzbqz;
                int i = new YJZB_DAL().Add(yjzb);
                if (i == 0)
                {
                    result = false;
                }
                else
                {
                    result = true;
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}