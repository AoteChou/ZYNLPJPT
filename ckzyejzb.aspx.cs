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
    public partial class ckzyejzb : System.Web.UI.Page
    {
        protected XyXkZyViewWrapper[] xyXkZyViewWrappers;

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
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                XyXkZyView[] xyXkZyViews = new XyXkZyView_DAL().getCKArray(xkbh);
                int length = xyXkZyViews.Length;
                xyXkZyViewWrappers = new XyXkZyViewWrapper[length];
                for (int i = 0; i < length; i++)
                {
                    xyXkZyViewWrappers[i] = new XyXkZyViewWrapper();
                    xyXkZyViewWrappers[i].XyXkZyView = xyXkZyViews[i];
                    int zybh = xyXkZyViewWrappers[i].XyXkZyView.ZYBH;
                    xyXkZyViewWrappers[i].Ejzbs = "所含二级指标为：<br/><br/>";
                    string[] result = new ZYEJZBView_DAL().getEJZBCs(xkbh, zybh);
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[result.Length - 1] == "暂无" || j == (result.Length - 1))
                        {
                            xyXkZyViewWrappers[i].Ejzbs += result[j];
                        }
                        else
                        {
                            xyXkZyViewWrappers[i].Ejzbs += result[j] + ", ";
                        }
                    }
                    xyXkZyViewWrappers[i].Ejzbs += "<br/>";
                }

            }
        }
    }

    public class XyXkZyViewWrapper
    {
        private XyXkZyView xyXkZyView;

        public XyXkZyView XyXkZyView
        {
            get { return xyXkZyView; }
            set { xyXkZyView = value; }
        }

        private string ejzbs;

        public string Ejzbs
        {
            get { return ejzbs; }
            set { ejzbs = value; }
        }

    }


}