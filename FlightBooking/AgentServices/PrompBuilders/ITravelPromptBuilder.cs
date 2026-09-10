namespace FlightBooking.AgentServices.PrompBuilders
{
    public interface ITravelPromptBuilder
    {
        string BuildPrompt(string userPrompt);
    }
}
