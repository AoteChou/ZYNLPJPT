using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class index : System.Web.UI.Page
    {
        protected MainMenu[] menus = null;


        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["yh"] == null || this.Session["visitedId"] == null||Request["visitedId"]==null)
            {
                this.Response.Redirect("Default.htm");
            }
            else if (!this.Session["visitedId"].ToString().Equals(Request["visitedId"].ToString()))
            {
                this.Session["visitedId"] = null;
                this.Session["yh"]=null;
                this.Response.Redirect("Default.htm");
            }
            else {
              
                menus = new YHGNView_DAL().getUserMenu((YH)Session["yh"]);
            }
        }
    }
}