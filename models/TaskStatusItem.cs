using System.Text.Json.Serialization;

namespace Models
{
    public class TaskStatusItem
    {
        [JsonPropertyName("taskStatusId")]
        public int TaskStatusId { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("isActive")]
        public bool IsActive { get; set; }
    }
}
