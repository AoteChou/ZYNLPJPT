/**  版本信息模板在安装目录下，可自行修改。
* XKZSTXView.cs
*
* 功 能： N/A
* 类 名： XKZSTXView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/4/25 15:33:40   N/A    初版
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
	/// XKZSTXView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class XKZSTXView
	{
		public XKZSTXView()
		{}
		#region Model
		private int _xkbh;
		private string _xkmc;
		private int _zslybh;
		private int _zsdybh;
		private int _zsdbh;
		private string _zsdmc;
		private string _zsdymc;
		private string _zslymc;
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
		public string ZSDMC
		{
			set{ _zsdmc=value;}
			get{return _zsdmc;}
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
		public string ZSLYMC
		{
			set{ _zslymc=value;}
			get{return _zslymc;}
		}
		#endregion Model

	}
}

