﻿using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// KCDetailView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KCDetailView
	{
		public KCDetailView()
		{}
		#region Model
		private int _kcbh;
		private string _kcmc;
		private string _kcjj;
		private string _kcfzr;
		private int _kkxk;
		private string _xkmc;
		private int _xybh;
		private string _xymc;
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
		public string KCMC
		{
			set{ _kcmc=value;}
			get{return _kcmc;}
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
		public string KCFZR
		{
			set{ _kcfzr=value;}
			get{return _kcfzr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int KKXK
		{
			set{ _kkxk=value;}
			get{return _kkxk;}
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

