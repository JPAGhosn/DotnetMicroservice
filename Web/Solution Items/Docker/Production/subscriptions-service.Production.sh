#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/subscriptions-service \
  -f ../../../Subscriptions/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/subscriptions-service;
 
kubectl delete deployments subscriptions-service;

kubectl delete secrets postgressubscriptions;
kubectl create secret generic postgressubscriptions --from-literal=POSTGRES_PASSWORD=admin;

kubectl apply -f ../../K8S/Subscriptions/Database/nodeport.yaml;
kubectl apply -f ../../K8S/Subscriptions/Database/pvc.yaml;
kubectl apply -f ../../K8S/Subscriptions/Database/deployment.yaml;

kubectl apply -f ../../K8S/Subscriptions/Service/service.yaml;
kubectl apply -f ../../K8S/Subscriptions/Service/nodeport.yaml;
