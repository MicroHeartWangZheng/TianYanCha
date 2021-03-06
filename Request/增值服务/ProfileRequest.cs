using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 企业简介
    /// </summary>
    public class ProfileRequest : TianRequest<BaseResponse<string>>
    {
        /// <summary>
        /// 搜索关键字（公司名称、公司id、注册号或社会统一信用代码）
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        public override string GetApiName()
        {
            return "services/v4/open/profile";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
