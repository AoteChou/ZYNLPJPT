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
    public partial class addZsdProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zsdMc=Request["zsdMc"]==null?"":Request["zsdMc"].ToString().Trim();
            string zslyName = Request["zslyName"] == null ? "" : Request["zslyName"].ToString().Trim();
            string zsdyName = Request["zsdyName"] == null ? "" : Request["zsdyName"].ToString().Trim();
            if (zsdMc == null || zsdMc == "" || zslyName == null || zslyName == "" || zsdyName == null || zsdyName == "")
            {
                result = false;
            }
            else {
                ZSTXView zstxView = new ZSTXView_DAL().GetModel(zslyName, zsdyName);
                if (zstxView == null)
                {
                    result = false;
                }
                else {
                    ZSD zsd = new ZSD();
                    zsd.ZSLYBH = zstxView.ZSLYBH;
                    zsd.ZSDYBH = zstxView.ZSDYBH;
                    zsd.ZSDMC = zsdMc;
                    zsd.BZ = Request["zsdBz"] == null ? "" : Request["zsdBz"].ToString().Trim();
                    int i = new ZSD_DAL().Add(zsd);
                    if (i == 0)
                    {
                        result = false;
                    }
                    else {
                        result = true;
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}