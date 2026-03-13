using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Models
{
    public class TaskStatusResponse
    {
        [JsonPropertyName("data")]
        public List<TaskStatusItem> Data { get; set; } = new();

        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }
    }
}
