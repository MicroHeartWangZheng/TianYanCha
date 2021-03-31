using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 验证企业
    /// </summary>
    public class MatchRequest : TianRequest<BaseResponse<MatchResponse>>
    {
        /// <summary>
        /// 注册号/组织机构代码/统一社会信用代码
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 公司名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        public override string GetApiName()
        {
            return "services/v4/open/match";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
