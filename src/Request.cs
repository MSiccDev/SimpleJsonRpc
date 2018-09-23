using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SimpleJsonRpc
{
    public class Request
    {
        public Request(string method, object parameters, int id = 1, string version = "2.0")
        {
            this.JsonRpc = version;
            this.Id = id;
            this.Method = method;

            this.Params = parameters ?? new List<object>(0);
        }

        [JsonProperty("jsonrpc", Required = Required.Always)]
        public string JsonRpc { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public int Id { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public string Method { get; set; }

        [JsonProperty("params")]
        public object Params { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this, Formatting.Indented);
    }
}
