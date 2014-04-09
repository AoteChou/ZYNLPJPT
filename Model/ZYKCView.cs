
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// ZYKCView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZYKCView
	{
		public ZYKCView()
		{}
		#region Model
		private string _kcjj;
		private string _kcmc;
		private int _xkbh;
		private string _zym;
		private string _zyfzr;
		private int _kcbh;
		private int _zybh;
		private int? _kcxzbh;
		private int _kkxq;
		private decimal? _llxf;
		private decimal? _sjxf;
		private string _kcxzmc;
        private string _xkmc;

        public string XKMC {
            set { _xkmc = value; }
            get { return _xkmc; }
        }

		/// <summary>
		/// 
		/// </summary>
		public string KCJJ
		{
			set{ _kcjj=value;}
			get{return _kcjj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KCMC
		{
			set{ _kcmc=value;}
			get{return _kcmc;}
		}
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
		public string ZYM
		{
			set{ _zym=value;}
			get{return _zym;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYFZR
		{
			set{ _zyfzr=value;}
			get{return _zyfzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int KCBH
		{
			set{ _kcbh=value;}
			get{return _kcbh;}
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
		public int? KCXZBH
		{
			set{ _kcxzbh=value;}
			get{return _kcxzbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int KKXQ
		{
			set{ _kkxq=value;}
			get{return _kkxq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? LLXF
		{
			set{ _llxf=value;}
			get{return _llxf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? SJXF
		{
			set{ _sjxf=value;}
			get{return _sjxf;}
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

