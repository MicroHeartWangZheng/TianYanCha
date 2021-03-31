using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
	public class JudicialResponse
    {
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("historyCount")]
		public long HistoryCount { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<JudicialItem> Items { get; set; }
	}

	public class JudicialItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 9957.14万人民币
		/// </summary>
		[JsonProperty("equityAmount")]
		public string EquityAmount { get; set; }

		/// <summary>
		/// 股权变更
		/// </summary>
		[JsonProperty("typeState")]
		public string TypeState { get; set; }

		/// <summary>
		/// 上海市第二中级人民法院
		/// </summary>
		[JsonProperty("executiveCourt")]
		public string ExecutiveCourt { get; set; }

		/// <summary>
		/// 中国纺织机械股份有限公司
		/// </summary>
		[JsonProperty("executedPerson")]
		public string ExecutedPerson { get; set; }

		/// <summary>
		/// （2015）沪二中法执 字第242号
		/// </summary>
		[JsonProperty("executeNoticeNum")]
		public string ExecuteNoticeNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("executedPersonCid")]
		public long ExecutedPersonCid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("assId")]
		public string AssId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("executedPersonType")]
		public string ExecutedPersonType { get; set; }
	}
}
