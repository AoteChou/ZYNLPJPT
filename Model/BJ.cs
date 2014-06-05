using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// BJ:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BJ
	{
		public BJ()
		{}
		#region Model
		private int _bjbh;
		private int _njbh;
		private int _zybh;
		private string _bjmc;
		private DateTime _rxnf;
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
		public int NJBH
		{
			set{ _njbh=value;}
			get{return _njbh;}
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
		public string BJMC
		{
			set{ _bjmc=value;}
			get{return _bjmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RXNF
		{
			set{ _rxnf=value;}
			get{return _rxnf;}
		}
		#endregion Model

	}
}

