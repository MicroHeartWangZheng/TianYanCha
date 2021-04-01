using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class SearchResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<SearchItem> Items { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long? Total { get; set; }
	}

	public class SearchItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("regNumber")]
		public string RegNumber { get; set; }

		/// <summary>
		/// 在业
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("creditCode")]
		public string CreditCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public DateTime? EstiblishTime { get; set; }

		/// <summary>
		/// 1342128万人民币
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("companyType")]
		public long? CompanyType { get; set; }

		/// <summary>
		/// <em>北京百度网讯科技有限公司</em>
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long? Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("orgNumber")]
		public string OrgNumber { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long? Type { get; set; }

		/// <summary>
		/// 北京
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }

		/// <summary>
		/// 梁志祥
		/// </summary>
		[JsonProperty("legalPersonName")]
		public string LegalPersonName { get; set; }
	}
}