---
# Page settings
layout: default
keywords: Azure Marketplace Container
comments: false

hide:
- navigation

# Micro navigation
micro_nav: false
---

[Home](/) > [Container Offers](../../index) > [Labs](../../index.md#labs) 🧪

# Lab 1 - Partner Center Setup for a Container Offer

> **Note:** This lab is part of a series of labs for Mastering Container Offers Workshop. You must finish this lab before moving on to the next sections.

This lab will walk you through setting up a Container Offer in [Partner Center](https://partner.microsoft.com/en-us/dashboard/marketplace-offers/overview). You will need a Partner Center account and need to have enrolled into the commercial marketplace program in order to be able to create offers in the marketplace.

## Table of Contents

<!-- no toc -->
- [Create a new Container Offer](#create-a-new-container-offer)
- [Review and Publish](#review-and-publish)

## Create a new Container Offer

In this section you will be creating a brand new Container Offer from scratch. This will be used for publishing the offer once the rest of your labs are complete.

1. On the Homepage of Partner Center, look for Marketplace Offers and click that tile. If you have disabled Workspaces, then it will be visible as Commercial Marketplace.
2. Click the **+ New Offer** button and select **Azure Container** from the dropdown.
3. Enter a unique **Offer ID** and an **Offer Alias** as described below.
    - Offer ID: **containerworkshop-YOUR_UNIQUE_STRING** (Replace the **YOUR_UNIQUE_STRING** with a value of your choice)
    - Offer Alias: **Container Workshop**
    - Submit the new offer.
4. Once the offer is created, navigate to the **Offer Setup** page by clicking on that tab on the left

## Offer Setup

The Offer Setup page allows changing your offer alias as well as as other functions. For the purpose of this lab, we will leave everything as is and only configure the **Setup details** and **Customer leads** sections.

### Setup details

1. Under **Setup details** check **Yes, I would like to sell through Microsoft and have Microsoft host transactions on my behalf**

### Customer leads

Here, you will attach your offer to an Azure Data Storage table which will act as a connected Customer Relationship Management system (CRM) for your offer. This is where sales leads will be collected.

It is recommended you install all the resources you'll create in this class into the same Resource Group, just to keep things tidy.

#### Create the Azure Storage account

1. Open a new tab for the [Azure portal](https://portal.azure.com) and log in.
2. In the **containerworkshop-YOUR_UNIQUE_STRING** Resource Group, create a standard Azure Storage account. This will be your CRM database, so name it **containerworkshopscrmUNIQUE_STRING**. rEPLACE **UNIQUE_STRING** with a different value. 
   
    > 🗒️ Note all characters are lower case for naming a storage account and no non-alphanumeric characters are allowed.

3. Once the storage account is created, browse to the storage account's **Overview** page.
4. In the left-hand menu, find the **Security + networking** section.
5. Uner the **key1** section click the **Show** button next to the **Connection string** hidden value.
6. Copy a connection string to your copy/paste buffer.

#### Configure Customer Leads in Partner Center

1. Go back to the Partner Center **Customer leads** in your browser.
2. Select the **Connect** link.
3. From the **Lead destination** dropdown, select **Azure Table**.
4. Enter your **Contact email** and paste in your **Storage account connection string**.
5. Click the **Validate** link to ensure your connection string is valid.
6. Click **Connect**.
7. CLick teh **Connect** button.

    > 🗒️For each page in Partner Center, you must click the **Save draft** at the bottom of the page before moving on.

8. Click **Save draft** at the bottom of the page.

### Properties

Navigate to the **Properties** tab on the left.

#### Categories

You must select at least one category for your offer. Container offers always appear under the Compute category in Azure Marketplace. For this lab we will be selecting the below configurations.

1. Click the **+ Categories** link.
1. In the left dropdown, select **Containers**.
1. In the right dropdown, select **Kubernetes App**.

#### Legal

You will use the Microsoft Standard Contract for this lab. You may choose differently when you are publishing to a production environment.

1. Scroll down to the **Legal** section.
2. Select "Use the Standard Contract for Microsoft’s commercial marketplace?" checkbox
3. Click **Accept**.
4. Click the **Save draft** button.

### Offer listing

Navigate to the **Offer listing** page in the left hand menu.

1. In the the **Search results summary** section, enter some text. Here is some text you may copy and paste for this purpose.

    > Quis aute iure reprehenderit in voluptate ...

2. For **Short Description** and **Description** sections, here is some text you may choose to copy and paste into the text boxes.

    > Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

3. In the **Privacy policy link**, enter the public link to the privacy policy for your company if you know it. If not, use the following link: `https://privacy.microsoft.com/privacystatement`. 
   
    > ⚠️ Please note that using Microsoft's privacy policy is only for the purpose of this lab and should not be used for your production offer.

4. In the **Support Contact** section, enter your contact information.
5. In the **Engineering Contact** section, enter your engineering contact information.
6. For the Marketplace media section you'll upload 2 images.
    1. For the **216X216 logo image,** upload the PNG provided in the `./items` directory of **lab1**. This PNG is named "**Contoso-Logo-216x216.png**."
    2. For the **1280X720** screenshot image, upload the PNG provided in the `./items` directory of **lab1**. This PNG is named "**Screenshots-1280x720.png**."
    3. Add a screenshot image caption.
7. Click the **Save draft** button and correct any errors that be shown before moving on.

### Preview audience

The preview audience specifies the subscriptions that will be able to test the offer before it goes, when it is in the **Preview** state. Everyone using the subscription will be able to purchasae the offer when in Preview (test) mode.

1. In the **Preview audience** section, enter your Azure subscription Id. 
1. Enter a **Description** (Optional).
1. Click **Save draft**.

### Plan overview

Skip this section for this lab. You will come back to it later.

## Review and Publish

Here, you can check your work by performing the first action of the publication process. You will submit your offer to an automated compliance checker to see if it is ready to be published.

1. Navigate to the **Offer overview** page.
1. In the upper right corner of the page, click the link for **Review and publish**.
1. Looking to the right side of the page, notice that some sections have a green circle and at least one is gray. The gray sections are not yet complete, preventing you from taking the next step of publishing your offer.

    > 🗒️The **Plan overview** section of the offer will not pass review and should be gray. This is okay for now as we need to fill out the **Plan overview** tab and you can't do that until we have a VM image. All other sections should be green.

1. Ensure all sections pass and are green except **Plan overview**, which will be addressed in the next lab.
1. Go back to all other sections that appear with a gray circle and complete those sections with the guidance provided above.

**Congratulations!** You have now finished this lab.

[Continue to Lab 2](../lab2-prepare-container-deployment/index.md)