#!/usr/bin/env bash

# How to generate TLS and crt
# openssl req -x509 -nodes -days 365 -newkey rsa:2048 -keyout tls.key -out tls.crt
# kubectl create secret tls kurkle-tls --cert=tls.crt --key=tls.key

#kubectl create secret tls kurkle-tls --cert=/path/to/tls.crt --key=/path/to/tls.key
kubectl delete ingress ingress-service;
kubectl apply -f ../K8S/ingress-service.yaml;