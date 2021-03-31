using System.Collections.Generic;
using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
	public class StaffResponse
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
		public List<StaffItem> Items { get; set; }
	}

	public class StaffItem
	{
		/// <summary>
		/// 李彦宏
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

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

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("typeJoin")]
		public List<string> TypeJoin { get; set; }
	}
}