wget https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh; `
chmod +x dotnet-install.sh; `
./dotnet-install.sh; `
$ENV:PATH="$HOME/.dotnet:$ENV:PATH"; `
git clone https://github.com/CentauriConsulting/Commercial-Marketplace-SaaS-Accelerator.git -b main --depth 1; `
 cd ./Commercial-Marketplace-SaaS-Accelerator/deployment/Templates; `
 Connect-AzureAD -Confirm; .\Deploy.ps1 `
 -Location "West Europe" `
 -PathToARMTemplate "./deploy.json" `
 -PublisherAdminUsers "comwenga@centauri.co.ke" `
 -ResourceGroupForDeployment "saas-accelerator" `
 -SQLAdminLogin "cloudextendapps" `
 -SQLAdminLoginPassword "#Karibu2022" `
 -SQLServerName "cloudextend" `
 -WebAppNamePrefix "ctri"
 -TenantID "xxxx-xxx-xxx-xxx-xxxx"
-AzureSubscriptionID "xxx-xx-xx-xx-xxxx"
-ADApplicationID "xxxx-xxx-xxx-xxx-xxxx"
-ADApplicationSecret "xxxx-xxx-xxx-xxx-xxxx"
-ADMTApplicationID "xxxx-xxx-xxx-xxx-xxxx"
-LogoURLpng "https://comwenga.blob.core.windows.net/assets/img/log240x240.png"
-LogoURLico "https://comwenga.blob.core.windows.net/assets/img/icon/favicon.ico"