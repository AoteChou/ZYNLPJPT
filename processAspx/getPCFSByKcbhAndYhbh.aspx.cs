using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class getPCFSByKcbhAndYhbh : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("xsbh") == null || Request.Form.Get("kcbh") == null)
            {
                //Response.Write("{\"total\":\"0\",\"rows\":[]}");
                return;
            }
            string xsbh = Request["xsbh"].ToString();
            int kcbh = int.Parse(Request["kcbh"].ToString());
            

            int pagenumber = int.Parse(Request["page"]);
            int pagesize = int.Parse(Request["rows"]);
            PCJL_DAL pcjl_dal = new PCJL_DAL();

            int startindex = (pagenumber - 1) * pagesize + 1;
            int endindex = pagenumber * pagesize;
            int size = pcjl_dal.getPCJLWithMark_ALL_Count(xsbh, kcbh);
            if (endindex > size)
            {
                endindex = startindex + size % pagesize - 1;
            }
                  
            
            PCJL[] pcjls = pcjl_dal.getPCJLWithMark_ALLByPage(xsbh, kcbh,startindex,endindex);
            //检查是否有成绩
            if (pcjls.Length == 0)
            {
                Response.Write("{\"total\":\"0\",\"rows\":[]}");
                return;
                //Response.Redirect("./ErrorPage.aspx?msg=亲...该门课程下还没有成绩,请返回&fh=true");
            }
            string[] gtrbh = new string[pcjls.Length];
            for (int i = 0; i < pcjls.Length; i++)
            {
                gtrbh[i] = pcjls[i].GTR;
            }

            YH_DAL yh_dal = new YH_DAL();
            string[] yhxm = yh_dal.getYHXMbyYHBH(gtrbh);

            Response.Write("{\"total\":\"" + size + "\",\"rows\":[");
              
            for (int i = 0; i <pcjls.Length; i++)
              {
                  if (i == 0)
                  {
                      Response.Write("{\"cpjlbh\":\"" + pcjls[i].PCJLBH + "\"");
                      Response.Write(",\"stbh\":\"" + pcjls[i].STBH + "\"");
                      Response.Write(",\"xzrq\":\"" + pcjls[i].XZRQ + "\"");
                      Response.Write(",\"scrq\":\"" + pcjls[i].SCRQ + "\"");
                      Response.Write(",\"gtr\":\"" + yhxm[i] + "\"");
                      Response.Write(",\"pfcs\":\"" + pcjls[i].PCFS + "\"");
                      Response.Write(",\"xzst\":\" <a  href=\\\"javascript:void(0)\\\" class=\\\"easyui-linkbutton\\\" style=\\\"margin-top:10px; margin-bottom:10px;\\\"onclick=\\\"window.location.href='processAspx/DownloadTest.aspx?stbh=" + pcjls[i].STBH + "'\\\" >下载题目</a>\"");
                      Response.Write(",\"xzwdda\":\"<a  href=\\\"javascript:void(0)\\\" class=\\\"easyui-linkbutton\\\" style=\\\"margin-top:10px; margin-bottom:10px;\\\" onclick=\\\"window.location.href='processAspx/DownloadMyAnswer.aspx?pcjlbh=" + pcjls[i].PCJLBH + "'\\\" >下载我的答案</a>\"}");

                  }
                  else {
                      Response.Write(",{\"cpjlbh\":\"" + pcjls[i].PCJLBH + "\"");
                      Response.Write(",\"stbh\":\"" + pcjls[i].STBH + "\"");
                      Response.Write(",\"xzrq\":\"" + pcjls[i].XZRQ + "\"");
                      Response.Write(",\"scrq\":\"" + pcjls[i].SCRQ + "\"");
                      Response.Write(",\"gtr\":\"" + yhxm[i] + "\"");
                      Response.Write(",\"pfcs\":\"" + pcjls[i].PCFS + "\"");
                      Response.Write(",\"xzst\":\" <a  href=\\\"javascript:void(0)\\\" class=\\\"easyui-linkbutton\\\" style=\\\"margin-top:10px; margin-bottom:10px;\\\"onclick=\\\"window.location.href='processAspx/DownloadTest.aspx?stbh=" + pcjls[i].STBH + "'\\\" >下载题目</a>\"");
                      Response.Write(",\"xzwdda\":\"<a  href=\\\"javascript:void(0)\\\" class=\\\"easyui-linkbutton\\\" style=\\\"margin-top:10px; margin-bottom:10px;\\\" onclick=\\\"window.location.href='processAspx/DownloadMyAnswer.aspx?pcjlbh=" + pcjls[i].PCJLBH + "'\\\" >下载我的答案</a>\"}");

                  }
                                   
              } 
           
           
            Response.Write("]}");
        }
    }
}