namespace Parusnik.Pcs.EventBus
{
    public record IntegrationEvent
    {
        public IntegrationEvent(string message) => Message = message;

        public string Message { get; set; }
    }
}
