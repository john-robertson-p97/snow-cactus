@echo off

SET var=%cd%
cd %~dp0..

docker build -t display                 -f P97.Display.Microservice/Containers/Dockerfile_Linux									.
docker build -t warehouse               -f P97.Warehouse.Microservice/Containers/Dockerfile_Linux								.
docker build -t cactusbuilder           -f P97.CactusBuilder.Microservice/Containers/Dockerfile_Linux							.
docker build -t cactusmaterialsupplier  -f P97.CactusMaterialSupplier.Microservice/Containers/Dockerfile_Linux					.
docker build -t snowmanbuilder          -f P97.SnowmanBuilder.Microservice/Containers/Dockerfile_Linux							.
docker build -t snowmanmaterialsupplier -f P97.SnowmanMaterialSupplier.Microservice/Containers/Dockerfile_Linux					.
docker build -t atlas-deliveryservice   -f P97.Atlas.Federation.DeliveryService.Microservice/Containers/Dockerfile_Linux		.
docker build -t atlas-phoenix           -f P97.Atlas.States.Phoenix.Microservice/Containers/Dockerfile_Linux					.
docker build -t atlas-sapporo           -f P97.Atlas.States.Sapporo.Microservice/Containers/Dockerfile_Linux					.

cd %var%