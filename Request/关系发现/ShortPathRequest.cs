using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 最短路径发现
    /// </summary>
    public class ShortPathRequest : TianRequest<BaseResponse<object>>
    {
        /// <summary>
        /// 类型. OWN-法人,SERVE_ALL-任职,INVEST-投资,BRANCH-分支机构,LAW-诉讼,CAC-竞合,EQ-债务,MORTGAGE_M-动产抵押,STOCK_PLEDGE_M-股权质押, LAND_MORTGAGE_M-土地抵押,CLIENT_M-客户,SUPPLY_M-供应商,FOREIGN_GUARANTEE_M-对外担保,ALL-所有类型
        /// </summary>
        [JsonProperty("types")]
        public string Types { get; set; }

        /// <summary>
        /// 深度（最大支持10，默认5）
        /// </summary>
        [JsonProperty("depth")]
        public string Depth { get; set; }

        /// <summary>
        /// 目标公司id（与目标公司名必须输入其中之一）
        /// </summary>
        [JsonProperty("idTo")]
        public string IdTo { get; set; }

        /// <summary>
        /// 目标公司名
        /// </summary>
        [JsonProperty("nameTo")]
        public string NameTo { get; set; }

        /// <summary>
        /// 源公司id（与源公司名必须输入其中之一）
        /// </summary>
        [JsonProperty("idFrom")]
        public string IdFrom { get; set; }

        /// <summary>
        /// 源公司名
        /// </summary>
        [JsonProperty("nameFrom")]
        public string NameFrom { get; set; }

        public override string GetApiName()
        {
            return "services/open/rela/shortPath";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
