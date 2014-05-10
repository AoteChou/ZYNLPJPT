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
    public partial class addKcxzproc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kcxzmc = Request["kcxzmc"] == null ? "" : Request["kcxzmc"].ToString().Trim();
            if (kcxzmc != null && kcxzmc != "")
            {
                KCXZ kcxz=new KCXZ();
                kcxz.KCXZMC = kcxzmc;
                try
                {
                    int rout = new KCXZ_DAL().Add(kcxz);
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