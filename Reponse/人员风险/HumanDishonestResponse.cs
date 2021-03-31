using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class HumanDishonestResponse
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
		public List<HumanDishonestItem> Items { get; set; }
	}

	public class HumanDishonestItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("businessentity")]
		public string Businessentity { get; set; }

		/// <summary>
		/// 北京
		/// </summary>
		[JsonProperty("areaname")]
		public string Areaname { get; set; }

		/// <summary>
		/// 北京市第三中级人民法院
		/// </summary>
		[JsonProperty("courtname")]
		public string Courtname { get; set; }

		/// <summary>
		/// 暂无
		/// </summary>
		[JsonProperty("unperformPart")]
		public string UnperformPart { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("staff")]
		public List<HumanDishonestStaffItem> Staff { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 暂无
		/// </summary>
		[JsonProperty("performedPart")]
		public string PerformedPart { get; set; }

		/// <summary>
		/// 贾跃亭
		/// </summary>
		[JsonProperty("iname")]
		public string Iname { get; set; }

		/// <summary>
		/// 违反财产报告制度
		/// </summary>
		[JsonProperty("disrupttypename")]
		public string Disrupttypename { get; set; }

		/// <summary>
		/// (2020)京03执恢88号
		/// </summary>
		[JsonProperty("casecode")]
		public string Casecode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cardnum")]
		public string Cardnum { get; set; }

		/// <summary>
		/// 全部未履行
		/// </summary>
		[JsonProperty("performance")]
		public string Performance { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("regdate")]
		public long Regdate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("publishdate")]
		public long Publishdate { get; set; }

		/// <summary>
		/// 中国国际经济贸易仲裁委员会
		/// </summary>
		[JsonProperty("gistunit")]
		public string Gistunit { get; set; }

		/// <summary>
		/// 支付股权认购价款本金十亿元及相应投资收益
		/// </summary>
		[JsonProperty("duty")]
		public string Duty { get; set; }

		/// <summary>
		/// 2019中国贸仲京裁字第0394号
		/// </summary>
		[JsonProperty("gistid")]
		public string Gistid { get; set; }
	}
	public class HumanDishonestStaffItem
	{
		/// <summary>
		/// 法定代表人
		/// </summary>
		[JsonProperty("role")]
		public string Role { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// 吴孟
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}

