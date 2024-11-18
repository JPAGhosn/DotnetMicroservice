#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/subscriptions-service \
  -f ../../../Subscriptions/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/subscriptions-service;

kubectl delete secrets postgressubscriptions;
kubectl create secret generic postgressubscriptions --from-literal=POSTGRES_PASSWORD=admin;

kubectl delete deployments subscriptions-service;

kubectl apply -f ../../K8S/Subscriptions/Service/service.yaml;