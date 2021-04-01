using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 企业信用报告（专业版）
    /// </summary>
    public class CompanyProRequest : TianRequest<BaseResponse<string>>
    {
        /// <summary>
        /// 公司名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 公司id
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 32位uuid（区分大小写）
        /// </summary>
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        public override string GetApiName()
        {
            return "services/open/report/company/pro";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
