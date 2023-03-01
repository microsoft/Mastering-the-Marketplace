---
# Page settings
layout: default
keywords: Azure AppSource Marketplace Container Offer
comments: false

# Hero section
title: Mastering container offers for Kubernetes apps
description: This course will take you from working with a local app through publishing a Container Offer to the Microsoft commercial marketplace.

# Micro navigation
micro_nav: false

hide:
- navigation
---

[Home](../index.md)

# Mastering Container offers for Kubernetes apps

Container offers for Kubernetes applications is a transactable offer type for deploying solution containers into an Azure Kubernetes Service in the customer's subscription. This course will take you from an overview to deep understanding of the offer type. The large majority of the course is demo-first.

<!-- no toc -->
- [Container offer for Kubernetes apps overview](#container-offer-for-kubernetes-apps-overview)
- [Container offer billing overview](#container-offer-billing-overview)
- [Container offer technical overview](#container-offer-technical-overview)
- [Deploying solution images to an Azure Container Registry](#deploying-solution-images-to-an-azure-container-registry)
- [Scanning container images for vulnerabilities](#scanning-container-images-for-vulnerabilities)
- [Preparing CNAB bundle artifacts](#preparing-cnab-bundle-artifacts)
- [Generating the CNAB bundle](#generating-the-cnab-bundle)
- [Create a container offer in Partner Center](#create-a-container-offer-in-partner-center)
- [Create a container offer plan in Partner Center](#create-a-container-offer-plan-in-partner-center)
- [Subscribe to a Kubernetes app in the Commercial Marketplace](#subscribe-to-a-kubernetes-app-in-the-commercial-marketplace)
- [Unsubscribe from a purchased Kubernetes app](#unsubscribe-from-a-purchased-kubernetes-app)
- [Securing virtual machines and containers for certification](#securing-virtual-machines-and-containers-for-certification)
- [🧪](#hands-on-labs) [Hands-on labs](#hands-on-labs)

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

This module provides a comprehensive overview of Container offers for Kubernetes apps. Topics include the following.

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

The following hands-on labs build upon each other. They take you through the complete process of creating and publishing a Container offer in the Microsoft commercial marketplace.

### Prerequisites

> ⚠️IMPORTANT
>
> To complete the labs that use partner Center, you must sign up for the Container offers public preview [here](https://forms.office.com/pages/responsepage.aspx?id=v4j5cvGGr0GRqy180BHbR0isU_qQJglCq3xE2-4gcIRUMFRIQk05Rk5WQlRPR05BVlhRQzNaMk9YOC4u)

There are prerequisites to these labs. Several accounts and pieces of software are required to perform the labs. Please visit the link below and complete the prerequisites detailed there before starting Lab 1.

[Technical Prerequisites](./Labs/prerequisites/index.md)

### Getting started

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

### Labs 🧪

1. [Prepare Container Deployment](./Labs/lab1-prepare-container-deployment/index.md)
2. [Create a CNAB Bundle Package](Labs/lab2-create-cnab-bundle-package/index.md)
3. [Publishing a Container offer](./Labs/lab3-publishing-container-offer/index.md)
4. [Purchasing a Container offer](Labs/lab4-purchasing-container-offer/index.md)