using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class PositionResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("graphId")]
		public long? GraphId { get; set; }

		/// <summary>
		/// 北京正方向汽车租赁有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 北京市朝阳区华严北里9号院35号楼4层1门7号
		/// </summary>
		[JsonProperty("regLocation")]
		public string RegLocation { get; set; }

		/// <summary>
		/// 北京市
		/// </summary>
		[JsonProperty("province")]
		public string Province { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("longitude")]
		public double longitude { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("latitude")]
		public double Latitude { get; set; }

		/// <summary>
		/// 朝阳区
		/// </summary>
		[JsonProperty("district")]
		public string District { get; set; }

		/// <summary>
		/// 市辖区
		/// </summary>
		[JsonProperty("city")]
		public string City { get; set; }
	}
}

