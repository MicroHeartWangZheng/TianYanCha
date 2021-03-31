using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class CustomerResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("clientsYear")]
		public List<ClientsYearItem> ClientsYear { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pageBean")]
		public CustomerPageBean PageBean { get; set; }
	}

	public class CustomerPageBean
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("result")]
		public List<CustomerResultItem> Result { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long Total { get; set; }
	}

	public class CustomerResultItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("announcement_date")]
		public long AnnouncementDate { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("amt")]
		public string Amt { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("logo")]
		public string Logo { get; set; }

		/// <summary>
		/// 联创
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("client_graphId")]
		public long ClientGraphId { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("relationship")]
		public string Relationship { get; set; }

		/// <summary>
		/// 山东联创互联网传媒股份有限公司
		/// </summary>
		[JsonProperty("client_name")]
		public string ClientName { get; set; }

		/// <summary>
		/// 客户公告
		/// </summary>
		[JsonProperty("dataSource")]
		public string DataSource { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ratio")]
		public string Ratio { get; set; }
	}

	public class ClientsYearItem
	{
		/// <summary>
		/// 全部报告期
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
