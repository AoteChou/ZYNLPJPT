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
    public partial class addCtr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string teaIdstr = Request["teaIds[]"]==null?null:Request["teaIds[]"].ToString().Trim();
            string kcbh = Request["kcbh"]==null?null:Request["kcbh"].ToString().Trim();
            string zybh = Request["zybh"]==null?null:Request["zybh"].ToString().Trim();

            if (teaIdstr == null || teaIdstr == "" || kcbh == null || kcbh == "" || zybh == null || zybh == "")
            {
                Response.Write(false);
            }
            else {
                string[] teaIds = teaIdstr.Split(',');
                int iKcbh = int.Parse(kcbh);
                int iZybh = int.Parse(zybh);
                new CT_DAL().Delete(iKcbh, iZybh);
                CT[] cts=new CT[teaIds.Length];
                for (int i = 0; i < teaIds.Length; i++) {
                    cts[i] = new CT();
                    cts[i].ZYBH = iZybh;
                    cts[i].KCBH = iKcbh;
                    cts[i].CTR = teaIds[i].Trim();
                }
                if (new CT_DAL().AddList(cts)) {
                    Response.Write(true);
                }else{
                    Response.Write(false);
                }
            }
            Response.End();
        }
    }
}