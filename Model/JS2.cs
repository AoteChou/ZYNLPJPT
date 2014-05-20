/**  版本信息模板在安装目录下，可自行修改。
* JS2.cs
*
* 功 能： N/A
* 类 名： JS2
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2014/3/31 16:02:13   N/A    初版
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
	/// JS2:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class JS2
	{
		public JS2()
		{}
		#region Model
		private int _jsbh;
		private string _jsm;
        private string _jsjj;
		/// <summary>
		/// 
		/// </summary>
		public int JSBH
		{
			set{ _jsbh=value;}
			get{return _jsbh;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JSM
		{
			set{ _jsm=value;}
			get{return _jsm;}
		}
        /// <summary>
        /// 
        /// </summary>
        public string JSJJ
        {
            set { _jsjj = value; }
            get { return _jsjj; }
        }
		#endregion Model

	}
}

