using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// YH:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YH
	{
		public YH()
		{}
		#region Model
		private string _yhbh;
		private string _mm;
		private string _xm;
		private bool _xb;
		/// <summary>
		/// 
		/// </summary>
		public string YHBH
		{
			set{ _yhbh=value;}
			get{return _yhbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MM
		{
			set{ _mm=value;}
			get{return _mm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XM
		{
			set{ _xm=value;}
			get{return _xm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool XB
		{
			set{ _xb=value;}
			get{return _xb;}
		}
		#endregion Model

	}
}

