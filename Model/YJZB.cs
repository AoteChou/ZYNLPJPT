﻿
using System;
namespace ZYNLPJPT.Model
{
    /// <summary>
    /// YJZB:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class YJZB
    {
        public YJZB()
        { }
        #region Model
        private int _yjzbbh;
        private string _yjzbmc;
        private int _xkbh;
        /// <summary>
        /// 
        /// </summary>
        public int YJZBBH
        {
            set { _yjzbbh = value; }
            get { return _yjzbbh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YJZBMC
        {
            set { _yjzbmc = value; }
            get { return _yjzbmc; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int XKBH
        {
            set { _xkbh = value; }
            get { return _xkbh; }
        }
        #endregion Model

    }
}

