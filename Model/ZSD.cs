using System;
namespace ZYNLPJPT.Model
{
    /// <summary>
    /// ZSD:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class ZSD
    {
        public ZSD()
        { }
        #region Model
        private int _zslybh;
        private int _zsdybh;
        private int _zsdbh;
        private string _zsdmc;
        private string _bz;
        private int _zsdqz;
        /// <summary>
        /// 
        /// </summary>
        public int ZSLYBH
        {
            set { _zslybh = value; }
            get { return _zslybh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ZSDYBH
        {
            set { _zsdybh = value; }
            get { return _zsdybh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int ZSDBH
        {
            set { _zsdbh = value; }
            get { return _zsdbh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string ZSDMC
        {
            set { _zsdmc = value; }
            get { return _zsdmc; }
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
        public int ZSDQZ
        {
            set { _zsdqz = value; }
            get { return _zsdqz; }
        }
        #endregion Model

    }
}