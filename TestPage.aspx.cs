using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZYNLPJPT.DAL;
using ZYNLPJPT.Model;
using ZYNLPJPT.Utility;

namespace ZYNLPJPT
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected STZSDView[] stzsdviews;
        protected int stbh;
        protected int teststate;
        protected void Page_Load(object sender, EventArgs e)
        {
            stbh=int.Parse( Request["stbh"]);
            STZSDView_DAL stzsdview_dal = new STZSDView_DAL();
            stzsdviews = stzsdview_dal.getbySTBH(stbh);
           
            teststate=int.Parse(Request["teststate"]);

                        
        }
    }
}