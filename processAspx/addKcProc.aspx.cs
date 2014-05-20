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
    public partial class addKcProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kcmc = Request["kcmc"] == null ? "" : Request["kcmc"].ToString().Trim();
            string kcfzr = Request["kcfzr"] == null ? "" : Request["kcfzr"].ToString().Trim();
            string kkxk = Request["kkxk"] == null ? "" : Request["kkxk"].ToString().Trim();
            string kcjj = Request["kcjj"] == null ? "" : Request["kcjj"].ToString().Trim();

            if (kcmc != null && kcmc != "" && kcfzr != null && kcfzr != "" && kkxk != null && kkxk != "")
            {
                
                KC kc = new KC();
                kc.KCMC = kcmc;
                if (kcfzr != "-1") {
                    kc.KCFZR = kcfzr;
                    JSTea_DAL jst_dal = new JSTea_DAL();
                    jst_dal.UpdateSFSKCFZR(true, kcfzr);
                
                }
                
                kc.KKXK = int.Parse(kkxk);
                kc.KCJJ = kcjj;
                try
                {
                    int rout = new KC_DAL().Add(kc);
                    if (rout == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                catch (Exception)
                {

                    result = false;
                }
                

            }
            Response.Write(result);
            Response.End();
        }
    }
}