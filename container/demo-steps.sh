################################
# Create ACR
################################
# 1. Create the ACR in the Azure portal
# 2. Turn on admin and collect those values for later (under Access keys)

################################
# Deploying solution images to an Azure Container Registry
################################

# login to Azure
az login

# add the service principal to the ACR
az ad sp create --id 32597670-3e15-4def-8851-614ff48c1efa
az acr show --name YOUR_ACR_NAME --query "id" --output tsv
az role assignment create --assignee 32597670-3e15-4def-8851-614ff48c1efa --scope /subscriptions/SUBSCRIPTION_ID/resourceGroups/YOUR_ACR_RESOURCE_GROUP_NAME/providers/Microsoft.ContainerRegistry/registries/YOUR_ACR_NAME --role acrpull
az provider register --namespace Microsoft.PartnerCenterIngestion --subscription SUBSCRIPTION_ID --wait

# create docker network
docker network create ecnet

# vote-back-redis
docker pull redis:alpine3.18
docker tag redis:alpine3.18 YOUR_ACR_NAME.azurecr.io/vote-back-redis-alpine:3.1.8
docker run --network ecnet -d -e ALLOW_EMPTY_PASSWORD=yes -p 6379:6379 --name vote-back-redis --hostname vote-back-redis YOUR_ACR_NAME.azurecr.io/vote-back-redis-alpine:3.1.8

# move to the project folder
cd azure-vote

# vote-front
docker build -t YOUR_ACR_NAME.azurecr.io/vote-front:1.3.2 .
docker run --network ecnet -d -p 8080:80 -e REDIS=vote-back-redis --name vote-front YOUR_ACR_NAME.azurecr.io/vote-front:1.3.2
docker commit vote-front YOUR_ACR_NAME.azurecr.io/vote-front:1.3.2

# Pushing image to the ACR
docker login YOUR_ACR_NAME.azurecr.io -u YOUR_ACR_NAME -p ACR_ADMIN_PASSWORD
docker push YOUR_ACR_NAME.azurecr.io/vote-back-redis-alpine:3.1.8
docker push YOUR_ACR_NAME.azurecr.io/vote-front:1.3.2

################################
# Generating the CNAB bundle
################################

# cpa tool
docker pull mcr.microsoft.com/container-package-app:latest
docker run -it -v /var/run/docker.sock:/var/run/docker.sock -v /PATH_TO_PROJECT_DIR:/app --entrypoint "/bin/bash" --name cpa-tool mcr.microsoft.com/container-package-app:latest
cd app
cpa verify
docker login YOUR_ACR_NAME.azurecr.io -u YOUR_ACR_NAME -p ACR_ADMIN_PASSWORD
cpa buildbundle --force

# use the porter utility to inspect the CNAB and get additional detail
porter inspect --reference YOUR_ACR_NAME.azurecr.io/com.contoso.azurevotingapp:1.0.0

################################
# Unsubscribe from a purchased Kubernetes app
################################

# delete the extension created during installation
az extension add --name k8s-extension
az k8s-extension list --cluster-name AKS_INSTANCE_NAME --resource-group AKS_RESOURCE_GROUP_NAME --cluster-type managedClusters
az k8s-extension delete --name votingextension --cluster-name AKS_INSTANCE_NAME --resource-group AKS_RESOURCE_GROUP_NAME --cluster-type managedClusters

# delete the namespace
az aks command invoke --name AKS_INSTANCE_NAME --resource-group AKS_RESOURCE_GROUP_NAME --command "kubectl get ns -A"
az aks command invoke --name AKS_INSTANCE_NAME --resource-group AKS_RESOURCE_GROUP_NAME --command "kubectl delete ns contoso"