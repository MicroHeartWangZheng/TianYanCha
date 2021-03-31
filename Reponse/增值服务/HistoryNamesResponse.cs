using Newtonsoft.Json;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class HistoryNamesResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("historyNames")]
		public List<string> HistoryNames { get; set; }

		/// <summary>
		/// 贵州荷泰集团酒业有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}

