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
    public partial class addNjProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string njMc = Request["njMc"] == null ? "" : Request["njMc"].ToString().Trim();
            string rxnf = Request["rxnf"] == null ? "" : Request["rxnf"].ToString().Trim();
            if (njMc == null || njMc == "" || rxnf == null || rxnf == "")
            {
                result = false;
            }
            else
            {
                bool isFormatEx = false;
                DateTime dt = DateTime.Now ;
                try
                {
                    dt = DateTime.Parse(rxnf);
                }
                catch (Exception ex)
                {
                    isFormatEx = true;
                }
                if (!isFormatEx)
                {
                    NJ nj = new NJ();
                    nj.NJMC = njMc;
                    nj.RXNF = dt;
                    NJ_DAL njDal = new NJ_DAL();
                    if (njDal.Exists(njMc))
                    {
                        result = false;
                    }
                    else
                    {
                        int i = njDal.Add(nj);
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
}