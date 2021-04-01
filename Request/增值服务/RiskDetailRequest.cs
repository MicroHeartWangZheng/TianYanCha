using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 天眼风险详情
    /// </summary>
    public class RiskDetailRequest : TianRequest<BaseResponse<object>>
    {
        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>

        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// 传入企业风险接口返回值中的id,对应的风险类型不同，返回数据也不同，示例仅供查看对比字段含义
        /// </summary>
        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// 风险类型
        /// </summary>
        [JsonProperty("type")]
        public long? Type { get; set; }

        /// <summary>
        /// 当前页数（默认第一页）
        /// </summary>
        [JsonProperty("pageNum")]
        public string PageNum { get; set; }

        public override string GetApiName()
        {
            return "services/v4/open/riskDetail";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
