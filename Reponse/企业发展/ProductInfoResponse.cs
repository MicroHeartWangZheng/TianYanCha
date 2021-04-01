using System.Collections.Generic;
using Newtonsoft.Json;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class ProductInfoResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long? Total { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<GetProductInfoItem> Items { get; set; }
	}

	public class GetProductInfoItem
	{
		/// <summary>
		/// 百度灵医
		/// </summary>
		[JsonProperty("product")]
		public string Product { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logoOssPath")]
		public string LogoOssPath { get; set; }


		public string SetupDate => Setup.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("setupDate")]
		public long? Setup { get; set; }

		/// <summary>
		/// AI医疗服务平台
		/// </summary>
		[JsonProperty("yewu")]
		public string Yewu { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("graphId")]
		public long? GraphId { get; set; }

		/// <summary>
		/// 人工智能
		/// </summary>
		[JsonProperty("hangye")]
		public string Hangye { get; set; }
	}
}