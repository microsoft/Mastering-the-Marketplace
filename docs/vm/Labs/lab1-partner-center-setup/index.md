---
# Page settings
layout: default
keywords: Azure Marketplace Virtual Machine
comments: false

# Hero section
title: Lab 1 - Partner Center Setup for a Virtual Machine Offer
description: This lab will walk you through setting up a Virtual Machine Offer in Partner Center. You will need to ensure that you have created an account in Partner Center and have enrolled into the commercial marketplace program in order to be able to create Offers in the Marketplace.

# Micro navigation
micro_nav: false
---

👈 [Back to Virtual Machine labs](../../index.md#labs)

This lab is part of a series of labs for Mastering the Virtual Machine Offers Workshop. You should finish this lab before moving on to the next sections. 

<!-- no toc -->
1. [Prerequisites before starting this lab](#prerequisites-before-starting-this-lab)
2. [Create a new Virtual Machine Offer](#create-a-new-virtual-machine-offer)
    - [Offer Setup](#offer-setup)
    - [Properties](#properties)
    - [Offer listing](#offer-listing)
    - [Preview audience](#preview-audience)
    - [Technical configuration](#technical-configuration)
    - [Plan overview](#plan-overview)
    - [Resell through CSPs](#resell-through-csps)
3. [Review and Publish](#review-and-publish)

## Prerequisites before starting this lab

1. Partner Center Account with enrollment in the commercial marketplace program
2. Access to the Azure Portal on the same tenant as is on Partner Center (Same tenancy is required to ensure you can publish images out of Azure Compute Galleries, more on this in the later modules).

## Create a new Virtual Machine Offer

In this section you will be creating a brand new VM Offer from scratch. This will be used for publishing the offer once the rest of your labs are completed.

The following steps will create an offer on your Partner Center Portal.

1. On the Homepage of Partner Center, look for Marketplace Offers and click that tile. If you have disabled Workspaces, then it will be visible as Commercial Marketplace.
2. Click the **+ New Offer** button and select **Azure Virtual Machine** from the dropdown.
3. You will now have to enter a unique Offer ID and an Offer Alias. For the purpose of uniformity for this lab, we will set a unique string to identify resources, like so,
    - Offer ID: **vmworkshop-YOUR_UNIQUE_STRING**
    - Offer Alias: **VM Workshop YOUR_UNIQUE_STRING**

    Replace the variable YOUR_UNIQUE_STRING with a name unique to your organization

Once the offer is created, navigate to the Offer Setup page by clicking on that tab on the left.

## Offer Setup

Offer Setup page will direct you with ways to change your offer alias as well as enable Test Drive. For the purpose of this lab, we will leave everything as is and only configure the Customer leads section.


### Customer leads

Here, you will attach your offer to an Azure Data Storage table which will act as a connected Customer Relationship Management system (CRM) for your offer.

### Create the Azure Storage account

This is the first time you're using the Azure portal for this class. It is recommended that you install all the resources you'll create in this class into the same Resource Group, just to keep things tidy within your Azure subscription.

1. Open a new tab for the [Azure portal](https://portal.azure.com) and log in.
1. Create a Resource Group named **vmworkshop-YOUR_UNIQUE_STRING**. Please note that this is the same unique string you added while creating the offer. 
1. In the **vmworkshop-YOUR_UNIQUE_STRING** Resource Group, create a standard Azure Storage account. This will be your CRM database, so name it **vmworkshopsayouruniquestring **. Note all characters are lower case for naming a storage account.
1. Once the storage account is created, browse to the storage account's overview page.
1. In the left-hand menu, find the **Security + networking** section.
1. In that section, find and click on the **Access keys** link.
1. At the top of the page, click the **Show keys** link, and you see the connection strings for the database.
1. Copy a connection string to your copy/paste buffer.

### Configure Customer Leads in Partner Center

1. Go back to the Partner Center tab in your browser.
1. Select the **Connect** link.
1. From the **Lead destination** dropdown, select **Azure Table**.
1. Enter your **Contact email** and paste in your **Storage account connection string**.
1. Click the **Validate** link to ensure your connection string is valid.
1. Click **Connect**.

    For each page, you must click the **Save draft** at the bottom of the page to move on.

1. Click **Save draft** at the bottom of the page.

## Properties
Navigate to the Properties page by selecting the Properties tab on the left.

### Categories

You must select at least one category for your offer. Virtual machine offers always appear under the Compute category in Azure Marketplace. For this lab we will be selecting the below configurations.

1. Click the **+ Categories** link.
1. In the left dropdown, select **Compute**.
1. In the right dropdown, select **Application Infrastructure**.

### Legal
We will be using the Microsoft Standard Contract for this lab. You may choose differently when you are publishing to the prod environment.

1. Scroll down to the **Legal** section.
1. Select **Use the Standard Contract for Microsoft’s commercial marketplace?** checkbox
1. Click **Accept**.
1. Click the **Save draft** button.

<br/>

### Offer listing
Navigate to the Offer listing page.

1. In the the **Offer listing** section, for **Search results summary** enter **VM Workshop summary**.
1. For **Short Description** and **Description**, here is some text you may choose to copy and paste into the text box.
    
    ```text
    Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
    ```

1. In the **Privacy policy link**, enter the public link to the privacy policy for your company if you know it. If not, follow this link to [Microsoft's privacy policy](https://privacy.microsoft.com/privacystatement) and use that URL. 
    >Please note that using Microsoft's privacy policy is only for the purpose of this lab and should not be used for your production offer.
1. In the **Customer Support links** section, enter Azure support website information (Optional)
1. In the **Partner Support Contact** section, enter your contact information.
1. In the **Engineering Contact** section, enter your engineering contact information.
1. In the **Cloud Solution Provider Program Contact** section, enter the appropriate contact information (Optional)

1. For the Marketplace media section you'll upload 2 images, both of which are [available here](https://github.com/microsoft/Mastering-the-Marketplace/tree/main/docs/vm/Labs/lab1-partner-center-setup/items).
    1. For the **216X216 logo image,** upload the PNG provided. This PNG is named "**Contoso-Logo-216x216.png**."
    1. For the **1280X720** screenshot image, upload the PNG provided. This PNG is named "**Screenshots-1280x720.png**."
    1. Add a screenshot image caption.
1. Click the **Save draft** button and correct any errors that be shown before moving on.

### Preview audience

1. In the **Preview audience** section, enter your Azure subscription Id. 
1. Enter a **Description** (Optional).
1. Click **Save draft**.

### Technical configuration

Skip this section for this first lab.

### Plan overview

Skip this section for this lab. You'll come back to it later.

### Resell through CSPs

Finally navigate to the Resell through CSPs tab.

1. Select "No partners in the CSP program."
1. Click the **Save draft** button at the bottom of the screen.

## Review and Publish

In this short exercise, you will check your work by performing the first action of the publication process. You will submit your offer for review to see if it is ready to be published.

1. Open your offer's overview page.
1. In the upper right corner of the page, click the link for **Review and publish**.
1. Looking to the right side of the page, notice that some sections have a green circle and at least one is gray. The gray sections are not yet complete, preventing you from taking the next step of publishing your offer.

    > The **Plan overview** section of the offer will not pass review. This is okay for now as we need to fill out the **Plan overview** tab and you can't do that until we have a VM image. All other sections should be green.

1. Go back to all sections that appear with a gray circle and complete those sections with the guidance provided above.
1. Ensure all sections pass except **Plan overview**, which will be addressed in the next lab.

**Congratulations!** You have now finished this lab.

👈 [Back to Virtual Machine labs](../../index.md#labs)