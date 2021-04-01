using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class AbnormalResponse
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
        public List<AbnormalItem> Items { get; set; }
    }

	public class AbnormalItem
	{
		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("removeDate")]
		public DateTime? RemoveDate { get; set; }

		/// <summary>
		/// 未按照规定报送年度报告
		/// </summary>
		[JsonProperty("putReason")]
		public string PutReason { get; set; }

		/// <summary>
		/// 长沙市工商行政管理局天心分局
		/// </summary>
		[JsonProperty("putDepartment")]
		public string PutDepartment { get; set; }

		/// <summary>
		/// 长沙市工商行政管理局天心分局
		/// </summary>
		[JsonProperty("removeDepartment")]
		public string RemoveDepartment { get; set; }

		/// <summary>
		/// 依法补报了未报年份的年度报告并公示
		/// </summary>
		[JsonProperty("removeReason")]
		public string RemoveReason { get; set; }

		/// <summary>
		/// 
		/// </summary>
		[JsonProperty("putDate")]
		public DateTime? PutDate { get; set; }
	}
}

