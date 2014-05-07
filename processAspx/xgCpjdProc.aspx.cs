using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class xgCpjdProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string nj = Request["njName"] == null ? "" : Request["njName"].ToString().Trim();
            string zyName = Request["zyName"] == null ? "" : Request["zyName"].ToString().Trim();
            string jdMc = Request["jdMc"] == null ? "" : Request["jdMc"].ToString().Trim();
            string qsxq = Request["qsxq"] == null ? "" : Request["qsxq"].ToString().Trim();
            string jzxq = Request["jzxq"] == null ? "" : Request["jzxq"].ToString().Trim();
            string snjbh = Request["njbh"] == null ? "" : Request["njbh"].ToString();
            string szybh = Request["zybh"] == null ? "" : Request["zybh"].ToString();
            string sjdbh = Request["jdbh"] == null ? "" : Request["jdbh"].ToString();
            int iQsxq,iJzxq;
            iQsxq=int.Parse(qsxq);
            iJzxq=int.Parse(jzxq);
            if(nj==null||nj==""||zyName==null||zyName==""||jdMc==null||jdMc==""||qsxq==""||jzxq==""||snjbh==""||szybh==""||sjdbh==""){
                result=false;    
            }else{
                if(iJzxq<iQsxq){
                    result=false;
                }else{
                    string cpjdJj=Request["cjpdJj"]==null?"":Request["cpjdJj"].ToString();
                    int njbh=int.Parse(snjbh);
                    int zybh=int.Parse(szybh);
                    int jdbh=int.Parse(sjdbh);
                    CPJD cpjd=new CPJD ();
                    cpjd.JDBH=jdbh;
                    cpjd.NJBH=njbh;
                    cpjd.ZYBH=zybh;
                    cpjd.QSXQ=iQsxq;
                    cpjd.JZXQ=iJzxq;
                    cpjd.JDMC=jdMc;
                    cpjd.CPJDJJ=cpjdJj;
                    CPJD_DAL cpjdDal = new CPJD_DAL();
                    if (cpjdDal.ExistsForXG(jdMc,jdbh))
                    {
                        result = false;
                    }
                    else {
                        if (cpjdDal.Update(cpjd))
                        {
                            result = true; ;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}
     