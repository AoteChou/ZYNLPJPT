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
    public partial class addEjzbProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string ejzbMc = Request["ejzbMc"] == null ? "" : Request["ejzbMc"].ToString().Trim();
            string yjzbName = Request["yjzbName"] == null ? "" : Request["yjzbName"].ToString().Trim();
            if (ejzbMc == null || ejzbMc == ""  || yjzbName == null || yjzbName == "")
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
                else {
                    EJZB ejzb = new EJZB();
                    ejzb.EJZBMC = ejzbMc;
                    ejzb.YJZBBH = yjzb.YJZBBH;
                    EJZB_DAL ejzbDal = new EJZB_DAL();
                    if(ejzbDal.ExistsForAdd(yjzb.YJZBBH,ejzbMc)){
                        result=false;
                    }else{
                        int i = ejzbDal.Add(ejzb);
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