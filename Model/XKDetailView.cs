﻿using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// XKDetailView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XKDetailView
	{
		public XKDetailView()
		{}
		#region Model
		private int _xkbh;
		private int _xybh;
		private string _xkfzr;
		private string _xkmc;
		private string _xymc;
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
		public int XYBH
		{
			set{ _xybh=value;}
			get{return _xybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XKFZR
		{
			set{ _xkfzr=value;}
			get{return _xkfzr;}
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
		public string XYMC
		{
			set{ _xymc=value;}
			get{return _xymc;}
		}
		#endregion Model

	}
}

