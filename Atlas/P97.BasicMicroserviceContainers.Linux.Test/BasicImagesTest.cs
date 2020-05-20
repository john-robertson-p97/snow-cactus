using Microsoft.VisualStudio.TestTools.UnitTesting;
using P97.MicroserviceContainers.TestUtils;
using System;
using System.Collections.Generic;
using System.IO;

namespace P97.BasicMicroserviceContainers.Linux.Test
{
    [TestClass]
    public class BasicImagesTest
    {
        [TestMethod]
        public void display_dockerfile_works()
        {
            const string repo = Display.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.Display.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void warehouse_dockerfile_works()
        {
            const string repo = Warehouse.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.Warehouse.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void cactusbuilder_dockerfile_works()
        {
            const string repo = CactusBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.CactusBuilder.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void cactusmaterialsupplier_dockerfile_works()
        {
            const string repo = CactusMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.CactusMaterialSupplier.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void snowmanbuilder_dockerfile_works()
        {
            const string repo = SnowmanBuilder.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.SnowmanBuilder.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        [TestMethod]
        public void snowmanmaterialsupplier_dockerfile_works()
        {
            const string repo = SnowmanMaterialSupplier.Microservice.Surface.Definitions.UriInfo.ServiceName;
            var dockerUtility = new DockerUtility(_workingDirectory);

            dockerUtility.Prune();
            dockerUtility.BuildImage(repo, @"P97.SnowmanMaterialSupplier.Microservice\Containers\Dockerfile_Linux");
            List<string> images = dockerUtility.GetRepos();
            dockerUtility.Prune();

            Assert.IsTrue(images.Contains(repo));
        }

        private readonly string _workingDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.Parent.FullName;
    }
}
