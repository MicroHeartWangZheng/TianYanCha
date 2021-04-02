using System.Collections.Generic;
using Newtonsoft.Json;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class FindJingpinResponse
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
		public List<FindJingpinItem> Items { get; set; }
	}

	public class FindJingpinItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("date")]
		public long? Date { get; set; }

		/// <summary>
		/// 百度IDL研究院
		/// </summary>
		[JsonProperty("product")]
		public string Product { get; set; }

		/// <summary>
		/// 深圳魅闪科技有限公司
		/// </summary>
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }


		public string SetupDateStr => Setup.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("setupDate")]
		public long? Setup { get; set; }

		/// <summary>
		/// 网红打造系统研发商
		/// </summary>
		[JsonProperty("yewu")]
		public string Yewu { get; set; }

		/// <summary>
		/// 魅闪科技
		/// </summary>
		[JsonProperty("jingpinProduct")]
		public string JingpinProduct { get; set; }

		/// <summary>
		/// A轮
		/// </summary>
		[JsonProperty("round")]
		public string Round { get; set; }

		/// <summary>
		/// 广东
		/// </summary>
		[JsonProperty("location")]
		public string Location { get; set; }

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

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("iconOssPath")]
		public string IconOssPath { get; set; }
	}
}