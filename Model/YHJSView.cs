using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// YHJSView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YHJSView
	{
        public YHJSView()
        { }
        #region Model
        private string _jsm;
        private string _mm;
        private string _xm;
        private bool _xb;
        private string _yhbh;
        private int _jsbh;
        /// <summary>
        /// 
        /// </summary>
        public string JSM
        {
            set { _jsm = value; }
            get { return _jsm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string MM
        {
            set { _mm = value; }
            get { return _mm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string XM
        {
            set { _xm = value; }
            get { return _xm; }
        }
        /// <summary>
        /// 
        /// </summary>
        public bool XB
        {
            set { _xb = value; }
            get { return _xb; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string YHBH
        {
            set { _yhbh = value; }
            get { return _yhbh; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int JSBH
        {
            set { _jsbh = value; }
            get { return _jsbh; }
        }
        #endregion Model

	}
}

