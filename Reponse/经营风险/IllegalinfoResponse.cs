using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class IllegalinfoResponse
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
		public List<IllegalinfoItem> Items { get; set; }
	}

	public class IllegalinfoItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("removeDate")]
		public string RemoveDate { get; set; }

		/// <summary>
		/// 被列入经营异常名录届满3年仍未履行相关义务的
		/// </summary>
		[JsonProperty("putReason")]
		public string PutReason { get; set; }

		/// <summary>
		/// 深圳市市场和质量监督管理委员会福田局
		/// </summary>
		[JsonProperty("putDepartment")]
		public string PutDepartment { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("removeDepartment")]
		public string RemoveDepartment { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("removeReason")]
		public string RemoveReason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putDate")]
		public long? PutDate { get; set; }
	}
}

