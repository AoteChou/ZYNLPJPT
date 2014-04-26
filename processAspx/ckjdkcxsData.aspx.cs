using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class ckjdkcxsData : System.Web.UI.Page
    {
        protected TeaAndStusWrapper[] teaAndStusWrappers;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
            else
            {
                if (Request["xkbh"] == null || Request["xkbh"].ToString() == "" || Request["njbh"] == null || Request["njbh"].ToString() == "" || Request["jdbh"] == null || Request["jdbh"].ToString() == "" || Request["kcbh"] == null || Request["kcbh"].ToString() == "" || Request["zybh"] == null || Request["zybh"].ToString() == "")
                {
                    Response.Redirect("../Default.htm");
                }
                else
                {
                    int  xkbh = int.Parse(Request["xkbh"].ToString());
                    int  njbh = int.Parse(Request["njbh"].ToString());
                    int  kcbh = int.Parse(Request["kcbh"].ToString());
                    int  jdbh = int.Parse(Request["jdbh"].ToString());
                    int  zybh = int.Parse(Request["zybh"].ToString());
                    YH[] jsTea = new JDKCXSNewView_DAL().getGTTeas(xkbh,njbh,kcbh,jdbh,zybh);
                    int length = jsTea.Length;
                    teaAndStusWrappers=new TeaAndStusWrapper[length];
                    for (int i = 0; i < length; i++) {
                        teaAndStusWrappers[i] = new TeaAndStusWrapper();
                        teaAndStusWrappers[i].TeaName = jsTea[i].XM;
                        YH[] xs = new JDKCXSNewView_DAL().getGTXSs(xkbh,njbh,kcbh,jdbh,zybh,jsTea[i].YHBH);
                        if (xs.Length == 0)
                        {
                            teaAndStusWrappers[i].StuNames = "暂无";
                        }
                        else {
                            teaAndStusWrappers[i].StuNames = "";
                            for (int j = 0; j < xs.Length; j++)
                            {
                                if (j % 6 == 0) {
                                    teaAndStusWrappers[i].StuNames += "<br/>";
                                }
                                teaAndStusWrappers[i].StuNames += xs[j].YHBH + ":" + xs[j].XM + "         ";
                            }
                        }
                    }
                }
            }
        }
    }



    public class TeaAndStusWrapper
    {
        string teaName;

        public string TeaName
        {
            get { return teaName; }
            set { teaName = value; }
        }

        string stuNames;

        public string StuNames
        {
            get { return stuNames; }
            set { stuNames = value; }
        }
    }


}