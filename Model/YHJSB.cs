using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// YHJSB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YHJSB
	{
		public YHJSB()
		{}
		#region Model
		private string _yhbh;
		private int _jsbh;
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
		public int JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
		}
		#endregion Model

	}
}

