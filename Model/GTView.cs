using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// GTView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GTView
	{
		public GTView()
		{}
		#region Model
		private int _pcjlbh;
		private int _stbh;
		private int _kcbh;
		private string _xsbh;
		private DateTime _xzrq;
		private DateTime? _scrq;
		private string _gtr;
		private int? _pcfs;
		/// <summary>
		/// 
		/// </summary>
		public int PCJLBH
		{
			set{ _pcjlbh=value;}
			get{return _pcjlbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int STBH
		{
			set{ _stbh=value;}
			get{return _stbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int KCBH
		{
			set{ _kcbh=value;}
			get{return _kcbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSBH
		{
			set{ _xsbh=value;}
			get{return _xsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime XZRQ
		{
			set{ _xzrq=value;}
			get{return _xzrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SCRQ
		{
			set{ _scrq=value;}
			get{return _scrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GTR
		{
			set{ _gtr=value;}
			get{return _gtr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PCFS
		{
			set{ _pcfs=value;}
			get{return _pcfs;}
		}
		#endregion Model

	}
}

