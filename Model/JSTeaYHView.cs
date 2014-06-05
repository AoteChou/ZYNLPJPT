using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JSTeaYHView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JSTeaYHView
	{
		public JSTeaYHView()
		{}
		#region Model
		private string _yhbh;
		private string _mm;
		private string _xm;
		private bool _xb;
		private bool _sfsxkfzr;
		private bool _sfskcfzr;
		private int _ssxk;
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
		#endregion Model

	}
}

