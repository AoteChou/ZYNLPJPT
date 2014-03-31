/**  版本信息模板在安装目录下，可自行修改。
* JS.cs
*
* 功 能： N/A
* 类 名： JS
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:12   N/A    初版
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

