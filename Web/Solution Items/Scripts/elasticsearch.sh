#!/usr/bin/env bash

kubectl apply -f ../K8S/ElasticSearch/elasticsearch.yaml;
kubectl apply -f ../K8S/ElasticSearch/elasticsearch-nodeport.yaml;
kubectl apply -f ../K8S/ElasticSearch/kibana.yaml;
kubectl apply -f ../K8S/ElasticSearch/kibana-nodeport.yaml;

