using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 企业业务
    /// </summary>
    public class ProductInfoRequest : TianRequest<BaseResponse<ProductInfoResponse>>
    {
        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("pageSize")]
        public long? PageSize { get; set; }

        /// <summary>
        /// 当前页数（默认第一页）
        /// </summary>
        [JsonProperty("pageNum")]
        public string PageNum { get; set; }

        /// <summary>
        /// 搜索关键字（公司名称、公司id、注册号或社会统一信用代码）
        /// </summary>
        [JsonProperty("keyword")]
        public string KeyWord { get; set; }

        public override string GetApiName()
        {
            return "services/open/cd/getProductInfo/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
