using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class TaxesCodeResponse
	{

		/// <summary>
		/// 纳税人识别号
		/// </summary>
		[JsonProperty("result")]
		public string Result { get; set; }
	}
}

