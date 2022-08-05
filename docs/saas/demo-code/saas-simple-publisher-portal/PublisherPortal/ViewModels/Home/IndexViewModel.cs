using System.Collections.Generic;
using Microsoft.Marketplace.SaaS.Models;

namespace PubisherPortal.ViewModels.Home
{
    public class IndexViewModel
    {
        public IList<Subscription> Subscriptions { get; internal set; }
    }
}
