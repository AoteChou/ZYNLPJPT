/**  版本信息模板在安装目录下，可自行修改。
* STZSDB.cs
*
* 功 能： N/A
* 类 名： STZSDB
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:17   N/A    初版
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
	/// STZSDB:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STZSDB
	{
		public STZSDB()
		{}
		#region Model
		private int _zslybh;
		private int _zsdybh;
		private int _zsdbh;
		private int _stbh;
		private decimal _zsdbz;
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
		public int ZSDBH
		{
			set{ _zsdbh=value;}
			get{return _zsdbh;}
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
		public decimal ZSDBZ
		{
			set{ _zsdbz=value;}
			get{return _zsdbz;}
		}
		#endregion Model

	}
}

