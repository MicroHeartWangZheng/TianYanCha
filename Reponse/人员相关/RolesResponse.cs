using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class RolesResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("legalList")]
		public List<LegalListItem> LegalList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("officeList")]
		public List<OfficeListItem> OfficeList { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("holderList")]
		public List<HolderListItem> HolderList { get; set; }
	}
	public class HolderListItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("percent")]
		public string Percent { get; set; }

		/// <summary>
		/// 217128 万元
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }

		public string EstiblishTimeStr => Estiblish.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long? Estiblish { get; set; }

		/// <summary>
		/// 开业
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("subscribed")]
		public string Subscribed { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public long? Cid { get; set; }
	}
	public class OfficeListItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long? EstiblishTime { get; set; }

		/// <summary>
		/// 开业
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 执行董事
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public long? Cid { get; set; }

		/// <summary>
		/// 217128 万元
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 北京百度网讯科技有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
	}
	public class LegalListItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("hid")]
		public long? Hid { get; set; }

		/// <summary>
		/// 105000.000000万人民币
		/// </summary>
		[JsonProperty("regCapital")]
		public string RegCapital { get; set; }

		/// <summary>
		/// 福建百度博瑞网络科技有限公司
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("base")]
		public string Base { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("estiblishTime")]
		public long? EstiblishTime { get; set; }

		/// <summary>
		/// 存续（在营、开业、在册）
		/// </summary>
		[JsonProperty("regStatus")]
		public string RegStatus { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// 李彦宏
		/// </summary>
		[JsonProperty("legalPersonName")]
		public string LegalPersonName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("cid")]
		public long? Cid { get; set; }
	}
}

