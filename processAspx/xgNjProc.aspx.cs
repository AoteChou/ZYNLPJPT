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
    public partial class xgNjProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             bool result = false;
            string njMc = Request["njMc"] == null ? "" : Request["njMc"].ToString().Trim();
            string rxnf = Request["rxnf"] == null ? "" : Request["rxnf"].ToString().Trim();
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString().Trim();
            if (njMc == null || njMc == "" || rxnf == null || rxnf == ""||snjbh==null||snjbh=="")
            {
                result = false;
            }
            else
            {
                bool isFormatEx = false;
                DateTime dt = DateTime.Now;
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
                    int njbh=int.Parse(snjbh);
                    nj.NJBH = njbh;
                    NJ_DAL njDal = new NJ_DAL();
                    if (njDal.Exists(njMc,njbh))
                    {
                        result = false;
                    }
                    else
                    {
                        if (njDal.Update(nj))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false ;
                        }
                    }
                }
                Response.Write(result);
                Response.End();
            }
        }
    }
}