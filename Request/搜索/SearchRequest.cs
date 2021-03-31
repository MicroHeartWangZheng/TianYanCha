using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 搜索
    /// </summary>
    public class SearchRequest : TianRequest<BaseResponse<SearchResponse>>
    {
        /// <summary>
        /// 搜索关键字（公司名称、公司id、注册号或社会统一信用代码）
        /// </summary>
        [JsonProperty("word")]
        public string Word { get; set; }

        public override string GetApiName()
        {
            return "services/open/search/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
