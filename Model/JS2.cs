using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JS2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JS2
	{
		public JS2()
		{}
		#region Model
		private int _jsbh;
		private string _jsm;
        private string _jsjj;
		/// <summary>
		/// 
		/// </summary>
		public int JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSM
		{
			set{ _jsm=value;}
			get{return _jsm;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string JSJJ
        {
            set { _jsjj = value; }
            get { return _jsjj; }
        }
		#endregion Model

	}
}

