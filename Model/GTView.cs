/**  版本信息模板在安装目录下，可自行修改。
* GTView.cs
*
* 功 能： N/A
* 类 名： GTView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/28 17:41:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace ZYNLPJPT.Model
{
	/// <summary>
	/// GTView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GTView
	{
		public GTView()
		{}
		#region Model
		private int _pcjlbh;
		private int _stbh;
		private int _kcbh;
		private string _xsbh;
		private DateTime _xzrq;
		private DateTime? _scrq;
		private string _gtr;
		private int? _pcfs;
		/// <summary>
		/// 
		/// </summary>
		public int PCJLBH
		{
			set{ _pcjlbh=value;}
			get{return _pcjlbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int STBH
		{
			set{ _stbh=value;}
			get{return _stbh;}
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
		public string XSBH
		{
			set{ _xsbh=value;}
			get{return _xsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime XZRQ
		{
			set{ _xzrq=value;}
			get{return _xzrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SCRQ
		{
			set{ _scrq=value;}
			get{return _scrq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GTR
		{
			set{ _gtr=value;}
			get{return _gtr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? PCFS
		{
			set{ _pcfs=value;}
			get{return _pcfs;}
		}
		#endregion Model

	}
}

