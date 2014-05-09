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
    public partial class xgZyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zyMc = Request["zyMc"] == null ? "" : Request["zyMc"].ToString().Trim();
            string sxybh = Request["xybh"] == null ? "" : Request["xybh"].ToString().Trim();
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString().Trim();
            string szybh=Request["zybh"]==null?"":Request["zybh"].ToString().Trim();
            if (zyMc == null || zyMc == "" || sxybh == "" || sxybh == null || sxkbh == null || sxkbh == ""||szybh==null||szybh=="")
            {
                result = false;
            }
            else
            {
                int xybh = int.Parse(sxybh);
                int xkbh = int.Parse(sxkbh);
                int zybh = int.Parse(szybh);
                ZY_DAL zyDal = new ZY_DAL();
                if (zyDal.Exists(zyMc,zybh,xkbh))
                {
                    result = false;
                }
                else
                {
                    ZY zy = new ZY();
                    zy.ZYBH = zybh;
                    zy.ZYM = zyMc;
                    zy.XKBH = xkbh;
                    if (zyDal.UpdateForXG(zy))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}