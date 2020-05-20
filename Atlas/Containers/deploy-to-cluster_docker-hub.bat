@ECHO off

kubectl create -f %~dp0..\P97.Display.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.Warehouse.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.CactusBuilder.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.CactusMaterialSupplier.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.SnowmanBuilder.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.SnowmanMaterialSupplier.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.Atlas.Federation.DeliveryService.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.Atlas.States.Phoenix.Microservice\Containers\k8s_docker-hub.yaml
kubectl create -f %~dp0..\P97.Atlas.States.Sapporo.Microservice\Containers\k8s_docker-hub.yaml