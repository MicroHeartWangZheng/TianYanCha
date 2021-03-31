using Newtonsoft.Json;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class CompanyHoldingResponse
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
		public List<CompanyHoldingItem> Items { get; set; }
	}

	public class CompanyHoldingItem
	{
		/// <summary>
		/// 存续
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("chainList")]
		public List<List<ChainListItemItem>> ChainList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long EstiblishTime { get; set; }

		/// <summary>
		/// 20000万人民币
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 上海百度小额贷款有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 百度
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("percent")]
		public string Percent { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public string Cid { get; set; }

		/// <summary>
		/// 向海龙
		/// </summary>
		[JsonProperty("legalPersonName")]
		public string LegalPersonName { get; set; }
	}

	public class ChainListItemItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}

