using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class HumanCompanyHoldingResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("total")]
        public long Total { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("items")]
        public List<HumanCompanyHoldingItem> Items { get; set; }
    }

    public class HumanCompanyHoldingItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("legalPersonId")]
        public long LegalPersonId { get; set; }

        /// <summary>
        /// 开业
        /// </summary>
        [JsonProperty("regStatus")]
        public string RegStatus { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("chainList")]
        public List<List<HumanChainListItemItem>> ChainList { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("legalType")]
        public long LegalType { get; set; }

        /// <summary>
        /// 1001.000000万人民币
        /// </summary>
        [JsonProperty("regCapital")]
        public string RegCapital { get; set; }

        /// <summary>
        /// 北京宏景天下投资有限公司
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 宏景天下
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("percent")]
        public DateTime? Percent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cid")]
        public string Cid { get; set; }

        /// <summary>
        /// 周达
        /// </summary>
        [JsonProperty("legalPersonName")]
        public string LegalPersonName { get; set; }
    }
    public class HumanChainListItemItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("value")]
        public DateTime? Value { get; set; }
    }
}

