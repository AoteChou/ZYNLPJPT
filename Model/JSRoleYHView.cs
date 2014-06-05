using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JSRoleYHView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JSRoleYHView
	{
		public JSRoleYHView()
		{}
		#region Model
		private string _yhbh;
		private string _xm;
		private bool _xb;
		private bool _sfsxkfzr;
		private bool _sfskcfzr;
		private int _ssxk;
		private string _xkmc;
		private int _xybh;
		private string _xymc;
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
		/// <summary>
		/// 
		/// </summary>
		public bool SFSXKFZR
		{
			set{ _sfsxkfzr=value;}
			get{return _sfsxkfzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool SFSKCFZR
		{
			set{ _sfskcfzr=value;}
			get{return _sfskcfzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SSXK
		{
			set{ _ssxk=value;}
			get{return _ssxk;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XKMC
		{
			set{ _xkmc=value;}
			get{return _xkmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int XYBH
		{
			set{ _xybh=value;}
			get{return _xybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XYMC
		{
			set{ _xymc=value;}
			get{return _xymc;}
		}
		#endregion Model

	}
}

