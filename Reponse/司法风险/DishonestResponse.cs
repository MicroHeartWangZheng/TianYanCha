using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class DishonestResponse
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
		public List<DishonestItem> Items { get; set; }
	}

	public class DishonestItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("businessentity")]
		public string Businessentity { get; set; }

		/// <summary>
		/// 湖北
		/// </summary>
		[JsonProperty("areaname")]
		public string AreaName { get; set; }

		/// <summary>
		/// 建始县人民法院
		/// </summary>
		[JsonProperty("courtname")]
		public string CourtName { get; set; }

		/// <summary>
		/// 暂无
		/// </summary>
		[JsonProperty("unperformPart")]
		public string UnperformPart { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("staff")]
		public string Staff { get; set; }

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
		/// 恩施鑫地源农业开发有限公司
		/// </summary>
		[JsonProperty("iname")]
		public string Iname { get; set; }

		/// <summary>
		/// 有履行能力而拒不履行生效法律文书确定义务
		/// </summary>
		[JsonProperty("disrupttypename")]
		public string DisruptTypeName { get; set; }

		/// <summary>
		/// (2020)鄂2822执962号
		/// </summary>
		[JsonProperty("casecode")]
		public string CaseCode { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cardnum")]
		public string CardNum { get; set; }

		/// <summary>
		/// 全部未履行
		/// </summary>
		[JsonProperty("performance")]
		public string Performance { get; set; }

		public string Regdate => Reg.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("regdate")]
		public long? Reg { get; set; }

		public string PublishDate => Publish.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("publishdate")]
		public long? Publish { get; set; }

		/// <summary>
		/// 建始县人民法院
		/// </summary>
		[JsonProperty("gistunit")]
		public string Gistunit { get; set; }

		/// <summary>
		/// 　　　　一、陈伦新、谢莫翠定于2020年6月30日前一次性偿还恩施州金源典当有限责任公司建始分公司借款本金52万元。
		/// </summary>
		[JsonProperty("duty")]
		public string Duty { get; set; }

		/// <summary>
		/// (2020)鄂2822民特92号
		/// </summary>
		[JsonProperty("gistid")]
		public string Gistid { get; set; }
	}
}
