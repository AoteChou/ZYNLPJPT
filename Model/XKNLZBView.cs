/**  版本信息模板在安装目录下，可自行修改。
* XKNLZBView.cs
*
* 功 能： N/A
* 类 名： XKNLZBView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/27 15:27:42   N/A    初版
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
	/// XKNLZBView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XKNLZBView
	{
		public XKNLZBView()
		{}
		#region Model
		private int _xkbh;
		private string _xkmc;
		private int _yjzbbh;
		private string _yjzbmc;
		private int _ejzbbh;
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
		public string XKMC
		{
			set{ _xkmc=value;}
			get{return _xkmc;}
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
		public string YJZBMC
		{
			set{ _yjzbmc=value;}
			get{return _yjzbmc;}
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
		public string EJZBMC
		{
			set{ _ejzbmc=value;}
			get{return _ejzbmc;}
		}
		#endregion Model

	}
}

