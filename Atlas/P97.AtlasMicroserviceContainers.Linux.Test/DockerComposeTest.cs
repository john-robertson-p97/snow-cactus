using Microsoft.VisualStudio.TestTools.UnitTesting;
using P97.MicroserviceContainers.TestUtils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace P97.AtlasMicroserviceContainers.Linux.Test
{
    [TestClass]
    public class DockerComposeTest
    {
        [TestMethod]
        public void docker_compose_file_works()
        {
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.RunDockerCompose();
            List<string> repos = dockerUtility.GetRepos();
            dockerUtility.StopContainers();
            dockerUtility.Prune();

            Assert.IsTrue(_manifest.All(x => repos.Contains(x)));
        }

        private readonly string _workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;

        private readonly IEnumerable<string> _manifest = new[] {
            Atlas.Federation.DeliveryService.Microservice.Surface.Definitions.UriInfo.ServiceName,
            Atlas.States.Phoenix.Microservice.Surface.Definitions.UriInfo.ServiceName,
            Atlas.States.Sapporo.Microservice.Surface.Definitions.UriInfo.ServiceName,
            CactusBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName,
            CactusMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName,
            Display.Microservice.Surface.Definitions.UriInfo.ServiceName,
            SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName,
            SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName,
            Warehouse.Microservice.Surface.Definitions.UriInfo.ServiceName
        };
    }
}
