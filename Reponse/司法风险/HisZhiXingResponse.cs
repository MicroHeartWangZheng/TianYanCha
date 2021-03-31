using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
    public class HisZhiXingResponse
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
		public List<HisZhiXingItem> Items { get; set; }
	}

	public class HisZhiXingItem
	{
		/// <summary>
		/// 北京市海淀区人民法院
		/// </summary>
		[JsonProperty("execCourtName")]
		public string ExecCourtName { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("pname")]
		public string Pname { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("partyCardNum")]
		public string PartyCardNum { get; set; }

		/// <summary>
		/// (2018)京0108执11487号
		/// </summary>
		[JsonProperty("caseCode")]
		public string CaseCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("caseCreateTime")]
		public long CaseCreateTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("execMoney")]
		public string ExecMoney { get; set; }
	}
}
