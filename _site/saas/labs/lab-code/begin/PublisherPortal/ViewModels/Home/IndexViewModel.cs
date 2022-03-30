using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;

namespace PublisherPortal.ViewModels.Home;

public class IndexViewModel
{
    public IList<Subscription> Subscriptions { get; internal set; }
}