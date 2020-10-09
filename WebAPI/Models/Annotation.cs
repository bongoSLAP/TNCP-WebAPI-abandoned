using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Newtonsoft.Json;

namespace WebAPI.Models
{
    public class Annotation
    {
        [JsonProperty(PropertyName = "annotationId")]
        public string Id { get; set; }
        [JsonProperty(PropertyName = "textAnnotated")]
        public string TextAnnotated { get; set; }
        [JsonProperty(PropertyName = "isUnified")]
        public bool IsUnified { get; set; }
        [JsonProperty(PropertyName = "urlOfArticle")]
        public string Url { get; set; }

        public class Anchor 
        {
            [JsonProperty(PropertyName = "nodeName")]
            public string NodeName { get; set; }
            [JsonProperty(PropertyName = "nodeType")]
            public string NodeType { get; set; }
            [JsonProperty(PropertyName = "wholeText")]
            public string WholeText { get; set; }

            public class ParentNode
            {
                [JsonProperty(PropertyName = "nodeName")]
                public string NodeName { get; set; }
                [JsonProperty(PropertyName = "nodeType")]
                public string NodeType { get; set; }
                [JsonProperty(PropertyName = "parentWholeText")]
                public string ParentWholeText { get; set; }

            }

            [JsonProperty(PropertyName = "parentNode")]
            public ParentNode parentNode = new ParentNode();
        }

        [JsonProperty(PropertyName = "anchor")]
        public Anchor anchor = new Anchor();

        public class Focus
        {
            [JsonProperty(PropertyName = "nodeName")]
            public string NodeName { get; set; }
            [JsonProperty(PropertyName = "nodeType")]
            public string NodeType { get; set; }
            [JsonProperty(PropertyName = "wholeText")]
            public string WholeText { get; set; }

            public class ParentNode
            {
                [JsonProperty(PropertyName = "nodeName")]
                public string NodeName { get; set; }
                [JsonProperty(PropertyName = "nodeType")]
                public string NodeType { get; set; }
                [JsonProperty(PropertyName = "parentWholeText")]
                public string ParentWholeText { get; set; }
            }

            [JsonProperty(PropertyName = "parentNode")]
            public ParentNode parentNode = new ParentNode();
        }

        [JsonProperty(PropertyName = "focus")]
        public Focus focus = new Focus();
    }
}