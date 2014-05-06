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
    public partial class ckzy : System.Web.UI.Page
    {
        protected XYXKZYDetailView[] xyXkZyViews;

        protected string[] allXyNames;

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
                string queryXym = null;
                allXyNames = new XY_DAL().getAllArrayByStr();
                if (Request["choosedXy"] == null || Request["choosedXy"].ToString() == "")
                {
                    queryXym = allXyNames[0];
                }
                else
                {
                    queryXym = Request["choosedXy"].ToString();
                    List<string> lists = allXyNames.ToList();
                    lists.Remove(queryXym);
                    lists.Add(queryXym);
                    lists.Reverse();
                    allXyNames = lists.ToArray();
                }
                xyXkZyViews = new XYXKZYDetailView_DAL().getArrayByXyMc(queryXym);
            }
        }
    }
}