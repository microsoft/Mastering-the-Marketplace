---
# Page settings
layout: default
keywords: Azure AppSource Marketplace SaaS
comments: false

hide:
  - toc

title: Choose your Azure marketplace offer type
---

If you are deciding which offer type you will be creating, this page is for you. Primary considerations for choosing an offer type include deployment architectures and billing models. This page has resources to help walk through these topics as well as any others related to getting started.

The Azure Marketplace enables several types of deployment architectures. Are you unsure of which type of offer you need to bring your solution to the Microsoft commercial marketplace? The following model walks through which offer type is a good fit for your solution.

**<a href="https://partner.microsoft.com/en-us/training/assets/detail/choosing-your-azure-marketplace-offer-type-mp4" target="_blank">Video walkthrough</a>**

![Find your offer type](./assets/0.04-choose-offer-type.png)

## Supporting content

<!-- no toc -->
- [About SaaS offers](#about-saas-offers)
- [About Virtual Machine offers](#about-virtual-machine-offers)
- [About Container offers for Kubernetes apps](#about-container-offers-for-kubernetes-apps)
- [About Azure Managed Application offers](#about-azure-managed-application-offers)


### About SaaS offers

SaaS offers allow for software that is delivered as SaaS to be transacted on the Azure Marketplace.

- A SaaS offer runs in the publisher’s tenant
- Supports metered billing
- Requires some integration with marketplace SaaS APIs

🚦Learn more about SaaS offers [here](../learning-paths/saas-offers.md).

⏯️ Experience the SaaS Accelerator course [here](../saas-accelerator/index.md).

### About Virtual Machine offers

Virtual Machine offers allow publishers to install their software on a virtual machine.

- Runs in the customer’s tenant and subscription
- Pricing is based on usage of the product
- Does not support metered billing

🚦Learn more about Virtual Machine offers [here](../learning-paths/virtual-machine-offers.md).

### About Azure Managed Application offers

AMAs offer a powerful ARM-based deployment model allowing publishers to make any Azure service part of their solution.

- Runs in the customer’s tenant
- Enables the publisher to manage the resources in the customer’s tenant
- Deploys via an ARM template
- Supports metered billing

🚦Learn more about Managed Application offers [here](../learning-paths/ama-offers.md).

### About Container offers for Kubernetes apps

Container offers for K8s apps enable bundling your software into container images and deploying onto the customer's Azure Kubernetes Service instance.

- Runs in the customer’s tenant and subscription
- Pricing is based on usage of the product
- Supports metered billing