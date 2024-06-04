---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

# Hero section
title: Mastering SaaS offers
description: These topics focus on helping you understand general topics regarding SaaS offers for the Microsoft commercial marketplace.

hide:
  - toc
---

SaaS offers are a popular deployment architecture for deploying offers onto the Azure marketplace. The below course takes you through SaaS offers from start to finish.

<!-- no toc -->
1. [SaaS Offer Overview](#saas-offer-overview)
1. [SaaS Offer Technical Overview](#saas-offer-technical-overview)
1. [Purchasing a Private SaaS Plan](#purchasing-a-private-saas-plan)
1. [Purchasing a SaaS offer from the Azure Marketplace](#purchasing-a-saas-offer-from-the-azure-marketplace)
1. [Purchasing a SaaS offer from AppSource](#purchasing-a-saas-offer-from-appsource)
1. [Publishing a SaaS Offer](#publishing-a-saas-offer)
1. [Publishing a Private SaaS Plan](#publishing-a-private-saas-plan)
1. [Using the SaaS Offer Fulfillment API](#using-the-saas-offer-fulfillment-api)
1. [The SaaS Client Library for .NET](#the-saas-client-library-for-net)
1. [Building a Simple Landing Page in .NET](#building-a-simple-landing-page-in-net)
1. [Building a Simple SaaS Publisher Portal in .NET](#building-a-simple-saas-publisher-portal-in-net)
1. [SaaS Webhook Overview](#saas-webhook-overview)
1. [Implementing a Simple SaaS Webhook in .NET](#implementing-a-simple-saas-webhook-in-net)
1. [Securing your SaaS offer webhook](securing-your-saas-offer-webhook)
1. [SaaS Metered Billing Overview](#saas-metered-billing-overview)
1. [The SaaS Metered Billing API with REST](#the-saas-metered-billing-api-with-rest)
1. [Hands-on labs](#hands-on-labs)

---

## SaaS Offer Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196417">Video</a> | [PDF](./pdfs/01-SaaS-Offer-Overview.pdf)

This video offers a technical overview of #Microsoft Azure Marketplace SaaS offers. It shows what you need to get started creating a SaaS offer of your own.

- 00:00 – [Overview](https://www.youtube.com/watch?v=9PCTioPbI8M&t=0s)
- 00:57 - [Microsoft commercial marketplace](https://www.youtube.com/watch?v=9PCTioPbI8M&t=57s)
- 05:01 - [SaaS offer creation process](https://www.youtube.com/watch?v=9PCTioPbI8M&t=301s)
- 07:53 - [Pricing models](https://www.youtube.com/watch?v=9PCTioPbI8M&t=473s)
- 13:31 - [Summary](https://www.youtube.com/watch?v=9PCTioPbI8M&t=811s)

## SaaS Offer Technical Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196315">Video</a> | [PDF](./pdfs/04-SaaS-Offer-Technical-Overview.pdf)

Watch a deep technical overview of how SaaS offers work in the Microsoft Azure Marketplace. Learn how the API flows and interactions should work and how to build your landing page. Topics include the following.

- [00:00 - Overview](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=0s)
- [00:45 - Flow overview](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=45s)
- [02:15 - The Landing Page​](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=135s)
- [03:38 - SaaS Offer Purchase Flow in Depth​](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=218s)
- [07:53 - SaaS Offer Fulfillment API​](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=473s)
- [09:20 - Metered Billing Overview​](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=560s)
- [11:33 - SaaS Offer Webhook​](https://www.youtube.com/watch?v=0c-rzJkTV7w&t=693s)

## Purchasing a Private SaaS Plan

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196255">Video</a> | [PDF](./pdfs/02.2-Purchasing-a-Private-SaaS-Plan.pdf)

This video shows how to subscribe to private SaaS plans in the #Microsoft Azure Marketplace. Topics include the following.

- 00:00 – [Overview](https://www.youtube.com/watch?v=44CCTjiwcfA&t=0s)
- 00:52 - [Private plans](https://www.youtube.com/watch?v=44CCTjiwcfA&t=52s)
- 03:03 - [Tenant Id](https://www.youtube.com/watch?v=44CCTjiwcfA&t=183s)
- 03:46 - [Purchasing a SaaS plan](https://www.youtube.com/watch?v=44CCTjiwcfA&t=226s)
- 06:45 – [Summary](https://www.youtube.com/watch?v=44CCTjiwcfA&t=405s)

## Purchasing a SaaS offer from the Azure Marketplace

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2218020">Video</a>

This video demonstrates the customer purchasing process when subscribing to a SaaS offer from within the Azure Marketplace.

- 00:00 - [Overview](https://www.youtube.com/watch?v=31PR7tTLrlQ&t=0s)
- 00:50 - [Subscribing from the Azure marketplace](https://www.youtube.com/watch?v=31PR7tTLrlQ&t=50s)
- 06:04 - [Subscribing from the Azure portal](https://www.youtube.com/watch?v=31PR7tTLrlQ&t=364s)
- 07:06 – [Summary](https://www.youtube.com/watch?v=31PR7tTLrlQ&t=426s)

## Purchasing a SaaS offer from AppSource

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2217862">Video</a>

This video demonstrates the customer purchasing process when subscribing to a SaaS offer from within the AppSource storefront.

## Publishing a SaaS Offer

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196318">Video</a> | [PDF](./pdfs/03.1-Publishing-a-SaaS-Offer.pdf)

This detailed video presents the concepts of publishing a SaaS offer and then walks through the steps of doing so in Partner Center. This module goes all the way from creating an offer, to adding and plan, and finally publishing the offer live. It also speaks to the need of developers to have a sandbox environment in which they can test and development the landing page and webhook.

- 00:00 - [Overview](https://www.youtube.com/watch?v=AnZDa0Z1z8I&t=0s)
- 00:36 - [The publication flow](https://www.youtube.com/watch?v=AnZDa0Z1z8I&t=36s)
- 04:30 - [Publishing a SaaS offer](https://www.youtube.com/watch?v=AnZDa0Z1z8I&t=270s)
- 19:52 – [Summary](https://www.youtube.com/watch?v=AnZDa0Z1z8I&t=1192s)

## Publishing a Private SaaS Plan

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196256">Video</a> | [PDF](./pdfs/03.2-Publishing-Private-SaaS-Plan.pdf)

This brief video builds upon what you learned in, “Publishing a SaaS Offer.” It presents the concepts of using private plans and then shows how to do so inside Partner Center.

- 00:00 – [Overview](https://www.youtube.com/watch?v=67E7LPL_aic&t=0s)
- 00:35 - [About private plans](https://www.youtube.com/watch?v=67E7LPL_aic&t=35s)
- 03:02 - [Creating a private SaaS plan](https://www.youtube.com/watch?v=67E7LPL_aic&t=182s)
- 07:11 - [Summary](https://www.youtube.com/watch?v=67E7LPL_aic&t=431s)

## Using the SaaS Offer Fulfillment API

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196320">Video</a>

See the SaaS Fulfillment API in action as we send it through its paces using Postman. 

You’ll learn how to authenticate with Azure Active Directory, resolve and activate subscriptions just like your Landing Page does, and see many other features of the API.

- [00:00 – Overview](https://www.youtube.com/watch?v=V_G4pOy0Sdo&t=0s)
- [00:32 - About the API](https://www.youtube.com/watch?v=V_G4pOy0Sdo&t=32s)
- [01:08 - Preparing to use the API](https://www.youtube.com/watch?v=V_G4pOy0Sdo&t=68s)
- [03:37 - Demo: Using the API with Postman](https://www.youtube.com/watch?v=V_G4pOy0Sdo&t=217s)
- [13:41 - Summary](https://www.youtube.com/watch?v=V_G4pOy0Sdo&t=821s)


## The SaaS Client Library for .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196324">Video</a> | [PDF](./pdfs/07-The-SaaS-Client-Library-for-.NET.pdf)

This module introduces the SaaS Client Library for .NET developer who want to work with the SaaS APIs at a level of abstraction above the REST level. The client library is a fully functional .NET package that you can install and use in your applications, and you’ll see how to do just that.

- 00:00 – [Overview](https://www.youtube.com/watch?v=uihNXaDBXVQ&t=0s)
- 00:37 - [Introducing the client library](https://www.youtube.com/watch?v=uihNXaDBXVQ&t=37s)
- 03:05 - [A simple application](https://www.youtube.com/watch?v=uihNXaDBXVQ&t=185s)
- 05:25 - [Tour the library](https://www.youtube.com/watch?v=uihNXaDBXVQ&t=325s)
- 06:50 – [Summary](https://www.youtube.com/watch?v=uihNXaDBXVQ&t=410s)

## Building a Simple Landing Page in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196323">Video</a> | [PDF](./pdfs/08-simple-landing-page-dotnet.pdf)

In this module we examine the elements of building a simple landing page and looking at how it works.  

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the SaaS Client Library for .NET to build out our landing page functionality.

- 00:00 – [Overview](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=0s)
- 00:59 - [The purpose of the landing page](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=59s)
- 03:11 - [A humble landing page in action](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=191s)
- 09:19 - [The code](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=559s)
- 17:59 - [Available data to display](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=1079s)
- 20:21 – [Summary](https://www.youtube.com/watch?v=QoDXqp3GH_s&t=1221s)

## Building a Simple SaaS Publisher Portal in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196257">Video</a> | [PDF](./pdfs/09-simple-publisher-portal-dotnet.pdf)

This video shows a very simple example of a publisher’s portal used to manage SaaS subscriptions. The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the SaaS Client Library for .NET to build out our portal functionality.

- 00:00 – [Overview](https://www.youtube.com/watch?v=bKNFoLfrTHU&t=0s)
- 00:46 - [Why have a publisher portal?](https://www.youtube.com/watch?v=bKNFoLfrTHU&t=46s)
- 01:47 - [A simple publisher portal](https://www.youtube.com/watch?v=bKNFoLfrTHU&t=107s)
- 05:47 - [The code](https://www.youtube.com/watch?v=bKNFoLfrTHU&t=347s)
- 12:01 – [Summary](https://www.youtube.com/watch?v=bKNFoLfrTHU&t=721s)

## SaaS Webhook Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196258">Video</a> | [PDF](./pdfs/10.1-simple-webhook-overview.pdf)

This technical overview of the SaaS webhook explains the following concepts of the SaaS offer webhook.

-	Why to have this specialized HTTPS endpoint
-	POST events one may receive on the webhook
-	Flow models of how to handle requests
-	Potential fully implemented webhook architectures

And more! Consider watching this video before moving on to the code-based modules for implementing and securing a SaaS offer webhook.

## Implementing a Simple SaaS Webhook in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196159">Video</a>

This code-heavy module focuses on the fundamentals of implementing a SaaS offer webhook as an Azure function using .NET. Concepts are presented in such a way as to be architecture and technology stack agnostic.

- 00:00 – [Overview](https://www.youtube.com/watch?v=higEi441t1Q&t=0s)
- 00:27 - [Azure portal](https://www.youtube.com/watch?v=higEi441t1Q&t=27s)
- 01:09 - [Azure function](https://www.youtube.com/watch?v=higEi441t1Q&t=69s)
- 02:40 - [Long stream](https://www.youtube.com/watch?v=higEi441t1Q&t=160s)
- 03:19 - [Client view](https://www.youtube.com/watch?v=higEi441t1Q&t=199s)
- 04:17 - [Viewing the payload](https://www.youtube.com/watch?v=higEi441t1Q&t=257s)
- 05:56 – [Summary](https://www.youtube.com/watch?v=higEi441t1Q&t=356s)

## Securing your SaaS offer webhook

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196421">Video</a> | [PDF](./pdfs/10.3-simple-webhook-dotnet-securing-v2.pdf) | [Code](./code/10.3-simple-webhook-dotnet-securing-v2.zip)

This security-focused module introduces several techniques for securing a SaaS offer webhook and then dives into implementations of the techniques presented. The two techniques covered are using an Azure Function as a webhook and using a Logic app. 

Although the Azure Function example is implemented in .NET, it is done so in a way that illustrates core concepts for any development stack.

- 00:00 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=0s">Overview</a>
- 01:16 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=76s">Basic webhook flow</a>
- 02:54 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=174s">Implementing webhook security</a>
- 05:25 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=325s">Demo: Inspecting the marketplace JWT</a>
- 07:07 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=427s">Demo: Securing a webhook implemented in .NET</a>
- 12:18 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=738s">Demo: Securing a webhook implemented with a Logic app</a>
- 16:50 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=1010s">A security anti-pattern</a>
- 19:38 - <a target="_blank" href="https://www.youtube.com/watch?v=iWPte1PLMdw&t=1178s">Summary</a>


## SaaS Metered Billing Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196314">Video</a> | [PDF](./pdfs/11.1-saas-metered-billing-overview.pdf)

This module presents the fundamentals of billing through the marketplace based on usage, or metered billing. It covers several areas of metered billing including the following.

- 00:00 – [Overview](https://www.youtube.com/watch?v=DJQ-2-wh6vU&t=0s)
- 01:23 – [Demo](https://www.youtube.com/watch?v=DJQ-2-wh6vU&t=83s)
- 04:45 – [API communications](https://www.youtube.com/watch?v=DJQ-2-wh6vU&t=285s)
- 07:22 – [Summary](https://www.youtube.com/watch?v=DJQ-2-wh6vU&t=442s)

## The SaaS Metered Billing API with REST

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196418">Video</a>

We exercise the SaaS Billing REST API using Postman to illustrate how the API works. You’ll learn how the inputs to each API event and how to use the results, and finally how to invoke usage events in the metering API itself. This module is primarily demo.

## Hands-on labs

To perform the hands-on labs, visit [this GitHub repository](https://github.com/Azure/mtm-labs), which is home to the Mastering the Marketplace labs.
