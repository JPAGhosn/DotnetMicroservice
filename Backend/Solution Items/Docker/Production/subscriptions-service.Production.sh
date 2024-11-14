#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/subscriptions-service \
  -f ../../../Subscriptions/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/subscriptions-service
 