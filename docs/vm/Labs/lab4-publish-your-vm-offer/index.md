---
# Page settings
layout: default
keywords: Azure Marketplace Virtual Machine
comments: false

# Hero section
title: Lab 4 - Publish your VM Offer
description: This lab will walk you through generalizing and capturing an image.

# Micro navigation
micro_nav: false

hide:
  - navigation
---

👈 [Back to Virtual Machine labs](../../index.md#labs)

> This lab is part of a series of labs for Mastering the Virtual Machine Offers workshop. You should finish this lab before moving on to the next labs in this course. 

## Plan Overview

In this lab, we will complete the rest of the required setup on Partner Center to publish our offer. At this point, the only section that should need completion is Plan Overview. If you have any other sections pending completion, please refer to the previous labs. 

### Permissions for Shared Image Gallery

If your Partner Center account is the owner of the subscription hosting Azure Compute Gallery, nothing further is needed for permissions.

If you are not the owner of the subscription that created the shared image gallery, you will need to assign appropriate permissions in order to share the image on Partner Center. Follow the below steps:
1. Go to the Azure Compute Gallery.
1. Select Access control (IAM) on the left panel.
1. Select Add, then Add role assignment. 
1. The add role assignment window is shown. For Role, select Owner.
1. For Assign access to, select User, group, or service principal.
1. For Select, enter the Azure email of the person who will publish the image. Select Save.

### Create a plan on Partner center

1. Go to your Partner center account inside the Draft VM offer.
1. Select the Plan overview section and click on **New Plan**. Give your plan a unique Plan Id and Plan name and hit Create.
1. In the Plan listing tab, give your plan a name, description and summary.
1. Open the **Pricing and avaialbility** tab next. 
1. Add the required market in the **Edit Market** section.
1. Next select the **Free** plan under Price input options
1. Switch the plan visibility to **Private** and put in your Tenant and Subscription Id and click on **Save Draft**
1. Go to the Technical Configuration tab next and select the **Operating System family** based on your OS type
1. Select the **Vendor** and **OS friendly name**.
1. Select **D2 Standard v3** from **Recommended VM sizes**.
1. Select the appropriate properties depending on if you used extensions/cloud init 
1. Select the image type, Gen1/Gen2 based on the base image you selected in the VM Creation Lab
1. Lastly add the image by putting a version number and selecting the image from the created image gallery. 

### Review and Publish

Finally click on **Review and publish**. Youshould now see green checkmarks against all the sections and you are now ready to publish. Click on **Publish** at the bottom to start the publishing process.

---

**Congratulations!** You have now finished this lab.

👈 [Back to Virtual Machine labs](../../index.md#labs)