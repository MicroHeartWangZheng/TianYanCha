using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 资质证书
    /// </summary>
    public class CertificateRequest : TianRequest<BaseResponse<CertificateResponse>>
    {
        /// <summary>
        /// 公司名称（id与name只需输入其中一个）
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 证书类型（参考 证书类型.pdf）
        /// </summary>
        [JsonProperty("certificateName")]
        public string CertificateName { get; set; }

        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// 公司id（id与name只需输入其中一个）
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 当前页数（默认第一页）
        /// </summary>
        [JsonProperty("pageNum")]
        public string PageNum { get; set; }

        public override string GetApiName()
        {
            return "services/open/m/certificate/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
