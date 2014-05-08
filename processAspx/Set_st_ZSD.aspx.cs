using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using System.IO;
using Brettle.Web.NeatUpload;

namespace ZYNLPJPT.processAspx
{
    public partial class Set_st_ZSD : System.Web.UI.Page
    {
        protected int kcbh;
        protected string ctr;
        protected int[] zsdbh;//知识点编号
        protected string[] zsdmc;//知识点名称
        protected decimal[] ctbz;//出题比重
        protected string kcmc;//课程名称
        private string hzm;      //后缀名


        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                Response.Redirect("../Default.htm");
            }
        
         else
            {

                kcbh = Request["kcbh"] == null ? 0 : int.Parse(Request["kcbh"].ToString().Trim());
                kcmc = new KC_DAL().GetModel(kcbh).KCMC.ToString();
                ctr = Request["ctr"].Trim().ToString();
                string[] zsds = Request["zsds[]"].Trim().ToString().Split(',');
                string []zsdbz = Request["zsdbz[]"].Trim().ToString().Split(',');
                int length = zsds.Length;
                zsdbh = new int[length];
                zsdmc = new string[length];
                ctbz = new decimal[length];

                for (int i = 0; i < zsds.Length; i++)
                {
                    zsdbh[i] = int.Parse(zsds[i]);   //知识点编号(转化为整型)
                    zsdmc[i] = new ZSD_DAL().GetModel(zsdbh[i]).ZSDMC.Trim().ToString();
                    ctbz[i] = Convert.ToDecimal(zsdbz[i]);//知识点比重
                }

                //生成新出试题编号并保存于Session中
                ST st = new ST();
                st.STBH = new ST_DAL().GetMaxId();
                st.CTR = ctr;
                st.CTSJ = DateTime.Now;
                st.KCBH = kcbh;
                st.SFZDYJ = false;
                st.HZM = ".doc";

                new ST_DAL().Add(st);
                Session["newstbh"] = st.STBH;


                //设置试题知识点比重
               STZSDB []stzsdb = new STZSDB[length];
    
                for (int i = 0; i < length; i++)
                {
                    stzsdb[i] = new STZSDB();
                    stzsdb[i].ZSDBH = zsdbh[i];
                    stzsdb[i].STBH = st.STBH;
                    stzsdb[i].ZSDYBH = new Get_ZSD_BLL().get_ZSDYBH_ByZSD(stzsdb[i].ZSDBH);
                    stzsdb[i].ZSLYBH = new Get_ZSD_BLL().get_ZSLYBH_ByZSDY(stzsdb[i].ZSDYBH);
                    stzsdb[i].ZSDBZ = ctbz[i];

                    new STZSDB_DAL().Add(stzsdb[i]);
                }

                //返回试题编号
                Response.Write(st.STBH);
                Response.End();
           }

            //判断输入的出题比重是否符合要求

        }
    }
}