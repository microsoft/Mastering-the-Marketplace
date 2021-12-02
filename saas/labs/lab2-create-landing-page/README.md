> **This lab is incomplete and in active development. It is not ready for use at this time.**

# Lab 2: Create a Landing Page

In this lab you will build on what you accomplished in [Lab 1: Creating a SaaS Offer in Partner Center](../lab1-create-pc-offer/README.md). You will create a landing page and integrate it with your Partner Center SaaS Offer, enabling publishing of the offer and purchasing the offer in the **Preview** stage of the publication pipeline.

For this lab you will need the following.

1. An offer configured in [Partner Center](https://partner.microsoft.com/en-us/dashboard) as per Lab 1
1. An Azure account and access to the [Azure portal](https://portal.azure.com/)
1. Visual Studio 2022 or 2019 (any version)
1. Git (optional)

> **Note:** It is possible to complete this using Visual Studio Code, but the instructions will be tailored for using Visual Studio 2022.

## Exercise: Compile the Visual Studio Solution

In this exercise you'll get all the code needed for your SaaS solution and build it. This will ensure you have everything downloaded properly and are working in the right place.

There are three projects in the solution. We will deal with them one at a time over the course of the labs. In this lab, we will start with the landing page project.

1. Clone this repository or download a ZIP file of it's contents and UNZIP them on your machine.

    https://github.com/microsoft/Mastering-the-Marketplace

2. Using Visual Studio 2022 open the following solution file on your machine. Take care to choose the **begin** folder.

    `**\Mastering-the-Marketplace\saas\labs\lab-code\begin\SaaSLabsBegin.sln`

3. Build the solution. You should get no build errors.

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

1. Register another app registration. For the purposes of this lab, use `saas-workshop-multi-tenant` as the name of this app registration.
1. Under **Supported account types**, select the option: **Accounts in any organizational directory (Any Azure AD directory - Multitenant)**.
1. At the bottom of the page, click the **Register** button.

#### Add a platform to the multi-tenant app registration

1. In the left-hand enu under the **Overview** menu item click the **Quickstart** link.
1. Find the **Web application** section and click the **Start** button.
1. Click **ASP.NET Core**.
1. On the Quickstart page, click the **Make this change for me** button.
1. Under the **Configuring your application registration** click the **Make updates** button.
1. In the left-hand menu under the **Manage** section, click the **Authentication** link.
    > Here you can see that 2 URLS have been added to the the Redirect URIs section for you. These allow running your code in Visual Studio using the default debugger ports.

#### Create a client secret

1. Create a a client secret for this app registration.
1. Store is somewhere you can access it later.

## Exercise: appsettings.json

The `appsettings.json` file must be filled out before publishing the application. That's what you'll do in this section.

1. In the Landing Page project, open the `appsettings.json` file.
1. In the Azure portal click the **Azure Active Directory** button in the left-hand menu.
1. On the overview page, find the the **Primary domain** and replace `DOMAIN_NAME"` with the Primary domain from this screen.

### The saas-workshop-multi-tenant app registration

All changes in this section occur under the `AzureAD` section of the `appsettings.json` file.

1. In the left-hand menu under the **Manage** menu, click the **App registrations** link.
1. Click the `saas-workshop-multi-tenant` app registration.
1. In the `appsetting.json` file, replace `CLIENT_ID` with the **Application (client) ID** from this screen.

HERE

### The saas-workshop-single-tenant app registration

All changes in this section occur under the `MarketplaceAPI` section of the `appsettings.json` file.

1. in the left-hand menu under the **Manage** menu, click the **App registrations** link.
1. Click the `saas-workshop-single-tenant` app registration.
1. In the `appsetting.json` file, replace `CLIENT_ID` with the **Application (client) ID** from this screen.
1. In the `appsetting.json` file, replace `CLIENT_SECRET` with the client secret value you stored before. If you didn't do that part, you may create and use a new secret now.
1. In the `appsetting.json` file, replace `TENANT_ID` with the **Directory (tenant) ID** from this screen.

Congratulations, your `appsettings.json` file is ready to publish.

## Publishing your landing page

1. In the Solution Explorer of VIsual Studio, right click the LandingPage project and select **Publish**.
1. Select **Azure** as your publish target and click the **Next** button.
1. Select **Azure App Service (Windows)** for your Specific target and click the **Next** button.
1. Ensure you are signed in to Visual Studio with your Azure credentials.
1. To the far right of the words ""App Service Instances" click the **+ button**.
1. Use the name `LandingPage-as`.
1. On the next screen, select the correct subscription.
1. Choose the resource group you created earlier, `saas-workshop`.
1. Create a new **Hosting Plan** by select the **New** link to the far right. Accept the default name.
1. Set the location to be the same as the resource group you created earlier.
1. Click the **OK** button at the bottom of the dialog.
1. Click the **Create** button at the bottom of the resulting dialog.
1. In the resulting **Publish** dialog, select the App Service instance you just created.
1. Click the **Next** button at the bottom of the dialog.
1. For Publish type, select **Publish (generate pubxmlfile)**.
1. Click the **Finish** button at the bottom of the dialog.

    > This make take a moment to run as your application is being deployed to Azure.

1. In the command bar at the top of the Azure portal, search for and select **App Services**.
1. Click on the App Service you just created.
1. On the top right of the overview screen is the URL for the site. Copy it into your paste buffer.
1. In the command bar at the top pf the Azure portal, search for a select **App registrations**.
1. Click on the `saas-workshop-multi-tenant` app registration.
1. In the left-hand menu click the **Authentication** link.
1. In the **Web > Redirect URIs** section, click Add URI and paste in your Landing Page URL.
1. Paste it in again, this time adding a suffix of "/signin-oidc" so that your URI looks something like this.

    > https://*.azurewebsites.net/signin-oidc

Click the **Save** button at the bottom of the screen.




## Exercise: Make local changes to the landing page

Now you need to make some changes to the Landing Page project to deploy it with this new app registration.

This exercise will take you through some code changes needed to make the Landing Page application work properly. You will use the client library package `Marketplace.SaaS.Client`, [available here](https://www.nuget.org/packages/Marketplace.SaaS.Client) in the NuGet.org repository.

Open the Visual Studio solution file in Visual Studio from the `...\Mastering-the-Marketplace\saas\labs\lab-code\begin\` directory.

### Startup.cs

1. In `Startup.cs` find the function `ConfigureServices(IServiceCollection services)`.
1. In that funtion, place the following code at the top.

```csharp
    // Configure AAD and Graph integration
    // This enables SSO for AAD and access to the user's graph information
    services.AddMicrosoftIdentityWebAppAuthentication(this.Configuration) // Sign on with AAD
            .EnableTokenAcquisitionToCallDownstreamApi(new string[] { "user.read" }) // Call Graph API
            .AddMicrosoftGraph() // Use defaults with Graph V1
            .AddInMemoryTokenCaches(); // Add token caching
```

1. Using NuGet, install the package `Marketplace.SaaS.Client`.
1. In `Startup.cs` find the function `ConfigureMarketplaceServices(IServiceCollection services)`.
1. Add the following code to the function.

```csharp
    // get needed arguments from the Configuration in appsettings.json
    // or in the configuration settings in the Web Application
    var tenantId = Configuration["MarketplaceApi:TenantId"];
    var clientId = Configuration["MarketplaceApi:ClientId"];
    var clientSecret = Configuration["MarketplaceApi:ClientSecret"];

    // get standard Azure creds
    var creds = new ClientSecretCredential(tenantId, clientId, clientSecret);

    // register a MarketplaceSaaaSClient so it can be injected
    services.TryAddScoped<IMarketplaceSaaSClient>(sp =>
    {
        return new MarketplaceSaaSClient(creds);
    });
```

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