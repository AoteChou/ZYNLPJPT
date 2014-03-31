/**  版本信息模板在安装目录下，可自行修改。
* ZYKC.cs
*
* 功 能： N/A
* 类 名： ZYKC
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:26   N/A    初版
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
	/// ZYKC:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ZYKC
	{
		public ZYKC()
		{}
		#region Model
		private int _kcbh;
		private int _zybh;
		private int _kcxzbh;
		private int _kkxq;
		private decimal _llxf;
		private decimal _sjxf;
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
		public int KCXZBH
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
		public decimal LLXF
		{
			set{ _llxf=value;}
			get{return _llxf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal SJXF
		{
			set{ _sjxf=value;}
			get{return _sjxf;}
		}
		#endregion Model

	}
}

