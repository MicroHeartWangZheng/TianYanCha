using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class RiskInfoResponse
	{
		/// <summary>
		/// 中等
		/// </summary>
		[JsonProperty("riskLevel")]
		public string RiskLevel { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("riskList")]
		public List<RiskInfoItem> RiskList { get; set; }
	}

	public class RiskInfoItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("count")]
		public long Count { get; set; }

		/// <summary>
		/// 自身风险
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("list")]
		public List<RiskInfoItemChildren> List { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }
	}

	public class RiskInfoItemChildren
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }

		/// <summary>
		/// 高风险信息
		/// </summary>
		[JsonProperty("tag")]
		public string Tag { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("list")]
		public List<RiskInfoItemChildrenChildren> List { get; set; }

		/// <summary>
		/// 被执行人
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }
	}

	public class RiskInfoItemChildrenChildren
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("riskCount")]
		public long RiskCount { get; set; }

		/// <summary>
		/// 该公司 <em>曾因未按时履行法律义务而被法院强制执行</em>
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }

		/// <summary>
		/// 被执行人
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("humanGraphId")]
		public long HumanGraphId { get; set; }
	}
}

