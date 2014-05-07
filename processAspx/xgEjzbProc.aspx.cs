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
    public partial class xgEjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string ejzbMc = Request["ejzbMc"] == null ? "" : Request["ejzbMc"].ToString().Trim();
            string sejzbbh = Request["ejzbbh"] == null ? "" : Request["ejzbbh"].ToString();
            string yjzbName = Request["yjzbName"] == null ? "" : Request["yjzbName"].ToString().Trim();
            if (ejzbMc == null || ejzbMc == "" ||sejzbbh==null||sejzbbh==""||yjzbName==null||yjzbName=="")
            {
                result = false;
            }
            else
            {
                YJZB yjzb = new YJZB_DAL().GetModel(yjzbName);
                if (yjzb == null)
                {
                    result = false;
                }
                else
                {
                    int ejzbbh=int.Parse(sejzbbh);
                    EJZB ejzb = new EJZB();
                    ejzb.EJZBMC = ejzbMc;
                    ejzb.YJZBBH = yjzb.YJZBBH;
                    ejzb.EJZBBH = ejzbbh;
                    EJZB_DAL ejzbDal = new EJZB_DAL();
                    if (ejzbDal.ExistsForXG(yjzb.YJZBBH, ejzbMc, ejzbbh))
                    {
                        result = false;
                    }
                    else {
                        if (ejzbDal.Update(ejzb))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}