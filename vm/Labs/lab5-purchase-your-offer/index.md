---
# Page settings
layout: default
keywords: Azure Marketplace Virtual Machine
comments: false

# Hero section
title: Lab 5 - Purchase your Offer
description: This lab will walk you through setting up a Virtual Machine Offer in Partner Center. You will need to ensure that you have created an account in Partner Center and have enrolled into the commercial marketplace program in order to be able to create Offers in the Marketplace. 

# Micro navigation
micro_nav: false
---

> Note: This lab is part of a series of labs for Mastering the Virtual Machine Offers Workshop. You should finish this lab before moving on to the next sections. 

<!-- no toc -->
- [Prerequisites before starting this lab](#prerequisites-before-starting-this-lab)
- [Purchase your Offer](#purchase-your-offer)

## Prerequisites before starting this lab

1. Access to the Azure Portal on the same tenant as is on Partner Center 
1. An active Azure Subscription to pay for resource creation

<br />

## Purchase your Offer

1. Navigate to the offer link shown on Partner Center in the **Offer Overview** page
1. Select the plan you want to purchase from the drop down list and click **Create**
1. Under the Basics tab, configure the Subscription, Resource Group, Virtual Machine name and size based on your requirements (you may leave it default)
1. Switch over to Disks tab and select **Standard HDD** for OS Disk Type. Leave the rest default and click on **Review + create** at the bottom
1. ONce validation has passed, reverify the configuration details and click **Create**. This will start the deployment of your VM based on the plan selected.
1. Once deployment has succeeded, navigate to the resource group that hosts the new vm and copt the Public IP of the Virtual Machine.
1. Open a new tab and paste the copied Public IP. You will now see the deployed server page with the customized message you added in the Post Deployment script during VM creation.

Congratulations! You have now successfully completed this lab as well as purchased the offer the you created. You can now explore and create new images based on production requirements

If you are in a live class setting, please raise your hand (even if virtually) to indicate you are done with the lab.