#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/collections-service \
  -f ../../Collections/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/collections-service;

kubectl delete secrets \
  postgrescollections  ;
  
kubectl create secret generic \
  postgrescollections \
  --from-literal=POSTGRES_PASSWORD=admin;

kubectl delete deployments \
  collections-service \
  collections-database-deployment;
  
  
kubectl delete service \
  collections-cluster-ip-service \
  collections-database-cluster-ip \
  collections-database-load-balancer \
  collections-database-nodeport \
  collections-node-port;

kubectl apply -f ../K8S/Collections/Database/pvc.yaml;
kubectl apply -f ../K8S/Collections/Database/deployment.yaml;
kubectl apply -f ../K8S/Collections/Database/nodeport.yaml;

kubectl apply -f ../K8S/Collections/Service/service.yaml;
kubectl apply -f ../K8S/Collections/Service/nodeport.yaml;