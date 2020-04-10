@ECHO off

kubectl create -f %~dp0..\Warehouse.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\Display.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\CactusMaterialSupplier.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\CactusBuilder.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\Atlas.Phoenix.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\SnowmanMaterialSupplier.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\SnowmanBuilder.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\Atlas.Sapporo.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\Atlas.Express.Microservice\Containers\k8s_docker-hub.yaml