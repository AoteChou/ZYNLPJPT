/**  版本信息模板在安装目录下，可自行修改。
* ZSNLView.cs
*
* 功 能： N/A
* 类 名： ZSNLView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/14 18:23:19   N/A    初版
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
	/// ZSNLView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZSNLView
	{
		public ZSNLView()
		{}
		#region Model
		private int _zslybh;
		private int _zsdybh;
		private int? _ejzbbh;
		private string _zsdymc;
		private string _bz;
		private string _zslymc;
		private int _xkbh;
		/// <summary>
		/// 
		/// </summary>
		public int ZSLYBH
		{
			set{ _zslybh=value;}
			get{return _zslybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ZSDYBH
		{
			set{ _zsdybh=value;}
			get{return _zsdybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EJZBBH
		{
			set{ _ejzbbh=value;}
			get{return _ejzbbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZSDYMC
		{
			set{ _zsdymc=value;}
			get{return _zsdymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BZ
		{
			set{ _bz=value;}
			get{return _bz;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZSLYMC
		{
			set{ _zslymc=value;}
			get{return _zslymc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int XKBH
		{
			set{ _xkbh=value;}
			get{return _xkbh;}
		}
		#endregion Model

	}
}

