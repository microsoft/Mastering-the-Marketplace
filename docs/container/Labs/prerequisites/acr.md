---
# Page settings
layout: default
keywords: Azure Marketplace Container Offer
comments: false

# Hero section
description: This lab will walk you through setting up a Azure Kubernetes Cluster and Azure Container Registry. 

# Micro navigation
micro_nav: false

hide:
- navigation

---

[Home](/) > [Container Offers](../../../container/index.md) > [Prerequisites](./index.md)

# Create Azure Container Registry Prerequisite

This page walks through creating an Azure Container Registry (ACR) for use in the Container Offers lab.

1. Sign in to the [Azure portal](https://portal.azure.com)
2. Select **Create a resource** > **Containers** > **Container Registry**.

    ![Create ACR](images/qs-portal-01.png)

3. In the **Basics** tab, enter values for **Resource group** and **Registry name**. The registry name must be unique within Azure, and contain 5-50 alphanumeric characters. 
4. For this lab create a new resource group in the `West US` location named `myResourceGroup`.
5. For **SKU**, select 'Basic'.

    ![Basics tab](images/qs-portal-03.png)

6. Accept default values for the remaining settings. Select the **Review + create** button at the bottom of the screen. 
7. After reviewing the settings, select **Create**. The deployment of the ACR begins.
8. When the `Deployment succeeded` message appears, click the **Go to resource** button. You will see the ACR as in the image below.

    ![Registry](images/qs-portal-05.png)

9. Take note of the registry name and the value of the **Login server**, which is a fully qualified name ending with `azurecr.io`. You will use these values later.

**Congratulations!** You now have an Azure Container Registry to use in the labs.

Go back to the [lab prerequisites](index.md) and follow on with remaining steps.
