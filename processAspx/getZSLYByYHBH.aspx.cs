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
    public partial class getZSLYByYHBH : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("xsbh") == null)
            {
                Response.Write("{\"total\":\"0\",\"rows\":[]}");
                return;
            }
            string xsbh = Request["xsbh"].ToString();
            //获取用户所属的学科编号
            XSBJZYView_DAL xsbjzyview_dal = new XSBJZYView_DAL();
            DataSet ds1 = xsbjzyview_dal.GetList("xsbh=" + xsbh);
            int xkbh = -1;
            if (ds1.Tables[0].Rows.Count >= 0)
            {
                xkbh = int.Parse(ds1.Tables[0].Rows[0]["xkbh"].ToString());
            }
            else
            {
                return;
            }
            int pagenumber = int.Parse(Request["page"]);
            int pagesize = int.Parse(Request["rows"]);
            //获取学科下面的知识领域
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();
            int startindex = (pagenumber - 1) * pagesize + 1;
            int endindex = pagenumber * pagesize;
            int size = xkzstxview_dal.GetCount("zslybh", "xkbh=" + xkbh);
            if (endindex > size)
            {
                endindex = startindex + size % pagesize - 1;
            }
            DataSet ds = xkzstxview_dal.getZSLYByXkbh(xkbh, startindex, endindex);
            DataRowCollection datarows = ds.Tables[0].Rows;
            Response.Write("{\"total\":\"" + size + "\",\"rows\":[");
            for (int i = 0; i < endindex - startindex + 1; i++)
            {
                if (i == 0)
                {
                    Response.Write("{\"zslymc\":\"" + datarows[i]["zslymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zslyfs\":\"" + GetTestResult_BLL.getTestResult_ZSLY(xsbh,int.Parse(datarows[i]["zslybh"].ToString())) + "\"}");
                }
                else
                {
                    Response.Write(",{\"zslymc\":\"" + datarows[i]["zslymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zslyfs\":\"" + GetTestResult_BLL.getTestResult_ZSLY(xsbh,int.Parse(datarows[i]["zslybh"].ToString())) + "\"}");
                }

            }
            Response.Write("]}");

        }
    }
}