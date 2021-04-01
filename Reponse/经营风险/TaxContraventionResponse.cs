using Newtonsoft.Json;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class TaxContraventionResponse
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
        public List<TaxContraventionItem> Items { get; set; }
    }

    public class TaxContraventionItem
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("publish_time")]
        public string PublishTime { get; set; }

        /// <summary>
        /// 虚开增值税专用发票或者虚开用于骗取出口退税、抵扣税款的其他发票
        /// </summary>
        [JsonProperty("case_type")]
        public string CaseType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("department")]
        public string Department { get; set; }

        /// <summary>
        /// 宁波保税区航晨塑化有限公司
        /// </summary>
        [JsonProperty("taxpayer_name")]
        public string TaxpayerName { get; set; }
    }
}

