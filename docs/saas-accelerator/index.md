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