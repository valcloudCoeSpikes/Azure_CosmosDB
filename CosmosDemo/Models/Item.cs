using Newtonsoft.Json;
using System.Collections.Generic;

namespace CosmosDemo.Models
{
    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "projectName")]
        public string ProjectName { get; set; }

        [JsonProperty(PropertyName = "manager")]
        public string Manager { get; set; }

        [JsonProperty(PropertyName = "active")]
        public bool Active { get; set; }

        [JsonProperty(PropertyName = "tasks")]
        public List<ProjectTask> ProjectTask = new List<ProjectTask>();
    }
}
