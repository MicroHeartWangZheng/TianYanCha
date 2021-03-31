using System.Collections.Generic;
using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class CompanyProResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}