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
        protected void Page_Load(object sender, EventArgs e)
        {
            fh = bool.Parse(Request["fh"]);
            Response.Write(Request["msg"]);
        }
    }
}