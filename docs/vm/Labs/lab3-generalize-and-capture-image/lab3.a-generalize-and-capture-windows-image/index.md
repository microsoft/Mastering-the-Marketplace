---
# Page settings
layout: default
keywords: Azure Marketplace Virtual Machine
comments: false

# Hero section
title: Lab 3.a - Generalize and capture a Windows Image
description: This lab will walk you through steps to generalize and capture an image from the VM you created in the previous lab.

# Micro navigation
micro_nav: false
---

> Note: This lab is part of a series of labs for Mastering the Virtual Machine Offers Workshop. You should finish this lab as well as prior ones before moving on to the next sections.

<!-- no toc -->
- [Generalize and Capture](#generalize-and-capture)
  - [Remote into the Virtual Machine](#remote-into-the-virtual-machine)
  - [Generalize the Virtual Machine](#generalize-the-virtual-machine)
- [Capture the Image](#capture-the-image)
  - [Create an Image](#create-an-image)
- [Post Image Creation Exercise](#post-image-creation-exercise)

## Generalize and Capture

In this module, we will remote into the vm and generalize the Virtual machine

### Remote into the Virtual Machine

1. On your [Azure Portal](htps://portal.azure.com/#home), navigate to the VM you just created. Click on **Connect** from the tabs on the left under Settings.
1. In the RDP blade, select **Download RDP file**. This will download a copy to your local machine. Double-click the downloaded RDP file.
1. It will open a popup asking if you recognize the publisher. Click on **Connect**.
1. When asked for credentials, make sure to input the username and password you created for the VM.
1. Accept the certificate and click **Yes** when prompted.
1. Voila! You are now inside the VM.

> At this point we want to ensure that the VM doesn't have any pending updates. Search for **Check for Updates** and install any updates if there are any pending.

### Generalize the Virtual Machine

1. Open File Explorer inside the VM and navigate to C:\Windows\System32\Sysprep
1. Run the **sysprep** application
1. Check the **Generalize** checkbox under System cleanup actions
1. From the Shutdown options dropdown, select **Shutdown** and click **OK**

    At this point, your VM will process these commands and in a few minutes will close the application on its own. Please note that the VM should NOT be restarted once it is generalized.

## Capture the Image

In this module, we will capture an image from the Generalized VM and store it in a Compute Gallery. We will also define Image definitions within the Compute Gallery for organization.

1. Navigate to the VM on [Azure Portal](https://portal.azure.com) You will see that the VM has been stopped under VM Status
1. Click on **Capture** from the options available on top

### Create an Image

1. Select a subscription from the dropdown menu
1. For Resource Group, select the same resource group we created earlier **vmworkshop-rg-YOUR_UNIQUE_STRING**.
1. Under Instance details, select the **Yes, share it to a gallery as a VM image version** radio button
1. Under Gallery Details, select **Create new** and give it a name
1. For Operating system state, select the **Generalized** radio button
1. Click the **Create new** for **Target VM image definition** and give your definition a name and click **OK**
1. Give your image a version name of **0.0.1** 
1. Lastly click **Review + Create** at the bottom. Once validation has passed, click **Create**.

<br>

## Post Image Creation Exercise

In this exercise we will verify that the image is created and ready to be used.
1. In your [Azure Portal](https://portal.azure.com), search for **Compute Gallery** using the search bar and select your new Compute Gallery
1. Click on the definition you created
1. You should now see the version number of the image created as well as verify the Provisioning State is **Succeeded** and Replication Status is **Completed**.


<br>

**Congratulations!** You have now finished this lab.

If you are in a live class setting, please raise your hand (even if virtually) to indicate you are done with the lab.