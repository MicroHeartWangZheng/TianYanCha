using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TianYanCha.SDK.Reponse
{
    public class ParentCompanyResponse
    {   
        /// <summary>
        /// 1342128万人民币
        /// </summary>
        [JsonProperty("reg_capital")]
        public string RegCapital { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("estiblish_time")]
        public DateTime? EstiblishTime { get; set; }

        /// <summary>
        /// 梁志祥
        /// </summary>
        [JsonProperty("legalPersonName")]
        public string LegalPersonName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("personLogo")]
        public string PersonLogo { get; set; }

        /// <summary>
        /// 在业
        /// </summary>
        [JsonProperty("reg_status")]
        public string RegStatus { get; set; }

        /// <summary>
        /// 北京百度网讯科技有限公司
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 百度网讯
        /// </summary>
        [JsonProperty("alias")]
        public string Alias { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
