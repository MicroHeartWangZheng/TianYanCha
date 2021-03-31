using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class AllCompanysResponse
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
		public List<AllCompanysItem> Items { get; set; }
	}
	public class AllCompanysItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long EstiblishTime { get; set; }

		/// <summary>
		/// 开业
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 股东,执行董事
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public long Cid { get; set; }

		/// <summary>
		/// 217128 万元
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}

