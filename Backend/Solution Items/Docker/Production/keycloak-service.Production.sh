#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/keycloak \
  -f ../Dockerfiles/KeycloakDockerfile  \
  ../..;
  
docker push ${REGISTRY_URL}/kurkle/keycloak
 