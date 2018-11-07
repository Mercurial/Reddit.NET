﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class S3UploadLeaseContainer
    {
        [JsonProperty("s3UploadLease")]
        public S3UploadLease S3UploadLease;

        [JsonProperty("websocketUrl")]
        public string WebSocketURL;
    }
}