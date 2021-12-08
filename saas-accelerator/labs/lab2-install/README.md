# Lab 2: Installing the SaaS Accelerator

This lab takes you through a very quick installation process for the SaaS Accelerator using the Azure portal Cloud Shell.

## Exercise: Create an install document

Open your favorite text editor and paste the following PowersShell script into a text file.

```powershell
git clone https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator.git -b main --depth 1; `
 cd ./Commercial-Marketplace-SaaS-Accelerator/deployment/Templates; `
 Connect-AzureAD -Confirm; .\Deploy.ps1 `
 -Location "East US" `
 -PathToARMTemplate "./deploy.json" `
 -PublisherAdminUsers "ADMIN_USER_EMAIL" `
 -ResourceGroupForDeployment "RESOURCE_GROUP" `
 -SQLAdminLogin "SQL_ADMIN_USER_NAME" `
 -SQLAdminLoginPassword "SQL_PASSWORD" `
 -SQLServerName "SQL_SERVER_NAME" `
 -WebAppNamePrefix "WEB_NAME_PREFIX"
 ```

### Defined values

In your text editor, replace each of the ALL_CAPS values. They are described below.

| Parameter Value | Description and notes |
|---|---|
| **ADMIN_USER_EMAIL** | The email of the admin for the SaaS solution that will be deployed. This should be an email tied to an Azure subscription. |
| **RESOURCE_GROUP** | The name of the resource group you want to deploy the SaaS solution into. For the purposes of this lab, consider using `saas-accelerator-lab`. |
| **SQL_ADMIN_USER_NAME** | The admin username for the SQL Server that will be installed. Do NOT use name "admin" as it is not allowed and the deployment script will fail. |
| **SQL_PASSWORD** | The password for the SQL Server instance that will be installed. Make this password secure and at **least 22 characters long** so the deployment script doesn't fail. Do not use hyphens. |
| **SQL_SERVER_NAME** | The name of the SQL Server instance that will be deployed. The name can only contain lowercase letters. |
| **WEB_NAME_PREFIX** | A string that will be prefixed to the name of all resources that are created in your deployment resource group. This can be as short as three letters. Use lowercase alphanumeric characters only. |

### Optional parameters

The following values are optional and typically used for a more controlled deployment. We will not be using these parameters in this lab, but you can experiment with them on your own.

```powershell
-TenantID "xxxx-xxx-xxx-xxx-xxxx" `
-AzureSubscriptionID "xxx-xx-xx-xx-xxxx" `
-ADApplicationID "xxxx-xxx-xxx-xxx-xxxx" `
-ADApplicationSecret "xxxx-xxx-xxx-xxx-xxxx" `
-ADMTApplicationID "xxxx-xxx-xxx-xxx-xxxx" `
-LogoURLpng "https://company_com/company_logo.png" `
-LogoURLico "https://company_com/company_logo.ico"
```

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

Once the script completes, you may close the cloud shell by clicking the cloud shell button you used to open it.

If you see errors in the output of the script, cancel the run of the script by typing **CTRL+C**. Fix the errors and run the script again using a different name for the resources in the parameters to avoid collisions of resources during install.

When the script completes successfully, it will print the values you need for the Technical Configuration tab in Partner Center. It will look something like this.

```powershell
__ Add The following URL in PartnerCenter SaaS Technical Configuration->Landing Page section
   https://XXXXXX-portal.azurewebsites.net/
__ Add The following URL in PartnerCenter SaaS Technical Configuration->Connection Webhook section
   https://XXXXXX-portal.azurewebsites.net/api/AzureWebhook
__ Add The following TenantID in PartnerCenter SaaS Technical Configuration Tenant ID
   e6c97eb2-054c-4b5d-9a30-a064766a9e83
__ Add The following ApplicationID in PartnerCenter SaaS Technical Configuration->AAD Application ID section
   bc830358-8c71-4699-b5e6-ea617ac7b5ee
```

## Exercise: Partner Center Technical Configuration

1. Open Partner Center and browse to the **Technical configuration** page of your offer.
1. Enter the values into the appropriate text fields as per the instructions from the end of the script as shown above.
1. Click **Save Draft**.
1. Click **Review and publish**.
1. You should now be able to publish your offer. Do so.

Publication will take a while. Only after publication completes can you do the next lab.

To watch the publication process, refresh the offer's **Overview** page occasionally. Once your offer reaches the **Publisher preview** stage, you are ready for the next lab.

Do NOT press the **Go live** button.

**Congratulation!** You have finished this lab.

If you are in a live class setting, please raise your hand in Microsoft Teams to indicate you are done with the lab.
