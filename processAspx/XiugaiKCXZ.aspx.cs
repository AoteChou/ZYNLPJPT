using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.processAspx
{
    public partial class XiugaiKCXZ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet ds = new KCXZ_DAL().GetList("");

            int alength = ds.Tables[0].Rows.Count;

            Response.Write("[");
            string dataString = "";
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                dataString += "{\"kcxzbh\":\"" + ds.Tables[0].Rows[i]["kcxzbh"].ToString() + "\",\"kcxz\":\"" + ds.Tables[0].Rows[i]["kcxzmc"].ToString() + "\"},";

            }
            dataString = dataString.Substring(0, dataString.Length - 1);
            Response.Write(dataString);
            Response.Write("]");
        }
    }
}