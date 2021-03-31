using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class MatchResponse
	{
		/// <summary>
		/// true-匹配 false-不匹配
		/// </summary>
		[JsonProperty("result")]
		public bool Result { get; set; }
	}
}

