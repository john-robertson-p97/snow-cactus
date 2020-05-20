@ECHO off

kubectl delete service display
kubectl delete deployment display

kubectl delete service warehouse
kubectl delete deployment warehouse

kubectl delete service cactusbuilder
kubectl delete deployment cactusbuilder

kubectl delete service cactusmaterialsupplier
kubectl delete deployment cactusmaterialsupplier

kubectl delete service snowmanbuilder
kubectl delete deployment snowmanbuilder

kubectl delete service snowmanmaterialsupplier
kubectl delete deployment snowmanmaterialsupplier

kubectl delete service atlas-deliveryservice
kubectl delete deployment atlas-deliveryservice

kubectl delete service atlas-phoenix
kubectl delete deployment atlas-phoenix

kubectl delete service atlas-sapporo
kubectl delete deployment atlas-sapporo