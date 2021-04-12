using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class SupplyResponse
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("suppliesYear")]
		public List<SuppliesYearItem> SuppliesYear { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("pageBean")]
		public SupplyPageBean PageBean { get; set; }
	}

	public class SupplyPageBean
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("result")]
		public List<SupplyResultItem> Result { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("total")]
		public long? Total { get; set; }
	}

	public class SupplyResultItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("supplier_graphId")]
		public long? SupplierGraphId { get; set; }


		public string AnnouncementDateStr => AnnouncementDate.ToDateTime();
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("announcement_date")]
		public long? AnnouncementDate { get; set; }

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
		/// 上古彩
		/// </summary>
		[JsonProperty("alias")]
		public string Alias { get; set; }

		/// <summary>
		/// 北京上古彩科技股份有限公司
		/// </summary>
		[JsonProperty("supplier_name")]
		public string SupplierName { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("relationship")]
		public string Relationship { get; set; }

		/// <summary>
		/// 供应商公告
		/// </summary>
		[JsonProperty("dataSource")]
		public string DataSource { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("ratio")]
		public string Ratio { get; set; }
	}

	public class SuppliesYearItem
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
