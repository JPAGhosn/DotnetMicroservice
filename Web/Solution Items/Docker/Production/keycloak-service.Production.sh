kubectl delete secret postgreskeycloak
kubectl create secret generic postgreskeycloak --from-literal=POSTGRES_PASSWORD=admin

kubectl delete deployments keycloak-service keycloak-database;
kubectl delete services keycloak-database-nodeport;
kubectl delete configmap keycloak-realm-config;

kubectl create configmap keycloak-realm-config --from-file=../../Configurations;

kubectl apply -f ../../K8S/Keycloak/Database/pvc.yaml;
kubectl apply -f ../../K8S/Keycloak/Database/deployment.yaml;
kubectl apply -f ../../K8S/Keycloak/Database/nodeport.yaml;
kubectl apply -f ../../K8S/Keycloak/Service/service.yaml;
kubectl apply -f ../../K8S/Keycloak/Service/nodeport.yaml;