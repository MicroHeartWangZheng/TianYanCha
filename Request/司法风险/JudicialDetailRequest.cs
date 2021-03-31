using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 司法协助详情
    /// </summary>
    public class JudicialDetailRequest : TianRequest<BaseResponse<JudicialDetailResponse>>
    {
        /// <summary>
        /// 司法协助id
        /// </summary>
        [JsonProperty("assistanceId")]
        public string AssistanceId { get; set; }

        public override string GetApiName()
        {
            return "services/v4/open/getJudicialDetail";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
