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
    public partial class yhgnRecord : System.Web.UI.Page
    {
        protected GND[] gnd_list;//某一用户所对应功能点列表
        protected int length;        //功能点列表编号
        protected string yhbh;            //用户编号
        protected YHGNB[] yhgn_list;//用户功能表

        protected void Page_Load(object sender, EventArgs e)
        {
            yhbh =Request["yhbh"].ToString().Trim();
            string sql = " YHBH=" + yhbh.ToString();
            DataSet ds = new YHGNB_DAL().GetList(sql);
            length = ds.Tables[0].Rows.Count;
            yhgn_list = new YHGNB[length];
            gnd_list = new GND[length];
            for (int i = 0; i < length; i++)
            {
                yhgn_list[i] = new YHGNB();
                yhgn_list[i].YHBH = ds.Tables[0].Rows[i]["YHBH"].ToString();
                 yhgn_list[i].GNBH = int.Parse(ds.Tables[0].Rows[i]["GNBH"].ToString());

                gnd_list[i] = new GND();
                gnd_list[i] = new GND_DAL().GetModel(yhgn_list[i].GNBH);
            }
        }

    }
}