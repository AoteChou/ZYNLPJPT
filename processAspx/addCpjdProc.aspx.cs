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
    public partial class addCpjdProc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string nj = Request["njName"] == null ? "" : Request["njName"].ToString().Trim();
            string zyName = Request["zyName"] == null ? "" : Request["zyName"].ToString().Trim();
            string jdMc = Request["jdMc"] == null ? "" : Request["jdMc"].ToString().Trim();
            string qsxq = Request["qsxq"] == null ? "" : Request["qsxq"].ToString().Trim();
            string jzxq = Request["jzxq"] == null ? "" : Request["jzxq"].ToString().Trim();
            int iQsxq,iJzxq;
            iQsxq=int.Parse(qsxq);
            iJzxq=int.Parse(jzxq);
            if(nj==null||nj==""||zyName==null||zyName==""||jdMc==null||jdMc==""||qsxq==null||jzxq==null){
                result=false;    
            }else{
                if(iJzxq<iQsxq){
                    result=false;
                }else{
                    string cpjdJj=Request["cjpdJj"]==null?"":Request["cpjdJj"].ToString();
                    NJ njObj=new NJ_DAL().GetModel(nj);
                    ZY zy=new ZY_DAL().GetModel(zyName);
                    CPJD cpjd=new CPJD ();
                    cpjd.NJBH=njObj.NJBH;
                    cpjd.ZYBH=zy.ZYBH;
                    cpjd.QSXQ=iQsxq;
                    cpjd.JZXQ=iJzxq;
                    cpjd.JDMC=jdMc;
                    cpjd.CPJDJJ=cpjdJj;
                    CPJD_DAL cpjdDal = new CPJD_DAL();
                    if (cpjdDal.Exists(jdMc)) {
                        result = false;
                    }else{
                        if (cpjdDal.Add(cpjd) == 0)
                        {
                            result = false;
                        }
                        else
                        {
                            result = true;
                        }
                    }
                }
            }
            Response.Write(result);
            Response.End();
        }
    }
}