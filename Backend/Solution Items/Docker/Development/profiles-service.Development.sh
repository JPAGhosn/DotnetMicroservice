#!/usr/bin/env bash

REGISTRY_URL="localhost:9870";

docker build \
  -t ${REGISTRY_URL}/kurkle/profilesservice \
  -f ../../../Profiles/Dockerfile ../../.. \
  --build-arg BUILD_CONFIGURATION=Development