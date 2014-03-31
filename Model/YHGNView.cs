/**  版本信息模板在安装目录下，可自行修改。
* YHGNView.cs
*
* 功 能： N/A
* 类 名： YHGNView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:31   N/A    初版
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
	/// YHGNView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class YHGNView
	{
		public YHGNView()
		{}
		#region Model
		private string _gnm;
		private string _gnlj;
		private string _ssml;
		private int _gnbh;
		private string _yhbh;
		/// <summary>
		/// 
		/// </summary>
		public string GNM
		{
			set{ _gnm=value;}
			get{return _gnm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GNLJ
		{
			set{ _gnlj=value;}
			get{return _gnlj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSML
		{
			set{ _ssml=value;}
			get{return _ssml;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int GNBH
		{
			set{ _gnbh=value;}
			get{return _gnbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string YHBH
		{
			set{ _yhbh=value;}
			get{return _yhbh;}
		}
		#endregion Model

	}
}

