using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class getZSDYbyXK : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form.Get("xkbh") == null)
            {
                Response.Write("{\"total\":\"0\",\"rows\":[]}");
                return;
            }
            int xkbh = int.Parse(Request["xkbh"]);
            int pagenumber = int.Parse(Request["page"]);
            int pagesize = int.Parse(Request["rows"]);
            //获取学科下面的知识点
            XKZSTXView_DAL xkzstxview_dal = new XKZSTXView_DAL();
            int startindex = (pagenumber - 1) * pagesize + 1;
            int endindex = pagenumber * pagesize;
            int size = xkzstxview_dal.GetCount("zsdybh", "xkbh=" + xkbh);
            if (endindex > size)
            {
                endindex = startindex + size % pagesize - 1;
            }
            DataSet ds = xkzstxview_dal.getZSDYByXkbh(xkbh, startindex, endindex);
            DataRowCollection datarows = ds.Tables[0].Rows;
            Response.Write("{\"total\":\"" + size + "\",\"rows\":[");
            for (int i = 0; i < endindex - startindex + 1; i++)
            {
                if (i == 0)
                {
                    Response.Write("{\"zslymc\":\"" + datarows[i]["zslymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zsdymc\":\"" + datarows[i]["zsdymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zsdyfs\":\"" + datarows[i]["zsdybh"].ToString() + "\"}");
                }
                else
                {
                    Response.Write(",{\"zslymc\":\"" + datarows[i]["zslymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zsdymc\":\"" + datarows[i]["zsdymc"].ToString().Replace("\"", " ").Replace("\\", "/") + "\",\"zsdyfs\":\"" + datarows[i]["zsdybh"].ToString() + "\"}");
                }
                
            }
            Response.Write("]}");

        }
    }
}