using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// NJZYKC:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NJZYKC
	{
		public NJZYKC()
		{}
		#region Model
		private int _kcbh;
		private int _zybh;
		private int _njbh;
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
		public int ZYBH
		{
			set{ _zybh=value;}
			get{return _zybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NJBH
		{
			set{ _njbh=value;}
			get{return _njbh;}
		}
		#endregion Model

	}
}

