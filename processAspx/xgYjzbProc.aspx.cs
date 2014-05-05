using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class xgYjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string yjzbMc = Request["yjzbMc"] == null ? "" : Request["yjzbMc"].ToString().Trim();
            string sXkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            string sYjzbqz = Request["sYjzbqz"] == null ? "" : Request["sYjzbqz"].ToString().Trim();
            string syjzbbh = Request["yjzbbh"] == null ? "" : Request["yjzbbh"].ToString().Trim();
            if (yjzbMc == null || yjzbMc == "" || sXkbh == null || sXkbh == "" || sYjzbqz == null || sYjzbqz == ""||syjzbbh==null||syjzbbh=="")
            {
                result = false;
            }
            else
            {
                string yjzbJj = Request["yjzbJj"] == null ? "" : Request["yjzbJj"].ToString().Trim();
                int yjzbbh = int.Parse(syjzbbh);
                int iYjzbqz = int.Parse(sYjzbqz);
                int iXkbh = int.Parse(sXkbh);
                YJZB yjzb = new YJZB();
                yjzb.YJZBMC = yjzbMc;
                yjzb.BZ = yjzbJj;
                yjzb.XKBH = iXkbh;
                yjzb.YJZBQZ = iYjzbqz;
                yjzb.YJZBBH = yjzbbh;
                if (new YJZB_DAL().Update(yjzb))
                {
                    result = true ;
                }
                else
                {
                    result = false;
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}