using System;
using System.Collections.Generic;

namespace P97.Atlas.States.Phoenix.DataAccess
{
    /// <summary>
    ///     Data access type for workflows.
    /// </summary>
    internal interface IWorkflowDataAccess
    {
        /// <summary>
        ///     Gets the workflow for a given app tenant ID.
        /// </summary>
        /// <param name="appTenantId">
        ///     The app tenant ID to get the workflow for.
        /// </param>
        /// <returns>
        ///     An <see cref="IReadOnlyDictionary{string, IEnumerable{OutgoingCall}}"/> representing the workflow. 
        ///     The keys to this dictionary are the various event types that may be raised.  The values are sets of
        ///     zero or more outgoing calls that must be made in response.
        /// </returns>
        IReadOnlyDictionary<string, IEnumerable<OutgoingCall>> GetWorkflow(Guid appTenantId);
    }
}