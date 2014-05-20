
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// JS:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JS
	{
		public JS()
		{}
		#region Model
		private string _jsbh;
		private bool _sfsxkfzr;
		private bool _sfskcfzr;
		private int _ssxk;
		/// <summary>
		/// 
		/// </summary>
		public string JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
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

