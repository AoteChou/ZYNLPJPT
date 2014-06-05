using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ZYEJZB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZYEJZB
	{
		public ZYEJZB()
		{}
		#region Model
		private int _ejzbbh;
		private int _zybh;
		private int _nlyq;
		/// <summary>
		/// 
		/// </summary>
		public int EJZBBH
		{
			set{ _ejzbbh=value;}
			get{return _ejzbbh;}
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
		public int NLYQ
		{
			set{ _nlyq=value;}
			get{return _nlyq;}
		}
		#endregion Model

	}
}

