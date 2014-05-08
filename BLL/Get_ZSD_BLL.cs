using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;
using System.Data;

namespace ZYNLPJPT.BLL
{
    public class Get_ZSD_BLL
    {

        //知识点所在知识单元编号
        public int get_ZSDYBH_ByZSD(int zsdbh)
        {
            string sql = " zsdbh"+zsdbh;
            ZSD zsd = new ZSD_DAL().GetModel(zsdbh);
            return zsd.ZSDYBH;
        
        }

        //知识单元编号获得知识领域编号
        public int get_ZSLYBH_ByZSDY(int zsdybh)
        {
            ZSDY zsly = new ZSDY_DAL().GetModel(zsdybh);
            return zsly.ZSLYBH;
        
        }

        //获取课程中包含的知识单元
        public List<ZSDY> Get_ZSDY_ByKC(int kcbh)
        {
            String sql = " kcbh="+kcbh.ToString();
            DataSet ds = new KCZSDY_DAL().GetList(sql);
            List<ZSDY> zsdy_list = new List<ZSDY>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int zsdybh =Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());     //知识单元编号
                ZSDY zsdy = new ZSDY();
                zsdy = new ZSDY_DAL().GetModel(zsdybh);
                zsdy_list.Add(zsdy);
            }

            return zsdy_list;
        }

       //获取知识单元数
        public int Get_numOfZSDY(int kcbh)
        {
          return this.Get_ZSDY_ByKC(kcbh).Count;
        }

        //获取知识单元下面的知识点
        public List<ZSD> Get_ZSD_ByZSDY(int zsdybh)
        {
            String sql = "zsdybh=" + zsdybh.ToString();
            DataSet ds = new ZSD_DAL().GetList(sql);
            List<ZSD> zsd_list = new List<ZSD>();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                ZSD  zsd  = new ZSD();
                zsd.ZSDBH=Convert.ToInt32(ds.Tables[0].Rows[i][2].ToString());
                zsd.ZSDMC=ds.Tables[0].Rows[i][3].ToString();
                zsd.ZSDYBH=Convert.ToInt32(ds.Tables[0].Rows[i][1].ToString());
                zsd.ZSLYBH=Convert.ToInt32(ds.Tables[0].Rows[i][0].ToString());
                zsd.BZ=ds.Tables[0].Rows[i][4].ToString();
                zsd_list.Add(zsd);
            }

            return zsd_list;
        }

        //获取知识点数
        public int Get_numOfZSD(int zsdybh)
        {
            return this.Get_ZSD_ByZSDY(zsdybh).Count;
        }

        //获取整个课程的知识点
        public List<ZSD> Get_ZSDbyKC(int kcbh)
        {
            return null;
        
        }
    }
}