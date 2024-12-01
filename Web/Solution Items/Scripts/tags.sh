#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/tags-service \
  -f ../../Tags/Dockerfile ../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/tags-service ;

kubectl delete secrets postgrestags ;
kubectl create secret generic postgrestags --from-literal=POSTGRES_PASSWORD=admin ;

kubectl delete deployments tags-service tags-database-deployment ;
kubectl delete service tags-cluster-ip-service tags-database-cluster-ip tags-database-load-balancer tags-database-nodeport tags-node-port ;

kubectl apply -f ../K8S/Tags/Database/pvc.yaml;
kubectl apply -f ../K8S/Tags/Database/deployment.yaml;
kubectl apply -f ../K8S/Tags/Database/nodeport.yaml;

kubectl apply -f ../K8S/Tags/Service/service.yaml;
kubectl apply -f ../K8S/Tags/Service/nodeport.yaml;