using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// KCXZ:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KCXZ
	{
		public KCXZ()
		{}
		#region Model
		private int _kcxzbh;
		private string _kcxzmc;
		/// <summary>
		/// 
		/// </summary>
		public int KCXZBH
		{
			set{ _kcxzbh=value;}
			get{return _kcxzbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KCXZMC
		{
			set{ _kcxzmc=value;}
			get{return _kcxzmc;}
		}
		#endregion Model

	}
}

