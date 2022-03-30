# Lab 2 - The Managed Application Deployment Package

In this lab, you will edit the artifacts that go into a an Azure Managed Application deployment package. You will run your artifacts through a validation process and package them for use in deployment. Finally, you will create a new plan for your existing offer from [Lab 1](../lab-1-partner-center/README.md) and publish your offer.

## Exercise 1 - ARM TTK

This exercise introduces **Azure Resource Manager Template Toolkit** (ARM TTK), a tool that runs in PowerShell and validates the artifacts in your deployment package. The ARM TTK tool runs tests that ensure valid `mainTemplate.json` and `createUiDefinition ` files.

You will clone the ARM TTK repository and bring the code to your local machine where it can be executed using PowerShell. 

If you are not on Windows, you may download PowerShell for your platform.

- [Linux](https://github.com/Azure/arm-ttk/blob/master/arm-ttk/README.md#running-tests-on-linux)
- [macOS](https://github.com/Azure/arm-ttk/blob/master/arm-ttk/README.md#running-tests-on-macos)

1. Clone the [ARM TTK repository](https://github.com/Azure/arm-ttk) from GitHub.
2. Set up ARM TTK to run on your machine by executing the following commands in a PowerShell terminal.

> ```powershell
> cd "<PATH TO ARM TTK REPO>\arm-ttk\arm-ttk"
> 
> Import-Module .\arm-ttk.psd1
> ```

3. From the same directory you may execute the **ARM TTK** tool as shown below. Note the path is looking at the `end` folder, which contains the solution to this lab.

```powershell
$AMAPackage = "<PATH TO AMA-WORKSHOP>\ama-workshop\lab-2-deployment-package\assets\end\"

Test-AzTemplate -TemplatePath $AMAPackage
```

4. See that test pass. The output from ARM TTK should look something like this.

```
Validating end\createUiDefinition.json
  AllFiles
    [+] JSONFiles Should Be Valid (61 ms)
  CreateUIDefinition
    [+] Allowed Values Should Actually Be Allowed (190 ms)

    ...

Validating end\mainTemplate.json
  deploymentTemplate
    [+] adminUsername Should Not Be A Literal (90 ms)
    [+] apiVersions Should Be Recent In Reference Functions (171 ms)

    ...
```

> You will use the **ARM TTK** tool to check the status of your own package files several times during this lab. Because of this, do not close the terminal window between steps.

5. Set up ARM TTK to point at the `begin` directory for validation as shown below.

 ```powershell
 $AMAPackage = "<PATH TO AMA-WORKSHOP>\ama-workshop\lab-2-deployment-package\assets\begin\"
```

6. Run the tests as shown below. They should all pass although the `mainTemplate.json` file in the `begin` directory is basically a skeleton you will build on.

 ```powershell
 Test-AzTemplate -TemplatePath $AMAPackage
```

## Exercise 2 - `mainTemplate.json`

Here you will build out a ARM template that deploys a virtual machine along with some other Azure services.

The basic outline of a `mainTemplate.json` ARM template looks like this. 

```json
{
  "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.0",
  "parameters": {},
  "variables": {},
  "resources": [],
  "outputs": {}
}
```

There are several parameters the ARM template expects. You will fill them in and take note of the different types of parameters.

1. Open the [mainTemplate.json](assets/begin/mainTemplate.json) file in a text editor like VS Code.
2. Add the following JSON inside the **parameters** section of the ARM template.

```json
"adminUsername": {
  "type": "string",
  "metadata": {
    "description": "Username for the Virtual Machine."
  }
},
"adminPassword": {
  "type": "securestring",
  "metadata": {
    "description": "Password for the Virtual Machine."
  }
},
"storageAccountName": {
  "type": "string"
},
"storageAccountType": {
  "type": "string"
},
"windowsOSVersion": {
  "type": "string",
  "defaultValue": "2019-datacenter-gensecond",
  "allowedValues": [
    "2019-datacenter-gensecond",
    "2016-datacenter-gensecond"
  ],
  "metadata": {
    "description": "The Windows version for the VM. This will pick a fully patched image of this given Windows version."
  }
},
"vmSize": {
  "type": "string",
  "defaultValue": "Standard_D2s_V3",
  "metadata": {
    "description": "Size of the virtual machine."
  }
},
"vmName": {
  "type": "string",
  "defaultValue": "amaSimpleVM",
  "metadata": {
    "description": "Name of the virtual machine."
  }
},
"location": {
  "type": "string",
  "defaultValue": "[resourceGroup().location]",
  "metadata": {
    "description": "Location for all resources."
  }
}
```

> Take a moment to review the `type` attribute of each parameter. See that you can pass in multiple data types.

3. Run ARM TTK. The following test fails.

    ```cmd
    Parameters Must Be Referenced
    ```

4. Make the variables section look like the following JSON.

```json
"variables": {
  "itemPrefix": "[concat('ama', uniqueString(resourceGroup().id))]",
  "addressPrefix": "10.0.0.0/16",
  "domainNameLabel": "[concat(variables('itemPrefix'), '-dnl')]",
  "networkSecurityGroupName": "[concat(variables('itemPrefix'), '-nsg')]",
  "nicName": "[concat(variables('itemPrefix'), '-nic')]",
  "publicIPAddressName": "[concat(variables('itemPrefix'), '-ip')]",
  "storageAccountName": "[concat(parameters('storageAccountName'), uniqueString('storage'))]",
  "subnetName": "Subnet",
  "subnetPrefix": "10.0.0.0/24",
  "subnetRef": "[resourceId('Microsoft.Network/virtualNetworks/subnets', variables('virtualNetworkName'), variables('subnetName'))]",
  "virtualNetworkName": "[concat(variables('itemPrefix'), '-vnet')]"
}
```

5. Run ARM TTK.

    > Now there are **parameters** and **variables** that are not being referenced. This means they are not being referenced in the `resources` section which defines the actual resources to be created by the ARM template.
    >
    > Note the `itemPrefix` parameter is not reported as an unreferenced parameter since it being used by several other variables.

6. Add the following resource definitions to the `resources[]` section.
   
```json
{
  "type": "Microsoft.Storage/storageAccounts",
  "apiVersion": "2018-02-01",
  "name": "[variables('storageAccountName')]",
  "location": "[parameters('location')]",
  "sku": {
    "name": "[parameters('storageAccountType')]"
  },
  "kind": "Storage",
  "properties": {}
},
{
  "type": "Microsoft.Network/publicIPAddresses",
  "apiVersion": "2020-06-01",
  "name": "[variables('publicIPAddressName')]",
  "location": "[parameters('location')]",
  "properties": {
    "publicIPAllocationMethod": "Dynamic",
    "dnsSettings": {
      "domainNameLabel": "[variables('domainNameLabel')]"
    }
  }
},
{
  "comments": "Default Network Security Group for template",
  "type": "Microsoft.Network/networkSecurityGroups",
  "apiVersion": "2021-08-01",
  "name": "[variables('networkSecurityGroupName')]",
  "location": "[parameters('location')]",
  "properties": {
    "securityRules": [
      {
        "name": "default-allow-3389",
        "properties": {
          "priority": 1000,
          "access": "Allow",
          "direction": "Inbound",
          "destinationPortRange": "3389",
          "protocol": "Tcp",
          "sourcePortRange": "*",
          "sourceAddressPrefix": "*",
          "destinationAddressPrefix": "*"
        }
      }
    ]
  }
},
{
  "type": "Microsoft.Network/virtualNetworks",
  "apiVersion": "2020-06-01",
  "name": "[variables('virtualNetworkName')]",
  "location": "[parameters('location')]",
  "dependsOn": [
    "[resourceId('Microsoft.Network/networkSecurityGroups', variables('networkSecurityGroupName'))]"
  ],
  "properties": {
    "addressSpace": {
      "addressPrefixes": [ "[variables('addressPrefix')]" ]
    },
    "subnets": [
      {
        "name": "[variables('subnetName')]",
        "properties": {
          "addressPrefix": "[variables('subnetPrefix')]",
          "networkSecurityGroup": {
            "id": "[resourceId('Microsoft.Network/networkSecurityGroups', variables('networkSecurityGroupName'))]"
          }
        }
      }
    ]
  }
},
{
  "type": "Microsoft.Network/networkInterfaces",
  "apiVersion": "2020-06-01",
  "name": "[variables('nicName')]",
  "location": "[parameters('location')]",
  "dependsOn": [
    "[resourceId('Microsoft.Network/publicIPAddresses/', variables('publicIPAddressName'))]",
    "[resourceId('Microsoft.Network/virtualNetworks/', variables('virtualNetworkName'))]"
  ],
  "properties": {
    "ipConfigurations": [
      {
        "name": "ipconfig1",
        "properties": {
          "privateIPAllocationMethod": "Dynamic",
          "publicIPAddress": {
            "id": "[resourceId('Microsoft.Network/publicIPAddresses',variables('publicIPAddressName'))]"
          },
          "subnet": {
            "id": "[variables('subnetRef')]"
          }
        }
      }
    ]
  }
},
{
  "type": "Microsoft.Compute/virtualMachines",
  "apiVersion": "2020-06-01",
  "name": "[parameters('vmName')]",
  "location": "[parameters('location')]",
  "identity": {
    "type": "systemAssigned"
  },
  "dependsOn": [
    "[resourceId('Microsoft.Storage/storageAccounts/', variables('storageAccountName'))]",
    "[resourceId('Microsoft.Network/networkInterfaces/', variables('nicName'))]"
  ],
  "properties": {
    "hardwareProfile": {
      "vmSize": "[parameters('vmSize')]"
    },
    "osProfile": {
      "computerName": "[parameters('vmName')]",
      "adminUsername": "[parameters('adminUsername')]",
      "adminPassword": "[parameters('adminPassword')]"
    },
    "storageProfile": {
      "imageReference": {
        "publisher": "MicrosoftWindowsServer",
        "offer": "WindowsServer",
        "sku": "[parameters('windowsOSVersion')]",
        "version": "latest"
      },
      "osDisk": {
        "createOption": "FromImage"
      },
      "dataDisks": [
        {
          "diskSizeGB": 1023,
          "lun": 0,
          "createOption": "Empty"
        }
      ]
    },
    "networkProfile": {
      "networkInterfaces": [
        {
          "id": "[resourceId('Microsoft.Network/networkInterfaces',variables('nicName'))]"
        }
      ]
    },
    "diagnosticsProfile": {
      "bootDiagnostics": {
        "enabled": true,
        "storageUri": "[reference(resourceId('Microsoft.Storage/storageAccounts/', variables('storageAccountName'))).primaryEndpoints.blob]"
      }
    }
  }
}
```

> Take moment to examine the different resources that will be created by this ARM template.

7. Run ARM TTK. One test should fail.

    > ```terminal
    > apiVersions Should Be Recent
    > ```

8. The resource type of `Microsoft.Storage/storageAccounts` has an old API version. Fix this problem as recommended by ARM TTK.

9. Ensure ARM TTK passes with no errors.

Your ARM template is complete.

## Exercise 4 - `createUiDefinition.json`

This exercise will take you through creating the file that defines the user experience for installing your solution via the `mainTemplate.json` created in Exercise 3.

The role of the `createUiDefinition.json` file is to do the following.
   1. Provide parameters to the `mainTemplate.json` ARM template.
   2. Provide an installation user experience for the customer.

The main components of a `createUiDefinition.json` file looks like this.

```json
{
    "$schema": "https://schema.management.azure.com/schemas/0.1.2-preview/CreateUIDefinition.MultiVm.json#",
    "handler": "Microsoft.Azure.CreateUIDef",
    "version": "0.1.2-preview",
    "parameters": {
        "basics": [],
        "steps": [],
        "outputs": {}
    }
}
```

### Create the file

1. Create the file `createUiDefinition.json` in your `begin` folder.
2. Paste the above JSON into the new file.
3. Run ARM TTK. You get several errors on the `createUiDefinition.json` file because the sections of the file are yet filled in yet. 

### The Create UI Definition Sandbox

The Create UI Definition Sandbox is a tool for testing `createUiDefinition.json` files.

1. Open the [Create UI Definition Sandbox](https://portal.azure.com/?feature.customPortal=false#blade/Microsoft_Azure_CreateUIDef/SandboxBlade) in the Azure portal.
2. Delete the JSON in the JSON area of the sandbox blade.
3. Paste the JSON from your `createUiDefinition.json` file into the sandbox JSON area.
4. Click the **Preview** button at the bottom of the page.
   > The sandbox renders the content from your `createUiDefinition.json`.
   > The Basics section displays the default fields that are rendered when the `basics` section of the JSON is empty.

### The steps[] section

1. Go back to your `createUiDefinition.json` file.
2. Add the following JSON into the `steps[]` array. This will add a new tab, or blade, to the experience the customer will see during installation.

```json
{
  "name": "prefixBlade",
  "bladeTitle": "Item Prefix",
  "label": "Item Prefix",
  "elements": []
}
```
3. Paste the JSON from your file in the [Create UI Definition Sandbox](https://portal.azure.com/?feature.customPortal=false#blade/Microsoft_Azure_CreateUIDef/SandboxBlade). You should see a new **Item Prefix** tab.
4. Click the **Item Prefix** tab.
    > The blade is blank and has no controls on it.
5. On the left side of the sandbox, note there is a list of controls. Copy the TextBox control into your clipboard.
6. In your `createUiDefinition` file, paste the control into the `elements` array of the JSON blade.
7. Check your JSON in the sandbox.
8. Remove the blade definition from the `steps[]` array in the `createUiDefinition.json` file so that the array is empty.
9. Fill in the `steps[]` array with the JSON below.

```json

            {
                "name": "storageConfigBlade",
                "label": "Storage account settings",
                "bladeTitle": "Storage account settings",
                "elements": [
                    {
                        "name": "storageAccount",
                        "type": "Microsoft.Storage.MultiStorageAccountCombo",
                        "label": {
                            "prefix": "Storage account prefix",
                            "type": "Storage account type"
                        },
                        "toolTip": {
                            "prefix": "The prefix of the storage account",
                            "type": "The type of storage account"
                        },
                        "defaultValue": {
                            "type": "Standard_LRS"
                        },
                        "constraints": {
                            "allowedTypes": [
                                "Premium_LRS",
                                "Standard_LRS",
                                "Standard_GRS"
                            ]
                        },
                        "count": 2
                    }
                ]
            },
            {
                "name": "vmBlade",
                "bladeTitle": "Virtual Machine",
                "label": "Virtual Machine",
                "elements": [
                    {
                        "name": "vmName",
                        "type": "Microsoft.Common.TextBox",
                        "label": "Machine name",
                        "placeholder": "Virtual machine name",
                        "defaultValue": "",
                        "toolTip": "Use only allowed characters",
                        "constraints": {
                            "required": true,
                            "regex": "^[a-z0-9A-Z]{5,15}$",
                            "validationMessage": "Only alphanumeric characters are allowed, and the value must be 5-15 characters long."
                        },
                        "visible": true
                    },
                    {
                        "name": "adminUsername",
                        "type": "Microsoft.Compute.UserNameTextBox",
                        "label": "Admin Username",
                        "toolTip": "The username of the admin user for the VM",
                        "constraints": {
                            "required": true,
                            "regex": "^[a-z0-9A-Z]{1,30}$",
                            "validationMessage": "Only alphanumeric characters are allowed, and the value must be 1-30 characters long."
                        },
                        "osPlatform": "Windows",
                        "visible": true
                    },
                    {
                        "name": "adminPassword",
                        "type": "Microsoft.Common.PasswordBox",
                        "label": {
                            "password": "Password",
                            "confirmPassword": "Confirm password"
                        },
                        "toolTip": "Password for the VM",
                        "constraints": {
                            "required": true,
                            "regex": "^[a-zA-Z0-9]{12}$",
                            "validationMessage": "Password must be at least 12 characters long, contain only numbers and letters"
                        },
                        "options": {
                            "hideConfirmation": false
                        },
                        "visible": true
                    },
                    {
                        "name": "operatingSystem",
                        "type": "Microsoft.Common.DropDown",
                        "label": "Windows operating system",
                        "defaultValue": "2022-Datacenter",
                        "toolTip": "Choose an operating system to deploy",
                        "constraints": {
                            "allowedValues": [
                                {
                                    "label": "2019 Datacenter 2nd Gen",
                                    "value": "2019-datacenter-gensecond"
                                },
                                {
                                    "label": "2016 Datacenter 2nd Gen",
                                    "value": "2016-datacenter-gensecond"
                                }
                            ],
                            "required": true
                        },
                        "visible": true
                    },
                    {
                        "name": "vmSize",
                        "type": "Microsoft.Compute.SizeSelector",
                        "label": "Virtual machine size",
                        "toolTip": "Choose the size of virtual machine to create",
                        "recommendedSizes": [
                            "Standard_D2s_v3"
                        ],
                        "options": {
                            "hideDiskTypeFilter": false
                        },
                        "osPlatform": "Windows",
                        "visible": true
                    }
                ]
            },
            {
                "name": "tags",
                "label": "Tags",
                "elements": [
                    {
                        "name": "tagsByResource",
                        "type": "Microsoft.Common.TagsByResource",
                        "toolTip": "Tags for resources being created",
                        "resources": [
                            "Microsoft.Storage/storageAccounts",
                            "Microsoft.Compute/virtualMachines"
                        ]
                    }
                ]
            }
        
```
7. Check your JSON in the sandbox to ensure it is valid.

### The outputs section

Now that you have all of the steps defined in your `createUiDefinition.json` file, you can focus on the `outputs` section, which passes the control values to the ARM template during installation.

1. Fill in the `outputs` section of your `createUiDefinition.json` file with the JSON below.

```json
"adminPassword": "[steps('vmBlade').adminPassword]",
"adminUsername": "[steps('vmBlade').adminUsername]",
"windowsOSVersion": "[steps('vmBlade').operatingSystem]",
"vmSize": "[steps('vmBlade').vmSize]",
"location": "[location()]",
"storageAccountName": "[steps('storageConfigBlade').storageAccount.prefix]",
"storageAccountType": "[steps('storageConfigBlade').storageAccount.type]",
"vmName": "[steps('vmBlade').vmName]"
```

> Note how the output keys match the input parameter names in the `mainTemplate.json` ARM template. 
> Also note how the values reference blade values, except for the `location()` function, which is a required output value.

2. Check your files with **ARM TTK**.
3. Check your JSON in the sandbox.

Your `createUiDefinition.json` is now complete.

## Exercise 5 - Deploying your deployment package files

In this exercise, you will create a second plan in the offer you created in [Lab 1](../lab-1-partner-center/README.md).

1. In the `begin` folder, create a ZIP file with two deployment package files at the root. Name the file **gold-plan-deployment-package.zip**.
2. Go back to [Partner Center](https://partner.microsoft.com/en-us/dashboard/).
3. Navigate to the offer you created in Lab 1.
4. Click **Plan overview** in the left hand menu.
5. Create a new plan named **Gold** in your offer. Use the same techniques you used in Lab 1 to create your **Silver** plan.
   > When you get to the **Pricing and availability** section of your new offer, remember to check the boxes and fill in the units on the metered billing dimensions.

## Exercise 6 - Publish your offer

Now that you have two plans in your offer, it's time to publish your offer.

1. In Partner Center click the **Review and publish** button at the top right of the page, which takes you to the **Review publish changes** page.
2. Once all indicators are green, click the **Publish** button at the bottom of the page. You will be taken to the **Offer overview** page where you can monitor the status of your offer as it progresses to the **Publisher signoff** stage. (This requires refreshing the page periodically). 
   
   > The publishing process can take some time to complete, but should be done in time for the next lab.

  > **DO NOT** go past the **Publisher signoff** stage by clicking the **Go live** button once it appears.

## Conclusion

Great job, you've finished lab 2! 

In this lab you accomplished the following.

1. Used ARM TTK to validate your deployment files.
2. Fleshed out an ARM template in `mainTemplate.json`.
3. Created the user experience for installing the solution via the ARM template using `createUiDefinition,json`.
4. Created a deployment package from the artifacts in this lab.
5. Created a new plan in Partner Center and used your new deployment package in that plan.
6. Published your offer with its new plan.
