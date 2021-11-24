> **This lab is incomplete and in active development. It is not ready for use at this time.**

# Lab 3: Creating a Webhook

In this lab you will build on what you accomplished in [Lab 2: Creating a Landing Page](../lab2-create-landing-page/README.md). You will create a SaaS offer webhook and integrate it with your Partner Center SaaS offer, enabling publishing of the offer and purchasing the offer in the **Preview** stage of the publication pipeline.

The webhook in your Visual Studio solution is an Azure Function. There is no need to change the code in the webhook function at this time.

Looking through the webhook code you'll find that it simply prints the REST payload to the log. You will monitor this log to see the payload when the webhook is called.


## Exercise: Deploy the Azure Function Webhook

1. In Visual Studio, right click the `SaaSFunctions` project and select **Publish**. You may need to log in on the resulting screen.
1. In the top left of the **Publish** screen, click **+ New**. A publication wizard pops up.
1. For the target, select **Azure** and click **Next**.
1. Select **Azure Function App (Windows)** and click **Next**.
1. Select the right subscription in the dropdown.
1. To publish, you will need to create a new Function App. Above and to the right of the Function Apps tree at the bottom of the dialog, click the **+** button to add a new Function App.
1. In the **Name** field, accept the default.
1. Select the right subscription.
1. Select the same Resource Group you used to deploy your landing page.
1. Stick with **Plan Type:** Consumption.
1. Function Apps require the use of a Data Storage account. To the right of the **Azure Storage** field is a **New...** link. Click it.
1. On the Azure storage dialog, click the **OK** button.
1. Back on the **Function App (windows)** dialog, click the **Create** button.

> The deployment will run for a little while.

1. On the Publish dialog, click the **Next** button.
1. On Select the **Publish** option and click the **Finish** button.

> This has created the App service and a publish profile. 

## Exercise: Publishing the Webhook in Partner Center

Now you will re-publish your offer, this time with a valid webhook URL.

1. In partner Center, open the **Technical configuration** tab for your offer in your browser.
1. In another browser tab, open the Azure portal.
1. Find and click on the Azure function in the Azure portal.
1. In the left-hand menu find the Functions link and click it.
1. You see a single function named `Webhook`. Click that function.
1. Near the top of the screen, click **Get Function URL** and you are presented with a dialog.
1. Copy the full path to this function into your copy/paste buffer.
1. In Partner Center, on the **Technical configuration** tab, find the **Connection webhook** field.
1. Replace the previous value for the **Connection webhook** with the URL of the function application
1. Click **Save Draft**.
1. **Review an publish** your offer. It should pass validation (all sections are green) so you can publish.

> At no point should you click the **Go live** button.

Of course, there is a waiting period for the offer to be re-published. The good news is that it is usually much faster after the first time.

## Exercise: Monitoring the Function's Log

To see the function's output, we will monitor its log on Azure to see the output it will print to the log.

1. Open a new tab to the Azure portal.
1. Find the Function App and click it.
1. Scroll down in the left-hand menu until you find the **Monitoring** section.
1. In the **Monitoring** section, find the **Log stream** link and click it.
1. This should open what looks like a terminal window and you will see "Connected!" at the top of the window.

You are now watching the function application's log. There will be occasional keep-alive calls to the function that can be ignored. You can click the **Clear** button at the top of the screen to clear the text.

## Exercise: Invoking the Webhook

In a previous lab, you purchased a SaaS offer. That offer should still be in the `PendingFulfillment` state, so the customer can unsubscribe from the offer. That's what you will emulate to invoke the webhook and see it's output.

1. Open the Azure portal.
1. In the command bar at the top type "SaaS" and click the SaaS service that is found.
1. Find the offer you purchased earlier and click it.
1. At the top of the page, click and confirm **Cancel subscription**. You will get a message stating that cancellation of the subscription is in progress.