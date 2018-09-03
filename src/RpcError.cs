using Newtonsoft.Json;
using System.Collections;

namespace SimpleJsonRpc
{
    public class RpcError 
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }

    }
}
