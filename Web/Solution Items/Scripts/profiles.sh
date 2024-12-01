#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";


docker build \
  -t ${REGISTRY_URL}/kurkle/profiles-service \
  -f ../../Profiles/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/profiles-service;

kubectl delete secrets postgresprofiles ;
kubectl create secret generic postgresprofiles --from-literal=POSTGRES_PASSWORD=admin ;

kubectl delete deployments profiles-service profiles-database-deployment ;
kubectl delete service profiles-cluster-ip-service profiles-database-cluster-ip profiles-database-nodeport profiles-node-port ;

kubectl apply -f ../K8S/Profiles/Database/pvc.yaml;
kubectl apply -f ../K8S/Profiles/Database/deployment.yaml;
kubectl apply -f ../K8S/Profiles/Database/nodeport.yaml;

kubectl apply -f ../K8S/Profiles/Service/service.yaml;
kubectl apply -f ../K8S/Profiles/Service/nodeport.yaml;