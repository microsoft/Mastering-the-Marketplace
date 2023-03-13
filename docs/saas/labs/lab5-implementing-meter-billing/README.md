---
hide:
  - navigation

search:
    exclude: true
---

# Lab 5 - Implementing Meter billing using postman

👈 [Back to SaaS Offer labs](../../index.md#labs)

> 💀 The code in this lab is **NOT** meant to be used for production environments. It is a simple example with no error handling, no custom workflows, and is for learning purposes only.

## Overview

In this lab, you will build on what you have accomplished in previous labs. You will trigger a meter usage event using Postman tool. You can use any API testing tool but for this lab we will be using Postman. 

## Prerequisites

1. Postman tool
1. Published a SaaS offer with a [customer meter dimension on a plan](../lab1-create-pc-offer#preview-audience) to preview stage.
1. [App registration information](../lab2-create-landing-page#values-from-the-saas-workshop-single-tenant-app-registration) which is used in the technical configuration of the offer

## Exercise: Getting the access token 

1. Open Postman tool
1. Click + new tab
1. Change the request type from GET to POST
1. Enter the below URL into ***Enter request URL*** textbox
1. ```https://login.microsoftonline.com/{{tenantId}}/oauth2/v2.0/token``` (replace the {{tenantId}} with [saas-workshop-single-tenant](../lab2-create-landing-page#values-from-the-saas-workshop-single-tenant-app-registration) tenant/directory Id)
1. For Body, click on ```x-www-form-urlencoded``` radiobutton and enter the below key value pairs

    | KEY | VALUE |
    | ----------- | ----------- |
    | **grant_type** | `client_credentials` |
    | **client_id** | ```{{clientId}}``` (replace the {{clientId}} with [saas-workshop-single-tenant](../    lab2-create-landing-page#values-from-the-saas-workshop-single-tenant-app-registration) client/application Id) |
    | **client_secret** | ```{{clientSecret}}``` (replace the {{clientSecret}} with [saas-workshop-single-tenant](../    lab2-create-landing-page#values-from-the-saas-workshop-single-tenant-app-registration) secret) |
    | **scope** | ```20e940b3-4c77-4b0b-9a53-9e16a1b010a7/.default``` |

1. Click Send
1. You should see a json response with access token like below.

```
{
  "token_type": "Bearer",
  "expires_in": "3599",
  "ext_expires_in": "3599",
  "expires_on": "1645893398",
  "not_before": "1645889498",
  "resource": "20e940b3-4c77-4b0b-9a53-9e16a1b010a7",
  "access_token": "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiIsIng1dCI6Ik1yNS1BVWliZkJpaTdOZDFqQmViYXib1hXMCIsImtpZCI6Ik1yNS1BVWliZkJpaTdOZDFqQmViYXhib1hXMCJ9.eyJhdWQiOiI2MmQ5NGY2Yy1kNTk5LTQ4OWItYTc5Ny0zZTEwZTQyZmJlMjIiLCJpc3MiOiJodHRczovL3N0cy53aW5kb3dzLm5ldC9hNDk5NDQ0YS0zMTBlLTRmOTAtOTI4Yy1kNzA2MDzYmYzZTkIiwiaWF0IjoxNjQ1ODg5NDk4LCJuYmYiOjE2NDU4ODk0OTgsImV4cCI6MTY0NTg5MzM5OCwiYWlIjoiRTJaZ1lHaVFuOWgwVm5sM3BjKzg3R016SFN0MUFBPT0iLCJhcHBpZC6IjhjYzMyZTU1LWI5 OWYtNDY3YS1iMDM0LTMxMjgzZmJjODY2NyIsImFwcGlkYWNyI"
}
```

Great! Copy the value of the access_token from the response as we will be using this in our next exercise.

## Exercise: Invoking the Meter billing API usage event 
1. On the Postman tool Click + new tab
1. Change the request type from GET to POST

1. Enter the below URL into ***Enter request URL*** textbox
1. ```https://marketplaceapi.microsoft.com/api/usageEvent?api-version=2018-08-31```

1. For Headers, enter the below key value pairs

    | KEY | VALUE |
    | ----------- | ----------- |
    | **Content-Type** | ```application/json``` |
    | **authorization** | ```{{bearerToken}}``` (replace the {{bearerToken}} with  "Bearer " + access_token value copied from the first exercise) |

1. For Body, click on `raw` radiobutton and enter the below json

```
{
  "resourceId": "{{CustomerSaaSSubscriptionId}}",  // Replace {{CustomerSaaSSubscriptionId}} with an active subscritpion Id from your [publisher portal](../lab3-install-pub-portal#exercise-as-a-customer-request-subscription-activation) which is subscribed to plan with dimension)
  "quantity": 1.0,  // quantity of the usage you want to bill aganist this customer , we can leave it 1 for testing
  "dimension": "persmsId", //  DimensionId from the Offer plan created in [lab1](../lab1-create-pc-offer#for-marketplace-metering-service-dimensions)
  "effectiveStartTime": "{{eventtime}}",  // ( replace {{eventtime}} with a UTC time from now and until 24 hours back ex: '2022-02-26T17:17:31' )
  "planId": "gold-plan-id"  // PlanId from the Offer plan created in [lab1](../lab1-create-pc-offer#create-the-plan)
}
```

Click Send and you should see the below response.

```
{
  "usageEventId": "e91feebc-50dc-403b-a32b-93c24cc54ebb",
  "status": "Accepted",
  "messageTime": "2022-02-26T19:51:51.2516464Z",
  "resourceId": "7b853439-4fdf-4170-c542-f19217e11383",
  "resourceUri": "/subscriptions/bf7adf-hjhj7y-jhjkh887-khkjh/resourceGroups/sb-s/providers/Microsoft.SaaS/resources/saas",
  "quantity": 1.0,
  "dimension": "persmsId",
  "effectiveStartTime": "2022-02-26T17:17:31",
  "planId": "gold-plan-id"
}
```

This confirms a usage event has been reported to Microsoft and this will be billed to the customer.

---

**Congratulation!** You have finished this lab.

👈 [Back to SaaS Offer labs](../../index.md#labs)