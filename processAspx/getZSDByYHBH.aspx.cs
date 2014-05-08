using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.BLL;
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class getZSDByYHBH : System.Web.UI.Page
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
            //获取学科下面的知识单元
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();
            int startindex=(pagenumber-1)*pagesize+1;
            int endindex=pagenumber*pagesize;
            int size=xkzstxview_dal.GetRecordCount("xkbh="+xkbh);
            if (endindex > size) {
                endindex = startindex + size % pagesize-1;
            }
            XKZSTXView[] xkzstxviews = xkzstxview_dal.getByXkbh(xkbh,startindex,endindex);
            Response.Write("{\"total\":\""+size+"\",\"rows\":[");
            for (int i = 0; i < endindex-startindex+1; i++)
            {
                if (i == 0)
                {
                    Response.Write("{\"zslymc\":\"" + xkzstxviews[0].ZSLYMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdymc\":\"" + xkzstxviews[0].ZSDYMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdmc\":\"" + xkzstxviews[0].ZSDMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdfs\":\"" + GetTestResult_BLL.getTestResult_ZSD(xsbh,xkzstxviews[0].ZSDBH) + "\"}");
                }
                else
                {
                    Response.Write(",{\"zslymc\":\"" + xkzstxviews[i].ZSLYMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdymc\":\"" + xkzstxviews[i].ZSDYMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdmc\":\"" + xkzstxviews[i].ZSDMC.Replace("\"", " ").Replace("\\", "/") + "\",\"zsdfs\":\"" + GetTestResult_BLL.getTestResult_ZSD(xsbh,xkzstxviews[i].ZSDBH) + "\"}");
                }
            }
                Response.Write("]}");
        }
    }
}