using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// PCJL:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class PCJL
	{
		public PCJL()
		{}
		#region Model
		private int _stbh;
		private string _xsbh;
		private DateTime _xzrq;
		private DateTime? _scrq;
		private int? _pcfs;
		private int _pcjlbh;
		private string _gtr;
		private byte[] _xsstda;
		private string _hzm;
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
		public int? PCFS
		{
			set{ _pcfs=value;}
			get{return _pcfs;}
		}
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
		public string GTR
		{
			set{ _gtr=value;}
			get{return _gtr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] XSSTDA
		{
			set{ _xsstda=value;}
			get{return _xsstda;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string HZM
		{
			set{ _hzm=value;}
			get{return _hzm;}
		}
		#endregion Model

	}
}

