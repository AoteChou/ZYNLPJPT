using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT
{
    public partial class ckjdkc : System.Web.UI.Page
    {
        protected string[] allZyms;

        protected CPJDViewWrapper[] cpjdViewWrappers;

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
                string queryZym = null;
                int xkbh = new JSTea_DAL().GetModel(yh.YHBH.Trim()).SSXK;
                allZyms = new ZY_DAL().getArrayByXkbh(xkbh);
                if (Request["choosedMajor"] == null || Request["choosedMajor"].ToString() == "")
                {
                    queryZym = allZyms[0];
                }
                else
                {
                    queryZym = Request["choosedMajor"].ToString();
                    List<string> lists = allZyms.ToList();
                    lists.Remove(queryZym);
                    lists.Add(queryZym);
                    lists.Reverse();
                    allZyms = lists.ToArray();
                }
                CpjdView[] cpjdViews = new CpjdView_DAL().getRecentlySCAndCKArray(xkbh, queryZym.Trim());
                int length = cpjdViews.Length;
                cpjdViewWrappers = new CPJDViewWrapper[length];
                for (int i = 0; i < length; i++) {
                    cpjdViewWrappers[i] = new CPJDViewWrapper();
                    cpjdViewWrappers[i].CpjdView = cpjdViews[i];
                    int njbh = cpjdViewWrappers[i].CpjdView.NJBH;
                    int jdbh = cpjdViewWrappers[i].CpjdView.JDBH;
                    int zybh = cpjdViewWrappers[i].CpjdView.ZYBH;
                    cpjdViewWrappers[i].Jdkcs = "所含课程为：<br/><br/>";
                    string[] result = new JDKCView_DAL().getJDKCCs(njbh, jdbh,zybh);
                    for (int j = 0; j < result.Length; j++)
                    {
                        if (result[result.Length - 1] == "暂无" || j == (result.Length - 1))
                        {
                            cpjdViewWrappers[i].Jdkcs += result[j];
                        }
                        else
                        {
                            cpjdViewWrappers[i].Jdkcs += result[j] + ", ";
                        }
                    }
                    cpjdViewWrappers[i].Jdkcs += "<br/>";
                }
            }
        }
    }


    public class CPJDViewWrapper
    {
        private CpjdView cpjdView;

        public CpjdView CpjdView
        {
            get { return cpjdView; }
            set { cpjdView = value; }
        }

        private string jdkcs;

        public string Jdkcs
        {
            get { return jdkcs; }
            set { jdkcs = value; }
        }
    }
}