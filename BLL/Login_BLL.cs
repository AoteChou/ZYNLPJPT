using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZYNLPJPT.Model;
using ZYNLPJPT.DAL;

namespace ZYNLPJPT.BLL
{
    public class Login_BLL
    {
        public bool isVailedYH(string _yhbh,string _mm) {
            if (isNull(_yhbh, _mm))
            {
                return false;
            }
            else {
                if (new YH_DAL().isExist(_yhbh.Trim(),_mm.Trim()))
                {
                    return true;
                }
                else {
                    return false;
                }
            }
        }

        protected bool isNull(string _yhbh, string _mm)
        {
            if (_yhbh == null || _mm == null)
            {
                return true;
            }else
            {
                return false;
            }
        }

        public YH getYH(string yhbh) {
            return new YH_DAL().GetModel(yhbh);
        }

    }
}