# Lab 2: Installing the SaaS Accelerator

This lab takes you through a very quick installation process for the SaaS Accelerator using the Azure portal Cloud Shell. Once complete, you will have installed the SaaS Accelerator and published your offer in Partner Center.

<!-- no toc -->
1. [Exercise: Create an install document](#exercise-create-an-install-document)
1. [Exercise: Opening the cloud shell](#exercise-opening-the-cloud-shell)
1. [Exercise: Running the install script](#exercise-running-the-install-script)
1. [Exercise: Verify web applications](#exercise-verify-web-applications)
1. [Exercise: Partner Center Technical Configuration](#exercise-partner-center-technical-configuration)

## Exercise: Create an install document

Open your favorite text editor and paste the following PowersShell script into a text file.

```powershell
wget https://dotnet.microsoft.com/download/dotnet/scripts/v1/dotnet-install.sh; `
chmod +x dotnet-install.sh; `
./dotnet-install.sh; `
$ENV:PATH="$HOME/.dotnet:$ENV:PATH"; `
git clone https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator.git -b 5.0.0 --depth 1; `
cd ./Commercial-Marketplace-SaaS-Accelerator/deployment/Templates; `
Connect-AzureAD -Confirm; `
.\Deploy.ps1 `
 -WebAppNamePrefix "marketplacesaasgithub-SOME-UNIQUE-STRING" `
 -SQLServerName "marketplacesaasgithub-SOME-UNIQUE-STRING" `
 -SQLAdminLogin "adminlogin" `
 -SQLAdminLoginPassword "a_very_PASSWORD_2_SymB0L@s" `
 -PublisherAdminUsers "user@email.com" `
 -ResourceGroupForDeployment "MarketplaceSaasGitHub" `
 -Location "East US" `
 -PathToARMTemplate ".\deploy.json" `
 -TenantID "xxxx-xxx-xxx-xxx-xxxx"
 -AzureSubscriptionID "xxx-xx-xx-xx-xxxx"
 ```

 ### Defined values

In your text editor, replace each of the below values. They are described below.

| Parameter value | Description and notes |
|---|---|
| **AzureSubscriptionID** | The identity of the subscription to use when installing the accelerator. [Click here](https://docs.microsoft.com/en-us/azure/azure-portal/get-subscription-tenant-id#find-your-azure-subscription) to learn how to find your subscription ID. |
| **ResourceGroupForDeployment** | The name of the resource group you want to deploy the SaaS solution into. For the purposes of this lab, consider using `saas-accelerator-workshop`. |
| **SQLAdminLogin** | The admin username for the SQL Server that will be installed. Do NOT use name "admin" as it is not allowed and the deployment script will fail. |
| **SQLAdminLoginPassword** | The password for the SQL Server instance that will be installed. Make this password secure and at **least 12 characters long** so the deployment script doesn't fail. Do not use hyphens. |
| **SQLServerName** | The name of the SQL Server instance that will be deployed. The name can only contain lowercase letters. |
| **TenantID** | The identity of the tenant to be installed into. [Click here](https://docs.microsoft.com/en-us/azure/active-directory/fundamentals/active-directory-how-to-find-tenant#find-tenant-id-through-the-azure-portal) to learn how to find your tenant ID. |
| **WebAppNamePrefix** | A string that will be prefixed to the name of all resources that are created in your deployment resource group. This can be as short as three letters. Use lowercase alphanumeric characters only. |

[See here](https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator/blob/main/docs/Installation-Instructions.md#parameters) for explanations of all parameters including optional ones.

## Exercise: Opening the cloud shell

In the Azure portal, click the button next to the command bar as shown in the image below.

![Command shell](../images/01.png)

This opens the the PowerShell cloud shell, which is a command line that runs directly in Azure. Note the cloud shell is ready to use once you see a blinking cursor.

## Exercise: Running the install script

1. Go back to your PowerShell script in your text editor. The command should be completed and ready to run.
1. Copy the entire command into your copy/paste buffer.
1. Go back to the Azure portal in your browser and **right click** on the command shell window.
1. Select **Paste as plain text**.
1. If the script doesn't start running automatically, hit **Enter**.

The script will take several minutes to run. It may reach a point where it seems nothing is happening, but just wait through the entire install. It typically takes eight minutes or so.

### Install script errors

If you see errors in the output of the script, cancel the run of the script by typing **CTRL+C**.

1. Fix the errors in your install script. 
1. Change the `RESOURCE_GROUP` and `WEB_NAME_PREFIX` to new values to prevent collisions.
1. In the cloud shell, do the following.

   ```bash
   # go back to home directory
   cd ~

   # delete the repository directory that was created
   rm -rf ./Commercial-Marketplace-SaaS-Accelerator/
   ```

1. Run the revised script.

### Successful install

When the script completes successfully, it will print the values you need for the Technical Configuration tab in Partner Center. It will look something like the following. Copy this information to a note or file so you can retrieve it in case you close the browser window.

```text
   Add The following URL in PartnerCenter SaaS Technical Configuration->Landing Page section
   https://PREFIX-portal.azurewebsites.net/
   Add The following URL in PartnerCenter SaaS Technical Configuration->Connection Webhook section
   https://PREFIX-portal.azurewebsites.net/api/AzureWebhook
   Add The following TenantID in PartnerCenter SaaS Technical Configuration Tenant ID
   e6c97eb2-054c-4b5d-9a30-a064766a9e8f
   Add The following ApplicationID in PartnerCenter SaaS Technical Configuration->AAD Application ID section
   bc830358-8c71-4699-b5e6-ea617ac7b5ef
```

## Exercise: Verify web applications

Now you'll verify the two web application are up and running.

### The landing page

1. In the SaaS Accelerator's resource group, find the App service for the landing page and click it. It is the one named **PREFIX-portal**.
1. In the upper right corner is the URL of the web app. Click the URL.
1. You should be taken to a web page and receive no errors.

### The publisher portal

1. In the SaaS Accelerator's resource group, find the App service for the landing page and click it. It is the one named **PREFIX-admin**.
1. In the upper right corner is the URL of the web app. Click the URL.
1. You should be taken to a web page and receive no errors. If you are prompted to log in, do so.

## Exercise: Partner Center Technical Configuration

1. Open Partner Center and browse to the **Technical configuration** page of your offer.
1. Enter the values into the appropriate text fields as per the instructions from the end of the installation script that you copied earlier in this lab.
1. Click **Save Draft**.
1. Click **Review and publish**.
1. Publish your offer.

Publication will take a while. Only after publication completes can you do the next lab.

**Congratulations!** You have finished this lab.

If you are in a live class setting, please raise your hand in Microsoft Teams to indicate you are done with the lab.

> To watch the publication process, refresh the offer's **Overview** page occasionally. Once your offer reaches the **Publisher preview** stage, you are ready for the next lab. Do NOT press the **Go live** button.
