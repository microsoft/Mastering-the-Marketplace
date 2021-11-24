# SaaS Offers Series

These learning modules are designed to help you speed your time to publish your SaaS offer to the Microsoft commercial marketplace. 

This content is currently under development and will be released incrementally as it is created.

### Table of Contents

1. [SaaS Offer Overview](#saas-offer-overview)
1. [Purchasing a SaaS Offer](#purchasing-a-saas-offer)
1. [Purchasing a Private SaaS Plan](#purchasing-a-private-saas-plan)
1. [Publishing a SaaS Offer](#publishing-a-saas-offer)
1. [Publishing a Private SaaS Plan](#publishing-a-private-saas-plan)
1. [SaaS Offer Technical Overview](#saas-offer-technical-overview)
1. [Azure AD Application Registrations](#azure-ad-application-registrations)
1. [Using the SaaS Offer REST Fulfillment API](#using-the-saas-offer-rest-fulfillment-api)
1. [The SaaS Client Library for .NET](#the-saas-client-library-for-net)
1. [Building a Simple SaaS Landing Page in .NET](#building-a-simple-saas-landing-page-in-net)
1. [Building a Simple SaaS Publisher Portal in .NET](#building-a-simple-saas-publisher-portal-in-net)
1. [SaaS Webhook Overview](#saas-webhook-overview)
1. [Implementing a Simple SaaS Webhook in .NET](#implementing-a-simple-saas-webhook-in-net)
1. [Securing a Simple SaaS Webhook in .NET](#securing-a-simple-saas-webhook-in-net)

### Please help us improve this content for you

We would very much appreciate 2-3 minutes of your time to [give us your feedback](https://forms.office.com/r/0gCrzhSMkw) on the materials and to share your ideas for making this content better for you.

---

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

- SaaS Offer Subscription Flow
- Subscribing From the Azure Marketplace
- Subscribing From the Azure Portal
- The SaaS Management Service

## Purchasing a Private SaaS Plan

[Video](https://youtu.be/44CCTjiwcfA) | [PDF](./pdfs/02.2-Purchasing-a-Private-SaaS-Plan.pdf)

This video shows how to subscribe to private SaaS plans in the Microsoft Azure Marketplace. Topics include the following.

- About Private Plans
- Purchasing a SaaS Private Offer demo

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

> **NOTE:** The secrets that you set in an Application Registration have time limits. You may select up to 2 years for the secret to remain valid. In production, track when your secrets need to be changed and do so to avoid service outages.

This module introduces just enough on this topic to help us build our landing page and webhooks later in the course. For those interested in more reading, please see [Create and Azure AD app registration](https://docs.microsoft.com/azure/marketplace/azure-ad-transactable-saas-landing-page#create-an-azure-ad-app-registration) and [Quick start: Register an application with the Microsoft identity platform](https://docs.microsoft.com/azure/active-directory/develop/quickstart-register-app) from the official Microsoft documentation.

## Using the SaaS Offer REST Fulfillment API

[Video](https://youtu.be/eizdN6XNyvw) | [PDF](./pdfs/06-Using-the-SaaS-Offer-Fulfillment-API.pdf)

See the SaaS Fulfillment REST API in action as we send it through its paces using Postman. You’ll learn how to authenticate with Azure Active Directory, resolve and activate subscriptions just like your Landing Page does, and see many other features of the API.

This module prepares you for working with the language-specific client libraries.

This modules requires you to have knowledge of [Application Registrations in AAD](https://docs.microsoft.com/azure/active-directory/develop/quickstart-register-app).

An Application Registration is used in the examples when making the first request to retrieve an authentication token from Azure Active Directory. You should be familiar with creating an Application Registration and finding the following information in the Azure Portal.

1. The [Tenant ID and App ID](https://docs.microsoft.com/azure/active-directory/develop/howto-create-service-principal-portal#get-tenant-and-app-id-values-for-signing-in)
1. A [Client Secret](https://docs.microsoft.com/azure/active-directory/develop/howto-create-service-principal-portal#option-2-create-a-new-application-secret) on the Application Registration

## The SaaS Client Library for .NET

[Video](https://youtu.be/uihNXaDBXVQ) | [PDF](./pdfs/07-The-SaaS-Client-Library-for-.NET.pdf) | [Code](./demo-code/the-saas-client-library-for-dotnet)

This module introduces the [SaaS Client Library for .NET](https://github.com/microsoft/commercial-marketplace-client-dotnet) developers who want to work with the SaaS APIs at a level of abstraction above the REST level.

The client library is a fully functional .NET package that you can [install from NuGet](https://www.nuget.org/packages/Marketplace.SaaS.Client) and use in your applications.

This video shows a sample command line application that can talk to the client library API and the code is available in this repository via the link above.

## Building a Simple SaaS Landing Page in .NET

[Video](https://youtu.be/QoDXqp3GH_s) | [PDF](./pdfs/08-simple-landing-page-dotnet.pdf) | [Code](./demo-code/saas-simple-landing-page)

In this module we examine the elements of building a simple landing page and looking at how it works.We examine the following topics.

- The purpose of a landing page
- A humble landing page in action
- The code
- Available data to display

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the [SaaS Client Library for .NET](#the-saas-client-library-for-net) to build out our landing page functionality.

## Building a Simple SaaS Publisher Portal in .NET

[Video](https://youtu.be/bKNFoLfrTHU) | [PDF](./pdfs/09-simple-publisher-portal-dotnet.pdf) | [Code](./demo-code/saas-simple-publisher-portal)

In this module we examine the elements of building a publisher portal and at how it works.We examine the following topics.

- The purpose of a publisher portal
- A simple publisher portal in action
- The code

The technology stack used is C#, ASP.NET MVC, and Razor views, just to keep it simple. We use the [SaaS Client Library for .NET](#the-saas-client-library-for-net) to build out our portal functionality.

## SaaS Webhook Overview

[Video](https://youtu.be/Fl6CZyrJnw8) | [PDF](./pdfs/10.1-simple-webhook-overview.pdf)

This technical overview of the SaaS webhook explains the following concepts of the SaaS offer webhook.

- Why to have this specialized HTTPS endpoint
- POST events one may receive on the webhook
- Flow models of how to handle requests
- Potential fully implemented solution architectures

And more! Consider watching this video before moving on to the code-based modules for implementing and securing a SaaS offer webhook.

## Implementing a Simple SaaS Webhook in .NET

[Video](https://youtu.be/higEi441t1Q) | [Code](./demo-code/simple-webhook-dotnet-implementing)

This code-heavy module focuses on the fundamentals of implementing a SaaS offer webhook as an Azure function using .NET. Concepts are presented in such a way as to be architecture and technology stack agnostic.

## Securing a Simple SaaS Webhook in .NET

[Video](https://youtu.be/Wifuc5jAY7E) | [PDF](./pdfs/10.3-simple-webhook-dotnet-securing.pdf) | [Code](./demo-code/simple-webhook-dotnet-securing)

This security-focused module introduces several techniques for securing a SaaS offer webhook and then dives into code looking at implementations of the techniques presented. This module builds on the concepts and code presented in the module, “[Implementing a Simple SaaS Webhook in .NET](#implementing-a-simple-saas-webhook-in-net)”.

Although utilizing an Azure function built in .NET, topics are presented in such a way as to be architecture and technology stack agnostic.