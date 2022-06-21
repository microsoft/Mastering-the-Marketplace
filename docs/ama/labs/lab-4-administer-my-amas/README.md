# Lab 4 - Administering Your Purchased Managed Applications

In this lab you will act as the customer. You will explore what it means to manage the Azure managed applications that you purchased.

In [Lab 3](../lab-3-purchasing-ama/README.md), you purchased your Gold plan and then remoted into the virtual machine, where you could use the VM as a customer. Now we'll see what else it means to manage your purchases.

## Exercise 1 - The Managed Applications dashboard

1. Open the [Azure portal](https://portal.azure.com).
2. At the top of the screen in the search box, enter **Managed Applications**.
3. Select **Managed Applications** from the dropdown box. Note: Do **not** select **Managed Applications Center**.
4. You are seeing the **Managed Applications dashboard** and seeing all of the Managed Applications you have purchased.

## Exercise 2 - amaworksopsilver01

1. Click on **amaworksopsilver01**. You saw this view of this Managed Application in the previous lab.
2. Note the name of the Managed Resource Group, which should be **amaworksopsilver01-mrg**.
3. At the top left of the page, click the **Delete** button.
4. Click **Yes** to confirm the deletion of the Managed Application.
    > It will take some time, approximately 2 minutes or so, but the Managed Application and its corresponding Managed Resource Group will be deleted.
5. Go to the **Managed Applications dashboard** as explained in Exercise 1.
6. Confirm that **amaworksopsilver01** application does not exist. You can refresh this page for a few minutes until the application is no longer visible.
7. Go to the list of Resource Groups in the Azure Portal and ensure the **amaworksopsilver01-mrg** Resource Group is no longer there.
> Now that the Managed Resouce Group is gone, the subscription to this solution is cancelled and no more billing will take place.

## Conclusion

Congratulations, you have complete Lab 3! In this lab you did the following.

1. Got familiar with the Managed Application dashboard.
2. Deleted a managed application and showed that it deleted the corresponding resources associated with it.