using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
    public class ConsumptionRestrictionResponse
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
        public List<ConsumptionRestrictionItem> Items { get; set; }
    }

    public class ConsumptionRestrictionItem
    {
        /// <summary>
        /// (2017)京03执492号
        /// </summary>
        [JsonProperty("caseCode")]
        public string CaseCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("filePath")]
        public string FilePath { get; set; }

        /// <summary>
        /// 吴孟
        /// </summary>
        [JsonProperty("xname")]
        public string Xname { get; set; }

        /// <summary>
        /// 乐视控股
        /// </summary>
        [JsonProperty("qyinfoAlias")]
        public string QyinfoAlias { get; set; }

        /// <summary>
        /// 乐视控股（北京）有限公司
        /// </summary>
        [JsonProperty("qyinfo")]
        public string Qyinfo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("caseCreateTime")]
        public long CaseCreateTime { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cid")]
        public long Cid { get; set; }
    }
}
