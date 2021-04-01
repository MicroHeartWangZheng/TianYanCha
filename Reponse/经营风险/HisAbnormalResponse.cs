using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using TianYanCha.SDK.Extensions;

namespace TianYanCha.SDK.Reponse
{
    public class HisAbnormalResponse
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
        public List<HisAbnormalItem> Items { get; set; }
    }

    public class HisAbnormalItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }


        public string CreateTime => Create.ToDateTime();
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("createTime")]
        public long? Create { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("putDate")]
        public long? PutDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("removeDate")]
        public long? RemoveDate { get; set; }

        /// <summary>
        /// 依法补报了未报年份的年度报告并公示
        /// </summary>
        [JsonProperty("removeReason")]
        public string RemoveReason { get; set; }

        /// <summary>
        /// 长沙市工商行政管理局天心分局
        /// </summary>
        [JsonProperty("removeDepartment")]
        public string RemoveDepartment { get; set; }

        /// <summary>
        /// 长沙市工商行政管理局天心分局
        /// </summary>
        [JsonProperty("putDepartment")]
        public string PutDepartment { get; set; }

        /// <summary>
        /// 未按照规定报送2014年度年度报告
        /// </summary>
        [JsonProperty("putReason")]
        public string PutReason { get; set; }
    }
}

