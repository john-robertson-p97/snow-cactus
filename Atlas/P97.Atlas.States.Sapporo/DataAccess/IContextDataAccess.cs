using P97.Atlas.States.Sapporo.Surface.Data;
using System;

namespace P97.Atlas.States.Sapporo.DataAccess
{
    /// <summary>
    ///     Data access type for <see cref="ContextDto"/>s.
    /// </summary>
    internal interface IContextDataAccess
    {
        /// <summary>
        ///     Inserts a new <see cref="ContextDto"/>.
        /// </summary>
        /// <param name="context">
        ///     The <see cref="ContextDto"/> to be inserted.
        /// </param>
        void InsertContext(ContextDto context);

        /// <summary>
        ///     Gets the <see cref="ContextDto"/> that has the correlation ID provided.
        /// </summary>
        /// <param name="correlationId">
        ///     The correlation ID.  No more than one context should ever have the same correlation ID.
        /// </param>
        /// <returns>
        ///     The <see cref="ContextDto"/> possessing the correlation ID provided.
        /// </returns>
        ContextDto GetContext(Guid correlationId);
    }
}