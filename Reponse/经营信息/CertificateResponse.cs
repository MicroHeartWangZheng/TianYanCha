using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class CertificateResponse
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
		public List<CertificateItem> Items { get; set; }
	}

	public class CertificateItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("certNo")]
		public string CertNo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("endDate")]
		public DateTime? EndDate { get; set; }

		/// <summary>
		/// 所有未列明的其他管理体系认证
		/// </summary>
		[JsonProperty("certificateName")]
		public string CertificateName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("detail")]
		public List<DetailItem> Detail { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("startDate")]
		public DateTime? StartDate { get; set; }
	}

	public class DetailItem
	{
		/// <summary>
		/// 证书到期日期
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("content")]
		public string Content { get; set; }
	}
}
