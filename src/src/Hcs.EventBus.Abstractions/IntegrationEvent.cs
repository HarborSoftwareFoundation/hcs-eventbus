namespace Harbor.Hcs.EventBus
{
    public record IntegrationEvent
    {
        public IntegrationEvent(string message) => Message = message;

        public string Message { get; set; }
    }
}
