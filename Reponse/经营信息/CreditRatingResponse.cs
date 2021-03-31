using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace TianYanCha.SDK.Reponse
{
    public class CreditRatingResponse
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
        public List<CreditRatingItem> Items { get; set; }
    }

    public class CreditRatingItem
    {
        /// <summary>
        /// 稳定
        /// </summary>
        [JsonProperty("ratingOutlook")]
        public string RatingOutlook { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("ratingDate")]
        public DateTime? RatingDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("gid")]
        public long Gid { get; set; }

        /// <summary>
        /// 中诚信国际信用评级有限责任公司
        /// </summary>
        [JsonProperty("ratingCompanyName")]
        public string RatingCompanyName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("bondCreditLevel")]
        public DateTime? BondCreditLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 中诚信
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("subjectLevel")]
        public string SubjectLevel { get; set; }
    }
}
