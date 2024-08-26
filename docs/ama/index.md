---
# Page settings
layout: default
keywords: Azure AppSource Marketplace Virtual Machine
comments: false

# Hero section

description: This course is designed to help you decrease your onboarding when building an Azure Managed Application offers.

hide:
  - toc

theme:
  features:
    - navigation.top

title: Mastering Managed Application Offers

---

Managed Application offers facilitate a broad range of deployment scenarios for your custom software solution. Coupled with compute offers like virtual machines or containers, Managed Apps provide a powerful management model for publishers who want to perform ongoing maintenance of a given solution.

Managed Apps also facilitate the deployment of PaaS services like databases or networking components into the solution.

This course explores Managed Application offers in detail, helping you to create new offers, manage offers after purchase, and bill for services using the Managed Application.

This course is meant to help technologists who are building Managed Application offers for their custom software solutions.

---

<!-- no toc -->
1. [Managed Applications overview](#managed-applications-overview)
1. [Billing and pricing for Azure Applications](#billing-and-pricing-for-azure-applications)
1. [Managed Application deployment options](#managed-application-deployment-options)
1. [Purchasing an Azure Application: The customer experience](#purchasing-an-azure-application-the-customer-experience)
1. [Managing my Managed Applications: The customer experience](#managing-my-managed-applications-the-customer-experience)
1. [Administering customer subscriptions: The publisher experience](#administering-customer-subscriptions-the-publisher-experience)
1. [The deployment package](#the-deployment-package)
1. [Working with createUiDefinition.json](#working-with-createuidefinitionjson)
1. [Working with mainTemplate.json](#working-with-maintemplatejson)
1. [Managed Applications webhook](#managed-applications-webhook)
1. [Metered billing technical details](#metered-billing-technical-details)
1. [Deploying a custom virtual machine offer](#deploying-a-custom-virtual-machine-offer)
1. [Hands-on labs](#hands-on-labs)

---

## Managed Applications overview

<a href="https://partner.microsoft.com/en-us/training/assets/detail/managed-applications-overview-mp4" target="_blank">Video</a> | <a href="./pdfs/02.0-ma-overview.pdf" target="_blank">PDF</a>

This module introduces Azure Applications and Managed Applications at a high level. It also covers the difference between private and public Managed Applications. 

If you are looking to understand the basic value proposition and architecture of Managed Applications this video is for you.

– Overview
– Azure Applications in a nutshell
– Managed Applications overview
– Managed Applications in the Azure Marketplace
- Summary

## Billing and pricing for Azure Applications

<a href="https://partner.microsoft.com/en-us/training/assets/detail/billing-and-pricing-for-azure-applications-mp4" target="_blank">Video</a>

Azure Applications provide for charging customers for your software solution and for any maintenance services you provide. Accordingly, configuring billing and pricing for Azure Applications isn’t always intuitive.

This video walks through the options for charging customers provided by Azure Applications, both Solution Template and Managed Application offers. After viewing this video, you’ll understand how to configure pricing for your solution.

## Managed Application deployment options

<a href="https://partner.microsoft.com/en-us/training/assets/detail/managed-application-deployment-options-mp4" target="_blank">Video</a> | <a href="./pdfs/03.0-ma-deployment-options.pdf" target="_blank">PDF</a>

This module examines the different deployment modes for Managed Applications. Managed Apps may be configured in different ways for both publisher and customer access to the Managed Resource Group. Use this video to learn the implications of this and choose the right deployment mode for your application.

- Publisher management
- Customer access
- Deployment modes

## Purchasing an Azure Application: The customer experience

<a href="https://partner.microsoft.com/en-us/training/assets/detail/purchasing-an-azure-application-the-customer-experience-mp4" target="_blank">Video</a>

In this demo-heavy module customers will learn how to manage their subscriptions to Managed Applications and get an idea of the capabilities a customer has when accessing the Managed Resource Group associated with each Managed Application.

## Managing my Managed Applications: The customer experience

<a href="https://partner.microsoft.com/en-us/training/assets/detail/managing-my-azure-applications-the-customer-experience-mp4" target="_blank">Video</a>

This demo-only video shows customers how to administer their Managed Application purchases. It also examines customer access to the associated Managed Resource Groups.

- The Managed Application dashboard in the Azure portal
- Managed Resource Group access

## Administering customer subscriptions: The publisher experience 

<a href="https://partner.microsoft.com/en-us/training/assets/detail/administering-customer-subscriptions-the-publisher-experience-mp4" target="_blank">Video</a>

This quick demo shows how a publisher can use the Managed Applications center service in the Azure portal to administer the solution inside a customer’s Managed Resource Group.

## The deployment package

<a href="https://partner.microsoft.com/en-us/training/assets/detail/the-deployment-package-mp4" target="_blank">Video</a> | <a href="./pdfs/07.0-ma-deployment-package.pdf" target="_blank">PDF</a>

Get an overview of the deployment package required for all Managed Applications. This module covers the deployment package format and provides a high-level look at the contents of the file. Future modules of this course focus on the individual files found in the deployment package.

## Working with createUiDefinition.json

<a href="https://partner.microsoft.com/en-us/training/assets/detail/working-with-createuidefinition-json-mp4" target="_blank">Video</a> | <a href="./pdfs/08.0-ma-createuidefinition.pdf" target="_blank">PDF</a>

Dive deep into the createUiDefinition.json file and learn how to develop a useful and compelling user experience for customer deployments. This module shows the structure and usage of the createUiDefinition.json file as well as providing some great tips on working with this file.

– CreateUiDefinition overview
– Demo: createUiDefinition.json walkthrough
– Demo: The development sandbox
– Demo: Dynamic elements

## Working with mainTemplate.json

<a href="https://partner.microsoft.com/en-us/training/assets/detail/working-with-maintemplate-json-mp4" target="_blank">Video</a>

This demo-only module explores the ARM template required by Managed Applications in the deployment package. 

- ARM templates in Azure
- ARM template nomenclature
- Testing with ARM-TTK

## Managed Applications webhook

<a href="https://partner.microsoft.com/en-us/training/assets/detail/the-managed-applications-webhook-mp4" target="_blank">Video</a> | <a href="./pdfs/11.0-ma-webhook.pdf" target="_blank">PDF</a>

You may configure an optional webhook for Managed Applications that listens for events from the Azure Marketplace emitted during deployment of the application. This module offers and overview of the webhook as well as a complete demo on how it works.

- Webhook overview
- Webhook demo scenario
- Demo: Partner Center configuration
- Demo: Customer purchase process
- Demo: Inspecting the webhook payload

## Metered billing technical details

<a href="https://partner.microsoft.com/en-us/training/assets/detail/metered-billing-technical-details-mp4" target="_blank">Video</a> | <a href="./pdfs/12.2-ma-metered-billing-technical.pdf" target="_blank">PDF</a>

In this module, you’ll learn about the technical aspects of calling the metered billing API. This includes different architectures for creating your reporting system as well as a demo showing the API being called to invoke usage events.

- Direct reporting
- Centralized reporting
- Working with the metered billing API
- Demo: Working with the metered billing API

## Deploying a custom virtual machine offer

<a href="https://partner.microsoft.com/en-us/training/assets/detail/deploying-a-custom-virtual-machine-offer-mp4" target="_blank">Video</a> | <a href="./code/14.0-ma-deploy-custom-vm.zip">Code</a>

This demo-heavy module takes you through the process of deploying a custom virtual machine with a Managed Application. You’ll see all the steps involved including configuring things in Partner Center and how to author the deployment package files. 

Notice the code used in this module is available for download above.

- Scenario overview
- The custom VM offer in Partner Center – Demo
- The deployment package – Demo
- The deployment process – Demo

---

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.