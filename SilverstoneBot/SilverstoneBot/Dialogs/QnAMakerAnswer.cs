using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SilverstoneBot.Dialogs
{
    public class QnAMakerAnswer
    {
        [JsonProperty(PropertyName = "answer")]
        public string Answer { get; set; }

        [JsonProperty(PropertyName = "score")]
        public double Score { get; set; }
    }
}