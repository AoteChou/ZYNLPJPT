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
    public partial class XiuGaiKC2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kcmc = Request["kcmc"] == null ? "" : Request["kcmc"].ToString().Trim();
            string kcfzr = Request["kcfzr"] == null ? "" : Request["kcfzr"].ToString().Trim();
            string kkxk = Request["kkxk"] == null ? "" : Request["kkxk"].ToString().Trim();
            string kcjj = Request["kcjj"] == null ? "" : Request["kcjj"].ToString().Trim();
            string kcbh = Request["kcbh"] == null ? "" : Request["kcbh"].ToString().Trim();
            if (kcmc != null && kcmc != "" && kcfzr != null && kcfzr != "" && kkxk != null && kkxk != "" && kcbh != null && kcbh != "")
            {

                KC kc = new KC();
                kc.KCMC = kcmc;
                if (kcfzr != "-1")
                {
                    kc.KCFZR = kcfzr;
                    JSTea_DAL jst_dal = new JSTea_DAL();
                    jst_dal.UpdateSFSKCFZR(true, kcfzr);

                }
                
                kc.KKXK = int.Parse(kkxk);
                kc.KCJJ = kcjj; 
                kc.KCBH = int.Parse(kcbh);
                try
                {
                   bool rout = new KC_DAL().Update(kc);
                    if (rout)
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
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