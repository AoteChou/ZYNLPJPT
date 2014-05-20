using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT
{
    public partial class pzJsGn : System.Web.UI.Page
    {

        protected int length;
        protected JS2[] js;

        protected void Page_Load(object sender, EventArgs e)
        {
            string sql = " jsbh>=1";
            length = new JSRole_DAL().GetRecordCount(sql);
            js = new JS2[length];
            DataSet ds = new JSRole_DAL().GetList(sql);
            for (int i = 0; i < length; i++)
            {
                js[i] = new JS2();
                js[i].JSBH = int.Parse(ds.Tables[0].Rows[i]["jsbh"].ToString());
                js[i].JSM = ds.Tables[0].Rows[i]["jsm"].ToString();
            }

        }
    }
}