---
# Page settings
layout: default
keywords: Azure AppSource Marketplace Container Offer
comments: false

# Hero section
title: Mastering Container offers for Kubernetes apps
description: This course will take you from working with a local app through publishing a Container Offer to the Microsoft commercial marketplace.

# Micro navigation
micro_nav: false

hide:
- toc
---

This course covers transactable container offers designed for deploying solutions into Azure Kubernetes Service within the customer's subscription. With a focus on practical demonstrations, this course provides a comprehensive understanding of the offer type, from overview to in-depth insights.

>❗This course references the ARM template `cluster-deployment.json` in many places. Although using this filename will work technically, the recommended filename is `mainTemplate.json`. 
>
> The videos linked from this page were created before the recommended change in filename.

<!-- no toc -->
1. [Container offer for Kubernetes apps overview](#container-offer-for-kubernetes-apps-overview)
1. [Container offer billing overview](#container-offer-billing-overview)
1. [Container offer technical overview](#container-offer-technical-overview)
1. [Deploying solution images to an Azure Container Registry](#deploying-solution-images-to-an-azure-container-registry)
1. [Scanning container images for vulnerabilities](#scanning-container-images-for-vulnerabilities)
1. [Preparing CNAB bundle artifacts](#preparing-cnab-bundle-artifacts)
1. [Generating the CNAB bundle](#generating-the-cnab-bundle)
1. [Create a container offer in Partner Center](#create-a-container-offer-in-partner-center)
1. [Create a container offer plan in Partner Center](#create-a-container-offer-plan-in-partner-center)
1. [Subscribe to a Kubernetes app in the Commercial Marketplace](#subscribe-to-a-kubernetes-app-in-the-commercial-marketplace)
1. [Unsubscribe from a purchased Kubernetes app](#unsubscribe-from-a-purchased-kubernetes-app)
1. [Securing virtual machines and containers for certification](#securing-virtual-machines-and-containers-for-certification)
1. [Hands-on labs](#hands-on-labs) 🧪


---

## Container offer for Kubernetes apps overview

<a href="https://go.microsoft.com/fwlink/?linkid=2212264" target="_blank">Video</a> | [PDF](./pdfs/01.1-overview.pdf)

This video introduces Container Offers for Kubernetes Applications, a transactable offer type in the Azure Marketplace. After viewing this module you’ll understand the terminology used in this marketplace offer type and gain a deeper understanding of publishing one. Present in this module are the following sections.

- About the offer type
- Benefits of the offer type
- Container offers in the marketplace

## Container offer billing overview

<a href="https://go.microsoft.com/fwlink/?linkid=2212265" target="_blank">Video</a> | [PDF](./pdfs/01.2-billing-overview.pdf)

How to price and bill your solution is such a commonly visited topic that we’re providing a quick module on the subject. In this module you’ll learn about transactable offers, the pricing models for container offers, and the nomenclature of offers and plans.

## Container offer technical overview

<a href="https://go.microsoft.com/fwlink/?linkid=2212638" target="_blank">Video</a> | [PDF](./pdfs/02.1-technical-overview.pdf)

This module provides a comprehensive technical overview of Container offers for Kubernetes apps. Topics include the following.

- The development lifecycle
- About CNAB bundles
- Packaging the artifacts
- Deploying the final product

## Deploying solution images to an Azure Container Registry

<a href="https://go.microsoft.com/fwlink/?linkid=2212158" target="_blank">Video</a>

This hands-on demo introduces the application to be throughout the course and shows preparing an Azure Container Registry. Finally, you’ll see how to push your solution’s images to your own ACR. Sections include the following.

- Set up an ACR for use with the marketplace
- Run the demo application
- Push application images to an ACR

## Scanning container images for vulnerabilities

<a href="https://go.microsoft.com/fwlink/?linkid=2214918" target="_blank">Video</a>

In this comprehensive demo you’ll learn how to identify vulnerabilities in your images that can prevent your Container offer from passing certification. Not only will you see Microsoft Defender for Cloud in action, but you’ll see how to patch a container and prepare its’ image for publication to an ACR so that it no longer contains vulnerabilities.

## Preparing CNAB bundle artifacts

<a href="https://go.microsoft.com/fwlink/?linkid=2212266" target="_blank">Video</a>

In this hands-on module, learn about the artifacts needed to create your final CNAB bundle. This video explores what they are and looks at some details in each. You’ll see the following.

- Solution files
- Helm chart
- K8s deployment files
- Marketplace deployment files
- The CNAB manifest

## Generating the CNAB bundle

<a href="https://go.microsoft.com/fwlink/?linkid=2212639" target="_blank">Video</a>

This module demonstrates the process of creating a CNAB bundle for publication to the Microsoft commercial marketplace. This video is primarily on the command line and shows using the publicly available CNAB bundling tool available from the Microsoft public Azure Container Registry.

## Create a container offer in Partner Center

<a href="https://go.microsoft.com/fwlink/?linkid=2212160" target="_blank">Video</a>

In this all-demo module, you’ll see what is needed to create a Container Offer in Partner Center. The demo walks through all sections of creating an offer except for creating plans. Plan creation is shown in the next video of the course.

## Create a container offer plan in Partner Center

<a href="https://go.microsoft.com/fwlink/?linkid=2212159" target="_blank">Video</a>

This module focuses on creating a plan within an already existing offer. This hands-on demo walks through setting up a new plan in Partner Center including the technical configuration of the plan, in which we map the CNAB bundle to the new plan.

## Subscribe to a Kubernetes app in the Commercial Marketplace

<a href="https://go.microsoft.com/fwlink/?linkid=2212161" target="_blank">Video</a>

In this brief demo, you see how customers purchase a Kubernetes app and deploy it into their K8s cluster. You’ll see the process from marketplace to deployed and running application.

## Unsubscribe from a purchased Kubernetes app

<a href="https://go.microsoft.com/fwlink/?linkid=2212267" target="_blank">Video</a>

In this walkthrough video, you’ll see how to get rid of an application you may have purchased, and stop being billed for that app. We use the command line with the az CLI and KubeCtl to perform these operations.

## Securing virtual machines and containers for certification

<a href="https://go.microsoft.com/fwlink/?linkid=2220888" target="_blank">Video</a> | [PDF](./pdfs/0.0-securing-vm-and-container-images-overview.pdf)

The last thing you want is to create and publish an offer only to have it fail Microsoft’s certification process. This module provides important tips and effective practices for securing virtual machines and containers before publication to the Azure Marketplace, so your offer makes it through certification the first time.

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.
