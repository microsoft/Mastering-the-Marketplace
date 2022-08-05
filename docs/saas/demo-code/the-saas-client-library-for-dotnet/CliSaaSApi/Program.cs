using System;
using Azure.Identity;

namespace CliSaaSApi
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 4)
            {
                Console.WriteLine("Expected 4 parameters: TenantID ClientId ClientSecret SubscriptionId");
                return;
            }

            var tenantId = args[0];
            var clientId = args[1];
            var clientSecret = args[2];
            var subscriptionId = args[3];

            var cred = new ClientSecretCredential(tenantId, clientId, clientSecret);

            var marketplaceClient = new Microsoft.Marketplace.SaaS.MarketplaceSaaSClient(cred);

            var subscription = marketplaceClient.Fulfillment.GetSubscription(Guid.Parse(subscriptionId)).Value;

            Console.WriteLine("============================================");
            Console.WriteLine("SUBSCRIPTION DETAILS");
            Console.WriteLine("============================================");

            Console.WriteLine($"Subscription Name: {subscription.Name}");
            Console.WriteLine($"Subscription ID: {subscription.Id}");
            Console.WriteLine($"Plan ID: {subscription.PlanId}");
            Console.WriteLine($"Created Date: {subscription.Created}");
            
        }
    }
}
