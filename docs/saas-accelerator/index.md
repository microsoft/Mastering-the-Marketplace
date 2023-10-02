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

The SaaS Accelerator provides a fully functional community-led SaaS reference implementation for those interested in publishing transactable SaaS offers in Microsoft's marketplace in hours instead of days. This series of video modules and hands-on labs is designed to help you understand, install, use, and customize the [SaaS Accelerator](https://aka.ms/SaaSAccelerator) project.

<!-- no toc -->
1. [SaaS Accelerator Overview - A Hands-on Tour](#saas-accelerator-overview---a-hands-on-tour)
1. [SaaS Accelerator Architecture](#saas-accelerator-architecture)
1. [Installing the SaaS Accelerator with the Azure portal cloud shell](#installing-the-saas-accelerator-with-the-azure-portal-cloud-shell)
1. [Installing the SaaS Accelerator from the Azure Marketplace](#installing-the-saas-accelerator-from-the-azure-marketplace)
1. [Configuring Email in the SaaS Accelerator](#configuring-email-in-the-saas-accelerator)
1. [Invoking Metered Billing with the SaaS Accelerator](#invoking-metered-billing-with-the-saas-accelerator)
1. [Scheduling metered billing events](#scheduling-metered-billing-events)
1. [Custom Landing Page Fields with the SaaS Accelerator](#custom-landing-page-fields-with-the-saas-accelerator)
1. [Setting up a development environment for the SaaS Accelerator](#setting-up-a-development-environment-for-the-saas-accelerator)
1. [Replacing application secrets for the SaaS Accelerator](#replacing-application-secrets-for-the-saas-accelerator)
1. [Hands-on labs](#hands-on-labs)

---

## SaaS Accelerator Overview - A Hands-on Tour

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196164">Video</a>

This introduction to the accelerator demonstrates the [SaaS Accelerator's](https://aka.ms/SaaSAccelerator) core capabilities showing why it may be a good choice for your marketplace SaaS offer. In three short demos, this video shows its fundamental capabilities.

You'll see the landing page, the publisher's subscription management portal, and the customer's subscription management capabilities in action!

- [00:00 – Overview](https://www.youtube.com/watch?v=I9bQlhjNa_8&t=0s)
- [00:57 – Landing Page Demo](https://www.youtube.com/watch?v=I9bQlhjNa_8&t=57s)
- [02:55 – Publisher Subscription Management Portal](https://www.youtube.com/watch?v=I9bQlhjNa_8&t=175s)
- [04:17 – Customer Subscription Management](https://www.youtube.com/watch?v=I9bQlhjNa_8&t=257s)
- [05:15 – Summary](https://www.youtube.com/watch?v=I9bQlhjNa_8&t=315s)

## SaaS Accelerator Architecture

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196167">Video</a> | <a href="./pdfs/03-architecture.pdf">PDF</a>

This quick video covers the overall architecture of the SaaS Accelerator. The architecture is straightforward and is explained in plain language appropriate for those with any level of experience with Azure.

## Installing the SaaS Accelerator with the Azure portal cloud shell

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196326">Video</a>

Installing the SaaS Accelerator is straightforward. This module walks you through from beginning to end the steps necessary to get the SaaS Accelerator up and running. It covers initial installati9on via the Azure cloud shell, configuring Partner Center, and even updating your SaaS Accelerator installation to a new version.

Follow along and you will be up and running with the SaaS Accelerator in no time!

> **Special note:** Find the latest cloud shell install script for the SaaS Accelerator here.
> <a href="https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator/blob/main/docs/Installation-Instructions.md#basic-installation-script" target="_blank">Latest install script</a>

- [00:00 – Overview](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=0s)
- [01:08 - A typical installation](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=68s)
- [06:30 - Configuring Partner Center](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=390s)
- [09:05 - What got deployed](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=545s)
- [10:33 - Updating an existing installation](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=633s)
- [13:48 – Summary](https://www.youtube.com/watch?v=hQJQJu77WhQ&t=828s)



## Installing the SaaS Accelerator from the Azure Marketplace

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2241002">Video</a>

The SaaS Accelerator may be installed directly from the Azure Marketplace. Although the process involves several steps, it may be the right install path for you, and this video walks through all the required steps to get the SaaS Accelerator working from its offer in the Azure Marketplace.

- [00:00 – Overview](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=0s)
- [01:15 – Prerequisites](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=75s)
- [01:33 – Step 1: Preinstallation](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=93s)
- [02:00 – Step 2: Installation](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=120s)
- [02:40 – Step 3: Post-installation](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=160s)
- [03:38 – Updating an existing installation](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=218s)
- [04:01 – Demo all steps](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=241s)
- [13:59 – Summary](https://www.youtube.com/watch?v=B5l5p9LvDSU&t=839s)


## Configuring Email in the SaaS Accelerator

<a href="https://go.microsoft.com/fwlink/?linkid=2196165" target="_blank">Video</a>

You will likely want to receive email when a subscription changes state. For example, when a someone unsubscribes from your offer. This video shows how to configure the email setting within the SaaS Accelerator and get those notifications coming right to your inbox.

- [00:00 – Overview](https://www.youtube.com/watch?v=IniPruOrV8I&t=0s)
- [00:52 – Demo with SendGrid](https://www.youtube.com/watch?v=IniPruOrV8I&t=52s)
- [03:31 – Demo with admin portal](https://www.youtube.com/watch?v=IniPruOrV8I&t=211s)
- [06:47 – Summary](https://www.youtube.com/watch?v=IniPruOrV8I&t=407s)

## Invoking Metered Billing with the SaaS Accelerator

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196161">Video</a>

We look at the metered billing capabilities of the SaaS Accelerator for the Azure Marketplace. This video shows how to manually invoke metered billing events from the SaaS Accelerator without needing to integrate your solution with the SaaS Metering APIs.

- [00:00 – Overview](https://www.youtube.com/watch?v=DXmyagu98nE&t=0s)
- [00:32 – Metered Billing on Partner Center](https://www.youtube.com/watch?v=DXmyagu98nE&t=32s)
- [02:37 – Metered Billing on Publisher Portal](https://www.youtube.com/watch?v=DXmyagu98nE&t=157s)
- [04:45 – Summary](https://www.youtube.com/watch?v=DXmyagu98nE&t=285s)

## Scheduling metered billing events

<a href="https://go.microsoft.com/fwlink/?linkid=2236579" target="_blank">Video</a>

This module introduces the metered billing scheduler feature of the SaaS Accelerator, used to schedule calls to the metered billing service right from within the publisher portal. Learn about the feature, how to enable it, how to schedule a billing event and how to troubleshoot common issues.

- [00:00 – Overview](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=0s)
- [00:39 – About the scheduler](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=39s)
- [02:09 – Enabling the feature in the publisher portal](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=129s)
- [05:42 – Scheduling a billing event](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=342s)
- [08:18 – Monitoring and logging](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=498s)
- [09:26 – Summary](https://www.youtube.com/watch?v=IoXsoVpyhxY&list=PLmsFUfdnGr3wU_FrzwgElLTNSKTZ2CBOj&index=10&t=566s)

## Custom Landing Page Fields with the SaaS Accelerator

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196166">Video</a>

In addition to showing your subscribers information about their subscription when they arrive at your landing page, you may also want to capture some information from them. This is possible using custom fields on the landing page and this short video shows you how to use them.

## Setting up a development environment for the SaaS Accelerator

<a href="https://go.microsoft.com/fwlink/?linkid=2224222" target="_blank">Video</a> | [PDF](./pdfs/08-setting-up-a-dev-env.pdf)

If you want to customize the SaaS Accelerator to suit your environment, it can be a somewhat involved process. This video takes you from installing the accelerator, to debugging locally, through re-deploying it with your own code. The video is rather lengthy, so use the chapter links below to skip to the exact section you want to see.

- [00:00 – Overview](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=0s)
- [01:29 - Deploying to Azure and Partner Center](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=89s)
- [08:04 - Configure Azure resources for local development](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=484s)
- [11:21 - Getting the code from GitHub](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=681s)
- [13:45 - Configuring local project settings](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=825s)
- [18:46 - Running the admin site locally](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=1126s)
- [19:54 - Running the landing page site locally](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=1194s)
- [25:40 - Deploying changes to Azure](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=1540s)
- [30:42 – Summary](https://www.youtube.com/watch?v=H8p9n1bVTjY&t=1842s)

## Replacing application secrets for the SaaS Accelerator

<a href="https://go.microsoft.com/fwlink/?linkid=2227720" target="_blank">Video</a> | [PDF](pdfs/10-renewing-application-secrets.pdf)

In this instructional video, you'll learn how to replace application secrets for the SaaS Accelerator. The video is packed with demos that show you step-by-step how to replace your application secrets before they expire, causing errors on your landing page and admin portal. If you're experiencing these issues, this video will guide you through the process of correcting them, ensuring your SaaS Accelerator is running smoothly.

- [00:00 - Overview](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=0s)
- [01:00 - Impact of an expired application secret](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=60s)
- [02:15 - Steps of replacing secrets in Key Vault](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=135s)
- [02:47 - Demo: replacing secrets in Key Vault](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=167s)
- [07:00 - Steps of replacing secrets in App Service config](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=420s)
- [07:29 - Demo: Replacing secrets in App Service config](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=449s)
- [10:07 - Summary](https://www.youtube.com/watch?v=YZSgR_Qgiew&t=607s)

---

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-tech-enablement-labs), which is home to the Mastering the Marketplace labs.
