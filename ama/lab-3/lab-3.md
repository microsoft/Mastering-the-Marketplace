# Lab 3: Customizing the Managed Application UX
Azure Managed Applications Workshop

## Lab Overview

In this lab you will further customize the functionality of `createUiDefinition.json` and then customize the actual Managed Application instance working with `viewDefinition.json`. Finally, you will deploy this new functionality using the same publication technique you used in Lab 1.

# Exercise 1: Customize the installer

In this exercise you will customize `createUiDefinition.json` with some dynamic behavior.

## Getting started

1. In VS Code, open the file `lab-3 > begin > createUiDefinition.json`
2. Open the [Create UI Definition Sandbox](https://portal.azure.com/?feature.customPortal=false#blade/Microsoft_Azure_CreateUIDef/SandboxBlade)
3. Paste the contents of the file in VS Code into the sandbox window.
4. Click the Preview button on the sandbox. You will see a very uncustomized experience.

## Adding a textbox

In this section you will add a new step to the `createUiDefinition.json` file and validate the input for a textbox.

1. In the code file in VS Code, add the following step

```json
{
    "name": "storagePrefixStep",
    "label": "Storage Account Prefix",
    "bladeTitle": "Storage Account Prefix",
    "subLabel": {
        "preValidation": "Enter a prefix for your storage account prefix",
        "postValidation": "Done"
    },
    "elements": []
}
```

2. Paste the new file contents into the sandbox and preview your work. You will see a new tab named **Storage Account Prefix**.

3. Add the following element to the newly created step.

```json
{
    "name": "storagePrefix",
    "type": "Microsoft.Common.TextBox",
    "label": "Storage Account Prefix",
    "toolTip": "Use only allowed characters",
    "placeholder": "",
    "constraints": {
        "required": true
    },
    "visible": true
}
```

4. Preview your work in the sandbox.

5. Try typing some letters into the Storage Account Prefix textbox. Note you can type as few or as many letters as you like.

    We want to constrain the allowed values in the textbox using regular expressions such that only 4 characters may be entered.

6. Add the following JSON to the `constraints` section.

```json
"validations": [
    {
        "regex": "^[a-zA-Z][a-z0-9A-Z]{3,3}$",
        "message": "Only alphanumeric characters are allowed, and the value must be 4 characters long."
    }
]
```

7. Preview your work in the sandbox. Now you must match the regular expression for your prefix or you receive an error message.

8. Finally we need to allow customers to select the type of storage they want, so add the following element to the step.

```json
{
    "name": "storageType",
    "type": "Microsoft.Common.DropDown",
    "label": "Storage Type",
    "toolTip": "Select the storage type to use",
    "defaultValue": "Standard Locally Redundant",
    "constraints": {
        "allowedValues": [
            {
                "label": "Standard Locally Redundant",
                "value": "Standard_LRS"
            },
            {
                "label": "Premium Locally Redundant",
                "value": "Premium_LRS"
            },
            {
                "label": "Standard Globally Redundant",
                "value": "Standard_GRS"
            }
        ],
        "required": true
    },
    "visible": true
}
```

## Adding an API call

In this section you will add a new step to the `createUiDefinition.json` file and make calls to the Azure API, binding the return body to a dropdown list.

1. In the code file in VS Code, add the following step

```json
{
    "name": "apiBladeStep",
    "label": "API Calls",
    "elements": []
}
```

2. Paste the new file contents into the sandbox and preview your work. You will see a new step, **API Calls**,  added to the install experience.

3. Add  the following element to the step. The below JSON representes an API call that will be made from the createUiDefinition Experience

```json
{
    "name": "apiResourceGroups",
    "type": "Microsoft.Solutions.ArmApiControl",
    "toolTip": "This is an API control.",
    "request": {
        "method": "GET",
        "path": "[concat(subscription().id, '/resourcegroups?api-version=2020-06-01')]"
    }
}
```

4. Add  the following element to the step. The below JSON defines a dropdown that will be bound to the API call.

```json
{
    "name": "ddlResourceGroups",
    "type": "Microsoft.Common.DropDown",
    "label": "Existing Resource Groups",
    "toolTip": "Existing Resource Groups",
    "multiselect": true,
    "constraints": {
        "allowedValues": "[map(steps('apiBladeStep').apiResourceGroups.value, (item) => parse(concat('{\"label\":\"', item.name, '\",\"value\":\"', item.name, '\"}')))]",
        "required": true
    },
    "visible": true
}
```

3. Paste the new file contents into the sandbox and preview your work. Note that selecting the dropbox retrieves all resource groups present in your subscription.

4. Let's add one more API call just to see it working. Add the following elements into the **API Calls** step. This will create one ore dropdown bound to all storage accounts in your subscription.

```json
{
    "name": "apiStorageAccounts",
    "type": "Microsoft.Solutions.ArmApiControl",
    "toolTip": "This is an API that you will never see.",
    "request": {
        "method": "GET",
        "path": "[concat(subscription().id, '/providers/Microsoft.Storage/storageAccounts?api-version=2019-06-01')]"
    }
},
{
    "name": "ddlStorageAccounts",
    "type": "Microsoft.Common.DropDown",
    "label": "Existing Storage Accounts",
    "toolTip": "Existing Storage Accounts",
    "constraints": {
        "allowedValues": "[map(steps('apiBladeStep').apiStorageAccounts.value, (item) => parse(concat('{\"label\":\"', item.name, '\",\"value\":\"', item.name, '\"}')))]",
        "required": true
    },
    "visible": true
}
```
4. Paste the new file contents into the sandbox and preview your work.

# Exercise 2: Customize the Managed Application

In this exercise you will customize the `viewDefinition.json` file in the same directory you've been working in. The file starts off with no custom behavior defined.

1. Add the following view to the `views` array. This customizes the text on the front page of the managed application.

```json
{
    "kind": "Overview",
    "properties": {
        "header": "Welcome to Azure Managed Applications",
        "description": "This managed application is for **exercise purposes**."
    }
}
```

2. Now customize the managed application by adding some custom charts. Add the following view to the file.

```json
{
    "kind": "Metrics",
    "properties": {
        "displayName": "Sample Metrics",
        "version": "1.0.0",
        "charts": []
    }
}
```

3. Add the following chart to the `charts` array.

```json
{
    "displayName": "Availability chart",
    "chartType": "Bar",
    "metrics": [
        {
        "name": "Availability",
        "aggregationType": "avg",
        "resourceType": "Microsoft.Storage/storageAccounts"
        }
    ]
}
```

4. It is possible to have more than one chart in the charts array. Add the following chart to the charts array.

```json
{
    "displayName": "Transactions Chart",
    "chartType": "Area",
    "metrics": [
        {
        "name": "Transactions",
        "aggregationType": "sum",
        "resourceType": "Microsoft.Storage/storageAccounts"
        }
    ]
}
```

# Exercise 3: Deploy the Azure Managed Application with Service Catalog

With all of these changes in place, deploy the new files into a Service catalog managed application 
definition, just as you did in Lab 1.

## Creating the `app.zip` package

1. Create a ZIP file that contains these 3 files at the root of the ZIP.

- createUiDefinition.json
- mainTemplate.json
- viewDefinition.json

2.	Name your ZIP file `app.zip`.

    **Note:** If you are using a Mac, it is important you don’t pick up any hidden files from your file system.

3. Upload `app.zip` to the deployment storage account, overwriting the existing `app.zip` in your storage account.

## Creating the Service Catalog Managed Application Definition

1.	In your resource group, add a **Service Catalog Managed Application Definition**.

2.	On the creation form, use the following values.
    
    | Setting | Value |
    | --- | --- | 
    | Name | ma-03 |
    | Display name | ma-03 |
    | Package file uri | The URI of the blob you just uploaded |
    | Deployment Mode | Complete |
    | Lock level | None |

3. Click the Create button

## Deploy the application 

1. From within your resource group, click the Service catalog managed application definition you just created.
2. Select **Deploy from definition**.
3. Go through the setup screens to see your installation API calls.
4. Deploy the application. 

**It is a known issue that the charts will not show up in your new application for about an hour.**






