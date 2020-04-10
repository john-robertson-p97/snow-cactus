@ECHO off

ECHO Deleting previous Minikube cluster, if one exists...
minikube delete

ECHO Starting new Minikube cluster...
minikube start

ECHO Pointing Docker commands to the environment in Minikube...
FOR /f "tokens=*" %%i IN ('minikube -p minikube docker-env') DO %%i

ECHO Building Docker images...
CALL %~dp0\build-images_linux.bat

ECHO Deploying images to cluster...
CALL %~dp0\deploy-to-cluster_local.bat

for /f %%i in ('minikube ip') do set VAR=%%i
ECHO Finished!  You may now access the cluster through the following IP: %VAR%