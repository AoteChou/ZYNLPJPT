using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// KCZSDY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KCZSDY
	{
		public KCZSDY()
		{}
		#region Model
		private int _kcbh;
		private int _zslybh;
		private int _zsdybh;
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
		#endregion Model

	}
}

