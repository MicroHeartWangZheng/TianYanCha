using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class ZhiXingInfoResponse
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
		public List<ZhiXingInfoItem> Items { get; set; }
	}

	 public class ZhiXingInfoItem
	{
		/// <summary>
		/// (2019)冀0929执1399号
		/// </summary>
		[JsonProperty("caseCode")]
		public string CaseCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("partyCardNum")]
		public string PartyCardNum { get; set; }

		/// <summary>
		/// 河北展发房地产开发有限公司
		/// </summary>
		[JsonProperty("pname")]
		public string Pname { get; set; }

		/// <summary>
		/// 献县人民法院
		/// </summary>
		[JsonProperty("execCourtName")]
		public string ExecCourtName { get; set; }

		public string CaseCreateTimeStr => CaseCreate.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("caseCreateTime")]
		public long? CaseCreate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("execMoney")]
		public string ExecMoney { get; set; }
	}
}
