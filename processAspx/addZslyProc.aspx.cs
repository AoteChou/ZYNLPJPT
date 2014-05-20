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
    public partial class addZslyProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string zslyMc = Request["zslyMc"] == null ? "" : Request["zslyMc"].ToString().Trim();
            string sXkbh=Request["xkbh"]==null?"":Request["xkbh"].ToString().Trim();
            if (zslyMc == null || zslyMc == ""||sXkbh==null||sXkbh=="")
            {
                result = false;
            }else
            {
                string zslyJj=Request["zslyJj"]==null?"":Request["zslyJj"].ToString().Trim();
                int iXkbh = int.Parse(sXkbh);
                ZSLY zsly = new ZSLY();
                zsly.ZSLYMC = zslyMc;
                zsly.BZ = zslyJj;
                zsly.XKBH = iXkbh;
                ZSLY_DAL zslyDal = new ZSLY_DAL();
                if (zslyDal.Exists(zslyMc))
                {
                    result = false;
                }
                else {
                    int i = zslyDal.Add(zsly);
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
            Response.Write(result);
            Response.End();
        }
    }
}