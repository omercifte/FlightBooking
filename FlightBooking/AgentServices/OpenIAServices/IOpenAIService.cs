namespace FlightBooking.AgentServices.OpenIAServices
{
    public interface IOpenAIService
    {
        Task<string> GetResponseAsync(string prompt);
    }
}
