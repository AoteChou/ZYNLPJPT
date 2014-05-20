/**  版本信息模板在安装目录下，可自行修改。
* ZYNLZBView.cs
*
* 功 能： N/A
* 类 名： ZYNLZBView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/28 19:19:10   N/A    初版
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
	/// ZYNLZBView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZYNLZBView
	{
		public ZYNLZBView()
		{}
		#region Model
		private int _yjzbbh;
		private int _ejzbbh;
		private int _zybh;
		private int _nlyq;
		private string _ejzbmc;
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
		public int ZYBH
		{
			set{ _zybh=value;}
			get{return _zybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int NLYQ
		{
			set{ _nlyq=value;}
			get{return _nlyq;}
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

