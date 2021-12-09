# Lab 1: Creating a SaaS Offer in Partner Center

In this lab you will use your Partner Center account to create a **test** SaaS offer with a single plan. This offer will be used for development and testing purposes. This lab will familiarize you with Partner Center and prepare an offer you will publish in the next lab.

> **Completion of this lab is required for the following labs in the series to work properly.**

You will need the following to complete this lab.

1. A [Partner Center](https://partner.microsoft.com/en-us/dashboard) account
1. An Azure account and access to the [Azure portal](https://portal.azure.com/)

## Exercise: Create a New SaaS Offer

In this exercise, you will create a new SaaS offer in Partner Center and fill in the information needed to publish it.

### Create a new SaaS offer

1. From the Home page of [Partner Center](https://partner.microsoft.com/dashboard/home) click the **Commercial Marketplace** button.
1. Click the **+ New offer** button and at the dropdown and select **Software as a Service**.
1. Give your new offer an **Offer ID** and **Offer alias**. Although you are free to use whatever values you like, we will be using the following in this lab for reference.
    1. Offer ID: **saas-accelerator**
    1. Offer alias **SaaS Accelerator**

### Offer setup

Leave all information at the top of this page as is and scroll down to the **Customer leads** section of the page.

#### Customer leads

Here, you will attach your offer to an Azure Data Storage table which will act as a connected Customer Relationship Management system (CRM) for your offer.

#### Create the Azure Storage account

This is the first time you're using the Azure portal for this class. It is recommended that you install all the resources you'll create in this class into the same Resource Group, just to keep things tidy within your Azure subscription.

1. Open a new tab for the [Azure portal](https://portal.azure.com) and log in.
1. Create a Resource Group named **saas-accelerator**. Although you may use a different name, all labs will refer to the Resource Group with this name.
1. In the **saas-accelerator** Resource Group, create a standard Azure Storage account. This will be your CRM database, so name it accordingly to distinguish it from future storage accounts that will be created in this Resource Group.
1. Once the storage account is created, browse to the storage account's overview page.
1. In the left-hand menu, find the **Security + networking** section.
1. In that section, find and click on the **Access keys** link.
1. At the top of the page, click the **Show keys** link, and you see the connection strings for the database.
1. Copy a connection string to your copy/paste buffer.

#### Configure Customer Leads in Partner Center

1. Go back to the Partner Center tab in your browser.
1. Select the **Connect** link.
1. From the **Lead destination** dropdown, select **Azure Table**.
1. Enter your **Contact email** and paste in your **Storage account connection string**.
1. Click the **Validate** link to ensure your connection string is valid.
1. Click **Connect**.

For each page, you must click the **Save draft** at the bottom of the page to move on.

1. Click **Save draft** at the bottom of the page.

### Properties

Navigate to the **Properties** section.

#### Categories

You must select at least one category for your offer.

1. Click the **+ Categories** link.
1. In the left dropdown, select **Developer Tools**.
1. In the right dropdown, select **Developer Service**.

#### Legal

1. Scroll down to the **Legal** section.
1. Select **Use the Standard Contract for Microsoft’s commercial marketplace?** checkbox
1. Click **Accept**.
1. Click the **Save draft** button.

### Offer listing

1. In the the **Offer listing** section, for **Search results summary** enter **SaaS Workshop summary**.
1. For **Description**, here is some text you may choose to copy and paste into the text box.

    > Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

1. In **Getting started instructions** paste the following text.

    > Click the configure account button after the subscription is created.

1. In the **Privacy policy link**, enter the public link to the privacy policy for your company if you know it. If not, follow this link to [Microsoft's privacy policy](https://privacy.microsoft.com/privacystatement) and use that URL.
1. In the **Support contact** section, enter your contact information.
1. For the **Support link** field enter the support or homepage of your website.
1. For the **Engineering contact** section, enter your contact information.
1. for the **Supporting documents** section, upload the PDF document provided in the `items` directory of **lab1**. This document is named "**WellArchitectedFramework.pdf**."
1. You must give the document a name.
1. For the Marketplace media section you'll upload 2 images.
    1. For the **216X216 logo image,** upload the PNG provided in the `./items` directory of **lab1**. This PNG is named "**Contoso-Logo-216x216.png**."
    1. For the **1280X720** screenshot image, upload the PNG provided in the `./items` directory of **lab1**. This PNG is named "**Screenshots-1280x720.png**."
    1. Add a title to the screenshot image.
1. Click the **Save draft** button and correct any errors that be shown before moving on.

### Preview audience

1. In the **Preview audience** section, enter the email address you use for your Azure subscription. This is the email address you will use to purchase your offer later.
1. Enter a **Description**.
1. Click **Save draft**.

### Technical configuration

Skip this section for this first lab.

### Plan overview

In this section, you will create a single plan that costs $0. This plan will be used for testing purposes. The creation of this plan is covered in the next exercise.

## Exercise: Create a Plan

In this exercise, you will create a plan that costs $0 to purchase. This plan will be used to test the offer in later labs.

### Create the plan

1. Navigate to the **Plan overview** page.
1. At the top of the page click the **+ Create new plan** button.
1. Give the new plan a **Plan ID** and **Plan name**. These values can be whatever you like, but we will refer to them a follows throughout these labs.
    1. **Plan ID:** gold-plan-id
    1. **Plan name:** Gold Plan
1. Click the **Create** button and your new plan is created.

The Plan has several components to it, all of which must be completed.

### Plan Listing

1. The **Plan name** should read "Gold Plan."
1. The summary requires text to describe the plan. In this case, you may use the following placeholder text if you would like.

    > Lorem ipsum dolor sit amet, consectetur adipisci elit, sed eiusmod tempor incidunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur.
1. Click **Save draft**.

### Pricing and availability

**For Markets:**

1. Select the **Edit markets** link.
1. Choose at least one market within which to sell your plan. This will likely be the same country that hosts your Azure region.
1. Click **Save**.

**For pricing mode:**

1. Keep it **Flat rate**.
1. Leave **Billing term** as **Monthly**.
1. Enter 0 for the cost per month.
1. Leave the rest of the plan as is and click **Save draft**.

## Exercise: Resell through CSPs

1. Open the lef-hand menu item.
1. Select "No partners in the CSP program."
1. Click the **Save draft** button at the bottom of the screen.

## Exercise: Review and Publish

In this short exercise, you will check your work by performing the first action of the publication process. You will submit your offer for review to see if it is ready to be published.

1. Open your offer's overview page.
1. In the upper right corner of the page, click the link for **Review and publish**.
1. Looking to the right side of the page, notice that some sections have a green circle and at least one is gray. The gray sections are not yet complete, preventing you from taking the next step of publishing your offer.

    > The **Technical configuration** section of the offer will not pass review. This is okay for now as we need to fill out the **Technical configuration** tab and you can't do that until we have a landing page. All other sections should be green.

1. Go back to all sections that appear with a gray circle and complete those sections.
1. Ensure all sections pass except **Technical configuration**, which will be addressed in the next lab.

**Congratulation!** You have finished this lab.

If you are in a live class setting, please raise your hand in Microsoft Teams to indicate you are done with the lab.
