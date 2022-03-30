# Lab 5 - Administering Your Customer’s Managed Applications

This lab will take you through the process of administering Managed Applications your customer has purchased from you. When you are done you will have a feel for what it means to work with your customer's installed applications as a publisher.

## Exercise 1 - Introducing Managed Application Center

This exercise introduces the primary tool you will use for administering your customer's installations of your solution, **Managed Application Center**. 

1. In the Azure portal, in the search box at the top of the page, enter **Managed Application Center** and select it from the dropdown.
   > Note this page allows access to tools to manage both **Service Catalog-based** applications and **Marketplace applications**.
2. In the left hand menu, select **Browse > Marketplace applications**. You see a list of all the offers that have been purchased by yur customers.
3. Click the link **AMA Workshop 01**.
4. Here you see a list of all customer purchases of your marketplace Managed Applications.

## Exercise 2 - Working in your customer's Managed Resource Group

Now you will perform some "maintenance" of your customer's solution in their Managed Resource Group.

1. Next to the **workshopapp2** Application name, click the link **workshopapp2-mrg** to the Managed Resource Group.
2. Viewing the managed resource group contents, you see all the resources that were created by the ARM template.
   > Because your user ID was set to the **Owner** of the Managed Application, you can perform operations inside this Managed Resource Group.

### Managing a Virtual Machine

1. Click the link to the virtual machine.
2. On the top menu, click the **Stop** button. 
3. Click the **Yes button** to confirm Stop.
   > Because you are the owner of the Managed Application, the virtual machine stops.

### Removing Resources 

1. Go back to the **workshopapp2-mrg** Resource Group.
2. Find the **Storage account** and select the checkbox next to it. 
3. In the top menu, click the **Delete** button.
4. Type **yes** to confirm and then the **Delete** button at the bottom of the page.
   > Because you are the owner of the Managed Application, the storage account is deleted.

### Adding Resources

1. Go back to the **workshopapp2-mrg** Resource Group.
2. Click the **Create** button on the top of the page.
3. Click the **Storage account > create** link on the first page.
4. On the **Create Storage account** page, enter the following.
   1. Under **Project details**
      1. **Subscription:** Your current subscription
      2. **Resource group:** workshopapp2-mrg
   2. Under **Instance Details**
      1. **Storage account name:** anything you choose
      2. **Region:** A Region near you
      3. **Performance:** Standard
      4. **Redundancy:** Locally Redundant Storage (LRS)
5. Click the **Review + create** at the bottom of the page.
6.  Click the **Create** button at the bottom of the screen.
7.  After deployment, confirm the new storage account is in the Managed Resource Group.


## Exercise 3 - Deleting a Managed Application as a publisher

Here you will learn how easy it is to delete a customer's subscription, should you choose to for some reason, such as lack of payment.

1. Open the **Managed Application Center**.
2. Go to **Manage applications**.
3. Click the product that was purchased, **AMA Workshop 1**.
4. Click the Application name, **workshopapp2**.
5. In the top menu, click the **Delete** button.
6. Click **Yes** to confirm the deletion.
    > Although it may take a couple of minutes, the **Managed Application** and its corresponding **Managed Resource Group** are deleted.

## Conclusion

Congratulations, you have completed Lab 5. In this lab, you did the following.

1. Learned about the Managed Application Center inside the Azure portal.
2. Deleted and created a resource within the customer's Managed Resource Group.
3. Deleted a customer's Azure Managed Application.