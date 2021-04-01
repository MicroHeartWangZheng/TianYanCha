using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 人员控股企业
    /// </summary>
    public class HumanCompanyHoldingRequest : TianRequest<BaseResponse<HumanCompanyHoldingResponse>>
    {
        /// <summary>
        /// 人id（humanName和hid只需输入其中一个）
        /// </summary>
        [JsonProperty("hid")]
        public long? Hid { get; set; }

        /// <summary>
        /// 公司名称（cid和name只需输入其中一个）
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 姓名（humanName和hid只需输入其中一个）
        /// </summary>
        [JsonProperty("humanName")]
        public string HumanName { get; set; }

        /// <summary>
        /// 公司id（cid和name只需输入其中一个）
        /// </summary>
        [JsonProperty("cid")]
        public long? CId { get; set; }

        /// <summary>
        /// 每页条数（默认20条，最大20条）
        /// </summary>
        [JsonProperty("pageSize")]
        public string PageSize { get; set; }

        /// <summary>
        /// 当前页数（默认第一页）
        /// </summary>
        [JsonProperty("pageNum")]
        public string PageNum { get; set; }


        public override string GetApiName()
        {
            return "services/open/human/companyholding/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
