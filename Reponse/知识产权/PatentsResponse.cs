using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class PatentsResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public string Total { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("items")]
		public List<PatentsItem> Items { get; set; }
	}

	public class PatentsItem
	{
		/// <summary>
		/// 北京天眼查科技有限公司
		/// </summary>
		[JsonProperty("agent")]
		public string Agent { get; set; }

		/// <summary>
		/// 商标类别推荐方法和装置、以及存储介质和电子设备
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("patentNum")]
		public string PatentNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pubnumber")]
		public string Pubnumber { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationTime")]
		public DateTime ApplicationTime { get; set; }

		/// <summary>
		/// 计算；推算；计数;
		/// </summary>
		[JsonProperty("cat")]
		public string Cat { get; set; }

		/// <summary>
		/// ["北京天眼查科技有限公司"]
		/// </summary>
		[JsonProperty("applicantname")]
		public string Applicantname { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("eventTime")]
		public string EventTime { get; set; }

		/// <summary>
		/// 可少芳;韩霜;柳超
		/// </summary>
		[JsonProperty("inventor")]
		public string Inventor { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lawStatus")]
		public List<PatentsLawStatusItem> LawStatus { get; set; }

		/// <summary>
		/// 100086北京市海淀区知春路65号中国卫星通信大厦B座23层
		/// </summary>
		[JsonProperty("address")]
		public string Address { get; set; }

		/// <summary>
		/// 北京思源智汇知识产权代理有限公司
		/// </summary>
		[JsonProperty("agency")]
		public string Agency { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("searchType")]
		public string SearchType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("connList")]
		public List<string> ConnList { get; set; }

		/// <summary>
		/// 本公开的实施例公开了一种商标类别推荐方法和装置、电子设备和存储介质，其中，该方法包括：接收用户请求的行业；确定用户请求的行业的标识信息；基于用户请求的行业的标识信息，获取用户请求的行业对应的至少一个商标类别；向用户推荐至少一个商标类别。由此，本公开实施例通过行业的标识信息实现了将现有技术中从前端页面中缓存的固定的各行业的商标类别信息转变为从后端直接获取动态的各行业的商标类别信息，这样不仅提升了用户体验，还可以快速的查看现阶段各行业的商标类别信息，避免了人为推荐方式可能导致的商标类别确定的失误。  
		/// </summary>
		[JsonProperty("abstracts")]
		public string Abstracts { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("_type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicantName")]
		public string ApplicantName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pubDate")]
		public DateTime? PubDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationPublishTime")]
		public DateTime? ApplicationPublishTime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("appnumber")]
		public string Appnumber { get; set; }

		/// <summary>
		/// 发明专利
		/// </summary>
		[JsonProperty("patentType")]
		public string PatentType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("imgUrl")]
		public string ImgUrl { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uni")]
		public string Uni { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("mainCatNum")]
		public string MainCatNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("createTime")]
		public string CreateTime { get; set; }

		/// <summary>
		/// 商标类别推荐方法和装置、以及存储介质和电子设备
		/// </summary>
		[JsonProperty("patentName")]
		public string PatentName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("applicationPublishNum")]
		public string ApplicationPublishNum { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("allCatNum")]
		public string AllCatNum { get; set; }
	}

	public class PatentsLawStatusItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("date")]
		public DateTime? Date { get; set; }

		/// <summary>
		/// 授权
		/// </summary>
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}

