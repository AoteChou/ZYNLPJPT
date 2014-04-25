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
        private string _bz;
        private int _xkbh;
        private int _yjzbqz;
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
        public string BZ
        {
            set { _bz = value; }
            get { return _bz; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int XKBH
        {
            set { _xkbh = value; }
            get { return _xkbh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int YJZBQZ
        {
            set { _yjzbqz = value; }
            get { return _yjzbqz; }
        }
        #endregion Model

    }
}
