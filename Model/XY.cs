/**  版本信息模板在安装目录下，可自行修改。
* XY.cs
*
* 功 能： N/A
* 类 名： XY
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:19   N/A    初版
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
	/// XY:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XY
	{
		public XY()
		{}
		#region Model
		private int _xybh;
		private string _xymc;
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

