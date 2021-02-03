// Copyright (c) Parusnik.
// Licensed under the MIT License. See LICENSE in the project root for license information.

namespace Parusnik.Pcs.EventBus
{
    public record IntegrationEvent
    {
        public IntegrationEvent(string message) => Message = message;

        public string Message { get; set; }
    }
}
