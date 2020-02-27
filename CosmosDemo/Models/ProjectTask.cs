using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CosmosDemo.Models
{
    public class ProjectTask
    {
        [JsonProperty(PropertyName = "taskId")]
        public string TaskId { get; set; }

        [JsonProperty(PropertyName = "taskName")]
        public string TaskName { get; set; }

        [JsonProperty(PropertyName = "assignedTo")]
        public string AssignedTo { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }
    }
}
