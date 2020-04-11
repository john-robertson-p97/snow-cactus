@ECHO off

kubectl delete service warehouse-microservice
kubectl delete deployment warehouse-microservice

kubectl delete service display-microservice
kubectl delete deployment display-microservice

kubectl delete service cactusmaterialsupplier-microservice
kubectl delete deployment cactusmaterialsupplier-microservice

kubectl delete service cactusbuilder-microservice
kubectl delete deployment cactusbuilder-microservice

kubectl delete service atlas-phoenix-microservice
kubectl delete deployment atlas-phoenix-microservice

kubectl delete service snowmanmaterialsupplier-microservice
kubectl delete deployment snowmanmaterialsupplier-microservice

kubectl delete service snowmanbuilder-microservice
kubectl delete deployment snowmanbuilder-microservice

kubectl delete service atlas-sapporo-microservice
kubectl delete deployment atlas-sapporo-microservice

kubectl delete service atlas-deliveryservice-microservice
kubectl delete deployment atlas-deliveryservice-microservice