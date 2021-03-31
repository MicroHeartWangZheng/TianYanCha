using System.Collections.Generic;
using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class FindTeamMemberResponse
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
		public List<FindTeamMemberItem> Items { get; set; }
	}

	public class FindTeamMemberItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hid")]
		public long Hid { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("companyName")]
		public string CompanyName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("icon")]
		public string Icon { get; set; }

		/// <summary>
		/// 创始人&董事长&首席执行官
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("isDimission")]
		public long IsDimission { get; set; }

		/// <summary>
		/// 李彦宏
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("graphId")]
		public long GraphId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("iconOssPath")]
		public string IconOssPath { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("desc")]
		public string Desc { get; set; }
	}
}