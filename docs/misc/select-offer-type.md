---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

hide:
  - toc

title: Choose Your Offer Type
---

If you are deciding which offer type you will be creating, this page is for you. Primary considerations for choosing an offer type include billing options and deployment architectures. This page has resources to help walk through these topics as well as any others related to getting started.

<!-- no toc -->
- [Decision tree](#decision-tree)
- [Microsoft documentation](#microsoft-documentation)
- [SaaS offers](#saas-offers)
- [Virtual Machine offers](#virtual-machine-offers)
- [Azure Managed Application offers](#azure-managed-application-offers)

## Decision tree

Building on top of the above video, follow the questions in the below image to find the right offer type for you. 

![Find your offer type](./assets/offer-type-flow.png)

## Microsoft documentation

- <a target="_blank" href="https://docs.microsoft.com/azure/marketplace/publisher-guide-by-offer-type">Publishing guide by offer type</a>
- <a target="_blank" href="https://docs.microsoft.com/en-us/azure/marketplace/marketplace-commercial-transaction-capabilities-and-considerations#transact-overview">The transact overview</a> helps you understand some of the differences between transactable offer types.

## SaaS offers

SaaS offers allow for software that is delivered as SaaS to be transacted on the Azure Marketplace.

- A SaaS offer runs in the publisher’s tenant
- Supports metered billing
- Requires some integration with marketplace SaaS APIs

🚦Learn more about SaaS offers [here](../learning-paths/saas-offers.md).

⏯️ Experience the SaaS Accelerator course [here](../saas-accelerator/index.md).

## Virtual Machine offers

Virtual Machine offers allow publishers to install their software on a virtual machine.

- Runs in the customer’s tenant and subscription
- Pricing is based on usage of the product
- Does not support metered billing

🚦Learn more about Virtual Machine offers [here](../learning-paths/virtual-machine-offers.md).

## Azure Managed Application offers

- Runs in the customer’s tenant
- Enables the publisher to manage the resources in the customer’s tenant
- Deploys via an ARM template
- Supports metered billing

🚦Learn more about Managed Application offers [here](../learning-paths/ama-offers.md).
