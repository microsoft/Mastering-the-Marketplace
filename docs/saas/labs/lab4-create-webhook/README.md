---
hide:
  - navigation
search:
    exclude: true
---

# Lab 4 - Deploying and Monitoring a Webhook

👈 [Back to SaaS Offer labs](../../index.md#labs)

⚠️ Completion of this lab is required for the following labs in the series to work properly.

> 💀 The code in this lab is **NOT** meant to be used for production environments. It is a simple example with no error handling, no custom workflows, and is for learning purposes only.

## Overview

In this lab, you will build on what you accomplished in previous labs. You will create a SaaS offer webhook and integrate it with your Partner Center SaaS offer configuration, enabling your webhook to respond to subscription change events.

The webhook in your Visual Studio solution is an Azure Function. There is no need to change the code in the webhook function at this time.

Looking through the webhook code you'll find that it simply prints the REST payload to the log. You will monitor this log to see the payload when the webhook is called.

## Exercise: Create a Publish Profile

1. In Visual Studio, right click the `SaaSFunctions` project and select **Publish**. 
1. For the target, select **Azure** and click **Next**.
1. Select **Azure Function App (Windows)** and click **Next**.
1. Select the right subscription in the dropdown.
1. To publish, you will need to create a new Function App. Above and to the right of the Function Apps tree at the bottom of the dialog, click the **+** button to add a new Function App.
1. In the **Name** field, enter `SaaSWorkshopFunction` followed by a number to make it a unique name.
1. Select the right subscription.
1. Select the `saas-workshop`` Resource Group.
1. Stick with **Plan Type:** Consumption.
1. Function Apps require the use of a Data Storage account. To the right of the **Azure Storage** field is a **New...** link. Click it.
1. On the Azure storage dialog, click the **OK** button.
1. Back on the **Function App (windows)** dialog, click the **Create** button.

    > The App Service deployment will run for a little while.

1. On the Publish dialog, click the **Next** button.
1. On Select the **Publish** option and click the **Finish** button.

You have create an App Service, App Service Plan, storage account, and a publish profile. Now you will use the purlish profile to publish the function application itself.

## Exercise: Publish the Function App

At the top right of the publish screen, click the **Publish** button. 

It will take a moment to publish the function application. You can watch progress in Visual Studio's Output window.

## Exercise: Getting the webhook URI

You need the webhook URI to add to your **Technical Configuration** in Partner Center. The Function Application contains only one function and you need the URI of that one function.

1. Open the Azure portal.
1. Find and click on the Azure function in the Azure portal. It is inside your `saas-workshop` resource group.
1. In the left-hand menu find the **Functions** link and click it.
1. You see a single function named `Webhook`. Click that function.
1. Near the top of the screen, click **Get Function URL** and you are presented with a dialog.
1. Copy the full path to this function into your copy/paste buffer.

## Exercise: Publishing the webhook in Partner Center

Now you will re-publish your offer, this time with a valid webhook URL.

1. In Partner Center, on the **Technical configuration** tab, find the **Connection webhook** field.
1. Replace the previous value for the **Connection webhook** with the URL of the function application
1. Click **Save Draft**.
1. **Review and publish** your offer. It should pass validation (all sections are green) so you can publish.
1. Click the **Publish** button.

> The offer must be in the Partner Center's preview stage for the final exercise of this lab to work. At no point should you click the **Go live** button.

## Publication Time

This is where you must wait for your offer to be re-published. Of course, there is a waiting period for the offer to be re-published. The good news is that it is usually much faster after the first time.

> **Note:** If you are in a live workshop event, please raise your hand in Microsoft Teams to indicate you are done with the lab to this point. You will be coming back to finish the rest of the lab later, perhaps on your own after the workshop.

## Exercise: Preparing to monitor the function's log

To see the function's output, we will monitor its log on Azure to see the output it will print to the log. Application Insights must be enabled on the function to support this.

1. Open Azure portal and find the Function App. Click it.
1. Scroll down in the left-hand menu until you find the **Monitoring** section.
1. In the **Monitoring** section, find the **Log stream** link and click it. You are presented with a message to configure Application Insights.
1. Click the **Configure** button.
1. Under **Create new resource** enter `SaaSWorkshopFunction-ai`.
1. Choose an appropriate location.
1. Click the **OK** button at the bottom of the screen. Application insights will install.
1. In the upper breadcrumb navigation, click the function **SaaSWorkshopFunction** which takes you back to the Log monitoring screen.
1. This should open what looks like a terminal window and you will see "Connected!" at the top of the window.

You are now watching the function application's log. There will be occasional keep-alive calls to the function that can be ignored. You can click the **Clear** button at the top of the screen to clear the text at ay time.

## Exercise: Invoking the Webhook

In a previous lab, you purchased a SaaS offer. That offer is in the `Subscribed` state, so the customer can unsubscribe from the offer. That's what you will do to invoke the webhook and see it's output.

### Unsubscribe from the offer

1. Open a new tab to the Azure portal.
1. In the command bar at the top type **SaaS** and click the **SaaS** service that is appears.
1. Find the offer you purchased earlier and click it.
1. At the top of the page, click and confirm **Cancel subscription**. Fill in the required information to unsubscribe from the offer.
1. Click the **Cancel subscription** button. You will get a message in the upper right of your window stating that cancellation of the subscription is in progress.

### See the Unsubscribe event

Go back to your function's Log tab. You will likely have time to hit the **Clear** button to clear the screen.

> It can take a few minutes for the **Unsubscribe** event to invoke the webhook.

Don't forget that your offer must be in the **Publisher signoff** stage for the webhook to be fully published so it will be invoked.

Just wait for the Unsubscribe event to show up in the Log window and print the payload to the screen.

## Extra: Running the entire SaaS subscription workflow

You now have all the elements in place needed to manage a SaaS offer subscription purchase. To exercise all steps of the process you can do the following.

🗒️ You do not need to complete the following steps to consider this lab complete. 

1. Purchase the SaaS offer either through Partner Center or as a private offer in the Azure Portal.
1. Go to the landing page to activate the subscription.
1. Use the Publisher Portal to activate the subscription, changing its state to **Subscribed**.
1. **Cancel the subscription** from the **Subscribed** subscription through the SaaS management tool in the Azure portal.
1. Watch the webhook function get called with the full payload of the unsubscribed event.

---

**Congratulation!** You have finished this lab.

👈 [Back to SaaS Offer labs](../../index.md#labs)