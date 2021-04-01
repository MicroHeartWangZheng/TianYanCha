using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 企业商标信息
    /// </summary>
    public class TmRequest : TianRequest<BaseResponse<TmResponse>>
    {
        /// <summary>
        /// 申请开始时间
        /// </summary>
        [JsonProperty("appDateBegin")]
        public long? AppDateBegin { get; set; }
        /// <summary>
        /// 申请结束时间
        /// </summary>
        [JsonProperty("appDateEnd")]
        public long? AppDateEnd { get; set; }

        /// <summary>
        /// 国际分类(参考文档商标国际分类.pdf)
        /// </summary>
        [JsonProperty("tmClass")]
        public string TmClass { get; set; }

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

        /// <summary>
        /// 商标状态 1-商标已注册 2-商标无效 3-初审公告 4-等待实质审查 5-商标申请中 6-商标异议中 7-驳回复审中 8-商标其他情形 9-等待驳回复审 10-撤销/无效宣告申请审查中
        /// </summary>
        [JsonProperty("status")]
        public long? Status { get; set; }


        public override string GetApiName()
        {
            return "services/open/ipr/tm/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
