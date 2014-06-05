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

