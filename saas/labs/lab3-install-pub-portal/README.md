# Lab 3: Installing a Publisher Portal

This is a quick lab in which you will create one app registration and deploy a small website used by the publisher for activating customer subscriptions. After you have the new website installed, the customer can use their landing page to request subscription activation and use the publisher portal to activate the subscription.

## Exercise: Create an app registration

In this exercise, you will create a single-tenant app registration for the internal Publisher Portal application. This allows accounts you designate within your own tenant to access the application.

1. Log in to the Azure portal.
1. In the top-of-center command window in the portal, type "app reg" and select the item "App registrations" that appears. You will see a list of current app registrations.
1. At the top of the page, click the **+ New registration** link. You are taken to the **Register an application page**.
1. Use `saas-workshop-publisher` as the name of this app registration.
1. At the bottom of the page, click the **Register** button.

## Add a secret

Now you will add a secret to the app registration. Make sure to copy and paste the secret value somewhere you can access it later.

1. Click into the **saas-workshop-publisher** application registration.
1. In the left-hand menu, find the **Manage** menu and click the **Certificates and secrets** link.
1. Create a new client secret.
    1. Give it a description.
    1. Choose an expiration date. The 6-month default should be fine.
1. Copy the **Value** of the secret and paste it somewhere you can easily access it later.

## Exercise: Configure appsettings.json

Now you configure the `appsettings.json` file for the Publisher Portal application so you can publish it.

### AzureAD section

1. In Visual Studio, open the `appsetting.json` file in the **PublisherPortal** project.
1. Replace `YOUR_DOMAIN` with the same value you use in the `appsettings.json` file for the LandingPage project.
1. Replace `TENANT_ID` with the Tenant ID of the tenant you are working in. To find the Tenant ID, do the following.
    1. Type **Tenant** into the command bar at the top of the Azure portal and select **Tenant properties**.
    1. Find the **Tenant ID** field and copy the value into the `appsettings.json` file.
1. Replace `CLIENT_ID` with the **Application (client) ID** of the app registration you created in the above exercise.
1. Replace `CLIENT_SECRET` with the secret you created in the above exercise.

### MarketplaceApi section

For the `MarketplaceApi` section, you may copy and paste the section from the LandingPage project's `appsettings.json` file. It is an exact copy.

## Exercise: Create an App Service and publish profile for the Publisher Portal application

In this section, you'll create an App Service for your new portal so you can publish it in the next step.

1. Right click the project in Visual Studio and select **Publish**.
1. Select **Azure** as your target and then click the **Next** button.
1. Select **Azure App Service (Windows)** and then click the **Next** button.
1. Click the green **+** button to create a new App Service and the App Service creation dialog appears.
1. Enter **SaaSWorkshopPublisherPortal** with a number suffix as the name of the app service.
1. Set the Resource Group to `saas-workshop`.
1. Set the App service plan to the one you created earlier, likely named **SaaSWorkshopAppServicePlan**.
1. Click the **Create** button to create the App Service and be taken back to the Publish dialog.
1. Select your new App Service instance.
1. Click the **Next** button.
1. Select the **Publish** option to create a publish profile.
1. Click the **Finish** button.

## Exercise: Publish the Publisher Portal application

Now that you are back to the publish dialog, just click the Publish button in the upper-right of the page to publish your website.

This may take a few moments for the site to publish. You can monitor publish progress in Visual Studio's output window.

> The page will launch, but shows an error message. You aren't quite done configuring the publisher portal application.

### Update the application registration

1. In the command bar at the top of the Azure portal, search for and select **App Services**.
1. Click on the App Service you've just created, **SaaSWorkshopPublisherPortal** with a number suffix.
1. On the overview screen in Visual Studio, the **URL** for the site should be in the **Hosting** section. Copy it into your paste buffer.
1. In the command bar at the top of the Azure portal, search for and select **App registrations**.
1. Click on the `saas-workshop-publisher` app registration.
1. In the left-hand menu click the **Authentication** link.
1. In the **Web > Redirect URIs** section, click **Add URI** and paste in your publisher portal application URL.
1. Paste it in again on another line, this time adding a suffix of `/signin-oidc` so that your URI looks something like this.

    > https://*.azurewebsites.net/signin-oidc

Click the **Save** button at the top of the screen.
Using the App Service URL `https://<prefix>.azurewebsites.net`, browse to that web page
After authenticating you will see all the subscriptions to your offers. If you completed Lab 2, there should be at least one purchased subscription.

If you haven't completed Lab 2 by subscribing to your offer, please go do so now.

## Exercise: As a customer, request subscription activation

This exercise puts you in the place of the customer, and you will request your subscription be activated by the publisher.

1. In the command text box at the top of the Azure portal, type "SaaS" and select **SaaS** from the dropdown. This takes you to the SaaS management page where you can monitor and manage all your SaaS offers.
1. Click the SaaS offer you subscribed to in Lab 2. Note that it is the `Pending Configuration` state. The publisher has not provisioned your account yet.
1. Click the **Configure account now** button. This takes you to the offer's landing page.
1. Under the **Available Customer Actions** section, click the link for **Notify publisher to activate account**. This emulates sending a notice to your publisher that you want to activate your subscription.

## Exercise: As the publisher, activate the customer's subscription

This exercise puts you back in the role of the publisher, and you will activate the customer's subscription.

1. Open the publisher portal website.
1. Find and click on the subscription that needs to be activated.
1. Notice the **SaasSubscriptionStatus** field is in the `PendingFulfillmentStart` state.
1. Scroll down to the **Publisher Actions** section.
1. Click the **Activate this subscription** link.
1. Notice the status immediately changes to **Subscribed**.

## Exercise: See the activation on the client side

1. Go back to the landing page for the offer and note the **Subscription State** now equals `Subscribed`.
1. Go back to the SaaS management screen and find your subscription. It likely still reads `Pending configuration`.
1. This page caches the state of the subscriptions and updates every few minutes. Try refreshing the page occasionally until it reads `Subscribed`.

**Congratulations!** You have finished this lab.

If you are in a live class setting, please raise your hand in Microsoft Teams to indicate you are done with the lab.


