---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

# Hero section

title: Mastering the SaaS Accelerator

description: This series of video modules and hands-on labs is designed to help you understand, install, use, and customize the SaaS Accelerator project. The SaaS Accelerator provides a fully functional community-led SaaS reference implementation for those interested in publishing transactable SaaS offers in Microsoft's marketplace in hours instead of days.

hide:
  - toc

---

The SaaS Accelerator is offered under the MIT License as open source software and is **not supported by Microsoft**. 

**If you need help** with the accelerator or would like to report defects or feature requests use the Issues feature on [the GitHub repository](https://aka.ms/SaaSAccelerator).

This learning path provides in-depth learning for creating software as a service (SaaS) offers on the Azure Marketplace using the [SaaS Accelerator project](https://aka.ms/SaaSAccelerator).

Comprehensive training videos cover each topic in detail, providing step-by-step guidance on the accelerator. You'll learn about how to install and use the tool to meet marketplace SaaS offer requirements and manage your customer's subscriptions.

You'll also learn how to use this powerful tool to streamline development and customize your SaaS offers to meet the unique needs of your customers.

---

<!-- no toc -->
1. [SaaS Accelerator introduction](#saas-accelerator-introduction)
1. [SaaS Accelerator hands-on tour](#saas-accelerator-hands-on-tour)
1. [SaaS Accelerator architecture](#saas-accelerator-architecture)
1. [Installing the SaaS Accelerator with the Azure portal cloud shell](#installing-the-saas-accelerator-with-the-azure-portal-cloud-shell)
1. [Installing the SaaS Accelerator from the Azure Marketplace](#installing-the-saas-accelerator-from-the-azure-marketplace)
1. [Configuring email in the SaaS Accelerator](#configuring-email-in-the-saas-accelerator)
1. [Invoking metered billing with the SaaS Accelerator](#invoking-metered-billing-with-the-saas-accelerator)
1. [Scheduling metered billing events](#scheduling-metered-billing-events)
1. [Custom landing page fields with the SaaS Accelerator](#custom-landing-page-fields-with-the-saas-accelerator)
1. [Setting up a development environment for the SaaS Accelerator](#setting-up-a-development-environment-for-the-saas-accelerator)
1. [Replacing application secrets for the SaaS Accelerator](#replacing-application-secrets-for-the-saas-accelerator)
1. [Using the external notification feature](#using-the-external-notification-feature)
1. [Hands-on labs](#hands-on-labs)

---

## SaaS Accelerator introduction

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-accelerator-introduction-mp4">Video</a>

This short video introduces the <a href="https://aka.ms/SaaSAccelerator" target="blank">SaaS Accelerator</a>, a tool for integrating your SaaS offer with the Microsoft commercial marketplace. 

This powerful solution meets all the technical requirements for SaaS offers in the marketplace and more! Learn about the SaaS Accelerator and how you can get started in under 15 minutes without writing code.

## SaaS Accelerator hands-on tour

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-accelerator-hands-on-tour-mp4">Video</a>

This introduction to the accelerator demonstrates the SaaS Accelerator's core capabilities showing why it may be a good choice for your marketplace SaaS offer. 

In three short demos, this video shows its fundamental capabilities. You'll see the landing page, the publisher's subscription management portal, and the customer's subscription management capabilities in action!

- Landing Page Demo
- Publisher Subscription Management Portal
- Customer Subscription Management

## SaaS Accelerator architecture

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-accelerator-architecture-mp4">Video</a> | <a href="./pdfs/03-architecture.pdf">PDF</a>

This quick video covers the overall architecture of the SaaS Accelerator. 

The architecture is straightforward and is explained in plain language appropriate for those with any level of experience with Azure.

## Installing the SaaS Accelerator with the Azure portal cloud shell

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/installing-the-saas-accelerator-with-the-azure-portal-cloud-shell-mp4">Video</a>

Installing the SaaS Accelerator is straightforward. This module walks you through from beginning to end the steps necessary to get the SaaS Accelerator up and running. It covers initial installati9on via the Azure cloud shell, configuring Partner Center, and even updating your SaaS Accelerator installation to a new version.

Follow along and you will be up and running with the SaaS Accelerator in no time!

> **Special note:** Find the latest cloud shell install script for the SaaS Accelerator here.
> <a href="https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator/blob/main/docs/Installation-Instructions.md#basic-installation-script" target="_blank">Latest install script</a>

- A typical installation
- Configuring Partner Center
- What got deployed
- Updating an existing installation

## Installing the SaaS Accelerator from the Azure Marketplace

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/installing-the-saas-accelerator-from-the-azure-marketplace-mp4">Video</a>

The SaaS Accelerator may be installed directly from the Azure Marketplace. 

Although the process involves several steps, it may be the right install path for you, and this video walks through all the required steps to get the SaaS Accelerator working from its offer in the Azure Marketplace.

- Prerequisites
- Step 1: Preinstallation
- Step 2: Installation
- Step 3: Post-installation
- Updating an existing installation
- Demo all steps


## Configuring email in the SaaS Accelerator

<a href="https://partner.microsoft.com/en-us/training/assets/detail/configuring-email-in-the-saas-accelerator-mp4" target="_blank">Video</a>

You will likely want to receive email when a subscription changes state. For example, when a someone unsubscribes from your offer. 

This video shows how to configure the email setting within the SaaS Accelerator and get those notifications coming right to your inbox.

- Demo with SendGrid
- Demo with admin portal

## Invoking metered billing with the SaaS Accelerator

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/invoking-metered-billing-with-the-saas-accelerator-mp4">Video</a>

We look at the metered billing capabilities of the SaaS Accelerator for the Azure Marketplace. 

This video shows how to manually invoke metered billing events from the SaaS Accelerator without needing to integrate your solution with the SaaS Metering APIs.

- Metered Billing on Partner Center
- Metered Billing on Publisher Portal

## Scheduling metered billing events

<a href="https://partner.microsoft.com/en-us/training/assets/detail/scheduling-metered-billing-events-mp4" target="_blank">Video</a>

This module introduces the metered billing scheduler feature of the SaaS Accelerator, used to schedule calls to the metered billing service right from within the publisher portal. Learn about the feature, how to enable it, how to schedule a billing event and how to troubleshoot common issues.

This video applies to **version 7.5.0 and above** of the SaaS Accelerator. If you are running an earlier version, please see the video on installing the accelerator for instructions on how to upgrade your installation.

- About the scheduler 
- Enabling the feature in the publisher portal 
- Scheduling a billing event 
- Monitoring and logging 

## Custom landing page fields with the SaaS Accelerator

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/custom-landing-page-fields-with-the-saas-accelerator-mp4">Video</a>

In addition to showing your subscribers information about their subscription when they arrive at your landing page, you may also want to capture some information from them. This is possible using custom fields on the landing page and this short video shows you how to use them.

## Setting up a development environment for the SaaS Accelerator

<a href="https://partner.microsoft.com/en-us/training/assets/detail/setting-up-a-development-environment-for-the-saas-accelerator-mp4" target="_blank">Video</a> | [PDF](./pdfs/08-setting-up-a-dev-env.pdf)

If you want to customize the SaaS Accelerator to suit your environment, it can be a somewhat involved process. 

This video takes you from installing the accelerator, to debugging locally, through re-deploying it with your own code. The video is rather lengthy, so use the chapter links below to skip to the exact section you want to see.

- Deploying to Azure and Partner Center
- Configure Azure resources for local development
- Getting the code from GitHub
- Configuring local project settings
- Running the admin site locally
- Running the landing page site locally
- Deploying changes to Azure

## Replacing application secrets for the SaaS Accelerator

<a href="https://partner.microsoft.com/en-us/training/assets/detail/replacing-application-secrets-for-the-saas-accelerator-mp4" target="_blank">Video</a> | [PDF](pdfs/10-renewing-application-secrets.pdf)

Learn how to replace application secrets for the SaaS Accelerator. 

The video is packed with demos that show you step-by-step how to replace your application secrets before they expire, causing errors on your landing page and admin portal. If you're experiencing these issues, this video will guide you through the process of correcting them, ensuring your SaaS Accelerator is running smoothly.

- Impact of an expired application secret
- Steps of replacing secrets in Key Vault
- Demo: replacing secrets in Key Vault
- Steps of replacing secrets in App Service config
- Demo: Replacing secrets in App Service config

## Using the external notification feature

<a href="https://partner.microsoft.com/en-us/training/assets/detail/using-the-external-notification-feature-mp4" target="_blank">Video</a> | [PDF](./pdfs/12-setup-external-notification.pdf)

The external notification feature feature enables publishers to set up an external notification URL to receive event notifications for specific actions performed by customers. Publishers can configure the URL to which notifications will be sent.

This SaaS Accelerator feature enables publishers to integrate automated workflows between the SaaS Accelerator and their internal systems, allowing for scenarios such as automated creation of customer accounts.

- The external notification feature
- Feature demo

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.
