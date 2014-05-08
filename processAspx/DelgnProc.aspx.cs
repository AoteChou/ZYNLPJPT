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
    public partial class DelgnProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string js = Request["jsbh"] == null ? null : Request["jsbh"].ToString();
            string gnd = Request["gnbh"] == null ? null : Request["gnbh"].ToString();
            if (js == null || gnd == null || js == "" || gnd == "")
            {
                Response.Write(false);
            }
            else
            {
                int jsbh = int.Parse(js);
                int gnbh = int.Parse(gnd);
               bool del= new JSGNB_DAL().Delete(jsbh,gnbh);
              if(del==false)
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