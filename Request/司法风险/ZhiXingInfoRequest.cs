using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 被执行人
    /// </summary>
    public class ZhiXingInfoRequest : TianRequest<BaseResponse<ZhiXingInfoResponse>>
    {
        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// 搜索关键字（公司名称、公司id、注册号或社会统一信用代码）
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
            return "services/open/jr/zhixinginfo/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
