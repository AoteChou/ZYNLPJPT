using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class getResult_ZSLY : System.Web.UI.Page
    {
        protected string xsbh;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();

            }
            else
            {
                YH yh = (YH)Session["yh"];
                xsbh = yh.YHBH;

            }
        }
    }
}