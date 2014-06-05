using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ZSNLView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZSNLView
	{
		public ZSNLView()
		{}
		#region Model
		private int _zslybh;
		private int _zsdybh;
		private int? _ejzbbh;
		private string _zsdymc;
		private string _bz;
		private string _zslymc;
		private int _xkbh;
        private int _zsdyqz;
		/// <summary>
		/// 
		/// </summary>
		public int ZSLYBH
		{
			set{ _zslybh=value;}
			get{return _zslybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ZSDYBH
		{
			set{ _zsdybh=value;}
			get{return _zsdybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EJZBBH
		{
			set{ _ejzbbh=value;}
			get{return _ejzbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZSDYMC
		{
			set{ _zsdymc=value;}
			get{return _zsdymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZSLYMC
		{
			set{ _zslymc=value;}
			get{return _zslymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int XKBH
		{
			set{ _xkbh=value;}
			get{return _xkbh;}
		}
        /// <summary>
        /// 
        /// </summary>
        public int ZSDYQZ
        {
            set { _zsdyqz = value; }
            get { return _zsdyqz; }
        }
		#endregion Model

	}
}

