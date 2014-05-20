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
    public partial class updateKcxz : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kcxzmc = Request["kcxzmc2"] == null ? "" : Request["kcxzmc2"].ToString().Trim();
            string kcxzbh = Request["kcxzbh"] == null ? "" : Request["kcxzbh"].ToString().Trim();
            if (kcxzmc != null && kcxzmc != "" || kcxzbh != null && kcxzbh != "")
            {
                KCXZ kcxz = new KCXZ();
                kcxz.KCXZMC = kcxzmc;
                kcxz.KCXZBH =int.Parse(kcxzbh);
                try
                {
                    result = new KCXZ_DAL().Update(kcxz);
                    
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