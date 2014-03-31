/**  版本信息模板在安装目录下，可自行修改。
* KC.cs
*
* 功 能： N/A
* 类 名： KC
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:14   N/A    初版
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
	/// KC:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class KC
	{
		public KC()
		{}
		#region Model
		private int _kcbh;
		private string _kcjj;
		private string _kcmc;
		private string _kcfzr;
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
		public string KCFZR
		{
			set{ _kcfzr=value;}
			get{return _kcfzr;}
		}
		#endregion Model

	}
}

