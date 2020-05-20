using P97.Atlas.States.Sapporo.Surface.Data;
using System;
using System.Collections.Generic;

namespace P97.Atlas.States.Sapporo.DataAccess
{
    internal sealed class ContextDataAccess : IContextDataAccess
    {
        public void InsertContext(ContextDto context) => _contexts[context.CorrelationId] = context;

        public ContextDto GetContext(Guid correlationId) => _contexts[correlationId];

        private readonly Dictionary<Guid, ContextDto> _contexts = new Dictionary<Guid, ContextDto>();
    }
}