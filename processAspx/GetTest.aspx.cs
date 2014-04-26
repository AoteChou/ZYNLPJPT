using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.BLL;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT.processAspx
{
    public partial class GetTest : System.Web.UI.Page
    {
        //获取题目 检测是否存在还未完成的题目 否则用出题算法给出一道新题目
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Redirect("Default.htm");
            }
            else
            {
                YH yh = (YH)(Session["yh"]);
                int kcbh = int.Parse(Request["kcbh"]);
                GetTest_BLL gettest_bll = new GetTest_BLL();
                int teststate = -1;
                int stbh=-1;
                string xsbh=yh.YHBH;
                int pcjlbh=-1;
                PCJL_DAL pcjl_dal = new PCJL_DAL();
                PCJL pcjl = pcjl_dal.getPCJL_Undone(xsbh, kcbh);
                if (pcjl == null || Request["SFZJT"]!=null)//如果没有旧题就做新题  是否做旧题不是空的话就表示不出以前下的没有做的题目
                {
                    string msg="";//获取试题的消息，如果出错看msg返回的是什么
                    stbh = gettest_bll.getSTBH(xsbh, kcbh,ref msg);
                    if (stbh == -1) { //获取试题失败的话
                        Response.Redirect("./ErrorPage.aspx?msg="+msg+"&fh=true");
                    }
                    teststate = TestState.NEWTEST;
                    pcjl = new PCJL();
                    pcjl.STBH = stbh;
                    pcjl.XSBH = xsbh;
                    pcjl.XZRQ = DateTime.Now;

                    pcjlbh=pcjl_dal.Add(pcjl);

                }
                else
                {
                    //完成未完成的测试
                    stbh = pcjl.STBH;
                    pcjlbh = pcjl.PCJLBH;
                    teststate = TestState.UNDONETEST;
                }
                Response.Redirect("../TestPage.aspx?stbh=" + stbh + "&teststate=" + teststate+"&pcjlbh="+pcjlbh+"&kcbh="+kcbh);
            }
        }
    }
}