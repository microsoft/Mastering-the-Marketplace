---
# Page settings
layout: default
keywords: Azure AppSource Marketplace Container Offer
comments: false

# Hero section
title: Mastering Container Offers
description: This course will take you from working with a local app through publishing a Container Offer to the Microsoft commercial marketplace.

# Micro navigation
micro_nav: false

hide:
- navigation
---

[Home](../index.md)

# Mastering Container Offers

Container offers for Kubernetes applications is a transactable offer type for deploying solution containers into an Azure Kubernetes Service in the customer's subscription. This course will take you from an overview to deep understanding of the offer type. The large majority of the course is demo-first.

[✉️](https://forms.office.com/r/0gCrzhSMkw) [Let us know what you need](https://forms.office.com/r/0gCrzhSMkw) from this content, or tell us how we're doing.

🧪 [Grow your skills with the hands-on labs](#hands-on-labs).

## Table of Contents

<!-- no toc -->
- [Container Offer for Kubernetes Apps Overview](#container-offer-for-kubernetes-apps-overview)
- [Container Offer Billing Overview](#container-offer-billing-overview)
- [Container Offer Technical Overview](#container-offer-technical-overview)
- [Deploying Solution Images an Azure Container Registry](#deploying-solution-images-an-azure-container-registry)
- [Preparing CNAB Bundle Artifacts](#preparing-cnab-bundle-artifacts)
- [Generating the CNAB Bundle](#generating-the-cnab-bundle)
- [Create a Container Offer in Partner Center](#create-a-container-offer-in-partner-center)
- [Create a Container Offer Plan in Partner Center](#create-a-container-offer-plan-in-partner-center)
- [Subscribe to a Kubernetes App in the Commercial Marketplace](#subscribe-to-a-kubernetes-app-in-the-commercial-marketplace)
- [Unsubscribe from a Kubernetes app that You Purchased](#unsubscribe-from-a-kubernetes-app-that-you-purchased)
- [Hands-on labs](#hands-on-labs)

---

## Container Offer for Kubernetes Apps Overview

<a href="" target="_blank">Video</a> | [PDF](./pdfs/01.1-overview.pdf)

This video introduces Container Offers for Kubernetes Applications, a transactable offer type in the Azure Marketplace. After viewing this module you’ll understand the terminology used in this marketplace offer type and gain a deeper understanding of publishing one. Present in this module are the following sections.

- About the offer type
- Benefits of the offer type
- Container offers in the marketplace

## Container Offer Billing Overview

<a href="" target="_blank">Video</a> | [PDF](./pdfs/01.2-billing-overview.pdf)

How to price and bill your solution is such a commonly visited topic that we’re providing a quick module on the subject. In this module you’ll learn about transactable offers, the pricing models for container offers, and the nomenclature of offers and plans.

## Container Offer Technical Overview

<a href="" target="_blank">Video</a> | [PDF](./pdfs/02.1-technical-overview.pdf)

This module provides a comprehensive overview of Container offers for Kubernetes apps. Topics include the following.

- The development lifecycle
- About CNAB bundles
- Packaging the artifacts
- Deploying the final product

## Deploying Solution Images an Azure Container Registry

<a href="" target="_blank">Video</a>

This hands-on demo introduces the application to be throughout the course and shows preparing an Azure Container Registry. Finally, you’ll see how to push your solution’s images to your own ACR. Sections include the following.

- Set up an ACR for use with the marketplace
- Run the demo application
- Push application images to an ACR

## Preparing CNAB Bundle Artifacts

<a href="" target="_blank">Video</a>

In this hands-on module, learn about the artifacts needed to create your final CNAB bundle. This video explores what they are and looks at some details in each. You’ll see the following.

- Solution files
- Helm chart
- K8s deployment files
- Marketplace deployment files
- The CNAB manifest

## Generating the CNAB Bundle

<a href="" target="_blank">Video</a>

This module demonstrates the process of creating a CNAB bundle for publication to the Microsoft commercial marketplace. This video is primarily on the command line and shows using the publicly available CNAB bundling tool available from the Microsoft public Azure Container Registry.

## Create a Container Offer in Partner Center

<a href="" target="_blank">Video</a>

In this all-demo module, you’ll see what is needed to create a Container Offer in Partner Center. The demo walks through all sections of creating an offer except for creating plans. Plan creation is shown in the next video of the course.

## Create a Container Offer Plan in Partner Center

<a href="" target="_blank">Video</a>

This module focuses on creating a plan within an already existing offer. This hands-on demo walks through setting up a new plan in Partner Center including the technical configuration of the plan, in which we map the CNAB bundle to the new plan.

## Subscribe to a Kubernetes App in the Commercial Marketplace

<a href="" target="_blank">Video</a>

In this brief demo, you see how customers purchase a Kubernetes app and deploy it into their K8s cluster. You’ll see the process from marketplace to deployed and running application.

## Unsubscribe from a Kubernetes App that You Purchased

<a href="" target="_blank">Video</a>

In this walkthrough video, you’ll see how to get rid of an application you may have purchased, and stop being billed for that app. We use the command line with theaz CLI and KubeCtl to perform these operations.

## Hands-on labs

The following hands-on labs build upon each other. They take you through the complete process of creating and publishing a Container Offer in the Microsoft commercial marketplace.

### Prerequisites

There are prerequisites to these labs. Several accounts and pieces of software are required to perform the labs. Please visit the link below and complete the prerequisites detailed there before starting Lab 1.

[Technical Prerequisites](./Labs/prerequisites/index.md)

### Getting started

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

### Labs 🧪

1. [Set Up the Container Offer](./Labs/lab1-create-container-offer-setup/index.md)
2. [Prepare Container Deployment](./Labs/lab2-prepare-container-deployment/index.md)
3. [Create the CNAB Bundle Package](Labs/lab3-create-cnab-bundle-package/index.md)
4. [Publishing Container Offer](./Labs/lab4-publishing-container-offer/index.md)
5. [Purchasing Container Offer](Labs/lab5-purchasing-container-offer/index.md)