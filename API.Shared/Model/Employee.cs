using System.Text.Json.Serialization;

namespace API.Shared.Model
{
    public class Employee
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
