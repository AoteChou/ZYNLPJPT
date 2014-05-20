/**  版本信息模板在安装目录下，可自行修改。
* CPJD.cs
*
* 功 能： N/A
* 类 名： CPJD
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:11   N/A    初版
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
	/// CPJD:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CPJD
	{
		public CPJD()
		{}
		#region Model
		private int _njbh;
		private int _jdbh;
		private int _zybh;
		private string _jdmc;
		private int _qsxq;
		private int _jzxq;
		private string _cpjdjj;
		/// <summary>
		/// 
		/// </summary>
		public int NJBH
		{
			set{ _njbh=value;}
			get{return _njbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JDBH
		{
			set{ _jdbh=value;}
			get{return _jdbh;}
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
		public string JDMC
		{
			set{ _jdmc=value;}
			get{return _jdmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int QSXQ
		{
			set{ _qsxq=value;}
			get{return _qsxq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int JZXQ
		{
			set{ _jzxq=value;}
			get{return _jzxq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPJDJJ
		{
			set{ _cpjdjj=value;}
			get{return _cpjdjj;}
		}
		#endregion Model

	}
}

