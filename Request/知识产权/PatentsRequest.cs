using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 企业专利信息
    /// </summary>
    public class PatentsRequest : TianRequest<BaseResponse<PatentsResponse>>
    {
        /// <summary>
        /// 发布开始时间
        /// </summary>
        [JsonProperty("pubDateBegin")]
        public long? PubDateBegin { get; set; }

        /// <summary>
        /// 申请开始时间
        /// </summary>
        [JsonProperty("appDateBegin")]
        public long? AppDateBegin { get; set; }

        /// <summary>
        /// 发布结束时间
        /// </summary>
        [JsonProperty("pubDateEnd")]
        public long? PubDateEnd { get; set; }

        /// <summary>
        /// 申请结束时间
        /// </summary>
        [JsonProperty("appDateEnd")]
        public long? AppDateEnd { get; set; }

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
        /// 专利类型 1-发明专利 2-实用新型 3-外观专利 4-PCT发明 5-PCT实用新型
        /// </summary>
        [JsonProperty("patentType")]
        public long? PatentType { get; set; }


        public override string GetApiName()
        {
            return "services/open/ipr/patents/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
