#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/reactions-service \
  -f ../../../Reactions/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/reactions-service;

kubectl delete secrets postgresreactions;
kubectl create secret generic postgresreactions --from-literal=POSTGRES_PASSWORD=admin;

kubectl delete deployments reactions-service reactions-database-deployment;
kubectl delete service reactions-cluster-ip-service reactions-database-cluster-ip reactions-database-load-balancer reactions-database-nodeport reactions-node-port;

kubectl apply -f ../../K8S/Reactions/Database/pvc.yaml;
kubectl apply -f ../../K8S/Reactions/Database/deployment.yaml;
kubectl apply -f ../../K8S/Reactions/Database/nodeport.yaml;

kubectl apply -f ../../K8S/Reactions/Service/service.yaml;
kubectl apply -f ../../K8S/Reactions/Service/nodeport.yaml;