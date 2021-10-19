# SaaS Offers - Mastering the Marketplace Series

These videos are designed to help you publish your SaaS offer to the Microsoft Commercial Marketplace. This content is currently under development and will be released incrementally as it is created.

1. [SaaS Offer Overview](#saas-offer-overview)
1. [Purchasing a SaaS Offer](#purchasing-a-saas-offer)
1. [Purchasing a Private SaaS Plan](#purchasing-a-private-saas-plan)
1. [Publishing a SaaS Offer](#publishing-a-saas-offer)
1. [Publishing a Private SaaS Plan](#publishing-a-private-saas-plan)
1. [SaaS Offer Technical Overview](#saas-offer-technical-overview)
1. [Azure AD Application Registrations](#azure-ad-application-registrations)
1. [Using the SaaS Offer REST Fulfillment API](#using-the-saas-offer-rest-fulfillment-api)
1. [The SaaS Client Library for .NET](#the-saas-client-library-for-net)
1. Building a Simple Landing Page with the SaaS Client Library for .NET
1. Building a Simple Publisher Management Portal with the SaaS Client Library for .NET
1. Building a Simple SaaS Offer Webhook
1. Using the SaaS Offer Metered Billing
1. SaaS Accelerator Overview
1. [Installing the SaaS Accelerator](#installing-the-saas-accelerator)

# Learning Modules

## SaaS Offer Overview

[Video](https://www.youtube.com/watch?v=9PCTioPbI8M&list=PLmsFUfdnGr3wWUaB-QkSaQRHBNYKZj5PM) | [PDF](./pdfs/01-SaaS-Offer-Overview.pdf)

This module offers a technical overview of Microsoft Azure Marketplace SaaS Offers, including the following topics. 

 - The Microsoft Commercial Marketplace Ecosystem​
 - SaaS Offer Creation Process​
 - ​Pricing Models for SaaS Offers​ 
 - SaaS Solution Architectures 

 ## Purchasing a SaaS Offer

[Video](https://youtu.be/hYqoqbzCbfY) | [PDF](./pdfs/02.1-Purchasing-a-SaaS-Offer.pdf)

This video offers a guided step-by-step process to purchasing SaaS applications in the #Microsoft Azure Marketplace from the customers point of view, including the following topics.
-	SaaS Offer Subscription Flow
-	Subscribing From the Azure Marketplace
-	Subscribing From the Azure Portal
-	The SaaS Management Service

## Purchasing a Private SaaS Plan

[Video](https://youtu.be/44CCTjiwcfA) | [PDF](./pdfs/02.2-Purchasing-a-Private-SaaS-Plan.pdf)

This video shows how to subscribe to private SaaS plans in the Microsoft Azure Marketplace. Topics include the following.
-	About Private Plans
-	Purchasing a SaaS Private Offer demo


## Publishing a SaaS Offer

[Video](https://youtu.be/AnZDa0Z1z8I) | [PDF](./pdfs/03.1-Publishing-a-SaaS-Offer.pdf)

This detailed video presents the concepts of publishing a SaaS offer and then walks through the steps of doing so in Partner Center. This module goes all the way from creating an offer, to adding and plan, and finally publishing the offer live. It also speaks to the need of developers to have a sandbox environment in which they can test and development the landing page and webhook.

## Publishing a Private SaaS Plan

[Video](https://youtu.be/67E7LPL_aic) | [PDF](./pdfs/03.2-Publishing-Private-SaaS-Plan.pdf)

This brief video builds upon what you learned in, “[Publishing a SaaS Offer](#publishing-a-saas-offer).” It presents the concepts of using private plans and then shows how to do so inside Partner Center.

## SaaS Offer Technical Overview

[Video](https://youtu.be/0c-rzJkTV7w) | [PDF](./pdfs/04-SaaS-Offer-Technical-Overview.pdf)

Watch a deep technical overview of how SaaS offers work in the Microsoft Azure Marketplace. Learn how the API flows and interactions should work and how to build your landing page. Topics include the following. 

- The Landing Page​ authentication workflows
- SaaS Offer Purchase Flow in Depth​ 
- SaaS Offer Fulfillment API​ 
- Metered Fulfillment Overview​ 
- SaaS Offer Webhook

## Azure AD Application Registrations

[Video](https://youtu.be/-wjlgxJIlWQ) | [PDF](./pdfs/05-Azure-AD-Application-Registrations.pdf)

In this module we look at a generic topic, application registrations for Azure Active Directory because we’ll need to use them in our upcoming modules. They give us a mechanism to authenticate to Azure AD, which is a requirement of the landing page, if you recall.

This video should help you get a jump start on configuring application registrations for the apps we’ll be building in the next few modules.

This module introduces just enough on this topic to help us build our landing page and webhooks later in the course. For those interested in more reading, please see [Create and Azure AD app registration](https://docs.microsoft.com/en-us/azure/marketplace/azure-ad-transactable-saas-landing-page#create-an-azure-ad-app-registration) and [Quickstart: Register an application with the Microsoft identity platform](https://docs.microsoft.com/en-us/azure/active-directory/develop/quickstart-register-app) from the official Microsoft documentation.


## Using the SaaS Offer REST Fulfillment API

[Video](https://youtu.be/eizdN6XNyvw) | [PDF](./pdfs/06-Using-the-SaaS-Offer-Fulfillment-API.pdf)

See the SaaS Fulfillment REST API in action as we send it through its paces using Postman. You’ll learn how to authenticate with Azure Active Directory, resolve and activate subscriptions just like your Landing Page does, and see many other features of the API. 

This module prepares you for working with the language-specific client libraries.

This modules requires you to have knowledge of [Application Registrations in AAD](https://docs.microsoft.com/en-us/azure/active-directory/develop/quickstart-register-app). 

An Application Registration is used in the examples when making the first request to retrieve an authentication token from Azure Active Directory. You should be familiar with creating an Application Registration and finding the following information in the Azure Portal.

1. The [Tenant ID and App ID](https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#get-tenant-and-app-id-values-for-signing-in)
1. A [Client Secret](https://docs.microsoft.com/en-us/azure/active-directory/develop/howto-create-service-principal-portal#option-2-create-a-new-application-secret) on the Application Registration

## The SaaS Client Library for .NET

[Video](https://youtu.be/uihNXaDBXVQ) | [PDF](./pdfs/07-The-SaaS-Client-Library-for-.NET.pdf) | [Code](./code-samples/the-saas-client-library-for-dotnet)

This module introduces the [SaaS Client Library for .NET](https://github.com/microsoft/commercial-marketplace-client-dotnet) developers who want to work with the SaaS APIs at a level of abstraction above the REST level.

The client library is a fully functional .NET package that you can [install from NuGet](https://www.nuget.org/packages/Marketplace.SaaS.Client) and use in your applications.

This video shows a sample command line application that can talk to the client library API and the code is available in this repository via the link above.

## Installing the SaaS Accelerator

[Video](https://youtu.be/BVZTj6fssQ8) | [PDF](./pdfs/21-Installing-the-SaaS-Accelerator.pdf)

Installing the SaaS Accelerator is simple. This video walks you through from beginning to end the steps necessary to get the SaaS Accelerator up and running. This is not a review of the SaaS Accelerator’s functionality. For that, please see the video, “SaaS Accelerator Overview.”

This video will get you up and running with the SaaS Accelerator in no time at all!
