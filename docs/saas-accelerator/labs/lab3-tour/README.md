---
hide:
  - navigation
---

# Lab 3 - Using the SaaS Accelerator

👈 [Back to SaaS Offer labs](../../index.md#labs)

⚠️ Completion of the previous labs in this course is required for this lab to work.

## Overview

In this lab, you will familiarize you with the SaaS Accelerator, both from the customer and publisher points of view. The goal is to become comfortable with the SaaS Accelerator's landing page and publisher portal, so you (as a publisher) can monitor and manage your SaaS offer subscriptions.

## Exercise: Customer purchase 1

As a customer, you will be purchasing the offer. Here, you will do so from within Partner Center. You can do this from the **Overview** page of your offer under the **Publisher signoff** stage.

1. Open Partner Center to your offer's **Overview** page.
1. Find the link under the **Publisher signoff** stage.
1. Click the **Azure portal preview** link. A new tab opens in your browser.
1. Login if prompted.
1. Click the **Set up + subscribe** button.
1. Create a new resource group named `saas-accelerator-purchases`.
1. Under **SaaS details**, name your subscription `Subscription01`.
1. Click the **Review + subscribe** button at the bottom of the page.
1. Click the **Subscribe** button at the bottom of the page.

The SaaS subscription is created. This may take a minute or two. Once the SaaS subscription has been created, you can move on to the following steps.

## Exercise: The first landing page

In this exercise, you will visit the offer's landing page, provided by the SaaS Accelerator.

1. Click the **Configure account now** button.
1. Login and allow the read permissions. This is Azure AD SSO asking for your permission to read account details.
1. Click **Accept** to allow the application access to your basic account information.
1. You should now see a page with your subscription details on it.

    > Note that **Status** is currently `PendingFulfillmentStart`.

1. In the lower right corner, click the activate button.

### The landing page as a subscription tracker

Remember you are acting in the role of the customer. Perhaps you have more than one subscription with this publisher.

1. Click the **Go to subscriptions** list button in the lower right corner.
1. You have one subscription `PendingActivation` by the publisher.

## Exercise: Customer purchase 2

As a customer, you will be purchasing the offer. Here, you will do so from within the Azure portal as you would in a typical buying experience.

1. Open the Azure portal.
1. In the left menu, click the bit **+ Create a resource** link.
1. Under the search text box, click the **See more in Marketplace** link.
1. At the top of the screen, you'll see the text, **You have private products available. View private products**. Click the **View private products** link.
1. Find the **SaaS Accelerator 1** offer and click it.
1. Click the **Set up + subscribe** button.
1. Select the resource group you created earlier, `saas-accelerator-purchases`.
1. Under **SaaS details**, name your subscription `Subscription02`.
1. Click the **Review + subscribe** button at the bottom of the page.
1. Click the **Subscribe** button at the bottom of the page.

The SaaS subscription is being created. This may take a minute or two. Once the SaaS subscription has been created, you can move on to the following steps.

## Exercise: The second landing page

In this exercise, you will visit the offer's landing page, provided by the SaaS Accelerator.

1. Click the **Configure account now** button and log in if needed.
1. Click the **Activate** button.
1. Click the **Go to subscriptions** list button in the lower right corner.
1. You have two subscriptions, one in `PendingActivation` and another in `PendingFulfillmentStart`.

## Exercise: The publisher activates a subscription

Now you are going to the play the role of the publisher and activate the customer's subscriptions.

### The publisher portal

1. In the SaaS Accelerator's resource group, find the App service for the landing page and click it. It is the one named **PREFIX-admin**.
1. In the upper right corner is the URL of the web app. Click the URL.
1. You should be taken to a web page and receive no errors. If you are prompted to log in, do so.
1. Click the **Subscriptions** tile. You can see the two subscriptions awaiting activation.
1. For the `Subscription01` subscription, click the menu under **Action** and select **Activate**.
1. Note the status.
1. Click the **Activate** button.
1. Click the **Go to the subscription list** button and see the new state of the subscription.

## Explore for a few minutes

We encourage you to explore for a few minutes to play with the other capabilities of the SaaS Accelerator. First, there is the landing page, which also provides subscription visibility for the subscriber. Then there is the publisher portal, which allows monitoring and management of subscriptions.

Here are some things you might try.

- Look at the status of each subscription via its landing page. Get there from the SaaS blade in the Azure portal.
- Cancel, or **Unsubscribe**, a subscription from within the publisher portal.
- Look at the other ways to navigate the publisher portal and see subscriptions and offers.

---

**Congratulation!** You have finished this lab.

👈 [Back to SaaS Offer labs](../../index.md#labs)