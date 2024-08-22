---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

# Hero section
title: Mastering SaaS offers for developers
description: These topics focus on helping you understand general topics regarding SaaS offers for the Microsoft commercial marketplace.

hide:
  - toc
---

Learn how to create custom SaaS offers for the marketplace. This course offers all you need to know to integrate successfully with the marketplace for SaaS applications.

In this learning path, you'll work your way through all of the technical aspects of creating SaaS offers. When you're done, you'll have the skills to:

- Understand the elements of a complete SaaS offer.
- Create a custom landing page for your customers.
- Create and secure a webhook that listens for messages from the marketplace.
- Interact with the marketplace SaaS fulfillment API.

If you're a developer who is tasked with integrating your company's SaaS solution into the marketplace, this learning path is for you.

---

<!-- no toc -->
1. [SaaS Offer Overview](#saas-offer-overview)
1. [Publishing a SaaS Offer](#publishing-a-saas-offer)
1. [SaaS Offer Technical Overview](#saas-offer-technical-overview)
1. [Microsoft Entra ID configuration for your SaaS offer](#microsoft-entra-id-configuration-for-your-saas-offer)
1. [Using the SaaS Offer Fulfillment API](#using-the-saas-offer-fulfillment-api)
1. [The SaaS Client Library for .NET](#the-saas-client-library-for-net)
1. [Building a Simple Landing Page in .NET](#building-a-simple-landing-page-in-net)
1. [Building a Simple SaaS Publisher Portal in .NET](#building-a-simple-saas-publisher-portal-in-net)
1. [SaaS Webhook Overview](#saas-webhook-overview)
1. [Implementing a Simple SaaS Webhook in .NET](#implementing-a-simple-saas-webhook-in-net)
1. [Securing your SaaS offer webhook](#securing-your-saas-offer-webhook)
1. [SaaS Metered Billing Overview](#saas-metered-billing-overview)
1. [The SaaS Metered Billing API with REST](#the-saas-metered-billing-api-with-rest)
1. [Hands-on labs](#hands-on-labs)

---

## SaaS Offer Overview

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-offer-overview-mp4">Video</a> | [PDF](./pdfs/01-SaaS-Offer-Overview.pdf)

This video offers a technical overview of #Microsoft Azure Marketplace SaaS offers. It shows what you need to get started creating a SaaS offer of your own.

- Microsoft commercial marketplace
- SaaS offer creation process
- Pricing models

## Publishing a SaaS Offer

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/publishing-a-saas-offer-mp4">Video</a> | [PDF](./pdfs/03.1-Publishing-a-SaaS-Offer.pdf)

This detailed video presents the concepts of publishing a SaaS offer and then walks through the steps of doing so in Partner Center. 

This module goes all the way from creating an offer, to adding and plan, and finally publishing the offer live. It also speaks to the need of developers to have a sandbox environment in which they can test and development the landing page and webhook.

- The publication flow
- Publishing a SaaS offer

## SaaS Offer Technical Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196315">Video</a> | [PDF](./pdfs/04-SaaS-Offer-Technical-Overview.pdf)

Watch a deep technical overview of how SaaS offers work in the Microsoft Azure Marketplace. 

Learn how the API flows and interactions should work and how to build your landing page. Topics include the following.

- Flow overview
- The Landing Page​
- SaaS Offer purchase flow in depth​
- SaaS Offer Fulfillment API​
- Metered billing overview​
- SaaS Offer webhook​

## Microsoft Entra ID configuration for your SaaS offer

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/microsoft-entra-id-configuration-for-your-saas-offer-mp4">Video</a> | [PDF](./pdfs/05-Azure-AD-Application-Registrations%20-%20v3.pdf)

In this module we look at a generic topic, application registrations for Entra ID. We’ll need this knowledge in upcoming modules. Application registrations give us a mechanism to authenticate to Entra ID, which is a requirement of the SaaS offer’s landing page, if you recall.

This video should help you get a jump start on configuring application registrations for the apps we’ll be building in the next few modules.

- Application Registrations in Microsoft Entra ID
- Single- vs. multi-tenant
- User consent and scopes
- A sample solution architecture

## Using the SaaS Offer Fulfillment API

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/using-the-saas-offer-fulfillment-api-mp4">Video</a>

See the SaaS Fulfillment API in action as we send it through its paces using Postman. 

You’ll learn how to authenticate with Azure Active Directory, resolve and activate subscriptions just like your Landing Page does, and see many other features of the API.

- About the API
- Preparing to use the API
- Demo: Using the API with Postman

## The SaaS Client Library for .NET

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-client-library-for-net-mp4">Video</a> | [PDF](./pdfs/07-The-SaaS-Client-Library-for-.NET.pdf)

This module introduces the SaaS Client Library for .NET developer who want to work with the SaaS APIs at a level of abstraction above the REST level. 

The client library is a fully functional .NET package that you can install and use in your applications, and you’ll see how to do just that.

- Introducing the client library
- A simple application
- Tour the library

## Building a Simple Landing Page in .NET

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/building-a-simple-landing-page-in-net-mp4">Video</a> | [PDF](./pdfs/08-simple-landing-page-dotnet.pdf)

In this module we examine the elements of building a simple landing page and looking at how it works.  

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the SaaS Client Library for .NET to build out our landing page functionality.

- The purpose of the landing page
- A humble landing page in action
- The code
- Available data to display

## Building a Simple SaaS Publisher Portal in .NET

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/building-a-simple-saas-publisher-portal-in-net-mp4">Video</a> | [PDF](./pdfs/09-simple-publisher-portal-dotnet.pdf)

This video shows a very simple example of a publisher’s portal used to manage SaaS subscriptions. The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the SaaS Client Library for .NET to build out our portal functionality.

- Why have a publisher portal?
- A simple publisher portal
- The code

## SaaS Webhook Overview

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-webhook-overview-mp4">Video</a> | [PDF](./pdfs/10.1-simple-webhook-overview.pdf)

This technical overview of the SaaS webhook explains the following concepts of the SaaS offer webhook.

-	Why to have this specialized HTTPS endpoint
-	POST events one may receive on the webhook
-	Flow models of how to handle requests
-	Potential fully implemented webhook architectures

And more! Consider watching this video before moving on to the code-based modules for implementing and securing a SaaS offer webhook.

## Implementing a Simple SaaS Webhook in .NET

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/implementing-a-simple-saas-webhook-in-net-mp4">Video</a>

This code-heavy module focuses on the fundamentals of implementing a SaaS offer webhook as an Azure function using .NET. Concepts are presented in such a way as to be architecture and technology stack agnostic.

- Azure portal
- Azure function
- Log stream
- Client view
- Viewing the payload

## Securing your SaaS offer webhook

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/securing-your-saas-offer-webhook-mp4">Video</a> | [PDF](./pdfs/10.3-simple-webhook-dotnet-securing-v2.pdf) | [Code](./code/10.3-simple-webhook-dotnet-securing-v2.zip)

This security-focused module introduces several techniques for securing a SaaS offer webhook and then dives into implementations of the techniques presented. The two techniques covered are using an Azure Function as a webhook and using a Logic app. 

Although the Azure Function example is implemented in .NET, it is done so in a way that illustrates core concepts for any development stack.

- Basic webhook flow
- Implementing webhook security
- Demo: Inspecting the marketplace JWT
- Demo: Securing a webhook implemented in .NET
- Demo: Securing a webhook implemented with a Logic app
- A security anti-pattern

## SaaS Metered Billing Overview

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-metered-billing-overview-mp4">Video</a> | [PDF](./pdfs/11.1-saas-metered-billing-overview.pdf)

This module presents the fundamentals of billing through the marketplace based on usage, or metered billing. 

It covers several areas of metered billing including the following.

- Demo
- API communications

## The SaaS Metered Billing API with REST

<a target="_blank" href="https://partner.microsoft.com/en-us/training/assets/detail/saas-metered-billing-api-with-rest-mp4">Video</a>

We exercise the SaaS Billing REST API using Postman to illustrate how the API works. 

You’ll learn how the inputs to each API event and how to use the results, and finally how to invoke usage events in the metering API itself. This module is primarily demo.

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.
