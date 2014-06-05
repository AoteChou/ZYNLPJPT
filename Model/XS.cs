using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// XS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XS
	{
		public XS()
		{}
		#region Model
		private int _bjbh;
		private string _xsbh;
		private DateTime? _rxnf;
		/// <summary>
		/// 
		/// </summary>
		public int BJBH
		{
			set{ _bjbh=value;}
			get{return _bjbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSBH
		{
			set{ _xsbh=value;}
			get{return _xsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? RXNF
		{
			set{ _rxnf=value;}
			get{return _rxnf;}
		}
		#endregion Model

	}
}

