using Newtonsoft.Json;
using System.Net.Http;
using TianYanCha.SDK.Reponse;

namespace TianYanCha.SDK.Request
{
    public class BaseInfoV2Request : TianRequest<BaseResponse<BaseInfoV2Response>>
    {
        /// <summary>
        /// 公司名称（id与name只需输⼊其中⼀个）
        /// </summary>
       
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 公司id（id与name只需输⼊其中⼀个）
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// （id、name、统⼀信⽤代码，只需输⼊其中⼀个）
        /// </summary>
        [JsonProperty("keyword")]
        public string KeyWord { get; set; }

        public override string GetApiName()
        {
            return "services/open/ic/baseinfoV2/2.0";
        }

        public override HttpMethod GetHttpMethod()
        {
            return HttpMethod.Get;
        }
    }
}
