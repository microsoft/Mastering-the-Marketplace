using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Marketplace.Metering;
using Microsoft.Marketplace.Metering.Models;
using Microsoft.Marketplace.SaaS;
using Microsoft.Marketplace.SaaS.Models;

namespace PublisherPortal.Controllers;

[Authorize]
[Route("~/Meters")]
public class MetersController : Controller
{
    private readonly IMarketplaceSaaSClient _marketplaceSaaSClient;
    private readonly IMarketplaceMeteringClient _meteringClient;
    private readonly ILogger<HomeController> _logger;

    public MetersController(
        IMarketplaceSaaSClient marketplaceSaaSClient,
        IMarketplaceMeteringClient meteringClient,
        ILogger<HomeController> logger)

    {
        _marketplaceSaaSClient = marketplaceSaaSClient;
        _meteringClient = meteringClient;
        _logger = logger;
    }


    [Route("Subscription/{id}")]
    public async Task<IActionResult> IndexAsync(Guid id, CancellationToken cancellationToken)
    {
        var subscription = (await _marketplaceSaaSClient.Fulfillment.GetSubscriptionAsync(id, cancellationToken: cancellationToken)).Value;

        return View();
    }
}