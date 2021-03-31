using Newtonsoft.Json;

namespace TianYanCha.SDK.Reponse
{
    public class SnapshotResponse
    {
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
