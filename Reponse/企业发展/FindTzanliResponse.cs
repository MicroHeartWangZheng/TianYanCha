using System.Collections.Generic;
using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class FindTzanliResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<FindTzanliItem> Items { get; set; }
	}

	public class FindTzanliItem
	{
		/// <summary>
		/// 红手指
		/// </summary>
		[JsonProperty("product")]
		public string Product { get; set; }

		/// <summary>
		/// A轮
		/// </summary>
		[JsonProperty("lunci")]
		public string Lunci { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("company_id")]
		public string CompanyId { get; set; }

		/// <summary>
		/// {百度投资部:22822}
		/// </summary>
		[JsonProperty("rongzi_map")]
		public string RongziMap { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 百度投资部
		/// </summary>
		[JsonProperty("organization_name")]
		public string OrganizationName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("tzdate")]
		public long Tzdate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("graph_id")]
		public string GraphId { get; set; }

		/// <summary>
		/// ARM云计算研发服务商
		/// </summary>
		[JsonProperty("yewu")]
		public string Yewu { get; set; }

		/// <summary>
		/// 未披露
		/// </summary>
		[JsonProperty("money")]
		public string Money { get; set; }

		/// <summary>
		/// 湖南
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

		/// <summary>
		/// 湖南微算互联信息技术有限公司
		/// </summary>
		[JsonProperty("company")]
		public string Company { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("iconOssPath")]
		public string IconOssPath { get; set; }

		/// <summary>
		/// 企业服务
		/// </summary>
		[JsonProperty("hangye1")]
		public string Hangye1 { get; set; }
	}
}