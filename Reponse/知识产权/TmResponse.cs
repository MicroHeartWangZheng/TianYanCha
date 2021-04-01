using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class TmResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total")]
        public string Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("items")]
        public List<TmItem> Items { get; set; }
    }

    public class TmItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("regNo")]
        public string RegNo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tmPic")]
        public string TmPic { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("searchType")]
        public string SearchType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("connList")]
        public List<string> ConnList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("_type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tmClass")]
        public string TmClass { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("appDate")]
        public string AppDate { get; set; }

        /// <summary>
        /// 38-通讯服务
        /// </summary>
        [JsonProperty("longCls")]
        public string LongCls { get; set; }

        /// <summary>
        /// 北京百度网讯科技有限公司
        /// </summary>
        [JsonProperty("applicantCn")]
        public string ApplicantCn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("uni")]
        public string Uni { get; set; }

        /// <summary>
        /// 糯百度糯米
        /// </summary>
        [JsonProperty("tmName")]
        public string TmName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("tmFlow")]
        public string TmFlow { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eventTime")]
        public string EventTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 商标注册申请---申请收文
        /// </summary>
        [JsonProperty("category")]
        public string Category { get; set; }

        /// <summary>
        /// 等待实质审查
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}

