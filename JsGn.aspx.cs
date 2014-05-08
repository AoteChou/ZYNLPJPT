using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;
using System.Data;


namespace ZYNLPJPT
{
    public partial class JsGn : System.Web.UI.Page
    {

       protected GND[] gnd_list;//某一角色所对应功能点列表
       protected  int length;        //功能点列表编号
       protected int jsbh;            //角色编号
       protected JSGNB[] jsgn_list;//角色功能表

        protected void Page_Load(object sender, EventArgs e)
        {
            jsbh = int.Parse(Request["jsbh"].ToString().Trim());
            string sql = " JSBH=" + jsbh.ToString();
            DataSet ds = new JSGNB_DAL().GetList(sql);
            length = ds.Tables[0].Rows.Count;
            jsgn_list = new JSGNB[length];
            gnd_list = new GND[length];
            for (int i = 0; i < length; i++)
            {
                jsgn_list[i] = new JSGNB();
                jsgn_list[i].JSBH = int.Parse(ds.Tables[0].Rows[i]["JSBH"].ToString());
                jsgn_list[i].GNBH = int.Parse(ds.Tables[0].Rows[i]["GNBH"].ToString());

                gnd_list[i] = new GND();
                gnd_list[i] = new GND_DAL().GetModel(jsgn_list[i].GNBH);
            }
        }

    }
}