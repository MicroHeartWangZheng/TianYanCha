using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 法律诉讼详情
    /// </summary>
    public class LawSuitDetailRequest : TianRequest<BaseResponse<LawSuitDetailResponse>>
    {
        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        public override string GetApiName()
        {
            return "services/open/jr/lawSuit/detail";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
