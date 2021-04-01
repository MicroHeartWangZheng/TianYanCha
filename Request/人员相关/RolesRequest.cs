using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    /// <summary>
    /// 人员所有角色
    /// </summary>
    public class RolesRequest : TianRequest<BaseResponse<RolesResponse>>
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


        public override string GetApiName()
        {
            return "services/v4/open/roles";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
