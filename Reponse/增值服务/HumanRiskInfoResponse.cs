using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class HumanRiskInfoResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("count")]
		public long Count { get; set; }

		/// <summary>
		/// 周边风险
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("list")]
		public List<HumanRiskInfoItem> List { get; set; }
	}

	public class HumanRiskInfoItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }

		/// <summary>
		/// 被执行信息
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 高风险信息
		/// </summary>
		[JsonProperty("tag")]
		public string Tag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("list")]
		public List<HumanRiskInfoItemChildren> List { get; set; }
	}

	public class HumanRiskInfoItemChildren
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 他 担任法人的 <a target=&singlequote&_blank&singlequote& href=&singlequote&https://www.tianyancha.com/company/22822&singlequote&>北京百度网讯科技有限公司</a> 曾因未按时履行法律义务而被法院<em>强制执行</em>
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 被执行公司
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("companyId")]
		public long CompanyId { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("riskCount")]
		public long RiskCount { get; set; }
	}
}

