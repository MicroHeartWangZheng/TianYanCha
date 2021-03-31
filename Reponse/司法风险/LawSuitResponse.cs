using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class LawSuitResponse
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
		public List<LawSuitItem> Items { get; set; }
	}

	public class LawSuitItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("submittime")]
		public string Submittime { get; set; }

		/// <summary>
		/// 侵害作品信息网络传播权纠纷
		/// </summary>
		[JsonProperty("casereason")]
		public string Casereason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("agent")]
		public string Agent { get; set; }

		/// <summary>
		/// 被告-北京拓世宏业科技发展有限公司
		/// </summary>
		[JsonProperty("defendants")]
		public string Defendants { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("abstracts")]
		public string Abstracts { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lawsuitUrl")]
		public string LawsuitUrl { get; set; }

		/// <summary>
		/// 中维慧科知识产权服务（广州）有限公司与北京百度网讯科技有限公司、北京拓世宏业科技发展有限公司侵害作品信息网络传播权纠纷一审民事裁定书
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 广州互联网法院
		/// </summary>
		[JsonProperty("court")]
		public string Court { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		/// <summary>
		/// （2020）粤0192民初33590号
		/// </summary>
		[JsonProperty("caseno")]
		public string Caseno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// 
		/// </summary>
		public string SplitGids { get; set; }

		/// <summary>
		/// 裁定书
		/// </summary>
		[JsonProperty("doctype")]
		public string Doctype { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("judgetime")]
		public DateTime? Judgetime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("thirdParties")]
		public string ThirdParties { get; set; }

		/// <summary>
		/// 民事案件
		/// </summary>
		[JsonProperty("casetype")]
		public string Casetype { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 原告-中维慧科知识产权服务（广州）有限公司
		/// </summary>
		[JsonProperty("plalongiffs")]
		public string Plalongiffs { get; set; }
	}
}
