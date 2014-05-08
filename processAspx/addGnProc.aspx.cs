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
    public partial class addGnProc : System.Web.UI.Page
    {

        int jsbh;
        GND[] selected_gnd; //选择添加的功能点列表

        protected void Page_Load(object sender, EventArgs e)
        {
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString().Trim();
            if (jsbh_str == null || jsbh_str == "")
            {
                Response.Write(false);
            }

            else
            {
                jsbh = int.Parse(jsbh_str);
                string[] gnds = Request["gnbh[]"].ToString().Trim().Split(',');
                int length = gnds.Length;
                for (int i = 0; i < length; i++)
                {
                    JSGNB jsgnb = new JSGNB();
                    jsgnb.JSBH = jsbh;
                    jsgnb.GNBH = int.Parse(gnds[i]);
                    new JSGNB_DAL().Add(jsgnb);
                }
            
            }

        }
    }
}