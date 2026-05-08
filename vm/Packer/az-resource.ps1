# Create resource group
az group create --name myResourceGroup --location westus2

# Create resource group for temporary resource creation
az group create --name packer-rg --location westus2

# Create a service principal with Contributor permissions
az ad sp create-for-rbac --role Contributor --name az-climy2-04-29 --scopes /subscriptions/7xxxxxxxxxxx-xxx-xxx-xxxxxxa --query "{ client_id: appId, client_secret: password, tenant_id: tenant }"

# Create shared image gallery resource
az sig create --resource-group myResourceGroup --gallery-name packergallery

# Create shared image gallery image definition
az sig image-definition create --resource-group myResourceGroup --gallery-name packergallery --gallery-image-definition packerimagedefn --os-type Linux --publisher packerpublisher --offer packeroffer --sku packersku

