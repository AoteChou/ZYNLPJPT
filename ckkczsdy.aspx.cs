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
    public partial class ckkczsdy : System.Web.UI.Page
    {
        protected KCZSDYWrapper[] kczsdyWrappers;

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
                KCDetailView[] kcDetailViews = new KCDetailView_DAL().getSCAndCKArray(xkbh);
                int length = kcDetailViews.Length;
                kczsdyWrappers=new KCZSDYWrapper[length];
                for (int i = 0; i < length; i++)
                {
                    kczsdyWrappers[i] = new KCZSDYWrapper();
                    kczsdyWrappers[i].KcDetailView = kcDetailViews[i];
                    int kcbh=kczsdyWrappers[i].KcDetailView.KCBH;
                    kczsdyWrappers[i].Zsdys = "所含知识单元为：<br/><br/>";
                    string[] result = new KCZSDYView_DAL().getZSDYMCs(xkbh,kcbh);
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[result.Length - 1] == "暂无" || j == (result.Length - 1))
                        {
                            kczsdyWrappers[i].Zsdys += result[j];
                        }
                        else
                        {
                            kczsdyWrappers[i].Zsdys += result[j] + ", ";
                        }
                    }
                    kczsdyWrappers[i].Zsdys += "<br/>";
                }

            }
        }
    }

    public class KCZSDYWrapper
    {
        private KCDetailView kcDetailView;

        public KCDetailView KcDetailView
        {
            get { return kcDetailView; }
            set { kcDetailView = value; }
        }

        private string zsdys;

        public string Zsdys
        {
            get { return zsdys; }
            set { zsdys = value; }
        }

    }

}