#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/recipes-service \
  -f ../../Recipes/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/recipes-service;
 
kubectl delete deployments recipes-service ;

kubectl delete secrets postgresrecipes ;
kubectl create secret generic postgresrecipes --from-literal=POSTGRES_PASSWORD=admin ;

kubectl apply -f ../K8S/Recipes/Database/nodeport.yaml;
kubectl apply -f ../K8S/Recipes/Database/pvc.yaml;
kubectl apply -f ../K8S/Recipes/Database/deployment.yaml;

kubectl apply -f ../K8S/Recipes/Service/service.yaml;
kubectl apply -f ../K8S/Recipes/Service/nodeport.yaml;
