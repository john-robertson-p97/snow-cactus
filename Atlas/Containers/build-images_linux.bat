@echo off

SET var=%cd%
cd %~dp0..

docker build -t warehouse-microservice               -f P97.Warehouse.Microservice/Containers/Dockerfile_Linux								.
docker build -t display-microservice                 -f P97.Display.Microservice/Containers/Dockerfile_Linux								.
docker build -t cactusmaterialsupplier-microservice  -f P97.CactusMaterialSupplier.Microservice.AtlasPhoenix/Containers/Dockerfile_Linux	.
docker build -t cactusbuilder-microservice           -f P97.CactusBuilder.Microservice.AtlasPhoenix/Containers/Dockerfile_Linux				.
docker build -t atlas-phoenix-microservice           -f P97.Atlas.States.Phoenix.Microservice/Containers/Dockerfile_Linux					.
docker build -t snowmanmaterialsupplier-microservice -f P97.SnowmanMaterialSupplier.Microservice.AtlasSapporo/Containers/Dockerfile_Linux	.
docker build -t snowmanbuilder-microservice          -f P97.SnowmanBuilder.Microservice.AtlasSapporo/Containers/Dockerfile_Linux						.
docker build -t atlas-sapporo-microservice           -f P97.Atlas.States.Sapporo.Microservice/Containers/Dockerfile_Linux					.
docker build -t atlas-deliveryservice-microservice   -f P97.Atlas.Federation.DeliveryService.Microservice/Containers/Dockerfile_Linux		.

cd %var%