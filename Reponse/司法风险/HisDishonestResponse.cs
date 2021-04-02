using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class HisDishonestResponse
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
		public List<HisDishonestItem> Items { get; set; }
	}

	public class HisDishonestItem
	{
		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("iname")]
		public string Iname { get; set; }

		/// <summary>
		/// 梁志祥
		/// </summary>
		[JsonProperty("businessentity")]
		public string BusinessEntity { get; set; }

		/// <summary>
		/// (2017)粤0106民初3764号
		/// </summary>
		[JsonProperty("gistid")]
		public string GistId { get; set; }

		/// <summary>
		/// 广东
		/// </summary>
		[JsonProperty("areaname")]
		public string AreaName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cardnum")]
		public string CardNum { get; set; }

		/// <summary>
		/// 广州市天河区人民法院
		/// </summary>
		[JsonProperty("courtname")]
		public string CourtName { get; set; }

		public string PublishDateStr => Publish.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("publishdate")]
        public long? Publish { get; set; }
		
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 广州市天河区人民法院
		/// </summary>
		[JsonProperty("gistunit")]
		public string Gistunit { get; set; }

		/// <summary>
		/// 被执行人一次性支付申请人共30500元
		/// </summary>
		[JsonProperty("duty")]
		public string Duty { get; set; }

		/// <summary>
		/// 全部未履行
		/// </summary>
		[JsonProperty("performance")]
		public string Performance { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("regdate")]
		public long? Regdate { get; set; }

		/// <summary>
		/// (2018)粤0106执22542号
		/// </summary>
		[JsonProperty("casecode")]
		public string CaseCode { get; set; }

		/// <summary>
		/// 违反财产报告制度
		/// </summary>
		[JsonProperty("disrupttypename")]
		public string DisruptTypeName { get; set; }
	}
}
