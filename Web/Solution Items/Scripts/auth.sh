#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/auth-service \
  -f ../../Auth/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/auth-service;

kubectl delete deployments \
  auth-service \
  auth-database \
  ;
  
kubectl delete services \
  auth-node-port \
  auth-database-node-port \
  auth-database-cluster-ip \
  auth-database-load-balancer \
  ;
  
kubectl delete secrets postgresauth ;

kubectl create secret generic postgresauth \
  --from-literal=POSTGRES_PASSWORD=admin \
  ;

kubectl apply -f ../K8S/Auth/Database/pvc.yaml;
kubectl apply -f ../K8S/Auth/Database/deployment.yaml;
kubectl apply -f ../K8S/Auth/Database/nodeport.yaml;

kubectl apply -f ../K8S/Auth/Service/service.yaml;
kubectl apply -f ../K8S/Auth/Service/nodeport.yaml;