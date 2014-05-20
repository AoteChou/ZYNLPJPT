using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class DelyhgnProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string yh = Request["yhbh"] == null ? null : Request["yhbh"].ToString();
            string gnd = Request["gnbh"] == null ? null : Request["gnbh"].ToString();
            if (yh == null || gnd == null || yh == "" || gnd == "")
            {
                Response.Write(false);
            }
            else
            {
                string yhbh = yh;
                int gnbh = int.Parse(gnd);
                bool del = new YHGNB_DAL().Delete(gnbh,yh);
                if (del == false)
                {
                    Response.Write(false);
                }
                else
                {
                    Response.End();
                }
            }
        }
    }
}