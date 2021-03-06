﻿using Newtonsoft.Json;

namespace LogCast.Http.Contract
{
    public class Root
    {
        [JsonProperty("request", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Request Request;

        [JsonProperty("response", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Response Response;

        [JsonIgnore]
        public bool HasData => Request != null || Response != null;
        [JsonIgnore]
        public const string FieldName = "http";
    }
}