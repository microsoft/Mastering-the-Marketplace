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

This course details the Managed Application offer-building and onboarding process. It consists of on-demand video modules, slides, and practical [hands-on labs](#hands-on-labs) to apply your newly acquired knowledge.

<!-- no toc -->
1. [Managed Applications overview](#managed-applications-overview)
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

- [Hands-on labs](#hands-on-labs)

---

## Managed Applications overview

<a href="https://aka.ms/AAmighb" target="_blank">Video</a> | <a href="./pdfs/02.0-ma-overview.pdf" target="_blank">PDF</a>

This module introduces Azure Applications and Managed Applications at a high level. It also covers the difference between private and public Managed Applications. If you are looking to understand the basic value proposition and architecture of Managed Applications this video is for you.

- <a href="https://www.youtube.com/watch?v=jIIDRnj7XsY&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=jIIDRnj7XsY&t=48s" target="_blank">00:48 – Azure Applications in a nutshell</a>
- <a href="https://www.youtube.com/watch?v=jIIDRnj7XsY&t=167s" target="_blank">02:47 – Managed Applications overview</a>
- <a href="https://www.youtube.com/watch?v=jIIDRnj7XsY&t=547s" target="_blank">09:07 – Managed Applications in the Azure Marketplace</a>
- <a href="https://www.youtube.com/watch?v=jIIDRnj7XsY&t=774s" target="_blank">12:54 - Summary</a>

## Managed Application deployment options

<a href="https://aka.ms/AAmi8te" target="_blank">Video</a> | <a href="./pdfs/03.0-ma-deployment-options.pdf" target="_blank">PDF</a>

This module examines the different deployment modes for Managed Applications. Managed Apps may be configured in different ways for both publisher and customer access to the Managed Resource Group. Use this video to learn the implications of this and choose the right deployment mode for your application.

- <a href="https://www.youtube.com/watch?v=oURBQITPzsU&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=oURBQITPzsU&t=51s" target="_blank">00:51 – Publisher management</a>
- <a href="https://www.youtube.com/watch?v=oURBQITPzsU&t=227s" target="_blank">03:47 – Customer access</a>
- <a href="https://www.youtube.com/watch?v=oURBQITPzsU&t=351s" target="_blank">05:51 – Deployment modes</a>
- <a href="https://www.youtube.com/watch?v=oURBQITPzsU&t=536s" target="_blank">08:56 – Summary</a>

## Purchasing an Azure Application: The customer experience

<a href="https://aka.ms/AAmi12a" target="_blank">Video</a>

In this demo-heavy module customers will learn how to manage their subscriptions to Managed Applications and get an idea of the capabilities a customer has when accessing the Managed Resource Group associated with each Managed Application.

## Managing my Managed Applications: The customer experience

<a href="https://aka.ms/AAmi12d" target="_blank">Video</a>

This demo-only video shows customers how to administer their Managed Application purchases. It also examines customer access to the associated Managed Resource Groups.

- <a href="https://www.youtube.com/watch?v=CD2K2gNCfno&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=CD2K2gNCfno&t=56s" target="_blank">00:56 – The Managed Application dashboard in the Azure portal</a>
- <a href="https://www.youtube.com/watch?v=CD2K2gNCfno&t=278s" target="_blank">04:38 – Managed Resource Group access</a>
- <a href="https://www.youtube.com/watch?v=CD2K2gNCfno&t=387s" target="_blank">06:27 – Summary</a>

## Administering customer subscriptions: The publisher experience 

<a href="https://aka.ms/AAmi8tk" target="_blank">Video</a>

This quick demo shows how a publisher can use the Managed Applications center service in the Azure portal to administer the solution inside a customer’s Managed Resource Group.

## The deployment package

<a href="https://aka.ms/AAmi8tm" target="_blank">Video</a> | <a href="./pdfs/07.0-ma-deployment-package.pdf" target="_blank">PDF</a>

Get an overview of the deployment package required for all Managed Applications. This module covers the deployment package format and provides a high-level look at the contents of the file. Future modules of this course focus on the individual files found in the deployment package.

## Working with createUiDefinition.json

<a href="https://aka.ms/AAmi8tr" target="_blank">Video</a> | <a href="./pdfs/08.0-ma-createuidefinition.pdf" target="_blank">PDF</a>

Dive deep into the createUiDefinition.json file and learn how to develop a useful and compelling user experience for customer deployments. This module shows the structure and usage of the createUiDefinition.json file as well as providing some great tips on working with this file.

- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=0s" target="_blank">00:00 - Overview</a>
- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=51s" target="_blank">00:51 – CreateUiDefinition overview</a>
- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=382s" target="_blank">06:22 – Demo: createUiDefinition.json walkthrough</a>
- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=620s" target="_blank">10:20 – Demo: The development sandbox</a>
- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=847s" target="_blank">14:07 – Demo: Dynamic elements</a>
- <a href="https://www.youtube.com/watch?v=y00DmZLy374&t=1092s" target="_blank">18:12 – Summary</a>

## Working with mainTemplate.json

<a href="https://aka.ms/AAmi12k" target="_blank">Video</a>

This demo-only module explores the ARM template required by Managed Applications in the deployment package. 

- <a href="https://www.youtube.com/watch?v=0n34R31oxjU&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=0n34R31oxjU&t=61s" target="_blank">01:01 – ARM templates in Azure</a>
- <a href="https://www.youtube.com/watch?v=0n34R31oxjU&t=254s" target="_blank">04:14 – ARM template nomenclature</a>
- <a href="https://www.youtube.com/watch?v=0n34R31oxjU&t=392s" target="_blank">06:32 – Testing with ARM-TTK</a>
- <a href="https://www.youtube.com/watch?v=0n34R31oxjU&t=703s" target="_blank">11:43 – Summary</a>

## Managed Applications webhook

<a href="https://aka.ms/AAmi12o" target="_blank">Video</a> | <a href="./pdfs/11.0-ma-webhook.pdf" target="_blank">PDF</a>

You may configure an optional webhook for Managed Applications that listens for events from the Azure Marketplace emitted during deployment of the application. This module offers and overview of the webhook as well as a complete demo on how it works.

- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=0s" target="_blank">00:00 - Overview</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=46s" target="_blank">00:46 - Webhook overview</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=430s" target="_blank">07:10 - Webhook demo scenario</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=501s" target="_blank">08:21 - Demo: Partner Center configuration</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=555s" target="_blank">09:15 - Demo: Customer purchase process</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=656s" target="_blank">10:56 - Demo: Inspecting the webhook payload</a>
- <a href="https://www.youtube.com/watch?v=TdiruxQMNpk&t=730s" target="_blank">12:10 - Summary</a>

## Metered billing technical details

<a href="https://aka.ms/AAmn5s6" target="_blank">Video</a> | <a href="./pdfs/12.2-ma-metered-billing-technical.pdf" target="_blank">PDF</a>

In this module, you’ll learn about the technical aspects of calling the metered billing API. This includes different architectures for creating your reporting system as well as a demo showing the API being called to invoke usage events.

- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=60s" target="_blank">01:00 – Direct reporting</a>
- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=119s" target="_blank">01:59 – Centralized reporting</a>
- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=232s" target="_blank">03:52 – Working with the metered billing API</a>
- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=372s" target="_blank">06:12 – Demo: Working with the metered billing API</a>
- <a href="https://www.youtube.com/watch?v=4uFS5v6eLM0&t=709s" target="_blank">11:49 – Summary</a>

## Deploying a custom virtual machine offer

<a href="https://aka.ms/AAmzczc" target="_blank">Video</a> | <a href="./code/14.0-ma-deploy-custom-vm.zip">Code</a>

This demo-heavy module takes you through the process of deploying a custom virtual machine with a Managed Application. You’ll see all the steps involved including configuring things in Partner Center and how to author the deployment package files. Notice the code used in this module is available for download above.

- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=0s" target="_blank">00:00 – Overview</a>
- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=48s" target="_blank">00:48 – Scenario overview</a>
- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=229s" target="_blank">03:49 – The custom VM offer in Partner Center – Demo</a>
- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=428s" target="_blank">07:08 – The deployment package – Demo</a>
- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=731s" target="_blank">12:11 – The deployment process – Demo</a>
- <a href="https://www.youtube.com/watch?v=-uuulKPRFpo&t=906s" target="_blank">15:06 – Summary</a>

---

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.