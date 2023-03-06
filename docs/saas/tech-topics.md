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

<!-- no toc -->
- [SaaS Offer Technical Overview](#saas-offer-technical-overview)
- [Azure AD Application Registrations](#azure-ad-application-registrations)
- [Using the SaaS Offer REST Fulfillment API](#using-the-saas-offer-rest-fulfillment-api)
- [The SaaS Client Library for .NET](#the-saas-client-library-for-net)
- [Building a Simple SaaS Landing Page in .NET](#building-a-simple-saas-landing-page-in-net)
- [Building a Simple SaaS Publisher Portal in .NET](#building-a-simple-saas-publisher-portal-in-net)
- [SaaS Webhook Overview](#saas-webhook-overview)
- [Implementing a Simple SaaS Webhook in .NET](#implementing-a-simple-saas-webhook-in-net)
- [SaaS Metered Billing Overview](#saas-metered-billing-overview)
- [The SaaS Metered Billing API with REST](#the-saas-metered-billing-api-with-rest)
- [Programmatic Access to Reporting and Insights](#programmatic-access-to-reporting-and-insights)
- [Hands-on labs](#hands-on-labs)

---

## SaaS Offer Technical Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196315">Video</a> | [PDF](./pdfs/04-SaaS-Offer-Technical-Overview.pdf)

Watch a deep technical overview of how SaaS offers work in the Microsoft Azure Marketplace. Learn how the API flows and interactions should work and how to build your landing page. Topics include the following.

- The Landing Page​ authentication workflows
- SaaS Offer Purchase Flow in Depth​
- SaaS Offer Fulfillment API​
- Metered Fulfillment Overview​
- SaaS Offer Webhook

## Azure AD Application Registrations

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196262">Video</a> | [PDF](./pdf/../pdfs/05-Azure-AD-Application-Registrations.pdf)

In this module we look at a generic topic, application registrations for Azure Active Directory because we’ll need to use them in our upcoming modules. They give us a mechanism to authenticate to Azure AD, which is a requirement of the landing page, if you recall.

This video should help you get a jump start on configuring application registrations for the apps we’ll be building in the next few modules.

> **NOTE:** The secrets that you set in an Application Registration have time limits. You may select up to 2 years for the secret to remain valid. In production, track when your secrets need to be changed and do so to avoid service outages.

This module introduces just enough on this topic to help us build our landing page and webhooks later in the course. For those interested in more reading, please see [Create and Azure AD app registration](https://docs.microsoft.com/azure/marketplace/azure-ad-transactable-saas-landing-page#create-an-azure-ad-app-registration) and [Quick start: Register an application with the Microsoft identity platform](https://docs.microsoft.com/azure/active-directory/develop/quickstart-register-app) from the official Microsoft documentation.

## Using the SaaS Offer REST Fulfillment API

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196320">Video</a> | [PDF](./pdfs/06-Using-the-SaaS-Offer-Fulfillment-API.pdf)

See the SaaS Fulfillment REST API in action as we send it through its paces using Postman. You’ll learn how to authenticate with Azure Active Directory, resolve and activate subscriptions just like your Landing Page does, and see many other features of the API.

This module prepares you for working with the language-specific client libraries.

You will need knowledge of [Application Registrations in AAD](https://docs.microsoft.com/azure/active-directory/develop/quickstart-register-app).

An Application Registration is used in the examples when making the first request to retrieve an authentication token from Azure Active Directory. You should be familiar with creating an Application Registration and finding the following information in the Azure Portal.

1. The [Tenant ID and App ID](https://docs.microsoft.com/azure/active-directory/develop/howto-create-service-principal-portal#get-tenant-and-app-id-values-for-signing-in)
1. A [Client Secret](https://docs.microsoft.com/azure/active-directory/develop/howto-create-service-principal-portal#option-2-create-a-new-application-secret) on the Application Registration

## The SaaS Client Library for .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196324">Video</a> | [PDF](./pdfs/07-The-SaaS-Client-Library-for-.NET.pdf) | <a href="https://github.com/microsoft/Mastering-the-Marketplace/tree/main/docs/saas/demo-code/the-saas-client-library-for-dotnet">Code</a>

This module introduces the [SaaS Client Library for .NET](https://github.com/microsoft/commercial-marketplace-client-dotnet) developers who want to work with the SaaS APIs at a level of abstraction above the REST level.

The client library is a fully functional .NET package that you can [install from NuGet](https://www.nuget.org/packages/Marketplace.SaaS.Client) and use in your applications.

This video shows a sample command line application that can talk to the client library API and the code is available in this repository via the link above.

## Building a Simple SaaS Landing Page in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196323">Video</a> | [PDF](./pdfs/08-simple-landing-page-dotnet.pdf) | <a href="https://github.com/microsoft/Mastering-the-Marketplace/tree/main/docs/saas/demo-code/saas-simple-landing-page">Code</a>

In this module we examine the elements of building a simple landing page and looking at how it works.We examine the following topics.

- The purpose of a landing page
- A humble landing page in action
- The code
- Available data to display

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the [SaaS Client Library for .NET](#the-saas-client-library-for-net) to build out our landing page functionality.

## Building a Simple SaaS Publisher Portal in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196257">Video</a> | [PDF](./pdfs/09-simple-publisher-portal-dotnet.pdf) | <a href="https://github.com/microsoft/Mastering-the-Marketplace/tree/main/docs/saas/demo-code/saas-simple-publisher-portal">Code</a>

In this module we examine the elements of building a publisher portal and at how it works.We examine the following topics.

- The purpose of a publisher portal
- A simple publisher portal in action
- The code

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the [SaaS Client Library for .NET](#the-saas-client-library-for-net) to build out our portal functionality.

## SaaS Webhook Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196258">Video</a> | [PDF](./pdfs/10.1-simple-webhook-overview.pdf)

This technical overview of the SaaS webhook explains the following concepts of the SaaS offer webhook.

- Why to have this specialized HTTPS endpoint
- POST events one may receive on the webhook
- Flow models of how to handle requests
- Potential fully implemented solution architectures

And more! Consider watching this video before moving on to the code-based modules for implementing and securing a SaaS offer webhook.

## Implementing a Simple SaaS Webhook in .NET

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196159">Video</a> | <a href="https://github.com/microsoft/Mastering-the-Marketplace/tree/main/docs/saas/demo-code/simple-webhook-dotnet-implementing">Code</a>

This code-heavy module focuses on the fundamentals of implementing a SaaS offer webhook as an Azure function using .NET. Concepts are presented in such a way as to be architecture and technology stack agnostic.

## SaaS Metered Billing Overview

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196314">Video</a> | [PDF](./pdfs/11.1-saas-metered-billing-overview.pdf)

This module presents the fundamentals of billing through the marketplace based on usage, or metered billing. IT covers several areas of metered billing including the following.

1. How to configure Partner Center
1. The flow of API operations needed to use the SaaS billing API
1. Resources to save you time in building your SaaS application

## The SaaS Metered Billing API with REST

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2196418">Video</a>

We exercise the SaaS Billing REST API using Postman to illustrate how the API works. You’ll learn how the inputs to each API event and how to use the results, and finally how to invoke usage events in the metering API itself. This module is primarily demo.

## Programmatic Access to Reporting and Insights

<a target="_blank" href="https://go.microsoft.com/fwlink/?linkid=2223619">Video</a> | [PDF](../partner-center/pdfs/03.6-programmatic-access-to-reporting-and-insights.pdf)

This technical module demonstrates how to work with Partner Center reports and insights using the Partner Center API. This video shows technical details of working with the Partner Center API and is intended for technologists interested in automating marketplace reporting.

- <a target="_blank" href="https://www.youtube.com/watch?v=-YEy5VBsSdk&t=0s">00:00</a> – Overview
- <a target="_blank" href="https://www.youtube.com/watch?v=-YEy5VBsSdk&t=49s">00:49</a> – Prerequisites
- <a target="_blank" href="https://www.youtube.com/watch?v=-YEy5VBsSdk&t=149s">02:29</a> – Demo
- <a target="_blank" href="https://www.youtube.com/watch?v=-YEy5VBsSdk&t=680s">11:20</a> – Commercial marketplace documentation
- <a target="_blank" href="https://www.youtube.com/watch?v=-YEy5VBsSdk&t=732s">12:12</a> – Summary

## Hands-on labs

These hands-on labs focus on technical topics and are typically of use to technologists. They build upon each other. Perform them in sequential order to get a fully functional SaaS Offer published and working for your test environment.

Clone [this repository](https://github.com/microsoft/Mastering-the-Marketplace) to your local machine. You will need some artifacts from the lab folders to complete the labs.

### Prerequisites

1. Azure subscription that can create resources
1. A Partner Center Account
1. Visual Studio 2022, any version

### Labs🧪

1. [Creating a SaaS Offer in Partner Center](./labs/lab1-create-pc-offer/README.md)
1. [Creating a Landing Page](./labs/lab2-create-landing-page/README.md)
1. [Installing a Publisher Portal](./labs/lab3-install-pub-portal/README.md)
1. [Deploying and Monitoring a Webhook](./labs/lab4-create-webhook/README.md)
1. [Implementing Meter billing](./labs/lab5-implementing-meter-billing/README.md)