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
    public partial class xgZsdProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zsdMc = Request["zsdMc"] == null ? "" : Request["zsdMc"].ToString().Trim();
            string szslybh = Request["zslybh"] == null ? "" : Request["zslybh"].ToString().Trim();
            string szsdybh = Request["zsdybh"] == null ? "" : Request["zsdybh"].ToString().Trim();
            string szsdbh = Request["zsdbh"] == null ? "" : Request["zsdbh"].ToString().Trim();
            string sZsdQz = Request["sZsdQz"] == null ? "" : Request["sZsdQz"].ToString().Trim();
            if (zsdMc == null || zsdMc == "" || szslybh == null || szslybh == "" || szsdbh == null || szsdbh == "" || szsdybh == null || szsdybh == "" || sZsdQz == null || sZsdQz == "")
            {
                result = false;
            }
            else
            {
                int iZsdyQz = int.Parse(sZsdQz);
                ZSD zsd = new ZSD();
                int zslybh=int.Parse(szslybh);
                zsd.ZSLYBH = zslybh;
                int zsdybh=int.Parse(szsdybh);
                zsd.ZSDYBH = zsdybh;
                int zsdbh=int.Parse(szsdbh);
                zsd.ZSDBH = zsdbh;
                zsd.ZSDMC = zsdMc;
                zsd.ZSDQZ = iZsdyQz;
                ZSD_DAL zsdDal = new ZSD_DAL();
                if (zsdDal.Exists(zsdybh, zsdMc, zslybh))
                {
                    result = false;
                }
                else {
                    if (zsdDal.UpdateNotIncludeBZ(zsd))
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
}