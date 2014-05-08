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

namespace ZYNLPJPT
{
    public partial class addGn : System.Web.UI.Page
    {
     protected   int jsbh;
     protected GND[] gn_list;
     protected JSGNB[] jsgn_list;
     protected int length;

        protected void Page_Load(object sender, EventArgs e)
        {
            string jsbh_str = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            if (jsbh_str == null || jsbh_str == "")
                this.Response.Redirect("Default.htm");
            else
            {
                jsbh = int.Parse(jsbh_str);
                length = new JSGN_BLL().get_GNcount(jsbh);
                gn_list = new GND[length];
                jsgn_list = new JSGNB[length];
                gn_list = new JSGN_BLL().get_addGN(jsbh);
            }
        }
    }

}