using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// CPJD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CPJD
	{
		public CPJD()
		{}
		#region Model
		private int _njbh;
		private int _jdbh;
		private int _zybh;
		private string _jdmc;
		private int _qsxq;
		private int _jzxq;
		private string _cpjdjj;
		/// <summary>
		/// 
		/// </summary>
		public int NJBH
		{
			set{ _njbh=value;}
			get{return _njbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JDBH
		{
			set{ _jdbh=value;}
			get{return _jdbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ZYBH
		{
			set{ _zybh=value;}
			get{return _zybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDMC
		{
			set{ _jdmc=value;}
			get{return _jdmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int QSXQ
		{
			set{ _qsxq=value;}
			get{return _qsxq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JZXQ
		{
			set{ _jzxq=value;}
			get{return _jzxq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPJDJJ
		{
			set{ _cpjdjj=value;}
			get{return _cpjdjj;}
		}
		#endregion Model

	}
}

