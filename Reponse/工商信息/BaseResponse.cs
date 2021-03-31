using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class BaseResponse<DataResponse> : TianResponse 
    {
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("result")]
        public DataResponse Result { get; set; }
    }
}
