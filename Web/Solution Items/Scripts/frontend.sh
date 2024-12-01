#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/frontend-service \
  -f ../../krk-web/Dockerfile ../../krk-web;
  
docker push ${REGISTRY_URL}/kurkle/frontend-service;

kubectl delete deployments frontend-service ;

kubectl apply -f ../K8S/Frontend/Service/service.yaml;
kubectl apply -f ../K8S/Frontend/Service/nodeport.yaml;