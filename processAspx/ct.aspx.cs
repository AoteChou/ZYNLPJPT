using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.BLL;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.processAspx;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.processAspx
{
    public partial class ct : System.Web.UI.Page
    {
       protected int kcbh;                                                                      //课程编号
       protected String ctr;                                                                    //出题人
       protected List<ZSDY> zsdy_list;                                                  //课程下知识单元列表
       protected int num_zsdy_list;                                                        //知识单元数
       protected List<ZSD> []zsd_list;                                                   //知识点列表
       protected  int num_zsd_list=0;                                                     //知识点数
       protected ZSD[] zsd_list_all;

       protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {

                this.Response.Write("<script type='text/javascript'>window.parent.location='../Default.htm'</script>");
                this.Response.End();
            }

            else
            {
                YH yh = (YH)Session["yh"];
                ctr = yh.YHBH;                                                                  //出题人编号
            }

            kcbh = Convert.ToInt32(Request["kcbh"].ToString().Trim());
            zsdy_list = new List<ZSDY>();
            zsdy_list = new Get_ZSD_BLL().Get_ZSDY_ByKC(kcbh);          //知识单元列表
            num_zsdy_list = new Get_ZSD_BLL().Get_numOfZSDY(kcbh);//知识单元数    
            zsd_list = new List<ZSD>[num_zsdy_list];

            for (int i = 0; i <num_zsdy_list; i++)
            {
                zsd_list[i] = new List<ZSD>();
                zsd_list[i]=new Get_ZSD_BLL().Get_ZSD_ByZSDY(Convert.ToInt32(zsdy_list.ElementAt(i).ZSDYBH.ToString()));
                num_zsd_list += zsd_list[i].Count;                       //求知识点数
            }
          
            zsd_list_all=new ZSD[num_zsd_list];
            int k = 0;

           for(int i=0;i<num_zsdy_list;i++)
            {
                for (int j = 0; j < zsd_list[i].Count;j++)
                    zsd_list_all[k++] = zsd_list[i].ElementAt(j);
                
            }
            
        }
    
       //由知识单元编号获取知识单元实体
       protected ZSDY Get_ZSDYModel(int zsdybh)
       {
         return  new ZSDY_DAL().GetModel(zsdybh);
       }

        //知识点是否已出
       protected bool if_zsd_exit(int zsdbh)
       {
           return new Get_ZSD_BLL().ZSD_Exit(zsdbh);
       }
    }
}