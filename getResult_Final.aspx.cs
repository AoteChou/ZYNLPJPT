using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT
{
    public partial class getResult_Final : System.Web.UI.Page
    {
        protected int xkbh;
        protected int zybh;
        protected int result;
        protected string xsbh;
        //protected string yjzbCatagories;
        protected string yjzbData;
        protected string drilldownSeries;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["yh"] == null)
            {
                this.Response.Write("<script type='text/javascript'>window.parent.location='Default.htm'</script>");
                this.Response.End();

            }
            else
            {
                YH yh = (YH)Session["yh"];
                xsbh = yh.YHBH;
               
                List<ZBMCAndFS> yjzbmcAndFsList=new List<ZBMCAndFS>();
                result=ZYNLPJPT.BLL.GetTestResult_BLL.getTestResult_Final(xsbh,ref yjzbmcAndFsList);
                //yjzbCatagories = "[";
                yjzbData = "[";
                drilldownSeries = "[";
                for (int i = 0; i < yjzbmcAndFsList.Count;i++ )
                {
                    //Response.Write(yjzbmcAndFsList[i].Zbmc + "  " + yjzbmcAndFsList[i].Fs);
                    if (i == 0)
                    {
                        //yjzbCatagories +=  "'"+yjzbmcAndFsList[i].Zbmc+"'";
                        yjzbData += "{ name:'" + yjzbmcAndFsList[i].Zbmc + "',y:" + yjzbmcAndFsList[i].Fs + ",drilldown: '" + i + "'}";
                        drilldownSeries += "{ id: '" + i + "', data: [";
                    }
                    else {
                        //yjzbCatagories += ",'" + yjzbmcAndFsList[i].Zbmc + "'";
                        yjzbData += "," + "{ name:'" + yjzbmcAndFsList[i].Zbmc + "',y:" + yjzbmcAndFsList[i].Fs + ",drilldown: '" + i + "'}";
                        drilldownSeries += ",{ id: '" + i + "', data: [";
                    }



                    List<ZBMCAndFS> ejzbmcAndFsList = yjzbmcAndFsList[i].MCandFS_child;
                    for (int j = 0; j < ejzbmcAndFsList.Count; j++)
                    {
                       // Response.Write(ejzbmcAndFsList[j].Zbmc + "  " + ejzbmcAndFsList[j].Fs);
                        if (j == 0) {
                            drilldownSeries += "['" + ejzbmcAndFsList[j].Zbmc + "',"+ejzbmcAndFsList[j].Fs+"]";
                        }
                        else
                        {
                            drilldownSeries += ",['" + ejzbmcAndFsList[j].Zbmc + "'," + ejzbmcAndFsList[j].Fs + "]";
                            
                        }
                        
                    }
                    drilldownSeries += "]}";
                    
                }
                //yjzbCatagories += "]";
                yjzbData += "]";
                drilldownSeries += "]";

            }
        }
    }
}