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
    public partial class DelSingleGtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string skcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString();
            string szybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
            string sjdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
            string jsbh = Request["jsbh"] == null ? "" : Request["jsbh"].ToString();
            string xsbh = Request["xsbh"] == null ? "" : Request["xsbh"].ToString();
            if (skcbh == null || skcbh == "" || szybh == null || szybh == "" || sxkbh == null || sxkbh == ""||snjbh==null||snjbh==""||sjdbh==null||sjdbh==""||jsbh==null||jsbh==""||xsbh==""||xsbh==null)
            {
                result = false;
            }
            else
            {
                int kcbh = int.Parse(skcbh);
                int zybh = int.Parse(szybh);
                int njbh = int.Parse(snjbh);
                int jdbh = int.Parse(sjdbh);
                if (new JDKCXS_DAL().Delete(kcbh,zybh,njbh,jdbh,xsbh,jsbh))
                {
                    result = true;
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