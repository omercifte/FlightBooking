using FlightBooking.Dtos.AgentDtos;

namespace FlightBooking.AgentServices.OpenIAServices
{
    public interface IOpenAIService
    {
        Task<AgentResponseDto> GetResponseAsync(string prompt);
    }
}
