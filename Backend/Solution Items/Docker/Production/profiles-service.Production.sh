#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/profiles-service \
  -f ../../../Profiles/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Production;
  
docker push ${REGISTRY_URL}/kurkle/profiles-service
 