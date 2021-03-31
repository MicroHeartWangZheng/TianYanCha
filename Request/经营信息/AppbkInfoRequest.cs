using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 产品信息
    /// </summary>
    public class AppbkInfoRequest : TianRequest<BaseResponse<AppbkInfoResponse>>
    {

        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// 公司id（id与name只需输入其中一个）
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 当前页数（默认第一页）
        /// </summary>
        [JsonProperty("pageNum")]
        public string PageNum { get; set; }

        public override string GetApiName()
        {
            return "services/open/m/appbkInfo/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
