#!/usr/bin/env bash

kubectl delete deployments \
  seaweedfs-master \
#  seaweedfs-volume
  seaweedfs-filer ;
  
kubectl delete services seaweedfs-master seaweedfs-volume seaweedfs-filer seaweed-master-node-port ;

kubectl apply -f ../K8S/SeaweedFS/Service/seaweedfs.yaml;
kubectl apply -f ../K8S/SeaweedFS/Service/node-port.yaml;
