#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/glimpses-service \
  -f ../../Glimpses/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/glimpses-service;


kubectl delete secrets postgresglimpses ;
kubectl create secret generic postgresglimpses --from-literal=POSTGRES_PASSWORD=admin ;

kubectl delete deployments glimpses-service glimpses-database-deployment ;
kubectl delete service glimpses-cluster-ip-service glimpses-database-cluster-ip glimpses-database-load-balancer glimpses-database-nodeport glimpses-node-port ;

kubectl apply -f ../K8S/Glimpses/Database/pvc.yaml;
kubectl apply -f ../K8S/Glimpses/Database/deployment.yaml;
kubectl apply -f ../K8S/Glimpses/Database/nodeport.yaml;

kubectl apply -f ../K8S/Glimpses/Service/service.yaml;
kubectl apply -f ../K8S/Glimpses/Service/nodeport.yaml;