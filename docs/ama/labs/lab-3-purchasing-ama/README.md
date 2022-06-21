# Lab 3 - Purchasing an Azure Managed Application

This lab focuses on purchasing the offer and plans you created in [Lab 1](../lab-1-partner-center/README.md) and [Lab 2](../lab-2-deployment-package/README.md).

First, check Partner Center.

> This lab will only work if your offer in is published and visible in the **Publisher signoff** stage of publication as seen on the **Offer overview**. page in **Partner Center**. 
> 
> There should be a **Go live** button on the **Offer overview** page. Do **NOT** click this button at any point today as doing so will submit your offer to the certification team to make it live.

## Exercise 1 - The Silver plan

This exercise takes you through the process of buying your Silver plan, created in [Lab 1](../lab-1-partner-center/README.md). You'll also have a look at your resulting Managed Application.

### Finding the private plan

1. Open the [Azure portal](https://portal.azure.com/) and log in.
2. At the top of the screen click the **Create a resource** button. You are taken to the public Azure marketplace.
    > In Lab 1, you configured your offer to be available to your subscription while in the **Publisher signoff** stage. This makes your offer a private one and you need to navigate to the private offers part of the marketplace to purchase it.
3. Under the search box, click the link that reads **See more in the Marketplace**.
4. On this page you see a pink bar at the top of the screen telling you that you have private offers available. Click the link that reads **View private products**.
5. Locate your offer named **AMA Workshop 1 (preview)** and click on that tile. You are taken to the offer's purchase page, which is in **Preview** mode.

### Purchasing the Silver plan

#### Basics tab

1. In the plan dropdown, ensure Silver is selected.
   > This plan will create a simple **Data storage** service in your subscription.
2. Click the **Create** button. You are taken to the offer creation page, which needs your input.
3. On the **Basics** tab, you should see your current subscription selected. If not, select it from the dropdown.
4. For **Resource group** click the **Create new** link under the dropdown.
5. Name your new resource group **ama_workshop_purchases**.
6. Select a region near you.
7. In the **Managed Application Details** section, enter the following.
   1. **Application name:** workshopapp1
   2. **Managed Resource Group**: workshopapp1-mrg
8. At the bottom of the screen, click the **Next: Storage setting** button.

#### Storage settings tab

1. Enter the following values.
   1. **Storage account name prefix:** amaws01
   2. **Storage account type:** Standard_LRS
2. Click the **Review + create** button at the bottom of the screen.

#### Review + create tab

1. Scroll down to the **Co-Admin Access Permission** section.
2. Click the checkbox **I agree to the terms and conditions above**.
3. Click the **Create** button at the bottom of the screen. You are taken to the **Deployment** page. 
   > Deploying your application may take a couple of minutes.

#### Deployment screen

When deployment is complete, you are met with a message that reads, **Your deployment is complete**.

1. At the bottom of the screen click the **Go to resource** button. 

You are taken to the **managed application** instance.

## Exercise 2 - The deployed application

In this exercise you will tour the **workshopapp1** managed application you've just purchased. 

### The managed application

1. On the Essentials screen, note the following.
   1. The **support link** you entered in Partner Center is shown here.
   2. The link to the Resource group you created,  **ama_workshop_purchases** is present. This is the resource group containing the instance of a the managed application you are looking at right now.
   3. There is a link to the Managed resource group you created, **workshopapp1-mrg**. This is the resource group that contains the services deployed by the ARM template in your deployment package.
2. In the left hand menu, click **Parameters and outputs**.
   1. The arm template, `mainTemplate.json` that created the storage account that was deployed, took only three parameters and they are shown here.
   2. There are no **outputs** on this page because none were specified by the ARM template.
3. In the left hand menu, click **Authorizations**. 
   1. Note the role that the publisher has on this application is **Owner**. This corresponds to the role you selected in the **Technical configuration** tab of the plan in Partner Center.

## The Managed resource group

1. In the left hand menu, click on **Overview**.
2. In the Essentials section of the page, click the link to the **Managed resource group** you created, **workshopapp1-mrg**.
3. You are taken to the Resource group that contains the storage account deployed by the ARM template.

## Exercise 3 - The Gold plan

In this exercise you will go through the process of buying your Gold plan, created in [Lab 2](../lab-2-deployment-package/README.md). After deployment, you'll use the virtual machine deployed by the application.

### Purchasing the Gold plan

1. Click the link to **Home** in the top left corner of the screen.
2. Under **Azure services**, click **Create a resource**.
3. Go back to the **Private offers** section of the marketplace and find the **AMA Workshop 1** offer.
4. Purchase the **Gold** plan. Using the values as follows in the setup screens.
   1. Basics tab
      1. **Resource group:** ama_workshop_purchases
      2. **Region:** Any one near you
      3. **Application name:** amaworksopgold01
      4. **Managed Resource Group**: amaworksopgold01-mrg
   2. Storage account settings
      1. **Storage account prefix:** Any 3-5 alphanumeric value that is accepted
      2. **Storage account type:** Standard_LRS
   3. Virtual Machine
      1. **Machine name:** amavm01
      2. **Admin username:** Any accepted value of your choice
      3. **Password**: Any accepted value of your choice
      4. **Windows operating system:** Your choice
      5. **Virtual machine size:** Note you can Change the size of the virtual machine to be deployed, but larger sizes cost more money to your subscription. Consider taking the recommended value of **1x Standard D2s v3**.
5. Click the **Review + create** button at the bottom of the screen.
6. Check the box for **I  agree to the terms and conditions above**.
7. Click the **Create** button at the bottom of the screen and the plan is deployed.

### Exploring the Gold plan

This will be a simple peek into the resources created during deployment of your application.

1. Wait for deployment to complete.
2. Click the **Go to resource** button near the bottom of the screen.
3. Near the top right of the **Essentials** section of the page, click the link to the Managed Resource Group you created, **workshopapp2-mrg**.
4. Note all of the resources deployed by your ARM template. If you have any questions about how a particular resource was created, review your `mainTemplate.json` file for the resource definition.

### Remote into the virtual machine

Here you will actually log in into the virtual machine deployed by your Managed Application.

1. Click the virtual machine in the set of resources listed in the **Managed Resource Group**.
2. In the top left of the screen, click the **Connect** dropdown.

#### Windows users

1. Select **RDP** from the dropdown.
2. Click the button **Download RDP** file.
3. When prompted, click the **Open** button on the **Downloads** dialog. This will launch your remote desktop client.
4. Enter the **username and password** you entered when purchasing the Managed Application.
5. Connect to the remote machine.
    > Note you are currently in the role of a customer, and you have remoted into a virtual machine inside the **Managed Resource Group**.
6. Disconnect from the virtual machine.

#### Mac and Linux users

1. Select **SSH** from the dropdown.
2. Follow the instruction on the page, under **Connect via SSH with client**.
3. Use the **username and password** you entered while purchasing the Managed Application to log in to the virtual machine.
    > Note you are currently in the role of a customer, and you have remoted into a virtual machine inside the **Managed Resource Group**.
6. Disconnect from the virtual machine.

## Conclusion

Congratulations, you have completed Lab 3. In this lab you accomplished the following.

1. Purchased two plans you created using an offer from Lab 1.
2. Examined the artifacts deployed by each plan.
3. Logged into the virtual machine deployed by the Gold plan.
   