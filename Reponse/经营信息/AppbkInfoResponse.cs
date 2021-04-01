using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class AppbkInfoResponse
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
		public List<AppbkInfoItem> Items { get; set; }
	}

	public class AppbkInfoItem
	{
		/// <summary>
		/// 【产品介绍】
		/// </summary>
		[JsonProperty("brief")]
		public string Brief { get; set; }

		/// <summary>
		/// 其它
		/// </summary>
		[JsonProperty("classes")]
		public string Classes { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 百度糯米商家
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 百度糯米商家
		/// </summary>
		[JsonProperty("filterName")]
		public string FilterName { get; set; }

		/// <summary>
		/// 应用
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("uuid")]
		public string Uuid { get; set; }
	}
}
