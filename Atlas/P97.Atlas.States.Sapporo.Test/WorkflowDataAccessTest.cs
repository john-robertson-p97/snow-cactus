using Microsoft.VisualStudio.TestTools.UnitTesting;
using P97.Atlas.Federation.Surface.Definitions;
using P97.Atlas.States.Sapporo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace P97.Atlas.States.Sapporo.Test
{
    [TestClass]
    public class WorkflowDataAccessTest
    {
        [TestMethod]
        public void all_initiating_event_types_accounted_for()
        {
            var dataAccess = new WorkflowDataAccess();

            Guid[] appTenantIds = GetAppTenantIds().ToArray();
            Dictionary<Guid, IReadOnlyDictionary<string, IEnumerable<OutgoingCall>>> workflows =
                    appTenantIds.ToDictionary(x => x, x => dataAccess.GetWorkflow(x));
            IEnumerable<string> eventTypes = GetEventTypes(typeof(Atlas.Surface.Definitions.InitiatingEventTypes));

            Assert.IsTrue(appTenantIds.All(x => eventTypes.All(y => workflows[x].ContainsKey(y) && workflows[x][y] != null)));
        }

        [TestMethod]
        public void all_snowman_material_supplier_event_types_accounted_for()
        {
            var dataAccess = new WorkflowDataAccess();

            Guid[] appTenantIds = GetAppTenantIds().ToArray();
            Dictionary<Guid, IReadOnlyDictionary<string, IEnumerable<OutgoingCall>>> workflows =
                    appTenantIds.ToDictionary(x => x, x => dataAccess.GetWorkflow(x));
            IEnumerable<string> eventTypes = GetEventTypes(typeof(SnowmanMaterialSupplier.Surface.Definitions.EventTypes));

            Assert.IsTrue(appTenantIds.All(x => eventTypes.All(y => workflows[x].ContainsKey(y) && workflows[x][y] != null)));
        }

        private IEnumerable<Guid> GetAppTenantIds()
        {
            return
                typeof(AppTenantIds)
                    .GetFields(BindingFlags.NonPublic | BindingFlags.Static)
                    .Where(fi => fi.IsInitOnly)
                    .Select(x => (Guid)x.GetValue(typeof(AppTenantIds)));
        }

        private IEnumerable<string> GetEventTypes(Type type)
        {
            return
                type
                    .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                    .Where(fi => fi.IsLiteral && !fi.IsInitOnly)
                    .Select(x => (string)x.GetValue(typeof(AppTenantIds)));
        }
    }
}