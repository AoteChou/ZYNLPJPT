/**  版本信息模板在安装目录下，可自行修改。
* BjXsDetailView.cs
*
* 功 能： N/A
* 类 名： BjXsDetailView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/17 22:46:07   N/A    初版
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
	/// BjXsDetailView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BjXsDetailView
	{
		public BjXsDetailView()
		{}
		#region Model
		private int _bjbh;
		private int _njbh;
		private int _zybh;
		private string _bjmc;
		private DateTime _rxnf;
		private string _xsbh;
		private DateTime? _expr1;
		private string _xm;
		private bool _xb;
		private string _zym;
		private int _xkbh;
		private string _xkmc;
		/// <summary>
		/// 
		/// </summary>
		public int BJBH
		{
			set{ _bjbh=value;}
			get{return _bjbh;}
		}
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
		public int ZYBH
		{
			set{ _zybh=value;}
			get{return _zybh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BJMC
		{
			set{ _bjmc=value;}
			get{return _bjmc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RXNF
		{
			set{ _rxnf=value;}
			get{return _rxnf;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XSBH
		{
			set{ _xsbh=value;}
			get{return _xsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Expr1
		{
			set{ _expr1=value;}
			get{return _expr1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string XM
		{
			set{ _xm=value;}
			get{return _xm;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool XB
		{
			set{ _xb=value;}
			get{return _xb;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ZYM
		{
			set{ _zym=value;}
			get{return _zym;}
		}
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
		#endregion Model

	}
}

