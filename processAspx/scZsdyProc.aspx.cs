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
    public partial class scZsdyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string sxkbh = Request["xkbh"] == null ? "" : Request["xkbh"].ToString();
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString();
            string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString();
            if (sxkbh == null || sxkbh == "" || szslybh == null || szslybh == ""||szsdybh==null||szsdybh=="")
            {
                result = false;
            }
            else
            {
                int xkbh = int.Parse(sxkbh);
                int zslybh = int.Parse(szslybh);
                int zsdybh = int.Parse(szsdybh);
                if (new KCZSDY_DAL().Exists(zslybh,zsdybh)||new ZSD_DAL().Exists(zslybh,zsdybh))
                {
                    //该阶段已被配置，不能删除
                    result = false;
                }
                else
                {
                    if (new ZSDY_DAL().Delete(zslybh,zsdybh))
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