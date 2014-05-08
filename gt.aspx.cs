using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.Utility;
using ZYNLPJPT.DAL;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;

namespace ZYNLPJPT.processAspx
{
    public partial class gt : System.Web.UI.Page
    {
         
        protected PCJL pcjl;                                                           //评测记录实体
        protected int pcjlbh;                                                          //评测记录编号
        protected string kcmc;                                                      //课程名称
        protected STZSDB []stzsdb;                                              //试题知识点表列表
        protected int length;                                                        //试题知识点列表长度
        protected int stbh;                                                           //试题编号
        protected void Page_Load(object sender, EventArgs e)
        {
           
            pcjl = new PCJL();
            pcjlbh =int.Parse(Request["pcjlbh"].ToString());
            pcjl = new PCJL_DAL().GetModel(pcjlbh);
            kcmc = new ST_BLL().get_kcmc_Bystbh(pcjl.STBH).ToString().Trim();
            stbh = int.Parse(pcjl.STBH.ToString());

            //试题知识点列表
            string sql = " stbh="+pcjl.STBH;
            DataSet ds = new STZSDB_DAL().GetList(sql);
            length = ds.Tables[0].Rows.Count;
            stzsdb=new STZSDB[length];

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                stzsdb[i] = new STZSDB();
                stzsdb[i].STBH = int.Parse(ds.Tables[0].Rows[i]["stbh"].ToString());
                stzsdb[i].ZSDBH = int.Parse(ds.Tables[0].Rows[i]["zsdbh"].ToString());
                stzsdb[i].ZSDBZ =Convert.ToDecimal (ds.Tables[0].Rows[i]["zsdbz"].ToString());
                stzsdb[i].ZSDYBH = int.Parse(ds.Tables[0].Rows[i]["zsdybh"].ToString());
                stzsdb[i].ZSLYBH = int.Parse(ds.Tables[0].Rows[i]["zslybh"].ToString());
            }

        }

        //打分
        protected void Button1_Click(object sender, EventArgs e)
        {
            string score_str = score_TextBox.Text.ToString();
            if (score_str == null || score_str == "")
                Response.Write("<script>alert('请输入你所打的分数！')</script>");
            else
            {
                int score = int.Parse(score_str);
                if (score < 0 || score > 100)
                    Response.Write("<script>alert('分数不符合要求！')</script>");
                else
                {
                    pcjl.PCFS = score;
                   bool update= new PCJL_DAL().Update(pcjl);
                    if(update==true)
                    Response.Write("<script language=javascript>history.go(-1);</script>");
                    else
                      Response.Write("<script>alert('打分失败！')</script>");
                }
            }


        }

         
    }
}