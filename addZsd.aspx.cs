using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT
{
    public partial class addZsd : System.Web.UI.Page
    {
        protected int xkbh;

        protected string[] zslyNames;

        protected string[] zsdyNames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm';</script>");
                this.Response.End();
            }
            else
            {
                YH yh = (YH)Session["yh"];
                xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                zslyNames = new ZSLY_DAL().getArrayByXkbh(xkbh);
                if (zslyNames.Length > 0)
                {
                    zsdyNames = new ZSTXView_DAL().getArrayByXkbhAndYjzb(xkbh, zslyNames[0]);
                }
                else { 
                    zsdyNames=new string[0];
                }
            }            
        }
    }
}