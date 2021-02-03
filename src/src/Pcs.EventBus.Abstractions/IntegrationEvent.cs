// Copyright (c) Parusnik.
// Licensed under the MIT License. See the LICENSE file in the project root for more information.

namespace Parusnik.Pcs.EventBus
{
    public record IntegrationEvent
    {
        public IntegrationEvent(string message) => Message = message;

        public string Message { get; set; }
    }
}
