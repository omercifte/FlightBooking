namespace FlightBooking.AgentServices
{
    public interface ITravelAgentService
    {
        Task<string> AskAgentAsync(string prompt);
    }
}
