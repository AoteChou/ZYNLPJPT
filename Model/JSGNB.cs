using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JSGNB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JSGNB
	{
		public JSGNB()
		{}
		#region Model
		private int _jsbh;
		private int _gnbh;
		private bool _sfmrgn;
		/// <summary>
		/// 
		/// </summary>
		public int JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
		}
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
		public bool SFMRGN
		{
			set{ _sfmrgn=value;}
			get{return _sfmrgn;}
		}
		#endregion Model

	}
}

