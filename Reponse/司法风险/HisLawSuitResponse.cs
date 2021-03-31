using Newtonsoft.Json;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class HisLawSuitResponse
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
		public List<HisLawSuitItem> Items { get; set; }
	}

	public class HisLawSuitItem
	{
		/// <summary>
		/// 上诉人-<a href='https://www.tianyancha.com/company/22822' target='_blank'>北京百度网讯科技有限公司</a>
		/// </summary>
		[JsonProperty("plalongiffs")]
		public string Plalongiffs { get; set; }

		/// <summary>
		/// 河北省唐山市中级人民法院
		/// </summary>
		[JsonProperty("court")]
		public string Court { get; set; }

		/// <summary>
		/// 买卖合同纠纷
		/// </summary>
		[JsonProperty("casereason")]
		public string Casereason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("url")]
		public string Url { get; set; }

		/// <summary>
		/// （2016）冀02民辖终424号
		/// </summary>
		[JsonProperty("caseno")]
		public string Caseno { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// 巩传亚与北京百度网讯科技有限公司买卖合同纠纷二审民事裁定书
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("submittime")]
		public string Submittime { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("lawsuitUrl")]
		public string LawsuitUrl { get; set; }

		/// <summary>
		/// 民事案件
		/// </summary>
		[JsonProperty("casetype")]
		public string Casetype { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("thirdParties")]
		public string ThirdParties { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }

		/// <summary>
		/// 民事裁定书
		/// </summary>
		[JsonProperty("doctype")]
		public string Doctype { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("defendants")]
		public string Defendants { get; set; }
	}
}
