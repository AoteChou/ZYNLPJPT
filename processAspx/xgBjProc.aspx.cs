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
    public partial class xgBjProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string bjmc = Request["BjMc"] == null ? "" : Request["BjMc"].ToString().Trim();
            string sbjbh = Request["bjbh"] == null ? "" : Request["bjbh"].ToString().Trim();
            string szybh = Request["zybh"] == null ? "" : Request["zybh"].ToString().Trim();
            string rxnf = Request["rxnf"] == null ? "" : Request["rxnf"].ToString().Trim();
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString().Trim();
            if (sbjbh == null || sbjbh == "" || bjmc == null || bjmc == "" || rxnf == null || rxnf == "" || snjbh == null || snjbh == "" || szybh == "" || szybh == null)
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
                    int bjbh=int.Parse(sbjbh);
                    int njbh=int.Parse(snjbh);
                    int zybh=int.Parse(szybh);
                    BJ_DAL bjDal = new BJ_DAL();
                    if (bjDal.Exists(bjbh,bjmc,njbh,zybh))
                    {
                        result = false;
                    }
                    else
                    {
                        BJ bj = new BJ();
                        bj.BJBH = bjbh;
                        bj.BJMC = bjmc;
                        bj.NJBH = njbh;
                        bj.ZYBH = zybh;
                        bj.RXNF = dt;
                        if (bjDal.Update(bj))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
                Response.Write(result);
                Response.End();
            }
        }
    }
}