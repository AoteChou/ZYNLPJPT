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
    public partial class addBjProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string BjMc = Request["BjMc"] == null ? "" : Request["BjMc"].ToString().Trim();
            string xyName = Request["xyName"] == null ? "" : Request["xyName"].ToString().Trim();
            string xkName = Request["xkName"] == null ? "" : Request["xkName"].ToString().Trim();
            string zyName = Request["zyName"] == null ? "" : Request["zyName"].ToString().Trim();
            string njName = Request["njName"] == null ? "" : Request["njName"].ToString().Trim();
            if (njName == null || njName == "" || BjMc == null || BjMc == ""  || xyName == null || xyName == "" || xkName == null || xkName == "" || zyName == null || zyName == "")
            {
                result = false;
            }
            else
            {
                NJ_DAL njDal = new NJ_DAL();
                if (new BjDetailView_DAL().Exists(BjMc,xyName,xkName,zyName,njName))
                {
                    result = false;
                }
                else
                {
                    BJ bj = new BJ();
                    bj.BJMC = BjMc;
                    NJ nj = new NJ_DAL().GetModel(njName);
                    ZY zy = new ZY_DAL().GetModel(zyName);
                    bj.NJBH = nj.NJBH;
                    bj.ZYBH = zy.ZYBH;
                    bj.RXNF = nj.RXNF;

                    int i = new BJ_DAL().Add(bj);
                    if (i == 0)
                    {
                        result = false;
                    }
                    else
                    {
                        result = true;
                    }
                }
                Response.Write(result);
                Response.End();
            }
        }
    }
}