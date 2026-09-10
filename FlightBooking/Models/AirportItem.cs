using System.Text.Json.Serialization;

namespace FlightBooking.Models
{
    public class AirportItem
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }          // örn "COV" -> IATA kodu burada

        [JsonPropertyName("type")]
        public string? Type { get; set; }        // "airport"

        [JsonPropertyName("title")]
        public string? Title { get; set; }       // "Çukurova International Airport"

        [JsonPropertyName("subtitle")]
        public string? Subtitle { get; set; }

        [JsonPropertyName("city")]
        public string? City { get; set; }

        [JsonPropertyName("distance")]
        public string? Distance { get; set; }
    }
}
