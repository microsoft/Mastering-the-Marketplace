> **This lab is incomplete and in active development. It is not ready for use at this time.**

# Lab 1: Create a SaaS Offer in Partner Center

In this lab you will use your Partner Center account to create a **test** SaaS offer with a single plan. This offer will be used for development and testing purposes.

**Completion of this lab is required for the following labs in the series to work properly.**

You will need the following to complete this lab.

1. A [Partner Center](https://partner.microsoft.com/en-us/dashboard) account
1. An Azure account and access to the [Azure portal](https://portal.azure.com/)

## Exercise: Create a New SaaS Offer

In this exercise you will create a new SaaS offer in Partner Center and fill in information needed to publish it.

## Create a new SaaS offer

1. From the Home page of [Partner Center](https://partner.microsoft.com/dashboard/home) click the **Marketplace offers** button.
1. Click the **+ New offer** dropdown and select **Software as a Service**.
1. Give your new offer an **Offer ID** and **Offer alias**. Although you are free to use whatever values you like, we will be using the following in this lab for reference.
    1. Offer ID: **saas-workshop**
    1. Offer alias **SaaS Workshop**

## Offer setup

Leave all information on this page as is and scroll down to the **Customer leads** section of the page.

## Customer leads

Here, you will attach your offer to an Azure Data Storage table which will act as a connected CRM for your offer.

### Create the Azure Storage account

This is the first time you're using the Azure portal for this class. It is recommended that you install all the resources you'll create in this class into the same Resource Group, just to keep things tidy within your Azure subscription.

1. Open a new tab for the [Azure portal](https://portal.azure.com) and log in.
1. Create a Resource Group named **saas-workshop**. Although you may use a different name, all labs will refer to the Resource Group with this name.
1. In the **saas-workshop** Resource Group, create a standard Azure Data Storaage account. This will be your CRM database, so name it accordingly to distinguish it from future storage accounts that will be created in this Resource Group.
1. Once the storage account is created, browse to the storage account's overview page.
1. In the left-hand menu, find the **Security + networking** section.
1. In that section find and click on the **Access keys** link.
1. At the top of the page, click the **Show keys** link and you see the connection strings for the database.
1. Copy a connection string to your copy/paste buffer.

### Configure Customer Leads in Partner Center

1. Go back to the Partner Center tab in your browser.
1. Select the **Connect** link.
1. From the **Lead destination** dropdown select **Azure Table**.
1. Enter your **Contact email** and paste in your **Storage account connection string**.
1. CLick the **Validate** link to ensure your connection string is valid.
1. Click **Connect**.

For each page, you must click the **Save draft** at the bottom on the page to move on.

1. Click **Save draft** at the bottom of the page.

### Preview audience

1. In the **Preview audience** section, enter the email address you use for your Azure subscription. This is the email address you will use to purchase your offer later.
1. Enter a **Description**.
1. Click **Save draft**.

### Technical configuration

### Plan overview

## Exercise: Create a Plan

In this exercise you will create a plan that costs $0 to purchase. This plan will be used to test the offer in later labs.

### Create the plan

1.
1.

### Fill out the plan tabs

**Offer overview**

1.
1.

**Offer setup**

1.
1.

**Properties**

1.
1.

**Offer listing**

1.
1.

**Preview audience**

1.
1.

**Plan overview**

1.
1.

**Resell through CSPs**

1.
1.

**Technical configuration**

Leave this tab blank for now.

## Exercise: Review and Publish

In this short exercise you will check your work by performing the first action of the publication process. You will submit your offer for review to see if it is ready to be published.

1. In Partner Center, go to you offer in the **Marketplace offers** section.
2. Open your offer's overview page.
3. In the upper right corner of the page, click the link for **Review and publish**.
4. Looking to the right side of the page, notice that some sections have a green circle and at least one are gray. The gray sections are not yet complete, preventing you from taking the next step of publishing your offer.

> The **Technical configuration** section of the offer will not pass review. This is okay for now as we need to fill out the **Technical configuration** tab and you can't do that until we have a landing page.

5. Go back to all sections that appear with a gray circle and complete those sections.
6. Ensure all sections pass except **Technical configuration**, which will be addressed in the next lab.




