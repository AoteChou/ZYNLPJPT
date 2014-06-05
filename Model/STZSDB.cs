using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// STZSDB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STZSDB
	{
		public STZSDB()
		{}
		#region Model
		private int _zslybh;
		private int _zsdybh;
		private int _zsdbh;
		private int _stbh;
		private decimal _zsdbz;
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
		public int ZSDBH
		{
			set{ _zsdbh=value;}
			get{return _zsdbh;}
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
		public decimal ZSDBZ
		{
			set{ _zsdbz=value;}
			get{return _zsdbz;}
		}
		#endregion Model

	}
}

