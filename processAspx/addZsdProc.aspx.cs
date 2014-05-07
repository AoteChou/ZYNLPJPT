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
            string sZsdQz = Request["sZsdQz"] == null ? "" : Request["sZsdQz"].ToString().Trim();
            if (zsdMc == null || zsdMc == "" || zslyName == null || zslyName == "" || zsdyName == null || zsdyName == ""||sZsdQz==null||sZsdQz=="")
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
                    int iZsdyQz = int.Parse(sZsdQz);
                    ZSD zsd = new ZSD();
                    zsd.ZSLYBH = zstxView.ZSLYBH;
                    zsd.ZSDYBH = zstxView.ZSDYBH;
                    zsd.ZSDMC = zsdMc;
                    zsd.ZSDQZ = iZsdyQz;
                    zsd.BZ = Request["zsdBz"] == null ? "" : Request["zsdBz"].ToString().Trim();
                    ZSD_DAL zsdDal = new ZSD_DAL();
                    if (zsdDal.Exists(zstxView.ZSDYBH, zsdMc, zstxView.ZSLYBH))
                    {
                        result = false;
                    }
                    else {
                        int i = zsdDal.Add(zsd);
                        if (i == 0)
                        {
                            result = false;
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}