using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 税收违法详情
    /// </summary>
    public class TaxContraventionDetailRequest : TianRequest<BaseResponse<TaxContraventionDetailResponse>>
    {
        /// <summary>
        /// 违法id
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        public override string GetApiName()
        {
            return "services/open/mr/taxContravention/detail/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
