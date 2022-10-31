---
# Page settings
layout: default
keywords: Azure Marketplace Container Offer Mastering the Marketplace
comments: false

# Micro navigation
micro_nav: false

title: Lab 3

hide:
- navigation
---

[Home](../../../) > [Container Offers](../../) > [Labs](../../index.md#labs) 🧪

# Lab 3 - Publishing the Container Offer

> **Note:** This lab is part of a series of labs for Mastering Container Offers Workshop. You must finish this lab before moving on to the next sections.

In this lab, you will complete the rest of the required setup on Partner Center to publish your offer. The only section that should need completion in Partner Center is Plan Overview. If you have any other sections pending completion, please complete them before moving on to this lab.

<!-- no toc -->
- [Create a new Container Offer](#create-a-new-container-offer)
- [Review and Publish](#review-and-publish)
- [Create a plan on Partner center](#create-a-plan-on-partner-center)
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

The Offer Setup page allows changing your offer alias as well as as other functions. For the purpose of this lab, we will leave everything as is and only configure the **Setup details**.

### Setup details

1. Under **Setup details** check **Yes, I would like to sell through Microsoft and have Microsoft host transactions on my behalf**.
2. Click **Save draft**.

### Properties

Navigate to the **Properties** tab on the left.

#### Categories

You must select at least one category for your offer. Container offers always appear under the Compute category in Azure Marketplace.

1. Click the **+ Categories** link.
1. In the left dropdown, select **Containers**.
1. In the right dropdown, select **Kubernetes App**.

#### Leg al

You will use the Microsoft Standard Contract for this lab. You may choose differently when you are publishing to a production environment.

1. Scroll down to the **Legal** section.
2. Select "Use the Standard Contract for Microsoft’s commercial marketplace?" checkbox
3. Click **Accept**.
4. Click the **Save draft** button.

### Offer listing

Navigate to the **Offer listing** page in the left hand menu.

1. In the the **Search results summary** section, enter some text. Here is some text you may copy and paste for this purpose.

        Quis aute iure reprehenderit in voluptate ...

2. For **Short Description** and **Description** sections, here is some text you may choose to copy and paste into the text boxes.

        Quis aute iure reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint obcaecat cupiditat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.

3. Somewhere in the description, add teh phrase "Kubernetes app."

    > 🗒️ This ensures the offer shows up in the correct search results.

4. In the **Privacy policy link**, enter the public link to the privacy policy for your company if you know it. If not, use the following link.

        https://privacy.microsoft.com/privacystatement

    > ⚠️ Please note that using Microsoft's privacy policy is only for the purpose of this lab and should not be used for your production offer.

5. In the **Support Contact** section, enter your contact information.
6. In the **Engineering Contact** section, enter your engineering contact information.
7. For the Marketplace media section you'll upload 2 images.
    1. For the **216x216** logo image, upload the PNG provided in the `./images` directory of **lab1**. This PNG is named "[Contoso-Logo-216x216.png](./images/Contoso-Logo-216x216.png)."
    2. For the **1280x720** screenshot image, upload the PNG provided in the `./images` directory of **lab1**. This PNG is named "[Screenshots-1280x720.png](./images/Screenshots-1280x720.png)."
    3. Add a screenshot image caption.
8. Click the **Save draft** button and correct any errors that be shown before moving on.

### Preview audience

The preview audience specifies the subscriptions that will be able to test the offer before it goes, when it is in the **Preview** state. Everyone using the subscription will be able to purchasae the offer when in Preview (test) mode.

1. In the **Preview audience** section, enter your Azure subscription Id.
1. Enter a **Description** (Optional).
1. Click **Save draft**.


### Plan overview
1. Select the **Plan overview** section and click on **New Plan**. 
1. Give your plan a unique `Plan Id` and `Plan name` and click Create.

### Plan listing

1. Open the **Plan listing** .
2. You can edit the plan name if you wish.
3. Fill in the **Plan summary**. Add relevant text here as your plan summary.
4. Fill in the **Plan description**. Add relevant text here as your plan description.
5. Click **Save Draft**.

### Pricing and availability

1. Open the **Pricing and availability** tab.
1. For the **Edit Market** section, select at least one market in which to sell your product. This is typically the United States.
1. Under **Pricing**  select  **Custom price**.
1. Select **Per Core** and enter price as **0** USD/hour. For this workshop, you don't want to charge your account when testing.
1. Click **Save Draft**.

### Technical configuration

1. Go to the **Technical Configuration** tab. 
2. For the Cluster extension type, enter `**YOUR-COMPANY-NAME**.AzureTodoApp'.
3. Click the **Add CNAB Bundle** link and the **Azure Container Registry** dialog appears.

      ![Add CNAB Bundle](./images/plan.png)

4. Select your ACR as **Registry**.
5. For **Repo** select `com.nonmicrosoft.azuretodoapptest`.
6. For **CNAB Bundle**, select the `1.0.0` version you published earlier.
7. Click **Add CNAB Bundle**.
8. Click **Save draft**.

## Review and Publish

Finally click the **Review and publish** button. 

You should now see green checkmarks against all the sections and you are now ready to publish. Click on **Publish** at the bottom to start the publishing process.

> **Note:** It will take a while for the offer to publish ETA 2 days due to certification process.


**Congratulations!** You have now finished this lab.

[Continue to Lab 4](../lab4-purchasing-container-offer/index.md)