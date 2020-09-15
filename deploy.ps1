az login
az aks install-cli
az group create --name mapQuizResources --location eastus
az aks create --resource-group mapQuizResources --name mapQuizCluster --node-count 1 --enable-addons http_application_routing --generate-ssh-keys
az aks get-credentials --resource-group mapQuizResources --name mapQuizCluster
kubectl apply -f deploy-mapQuiz.yaml
