using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
    public class CourtRegisterResponse
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
		public List<CourtRegisterItem> Items { get; set; }
	}

	public class CourtRegisterItem
	{
		/// <summary>
		/// 南京银城物业服务有限公司
		/// </summary>
		[JsonProperty("litigant")]
		public string Litigant { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("filingDate")]
		public string FilingDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("litigantGids")]
		public string LitigantGids { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("caseStatus")]
		public string CaseStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("source")]
		public string Source { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("caseType")]
		public string CaseType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("sourceUrl")]
		public DateTime? SourceUrl { get; set; }

		/// <summary>
		/// 南京银城西堤国际小区业主委员会,南京银城物业服务有限公司
		/// </summary>
		[JsonProperty("defendant")]
		public string Defendant { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("juge")]
		public string Juge { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("startTime")]
		public string StartTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("department")]
		public string Department { get; set; }

		/// <summary>
		/// 南京
		/// </summary>
		[JsonProperty("area")]
		public string Area { get; set; }

		/// <summary>
		/// 祁沁工,李俊,刘卫东,夏怀亚,林锦国,张超,张照,朱忠云,吴春庚,杨根林,余幼玲,陈定,刘燕,霍啸南,刘美洁,倪良胜,袁春红,周俊,龚劲松,吕长禄
		/// </summary>
		[JsonProperty("plalongiff")]
		public string Plalongiff { get; set; }

		/// <summary>
		/// 李伟
		/// </summary>
		[JsonProperty("assistant")]
		public string Assistant { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("court")]
		public string Court { get; set; }

		/// <summary>
		/// (2016)苏01民终2522号
		/// </summary>
		[JsonProperty("caseNo")]
		public string CaseNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("caseReason")]
		public string CaseReason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("closeDate")]
		public string CloseDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("third")]
		public string Third { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("createTime")]
		public string CreateTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public long? Cid { get; set; }
	}
}
