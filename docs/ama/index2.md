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

This course details the Managed Application offer-building and onboarding process. It consists of on-demand video modules, slides, and practical hands-on labs to apply your newly acquired knowledge.

---

<!-- no toc -->
1. [Managed Applications overview](#managed-applications-overview)
1. [Managed Application deployment options](#managed-application-deployment-options)
1. [Purchasing an Azure Application](#purchasing-an-azure-application)
1. [Managing my Managed Applications: The customer experience](#managing-my-managed-applications-the-customer-experience)
1. [Administering customer subscriptions: The publisher experience](#administering-customer-subscriptions-the-publisher-experience)
1. [The deployment package](#the-deployment-package)
1. [Working with createUiDefinition.json](#working-with-createuidefinitionjson)
1. [Working with mainTemplate.json](#working-with-maintemplatejson)
1. [Managed Applications webhook](#managed-applications-webhook)
1. [Metered billing overview](#metered-billing-overview)
1. [Hands-on labs](#hands-on-labs)
1. [Prerequisites](#prerequisites)
1. [Getting started](#getting-started)
1. [Labs 🧪](#labs-)

---

## Managed Applications overview

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This module introduces Azure Applications and Managed Applications at a high level. It also covers the difference between private and public Managed Applications. If you are looking to understand the basic value proposition and architecture of Managed Applications this video is for you.

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">00:48 – Azure Applications in a nutshell</a>
- <a href="" target="_blank">02:47 – Managed Applications overview</a>
- <a href="" target="_blank">09:07 – Managed Applications in the Azure Marketplace</a>
- <a href="" target="_blank">12:54 - Summary</a>

## Managed Application deployment options

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This module examines the different deployment modes for Managed Applications. Managed Apps may be configured in different ways for both publisher and customer access to the Managed Resource Group. Use this video to learn the implications of this and choose the right deployment mode for your application.

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">00:51 – Publisher management</a>
- <a href="" target="_blank">03:47 – Customer access</a>
- <a href="" target="_blank">05:51 – Deployment modes</a>
- <a href="" target="_blank">08:56 – Summary</a>

## Purchasing an Azure Application

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

In this demo-heavy module customers will learn how to manage their subscriptions to Managed Applications and get an idea of the capabilities a customer has when accessing the Managed Resource Group associated with each Managed Application.

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">00:24 – The customer purchase experience</a>
- <a href="" target="_blank">05:13 – Summary</a>

## Managing my Managed Applications: The customer experience

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This demo-only video shows customers how to administer their Managed Application purchases. It also examines customer access to the associated Managed Resource Groups.

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">00:56 – The Managed Application dashboard in the Azure portal</a>
- <a href="" target="_blank">04:38 – Managed Resource Group access</a>
- <a href="" target="_blank">06:27 – Summary</a>

## Administering customer subscriptions: The publisher experience 

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This quick demo shows how a publisher can use the Managed Applications center service in the Azure portal to administer the solution inside a customer’s Managed Resource Group.

## The deployment package

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

Get an overview of the deployment package required for all Managed Applications. This module covers the deployment package format and provides a high-level look at the contents of the file. Future modules of this course focus on the individual files found in the deployment package.

## Working with createUiDefinition.json

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

Dive deep into the createUiDefinition.json file and learn how to develop a useful and compelling user experience for customer deployments. This module shows the structure and usage of the createUiDefinition.json file as well as providing some great tips on working with this file.

- <a href="" target="_blank">00:00 - Overview</a>
- <a href="" target="_blank">00:51 – CreateUiDefinition overview</a>
- <a href="" target="_blank">06:22 – Demo: createUiDefinition.json walkthrough</a>
- <a href="" target="_blank">10:20 – Demo: The development sandbox</a>
- <a href="" target="_blank">14:07 – Demo: Dynamic elements</a>
- <a href="" target="_blank">18:12 – Summary</a>

## Working with mainTemplate.json

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This demo-only module explores the ARM template required by Managed Applications in the deployment package. 

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">01:01 – ARM templates in Azure</a>
- <a href="" target="_blank">04:14 – ARM template nomenclature</a>
- <a href="" target="_blank">06:32 – Testing with ARM-TTK</a>
- <a href="" target="_blank">11:43 – Summary</a>

## Managed Applications webhook

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

You may configure an optional webhook for Managed Applications that listens for events from the Azure Marketplace emitted during deployment of the application. This module offers and overview of the webhook as well as a complete demo on how it works.

- <a href="" target="_blank">00:00 - Overview</a>
- <a href="" target="_blank">00:46 - Webhook overview</a>
- <a href="" target="_blank">07:10 - Webhook demo scenario</a>
- <a href="" target="_blank">08:21 - Demo: Partner Center configuration</a>
- <a href="" target="_blank">09:15 - Demo: Customer purchase process</a>
- <a href="" target="_blank">10:56 - Demo: Inspecting the webhook payload</a>
- <a href="" target="_blank">12:10 - Summary</a>

## Metered billing overview

<a href="" target="_blank">Video</a> | <a href="" target="_blank">PDF</a>

This module introduces the metered billing capabilities of Managed Applications. It covers what metered billing is and how it works at a high level, along with how to configure them in Partner Center. Additionally, this module includes some scenarios describing how to use the capability creatively.

- <a href="" target="_blank">00:00 – Overview</a>
- <a href="" target="_blank">00:46 – How metered billing works</a>
- <a href="" target="_blank">06:25 – Metered billing scenarios</a>
- <a href="" target="_blank">10:30 – Summary</a>

---

## Hands-on labs

These hand on labs build on top of one another, so progress through them in order to get a fully functional Azure Managed Application published and working for a test environment.

## Prerequisites

1. Azure subscription that can create resources
1. A Partner Center Account
1. VS Code or other text editor

## Getting started

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

## Labs 🧪

1. Lab 1 - [Publishing an Azure Managed Application Offer in Partner Center](./labs/lab-1-partner-center/README.md)
2. Lab 2 - [The Managed Application Deployment Package](./labs/lab-2-deployment-package/README.md)
3. Lab 3 - [Purchasing an Azure Managed Application](./labs/lab-3-purchasing-ama/README.md)
4. Lab 4 - [Administering Your Purchased Managed Applications](./labs/lab-4-administer-my-amas/README.md)
5. Lab 5 - [Administering Your Customer’s Managed Applications](./labs/lab-5-administer-customer-amas/README.md)
