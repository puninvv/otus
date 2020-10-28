using System.Text.Json.Serialization;

namespace HealthyService.Models
{
    public enum Status
    { 
        Unknown,
        OK,
    }

    public class HealthStatus
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Status Status { get; set; }
    }
}
