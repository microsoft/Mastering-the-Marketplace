---
# Page settings
layout: default
keywords: Azure Marketplace Virtual Machine
comments: false

# Hero section
title: Lab 2.a - Create a Windows Virtual Machine 
description: This lab will walk you through creating a Windows based Virtual Machine on the Azure Portal.

# Micro navigation
micro_nav: false

hide:
  - navigation

---

👈 [Back to Virtual Machine labs](../../../index.md#labs)

> This lab is part of a series of labs for Mastering the Virtual Machine Offers workshop. You should finish this lab before moving on to the next labs in this course.

## Upload Post Deployment Script

1. Clone the repository to access files in **scripts** folder
1. Navigate to the Homepage of [Azure Portal](https://portal.azure.com/#home) 
1. Use the Search bar to search for **Storage Accounts** and hit enter. Select the **vmworkshopsayouruniquestring** Storage account we created in the previous lab.
1. In the left pane, look for Data Storage and select **Containers**
1. Click on **+ Container** to create a new container
    - Enter **script** as the new container name
    - Select **Blob** for Public access level
    - Click **Create** at the bottom of the page
1. Open the new container, select **Upload** and upload the cloned script named **custom_extension_windows.ps1** 
1. If you open this script in VS Code or Notepad, you will see that it is running commands to install a web server and update the Virtual machine

## Create a Virtual Machine

1. Navigate to the Homepage of [Azure Portal](https://portal.azure.com/#home)
1. Click on the **+ Create a resource** button underneath Azure services
1. Use the Search bar to search for **Virtual Machines** and hit enter. Select the Virtual Machine offered by Microsoft Azure Service and click on **Create**

At this point you will be taken to the Virtual Machine service with several blades for configuration.

### Basics

#### Project Details

1. Select the **Subscription** from the dropdown menu to select which subscription will pay for the VM and other resource usage
1. To create a new Resource Group, click on **Create New** and name your resource group as **vmworkshop-rg-YOUR_UNIQUE_STRING**. Please make sure to follow the same convention for ease of access and understanding. 

    > Note that all the resources we create for the labs will reside within this new resource group

#### Instance Details

1. Name your Virtual Machine **vmworkshop-YOUR_UNIQUE_STRING**
1. Select the Region you are in from the dropdown menu
1. Under Availability options, select **No infrastructure redundancy required**
1. Select **Standard** Security type
1. For Image, click on See all images and select **Windows Server 2019 Datacenter - Gen1**. Configure the generation from the Configure VM Generation link below if necessary.
1. For size, click on See all sizes and select **Standard_B2ms**. This is sufficient to run this lab and will cost around $60/month, but regardless we will stop this virtual machine as soon as we generalize and capture the VM, so usage should be very low.

#### Administrator Account

1. Enter the username of your choice
1. Enter a strong password of your choice 
1. Confirm the strong password

#### Inbound Port Rules

1. Select the **Allowed selected ports** radio button for Public inbound ports
1. For Select Inbound ports Select **HTTP, RDP** as well as **HTTPS**
1. Leave the rest as is and Click **Next : Disks >** 

### Disks

#### Disk Options

1. For OS Disk Type, select **Standard HDD (locally-redundant storage**

Leave the rest of the fields as is on the page and click on **Next : Networking >**

### Networking

#### Network interface

1. For **Virtual network, Subnet, Public IP** keep the default values as is. This will create a new VM, Subnet and Public IP with the default variable names
1. Ensure Select inbound ports has **HTTP, RDP** and **HTTPS** checked

Leave the rest as is and click on **Next : Management >**

### Management

Do not change anything in this section and simply click on **Next : Advanced >**

### Advanced

#### Extensions

1. Click on Select an extension to install
1. From the display card, select **Custom Script Extension** and click on **Next**
1. For Script file, browse for the **vmworkshopsayouruniquestring** storage account, select **script** and look for the **custom_extension_windows.ps1** Block blob and select it. Lastly click **Select** at the bottom of the page. [If you dont see storage account, please make sure it is in the same region as the VM which is being created]
1. Now click **Create** under the Configure Custom Script Extension blade

1. Select **Review + create** button at the bottom of the Advanced blade

### Review + create

1. In this blade, you should ensure that you receive the **Validation Passed** message at the top. If for any reason you receive a **Validation failed** message, you should go back and review the fields in red.
1. Lastly take a look at the configurations you have selected and click **Create**

### Post VM Creation Exercise

1. At this point your deployment will start and show an **in progress** status. 
1. Once the deployment is complete, select **Go to resource**
1. Copy **Public IP Address** from the created VM and paste it into a browser of your choice. This will show a public facing IP on the internet with a custom Welcome screen. 
1. Once you see the custom welcome screen, you know that the post deployment script has done its job. 

### Windows Update Manually

In this module, we will remote into the vm and install an update manually. 
1. On your [Azure Portal](htps://portal.azure.com/#home), navigate to the VM you just created. Click on **Connect** from the tabs on the left under Settings.
1. In the RDP blade, select **Download RDP file**. This will download a copy to your local machine. Double-click the downloaded RDP file.
1. It will open a popup asking if you recognize the publisher. Click on **Connect**.
1. When asked for credentials, make sure to input the username and password you created for the VM.
1. Accept the certificate and click **Yes** when prompted.
1. Voila! You are now inside the VM.
1. Once the system is setup, search for **Check for Updates** in the VM and install all available updates

    > Note: Update all the shown updates before going further. Failure to do so will render your publish process on Partner center with errors

---

**Congratulations!** You have finished this lab.

👈 [Back to Virtual Machine labs](../../../index.md#labs)
