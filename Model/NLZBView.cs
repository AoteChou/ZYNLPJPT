using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// NLZBView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class NLZBView
	{
		public NLZBView()
		{}
		#region Model
		private int _xkbh;
		private int _yjzbbh;
		private int _ejzbbh;
		private string _yjzbmc;
		private string _ejzbmc;
		/// <summary>
		/// 
		/// </summary>
		public int XKBH
		{
			set{ _xkbh=value;}
			get{return _xkbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int YJZBBH
		{
			set{ _yjzbbh=value;}
			get{return _yjzbbh;}
		}
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
		public string YJZBMC
		{
			set{ _yjzbmc=value;}
			get{return _yjzbmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string EJZBMC
		{
			set{ _ejzbmc=value;}
			get{return _ejzbmc;}
		}
		#endregion Model

	}
}

