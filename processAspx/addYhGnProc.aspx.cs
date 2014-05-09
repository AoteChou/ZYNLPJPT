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
    public partial class addYhGnProc : System.Web.UI.Page
    {
        string yhbh;
        GND[] selected_gnd; //选择添加的功能点列表

        protected void Page_Load(object sender, EventArgs e)
        {
            string yhbh_str = Request["yhbh"] == null ? null : Request["yhbh"].ToString().Trim();
            if (yhbh_str == null || yhbh_str == "")
            {
                Response.Write(false);
            }

            else
            {
                yhbh = yhbh_str;
                string[] gnds = Request["gnbh[]"].ToString().Trim().Split(',');
                int length = gnds.Length;
                for (int i = 0; i < length; i++)
                {
                    YHGNB yhgnb = new YHGNB();
                    yhgnb.YHBH = yhbh;
                    yhgnb.GNBH = int.Parse(gnds[i]);
                    new YHGNB_DAL().Add(yhgnb);
                }

            }

        }
    }
}