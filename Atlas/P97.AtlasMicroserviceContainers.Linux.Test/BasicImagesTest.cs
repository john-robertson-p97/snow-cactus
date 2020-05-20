using Microsoft.VisualStudio.TestTools.UnitTesting;
using P97.MicroserviceContainers.TestUtils;
using System;
using System.Collections.Generic;
using System.IO;

namespace P97.AtlasMicroserviceContainers.Linux.Test
{
    [TestClass]
    public class BasicImagesTest
    {
        [TestMethod]
        public void atlas_delivery_service_dockerfile_works()
        {
            const string repo = "atlas-deliveryservice";
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.Atlas.Federation.DeliveryService.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void atlas_phoenix_dockerfile_works()
        {
            const string repo = "atlas-phoenix";
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.Atlas.States.Phoenix.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void atlas_sapporo_dockerfile_works()
        {
            const string repo = "atlas-sapporo";
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.Atlas.States.Sapporo.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        private readonly string _workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
    }
}
