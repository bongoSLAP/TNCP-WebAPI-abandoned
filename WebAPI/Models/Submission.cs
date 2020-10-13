using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Nest;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class PrelimSubmission
    {
        [JsonProperty(PropertyName = "assignedTo")]
        public string AssignedTo { get; set; }
        [JsonProperty(PropertyName = "argumentNature")]
        public string NatureOf { get; set; }
        [JsonProperty(PropertyName = "submissionText")]
        public string Text { get; set; }
        [JsonProperty(PropertyName = "isSource")]
        public bool IsSource { get; set; }
        [JsonProperty(PropertyName = "sourceLink")]
        public string Link { get; set; }
    }

    public class Submission : PrelimSubmission
    {
        [JsonProperty(PropertyName = "submissionId")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "urlOfArticle")]
        public string Url { get; set; }
    }
}