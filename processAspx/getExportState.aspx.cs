using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZYNLPJPT.processAspx
{
    public partial class getExportState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             
            if (Session["ExportState"]==null) {
                Session["ExportState"] = false;
                Response.Write(false);
            }
            else if ((bool)Session["ExportState"]) {
                Session["ExportState"] = false;
                Response.Write(true);
            }
            else if (!(bool)Session["ExportState"])
            {
                Response.Write(false);
            }
            else 
            {
                Response.Write(false);
            }

        }
    }
}