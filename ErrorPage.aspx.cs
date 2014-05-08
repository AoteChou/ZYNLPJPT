using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZYNLPJPT
{
    public partial class Errorpage : System.Web.UI.Page
    {
        protected bool fh;//是否返回
        protected bool gb;//是否关闭
        protected void Page_Load(object sender, EventArgs e)
        {
            
            Response.Write(Request["msg"]);
            if (Request.QueryString.Get("fh") == null)
            {
                fh = false;
            }
            else
            {
                fh = bool.Parse(Request["fh"]);
            }
            if (Request.QueryString.Get("gb") == null)
            {
                gb = false;
            }
            else {
                gb = bool.Parse(Request["gb"]);
            }
            if (gb) { //关闭的话就不能返回
                fh = false;
            }
        }
    }
}