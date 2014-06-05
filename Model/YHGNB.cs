using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// YHGNB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YHGNB
	{
		public YHGNB()
		{}
		#region Model
		private int _gnbh;
		private string _yhbh;
		/// <summary>
		/// 
		/// </summary>
		public int GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YHBH
		{
			set{ _yhbh=value;}
			get{return _yhbh;}
		}
		#endregion Model

	}
}

