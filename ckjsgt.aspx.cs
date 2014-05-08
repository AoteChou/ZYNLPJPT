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
    public partial class ckjsgt : System.Web.UI.Page
    {
        protected string[] allNjNames;

        protected JDKCView[] jdkcViews;

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
                string queryNjName = null;

                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                allNjNames = new NJ_DAL().getRecentyArray();
                if (Request["choosedNjName"] == null || Request["choosedNjName"].ToString() == "")
                {
                    queryNjName = allNjNames[0];
                }
                else
                {
                    queryNjName = Request["choosedNjName"].ToString();
                    List<string> lists = allNjNames.ToList();
                    lists.Remove(queryNjName);
                    lists.Add(queryNjName);
                    lists.Reverse();
                    allNjNames = lists.ToArray();
                }
                jdkcViews = new JDKCView_DAL().getCKAndSCArrayByNjNameAndXkbh(xkbh, queryNjName);
            }
        }
    }
}