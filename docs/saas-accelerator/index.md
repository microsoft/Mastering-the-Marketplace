---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

# Hero section
description: This series of video modules and hands-on labs is designed to help you understand, install, use, and customize the SaaS Accelerator project. The SaaS Accelerator provides a fully functional community-led SaaS reference implementation for those interested in publishing transactable SaaS offers in Microsoft's marketplace in hours instead of days.

hide:
  - navigation

---

[Home](../index.md)

# Mastering the SaaS Accelerator

This series of video modules and hands-on labs is designed to help you understand, install, use, and customize the [SaaS Accelerator](https://aka.ms/SaaSAccelerator) project. The SaaS Accelerator provides a fully functional community-led SaaS reference implementation for those interested in publishing transactable SaaS offers in Microsoft's marketplace in hours instead of days.

[✉️](https://forms.office.com/r/0gCrzhSMkw) [Let us know what you need](https://forms.office.com/r/0gCrzhSMkw) from this content, or tell us how we're doing.
 
[🧪](#hands-on-labs) [Grow your skills with the hands-on labs](#hands-on-labs).

---

<!-- no toc -->
- [SaaS Accelerator Overview - A Hands-on Tour](#saas-accelerator-overview---a-hands-on-tour)
- [SaaS Accelerator Architecture](#saas-accelerator-architecture)
- [Installing the SaaS Accelerator With the Install Script](#installing-the-saas-accelerator-with-the-install-script)
- [Invoking Metered Billing with the SaaS Accelerator](#invoking-metered-billing-with-the-saas-accelerator)
- [Custom Landing Page Fields with the SaaS Accelerator](#custom-landing-page-fields-with-the-saas-accelerator)
- [Configuring Email in the SaaS Accelerator](#configuring-email-in-the-saas-accelerator)
- [Setting up a development environment for the SaaS Accelerator](#setting-up-a-development-environment-for-the-saas-accelerator)
- [Hands-on labs](#hands-on-labs)

---

## SaaS Accelerator Overview - A Hands-on Tour

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196164">Video</a>

This introduction to the accelerator demonstrates the [SaaS Accelerator's](https://aka.ms/SaaSAccelerator) core capabilities showing why it may be a good choice for your marketplace SaaS offer. In three short demos, this video shows its fundamental capabilities. 

You'll see the landing page, the publisher's subscription management portal, and the customer's subscription management capabilities in action!

## SaaS Accelerator Architecture

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196167">Video</a> | <a href="./pdfs/03-architecture.pdf">PDF</a>

This quick video covers the overall architecture of the SaaS Accelerator. The architecture is straightforward and is explained in plain language appropriate for those with any level of experience with Azure.

## Installing the SaaS Accelerator With the Install Script

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196326">Video</a> | <a href="./pdfs/21-Installing-the-SaaS-Accelerator.pdf">PDF</a>

Installing the [SaaS Accelerator](https://aka.ms/SaaSAccelerator) is simple. This video walks you through from beginning to end the steps necessary to get the SaaS Accelerator up and running. 

This video will get you up and running with the SaaS Accelerator in no time at all! You will need to copy and paste some [PowerShell script from here](https://github.com/Azure/Commercial-Marketplace-SaaS-Accelerator/blob/main/docs/Installation-Instructions.md#installating-the-azure-marketplace-saas-accelerator-using-azure-cloud-shell).

## Invoking Metered Billing with the SaaS Accelerator

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196161">Video</a>

We look at the metered billing capabilities of the SaaS Accelerator for the Azure Marketplace. This video shows how to manually invoke metered billing events from the SaaS Accelerator without needing to integrate your solution with the SaaS Metering APIs.

## Custom Landing Page Fields with the SaaS Accelerator

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196166">Video</a>

In addition to showing your subscribers information about their subscription when they arrive at your landing page, you may also want to capture some information from them. This is possible using custom fields on the landing page and this short video shows you how to use them.

## Configuring Email in the SaaS Accelerator

<a href="https://go.microsoft.com/fwlink/?linkid=2196165" target="_blank">Video</a>

You will likely want to receive email when a subscription changes state. For example, when a someone unsubscribes from your offer. This video shows how to configure the email setting within the SaaS Accelerator and get those notifications coming right to your inbox.

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

---

## Hands-on labs

The following hands-on labs build upon each other. Completing them will get a fully functional SaaS Accelerator offer published and working for a test environment.

### Prerequisites

1. Azure subscription that can create resources
1. A Partner Center Account

### Labs🧪

1. [Preparing Partner Center](./labs/lab1-partner-center/README.md)
2. [Installing the Accelerator](./labs/lab2-install/README.md)
3. [Using the Accelerator](./labs/lab3-tour/README.md)