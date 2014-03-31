/**  版本信息模板在安装目录下，可自行修改。
* STZSDView.cs
*
* 功 能： N/A
* 类 名： STZSDView
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:30   N/A    初版
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
	/// STZSDView:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class STZSDView
	{
		public STZSDView()
		{}
		#region Model
		private string _zslymc;
		private string _zsly_bz;
		private int? _ejzbbh;
		private string _zsdymc;
		private string _zsdy_bz;
		private string _zsdmc;
		private string _zsd_bz;
		private int _zslybh;
		private int _zsdybh;
		private int _zsdbh;
		private int _stbh;
		private decimal _zsdbz;
		private int _kcbh;
		private DateTime _ctsj;
		private string _ctr;
		private int _sfsc;
		private string _kcmc;
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
		public string ZSLY_BZ
		{
			set{ _zsly_bz=value;}
			get{return _zsly_bz;}
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
		public string ZSDY_BZ
		{
			set{ _zsdy_bz=value;}
			get{return _zsdy_bz;}
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
		public string ZSD_BZ
		{
			set{ _zsd_bz=value;}
			get{return _zsd_bz;}
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
		public DateTime CTSJ
		{
			set{ _ctsj=value;}
			get{return _ctsj;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CTR
		{
			set{ _ctr=value;}
			get{return _ctr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SFSC
		{
			set{ _sfsc=value;}
			get{return _sfsc;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string KCMC
		{
			set{ _kcmc=value;}
			get{return _kcmc;}
		}
		#endregion Model

	}
}

