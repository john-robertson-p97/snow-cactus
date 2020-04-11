@echo off

SET var=%cd%
cd %~dp0..

docker build -t warehouse-microservice               -f Warehouse.Microservice/Containers/Dockerfile_Linux               .
docker build -t display-microservice                 -f Display.Microservice/Containers/Dockerfile_Linux                 .
docker build -t cactusmaterialsupplier-microservice  -f CactusMaterialSupplier.Microservice/Containers/Dockerfile_Linux  .
docker build -t cactusbuilder-microservice           -f CactusBuilder.Microservice/Containers/Dockerfile_Linux           .
docker build -t atlas-phoenix-microservice           -f Atlas.Phoenix.Microservice/Containers/Dockerfile_Linux           .
docker build -t snowmanmaterialsupplier-microservice -f SnowmanMaterialSupplier.Microservice/Containers/Dockerfile_Linux .
docker build -t snowmanbuilder-microservice          -f SnowmanBuilder.Microservice/Containers/Dockerfile_Linux          .
docker build -t atlas-sapporo-microservice           -f Atlas.Sapporo.Microservice/Containers/Dockerfile_Linux           .
docker build -t atlas-deliveryservice-microservice   -f Atlas.DeliveryService.Microservice/Containers/Dockerfile_Linux           .

cd %var%