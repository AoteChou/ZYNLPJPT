using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ZSTXView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZSTXView
	{
		public ZSTXView()
		{}
		#region Model
		private int _xkbh;
		private int _zslybh;
		private int _zsdybh;
		private string _zslymc;
		private string _zsdymc;
		private int? _ejzbbh;
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
		public string ZSLYMC
		{
			set{ _zslymc=value;}
			get{return _zslymc;}
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
		public int? EJZBBH
		{
			set{ _ejzbbh=value;}
			get{return _ejzbbh;}
		}
		#endregion Model

	}
}

