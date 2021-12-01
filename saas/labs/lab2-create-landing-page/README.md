> **This lab is incomplete and in active development. It is not ready for use at this time.**

# Lab 2: Create a Landing Page

In this lab you will build on what you accomplished in [Lab 1: Creating a SaaS Offer in Partner Center](../lab1-create-pc-offer/README.md). You will create a landing page and integrate it with your Partner Center SaaS Offer, enabling publishing of the offer and purchasing the offer in the **Preview** stage of the publication pipeline.

For this lab you will need the following.

1. An offer configured in [Partner Center](https://partner.microsoft.com/en-us/dashboard) as per Lab 1
1. An Azure account and access to the [Azure portal](https://portal.azure.com/)
1. Visual Studio 2022 (any version)
1. Git (optional)

> **Note:** It is possible to complete this using Visual Studio Code, but the instructions will be tailored for using Visual Studio 2022.

## Exercise: Compile the Visual Studio Solution

In this exercise you'll get all the code needed for your SaaS solution and build it. This will ensure you have everything downloaded properly and are working in the right place.

1. Clone this repository or download a ZIP file of it's contents and UNZIP them on your machine.

    https://github.com/microsoft/Mastering-the-Marketplace

2. Using Visual Studio 2022 open the following solution file on your machine. Take care to choose the **begin** folder.

    `**\saas\labs\lab-code\begin\SaaSLabsBegin.sln`

3. Build the solution. You should get no build errors.

There are currently three projects in the solution. We will deal with them one at a time over the course of the labs. In this lab, we will start with the landing page project.

## Exercise: Deploy the Landing Page

- Walk through Visual Studio Azure publishing wizard
- Deploy to new web app and service plan
- Store landing page URL
- Fill out `appsettings.json`

## Exercise: Create Application Registrations

In this exercise, you will create two application registrations. One will be single-tenant and used to connect to the SaaS API. The other will be multi-tenant and be used to authenticate users coming to your Landing Page.

### Create a single-tenant Application Registration

1. Log in to the Azure portal.
1. In the top-of-center command window in the portal, type "app reg" and select the item "App registrations" that appears. You will see a list of current application registrations.
1. At the top of the page click the **+ New registration** link. You are taken to the **Register an application page**.
1. You must provide a name for your application registration. For the purposes of this lab, use `saas-workshop-single-tenant` as the name of this app registration.
1. At the bottom of the page, click the **Register** button.

#### Add a secret

Here you will add a secret to the app registration. Make sure to copy and paste the secret somewhere you can access it later.

1. Click into the **saas-workshop-single-tenant** application registration.
1. In the lef-hand menu, find the Manage menu and click the **Certificates and secrets** link.
1. Create a new new client secret.
    1. Give it a description.
    1. CHoose an expiration date. The 6-month default should be fine.
1. Copy the **Value** of the secret and paste it somewhere you can easily access it later.

### Create a multi-tenant Application Registration

1. In the top-of-center command window in the portal, type "app reg" and select the item "App registrations" that appears. You will see a list of current application registrations.
1. At the top of the page click the **+ New registration** link. You are taken to the **Register an application page**.
1. You must provide a name for your application registration. For the purposes of this lab, use `saas-workshop-multi-tenant` as the name of this app registration.
1. Under **Supported account types**, select the option: **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**.
1. At the bottom of the page, click the **Register** button.

#### Add a platform to the app registration

1. Under the **Platform configurations** section, click the **+ Add a platform** link.
1. Select **Web**.
1. __PICK UP HERE__

## Exercise: Run the Landing Page Project Locally and Make Updates

This exercise will take you through some code changes needed to make the Landing Page application work properly. You will use the client library package `Marketplace.SaaS.Client`, [available here](https://www.nuget.org/packages/Marketplace.SaaS.Client) in the NuGet.org repository. 

1.
1.
1.

## Exercise: Redeploy the Code to See Your Changes

Using the Publish Profile you created earlier when deploying the Landing Page, you will re-deploy the application and see your changes working in the Landing Page.

1.
1.
1.

## Exercise: Update Your Offer in Partner Center and Publish It

Now that you have deployed your application, you can configure the **Technical configuration** in Partner Center.

1. Open your offer in Partner Center
1. Navigate to the **Technical configuration** tab
1.
1.
1.


> Publishing your offer will take some time. Hopefully your offer will be published to the preview stage by the end of the next lecture. Wait to purchase your offer until it is in preview as shown below. 
> To check your offers' publication status, go to the offer's **Overview** page. Look for links under the **Publisher signoff** section as shown below.

![Offer Overview](../lab-images/01.png)

Refresh the **Overview** page to get updates on your offer in the publication pipeline.

## Exercise: Buy Your Offer and Check Your Landing Page

After the offer is in preview stage in Partner Center, you may purchase it. After the initial purchase, you will then go to the landing page for the offer.

1.
1.
1.