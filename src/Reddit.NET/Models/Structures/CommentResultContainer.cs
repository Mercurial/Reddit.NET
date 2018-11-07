﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reddit.NET.Models.Structures
{
    [Serializable]
    public class CommentResultContainer
    {
        [JsonProperty("json")]
        public CommentResult JSON;
    }
}