using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class ProfileResponse
	{
		/// <summary>
		/// 简介
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}

