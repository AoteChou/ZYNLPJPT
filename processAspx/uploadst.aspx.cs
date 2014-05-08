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
using System.Data;

namespace ZYNLPJPT.processAspx
{
    public partial class uploadst : System.Web.UI.Page
    {
        protected int kcbh;
        protected string ctr;
        protected int[] zsdbh;      //知识点编号
        protected string[] zsdmc;//知识点名称
        protected float[] ctbz;     //出题比重
        protected string kcmc;   //课程名称
        private string hzm;         //后缀名
        protected int stbh;        //试题编号
        private ST_DAL st_dal=new ST_DAL();//试题DAL
        private  ST st_model=new ST();   //试题实体
        protected STZSDB[] stzsd_list;

        private static bool flag_tm;
        private static bool flag_da;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                flag_tm = false;
                flag_da = false;
            }
                if (Session["yh"] == null)
                {
                    Response.Redirect("../Default.htm");
                }

                else
                {
                  
                    /*
                       kcbh = Request["kcbh"] == null ? 0 : int.Parse(Request["kcbh"].ToString().Trim());
                       kcmc = new KC_DAL().GetModel(kcbh).KCMC.ToString();
                       ctr = Request["ctr"].Trim().ToString();
                       string[] zsds = Request["zsds[]"].Trim().ToString().Split(',');
                       string[] zsdbz = Request["zsdbz[]"].Trim().ToString().Split(',');
                       int length = zsds.Length;
                       zsdbh = new int[length];
                       zsdmc = new string[length];
                       ctbz = new float[length];
                       for (int i = 0; i < zsds.Length; i++)
                       {
                           zsdbh[i] = int.Parse(zsds[i]);                                                                  //知识点编号(转化为整型)
                           ctbz[i] = float.Parse(zsdbz[i]); //知识点出题比重(转化为浮点型)
                           zsdmc[i] = new ZSD_DAL().GetModel(zsdbh[i]).ZSDMC.Trim().ToString();
                       }
                    */

                    string stbh_str = Request["stbh"] == null ? null : Request["stbh"].ToString();
                    stbh = int.Parse(stbh_str);
                    st_model = st_dal.GetModel(stbh);
                    kcbh = st_model.KCBH;
                    kcmc = new KC_DAL().GetModel(kcbh).KCMC.ToString();
                    DataSet ds = new STZSDB_DAL().GetList(" stbh=" + stbh.ToString());
                    int length = ds.Tables[0].Rows.Count;
                    zsdbh = new int[length];
                    zsdmc = new string[length];
                    ctbz = new float[length];
                    for (int i = 0; i < length; i++)
                    {
                        zsdbh[i] = int.Parse(ds.Tables[0].Rows[i]["ZSDBH"].ToString());
                        zsdmc[i] = new ZSD_DAL().GetModel(zsdbh[i]).ZSDMC.Trim().ToString();
                        ctbz[i] = float.Parse(ds.Tables[0].Rows[i]["ZSDBZ"].ToString());
                    }
                }
           

        }

        //上传试题
        protected void submitButtonId_Click(object sender, EventArgs e)
        {
            if (IsValid && inputFileId.HasFile)
            {
                string fileName = inputFileId.FileName;
                hzm = fileName.Substring(fileName.LastIndexOf("."));

                string path = Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/" + new Random().Next().ToString() + fileName);
                inputFileId.MoveTo(path, MoveToOptions.Overwrite);
                FileStream filestream = new FileStream(path, FileMode.Open);
                byte[] tempbyte = new byte[filestream.Length];
                filestream.Write(tempbyte, 0, tempbyte.Length);

               /*
                st_model.CTR = ctr;
                st_model.CTSJ = DateTime.Now;
                st_model.KCBH = kcbh;
                st_model.SFZDYJ = false;
                st_model.SFSC = true;
                st_model.STBH = int .Parse(Session["newstbh"].ToString());
                st_model.TMNR = tempbyte;
                st_model.HZM = hzm;
                */
                st_model.TMNR = tempbyte;
                Session["st_model"] = st_model;
                flag_tm = true;
            }
        }
 
        
        //上传答案
        protected void submitAnswer_Click(object sender, EventArgs e)
        {
            if (IsValid && inputFileId.HasFile)
            {
                string fileName = inputFileId.FileName;
                hzm = fileName.Substring(fileName.LastIndexOf("."));

                string path = Path.Combine(Request.PhysicalApplicationPath, "uploadFiles/" + new Random().Next().ToString() + fileName);
                inputFileId.MoveTo(path, MoveToOptions.Overwrite);
                FileStream filestream = new FileStream(path, FileMode.Open);
                byte[] tempbyte = new byte[filestream.Length];
                filestream.Write(tempbyte, 0, tempbyte.Length);
                st_model.TMDA = tempbyte;
                Session["stda"] = st_model.TMDA;
                flag_da = true;
           }
   
   }

        //完成上传
        protected void finishupload_Click(object sender, EventArgs e)
        {
            if (flag_tm == false && flag_da == false)
            {
                Response.Write("<script type=text/javascript>alert('请上传题目和答案！')</script>");
            }
            else if (flag_tm == false && flag_da == true)
            {
                Response.Write("<script type=text/javascript>alert('请上传题目！')</script>");
           
            }
            else if (flag_tm == true && flag_da == false)
            {
                Response.Write("<script type=text/javascript>alert('请上传答案！')</script>");

            }

            else
            {

           
                st_model = (ST)Session["st_model"];
                st_model.TMDA = (byte[])Session["stda"];
                st_model.SFSC = true;
                bool num = st_dal.Update(st_model);

                if (num == true)
                {
                    Response.Redirect("../ctRecord.aspx?kcbh=" + st_model.KCBH.ToString());
                }
                else
                {
                    Response.Write("<script type=text/javascript>alert('上传失败！')</script>");
                }
                }
           

            //else
            //    Response.Write("<script type=text/javascript>alert('请完整上传试题和答案！')</script>");
        }

        //返回到出题页
        protected void goback_Click(object sender, EventArgs e)
        {
            Response.Redirect("../ctRecord.aspx?kcbh="+st_model.KCBH);
        }

    }
}
 