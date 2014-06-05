using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// CT:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CT
	{
		public CT()
		{}
		#region Model
		private int _kcbh;
		private int _zybh;
		private string _ctr;
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
		public string CTR
		{
			set{ _ctr=value;}
			get{return _ctr;}
		}
		#endregion Model

	}
}

