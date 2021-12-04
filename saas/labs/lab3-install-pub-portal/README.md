# Lab 3: Installing a Publisher Portal

This is a quick lab in which you will create one app registration and deploy a small website used by the publisher for activating customer subscriptions. After you have the new website installed, you will use the customer's landing page to request subscription activation and use the publisher portal to activate the subscription.

## Exercise: Create an app registration

In this exercise you will create a single-tenant app registration for the internal Publisher Portal application. This allows accounts you designate within your own tenant to access the application.

1. Log in to the Azure portal.
1. In the top-of-center command window in the portal, type "app reg" and select the item "App registrations" that appears. You will see a list of current app registrations.
1. At the top of the page, click the **+ New registration** link. You are taken to the **Register an application page**.
1. Use `saas-workshop-publisher` as the name of this app registration.
1. At the bottom of the page, click the **Register** button.

### Add a secret

Now you will add a secret to the app registration. Make sure to copy and paste the secret value somewhere you can access it later.

1. Click into the **saas-workshop-publisher** application registration.
1. In the left-hand menu, find the **Manage** menu and click the **Certificates and secrets** link.
1. Create a new client secret.
    1. Give it a description.
    1. Choose an expiration date. The 6-month default should be fine.
1. Copy the **Value** of the secret and paste it somewhere you can easily access it later.

## Exercise: Configure appsettings.json

Now you configure the `appsettings.json` file for the Publisher Portal application so you can publish it.

1. In VIsual Studio, open the `appsetting.json` file in the **PublisherPortal** project.


## Exercise: Install the minimalist Publisher Portal application

In this step, you will deploy and test the Publisher Portal application.

## Exercise: As a customer, request subscription activation

This exercise puts you in the place of the customer, and you will request your subscription be activated by the publisher.

## Exercise: As the publisher, activate the customer's subscription

This exercise puts you back in the role of the publisher, and you will activate the customer's subscription.
