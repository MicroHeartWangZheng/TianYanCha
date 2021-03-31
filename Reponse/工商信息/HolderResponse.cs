using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class HolderResponse
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
        public List<HolderItem> Items { get; set; }
    }

    public class HolderItem
    {
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("capital")]
		public List<CapitalItem> Capital { get; set; }

		/// <summary>
		/// 毕丽燕
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("capitalActl")]
		public List<CapitalActlItem> CapitalActl { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 毕
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public long Type { get; set; }
	}

	public class CapitalActlItem
	{
		/// <summary>
		/// 35万人民币
		/// </summary>
		[JsonProperty("amomon")]
		public string Amomon { get; set; }

		/// <summary>
		/// 货币
		/// </summary>
		[JsonProperty("paymet")]
		public string Paymet { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("time")]
		public DateTime? Time { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("percent")]
		public string Percent { get; set; }
	}

	public class CapitalItem
	{
		/// <summary>
		/// 420万人民币
		/// </summary>
		[JsonProperty("amomon")]
		public string Amomon { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("paymet")]
		public string Paymet { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("time")]
		public string Time { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("percent")]
		public string Percent { get; set; }
	}
}