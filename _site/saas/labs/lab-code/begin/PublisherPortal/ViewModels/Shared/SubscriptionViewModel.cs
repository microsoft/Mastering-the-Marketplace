using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;

namespace PublisherPortal.ViewModels.Shared;

public class SubscriptionViewModel
{
    public Subscription Subscription {  get; internal set; }
    public IReadOnlyList<Plan> Plans { get; set; }
}