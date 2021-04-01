using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
    public class JudicialDetailResponse
    {
        /// <summary>
		/// 
		/// </summary>
		[JsonProperty("assDetail")]
        public AssDetail AssDetail { get; set; }
    }

	public class AssDetail
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long? Id { get; set; }

		/// <summary>
		/// 1600万人民币元
		/// </summary>
		[JsonProperty("equityAmount")]
		public string EquityAmount { get; set; }

		/// <summary>
		/// 股权冻结|解除冻结
		/// </summary>
		[JsonProperty("typeState")]
		public string TypeState { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("executedPersonHid")]
		public long? ExecutedPersonHid { get; set; }

		/// <summary>
		/// 南宁市中级人民法院
		/// </summary>
		[JsonProperty("executiveCourt")]
		public string ExecutiveCourt { get; set; }

		/// <summary>
		/// 熊胜君
		/// </summary>
		[JsonProperty("executedPerson")]
		public string ExecutedPerson { get; set; }

		/// <summary>
		/// （2016）桂01执355号之二
		/// </summary>
		[JsonProperty("executeNoticeNum")]
		public string ExecuteNoticeNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("executedPersonCid")]
		public long? ExecutedPersonCid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("executedPersonType")]
		public string ExecutedPersonType { get; set; }
	}
}
