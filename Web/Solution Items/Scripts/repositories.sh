#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

# Deploy and push Git server
docker build \
  -t ${REGISTRY_URL}/kurkle/repositories-git-remote \
  -f ./Dockerfile-VCS .;
  
docker push ${REGISTRY_URL}/kurkle/repositories-git-remote;

# Deploy and push the service.
docker build \
  -t ${REGISTRY_URL}/kurkle/repositories-service \
  -f ../../Repositories/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/repositories-service;
 
kubectl delete deployments repositories-service ;

kubectl delete secrets postgresrepositories ;
kubectl create secret generic postgresrepositories --from-literal=POSTGRES_PASSWORD=admin ;

kubectl apply -f ../K8S/Repositories/Database/nodeport.yaml;
kubectl apply -f ../K8S/Repositories/Database/pvc.yaml;
kubectl apply -f ../K8S/Repositories/Database/deployment.yaml;

kubectl apply -f ../K8S/Repositories/Service/service.yaml;
kubectl apply -f ../K8S/Repositories/Service/nodeport.yaml;
