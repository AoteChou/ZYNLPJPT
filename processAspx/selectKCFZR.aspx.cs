using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;

namespace ZYNLPJPT.processAspx
{
    public partial class selectKCFZR : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            bool result = false;
            string kkxkid = Request["kkxkid"] == null ? "" : Request["kkxkid"].ToString().Trim();
            DataSet dataSet=new JSTea_DAL().GetList("ssxk=" + kkxkid);

            String json = "[";
            for (int n = 0; n < dataSet.Tables[0].Rows.Count; n++)
            {                
                string jsbh = dataSet.Tables[0].Rows[n]["JSBH"].ToString();
                //string ssxk = dataSet.Tables[0].Rows[n]["SSXK"].ToString();
                YH yh= new YH_DAL().GetModel(jsbh);
                json += "{\"JSBH\":\"" + jsbh + "\",\"XM\":\"" + yh.XM + "\"},";
            }
            json = json.Substring(0, json.Length - 1);
            json += "]";

            Response.Write(json);
            Response.End();
        }          
    }
}