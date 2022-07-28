---
# Page settings
layout: default
keywords: Azure AppSource Marketplace Virtual Machine
comments: false

# Hero section
title: Mastering Azure Managed Application Offers
description: This course is designed to help you decrease your onboarding when building an Azure Managed Application offer. The content is comprised of recordings of a virtual workshop and are divided into small digestible modules for easy consumption. Also included are several hands-on labs to turn your knowledge into skills.

hide:
  - navigation

---

This course is designed to help you decrease your onboarding when building an Azure Managed Application offer. The content is comprised of recordings of a virtual workshop and are divided into small digestible modules for easy consumption. Also included are several hands-on labs to turn your knowledge into skills.

---

**[Let us know what you need](https://forms.office.com/r/0gCrzhSMkw)** in this content library.

Get your hands dirty with the [hands-on labs](#hands-on-labs). The slides for this course, which are used in the following modules, [are here](./pdfs/ama-workshop-slides.pdf).

---

## Course Introduction

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196307">Video</a>

This module sets the stage for all the others that follow by providing a quick introduction to the course. See what the course will offer in various modules.

## Managed Applications Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196411">Video</a>

Solution Template offers and Azure Managed Application offers are very similar, but there is an important difference. Learn about the two types of managed applications in this module detailing the differences.

## Azure Managed Applications Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196308">Video</a>

Azure Managed Applications are the transactable Managed App offer type. Get a walkthrough of Azure Managed Applications including their general architecture and usage.

## Partner Center with Azure Managed Applications Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196143">Video</a>

Partner Center is the portal publishers use to create, configure, publish, and monitor their offers in the Microsoft Marketplace. This overview takes you through Partner Center for Azure Managed Applications.

## Configuring Partner Center for Azure Managed Applications - Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196410">Video</a>

Understanding Partner Center, the publisher's portal, is key to creating great offers. This demo walks through setting up a Partner Center offer for an Azure Managed Application.

## Azure Managed Application Deployment Package Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196244">Video</a>

The deployment package for Azure Managed Applications is the definition of the application itself. Learn about its components and their role in this quick overview.

## Working with a Azure Managed Application Deployment Package - Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196245">Video</a>

This demo walks through working with Azure Managed Application deployment packages. Learn about the usage and components of the ARM template, `mainTemplate.json`, and how to work with `createUiDefinition.json` to create great install experiences.

## Integrating Virtual Machine Offers into Azure Managed Applications

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196246">Video</a>

Deploying a custom virtual machine is a common need when working with Managed Apps. Get an overview of how to integrate a custom Virtual Machine offer into an Azure Managed Application deployment package.

## Purchasing an Azure Managed Application – Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196249">Video</a>

See the purchasing process of an Azure Managed Application from the customer’s point of view. This module is often helpful for customers looking to familiarize themselves with the purchase process.

## Managing My Purchased Azure Managed Applications – Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196409">Video</a>

Once a customer has purchased one or more Azure Managed Apps, they may need to manage those subscriptions. See the tools and techniques customers have through the Azure portal for managing their Azure Managed Application subscriptions.

## Managing My Customer’s Azure Managed Applications Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196309">Video</a>

Managing Azure Managed Application customer deployments is the responsibility of the publisher. See the tools techniques publishers use to do this easily and effectively through the Azure portal as well as getting a walkthrough of how to use them.

## Managing My Customer’s Azure Managed Applications – Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196243">Video</a>

Once deployed, Azure Managed Applications are managed and maintained by the publisher. This module shows the Azure portal-based tools and practices publishers use to manage their customer’s environments.

## Metered Billing for Azure Managed Applications Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196310">Video</a>

Billing for usage-based consumption is a requirement for many Azure Managed Applications. Get a walkthrough of metered billing and an architectural overview of how it works.

## Metered Billing for Azure Managed Applications – Demo

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196412">Video</a>

See metered billing in action at the REST API level. This module shows metered billing API interaction through Postman.

## Advanced Deployment Scenarios for Azure Managed Applications

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196306">Video</a>

This brief module covers a few advanced scenarios for Azure Managed Application deployments including containers and IoT integration.

---

## Hands-on labs

These hand on labs build on top of one another, so progress through them in order to get a fully functional Azure Managed Application published and working for a test environment.

### Prerequisites

1. Azure subscription that can create resources
1. A Partner Center Account
1. VS Code or other text editor

### Getting started

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

### Labs

1. Lab 1 - [Publishing an Azure Managed Application Offer in Partner Center](./labs/lab-1-partner-center/README.md)
2. Lab 2 - [The Managed Application Deployment Package](./labs/lab-2-deployment-package/README.md)
3. Lab 3 - [Purchasing an Azure Managed Application](./labs/lab-3-purchasing-ama/README.md)
4. Lab 4 - [Administering Your Purchased Managed Applications](./labs/lab-4-administer-my-amas/README.md)
5. Lab 5 - [Administering Your Customer’s Managed Applications](./labs/lab-5-administer-customer-amas/README.md)
