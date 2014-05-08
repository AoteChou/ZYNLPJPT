using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.BLL
{
    public class GetTest_BLL
    {
        /// <summary>
        /// 获取试题算法
        /// </summary>
        /// <param name="xsbh">学生编号</param>
        /// <param name="kcbh">课程编号</param>
        /// <returns>试题编号</returns>
        public int getSTBH(string xsbh,int kcbh, ref string msg) {
            //获取试题算法
            int stbh=-1;
            STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
            ST_Undone[] st_undoneArray=stzsdview_dal.getST_Undone(kcbh, xsbh);
            ST_DAL st_dal = new ST_DAL();
            System.Data.DataSet ds = st_dal.GetList("kcbh=" + kcbh + " and ST.SFSC = 'false' AND ST.SFZDYJ = 'false' AND ST.TMNR IS NOT NULL");
            System.Data.DataRowCollection allSTofThisKC = ds.Tables[0].Rows;
            if (allSTofThisKC.Count <= 0) { //该课程下没有试题
                msg = "出错啦 该门课程下还没有试题 请联系管理员~";
                return -1;
            }
            if (st_undoneArray.Length <= 0) { 
                //已经全部做完的情况下
                //step1：获取评测记录中 分数最低的题目
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                PCJL pcjl=pcjl_dal.getPCJLWithLowestMark(xsbh, kcbh);
                //step2：如果全部满分，则随机出题
                if (pcjl.PCFS == 100)
                {
                    int STcount = allSTofThisKC.Count;
                    Random r = new Random();
                    int randomBH = r.Next(0, STcount);
                    stbh = int.Parse(allSTofThisKC[randomBH]["stbh"].ToString());

                }
                else {
                    stbh = pcjl.STBH;
                }

            }
            else
            {
                //获取未涉及的知识点
                int[] zsd_undoneArray = stzsdview_dal.getZSD_Undone(kcbh, xsbh);
                //获取最匹配的知识点
                stbh = getbestST(st_undoneArray, zsd_undoneArray);
            }

            return stbh;
        }
        /// <summary>
        /// 查找最匹配的试题
        /// </summary>
        /// <param name="st_undoneArray">未完成的试题</param>
        /// <param name="zsd_undoneArray">未完成的知识点</param>
        /// <returns></returns>
        private int getbestST(ST_Undone[] st_undoneArray, int[] zsd_undoneArray)
        {
            int beststbh = 0;
            float bestundoneratio=0;
            int listCount=0;
            int undoneCount=0;
            foreach (ST_Undone st_undone in st_undoneArray) {
                
                listCount=st_undone.ZsdbhList.Count;
                undoneCount=0;
                for (int i = 0; i <listCount; i++) {

                    if (Array.IndexOf(zsd_undoneArray, st_undone.ZsdbhList[i]) >=0) { //找的到，即为没做过的知识点
                        undoneCount++;
                    }
                }
                float undoneRatio =  (float)undoneCount/(float)listCount ;
                //记录最高的
                if (undoneRatio > bestundoneratio) {
                    bestundoneratio = undoneRatio;
                    beststbh = st_undone.Stbh;
                }
                if(bestundoneratio==1){//找到100%符合的
                   break;
                }
            }
            return beststbh;
        }
    }
}