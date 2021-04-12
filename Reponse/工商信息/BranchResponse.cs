using System.Collections.Generic;
using Newtonsoft.Json;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
	public class BranchResponse
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
		public List<BranchItem> Items { get; set; }
	}

	public class BranchItem
	{
		/// <summary>
		/// 存续
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }


		public string EstiblishTimeStr => EstiblishTime.ToDateTime();

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long? EstiblishTime { get; set; }

		/// <summary>
		/// 0万元人民币
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 赵坤
		/// </summary>
		[JsonProperty("legalPersonName")]
		public string LegalPersonName { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司南京分公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 百度网讯
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("id")]
		public long? Id { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("category")]
		public string Category { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("personType")]
		public long? PersonType { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }
	}
}