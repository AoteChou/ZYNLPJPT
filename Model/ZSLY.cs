
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ZSLY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZSLY
	{
		public ZSLY()
		{}
		#region Model
        private int _zslybh;
        private string _zslymc;
        private string _bz;
        private int _xkbh;
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
        public string ZSLYMC
        {
            set { _zslymc = value; }
            get { return _zslymc; }
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
		#endregion Model

	}
}

