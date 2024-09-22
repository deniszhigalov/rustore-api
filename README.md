# Rustore API Build in C#

---

This is a module for working with Rustore Api developed on the Microsoft platform.

## Tools and Technologies Used

---

1. C# programming language
2. JetBrains Rider 2021.3.4 (IDE), Visual Studio 2022
3. Git & Github (Version Control)

## Support Developer

---

- Add a Star 🌟 to this 👆 Repository

## Instructions to Use 

---

Download or Clone the source code from [Here](https://github.com/deniszhigalov/rustore-api) or Find the package at nuget.org RustoreApi

## Manual

---

1. Get PrivateKey according to the instructions in the documentation on the official Rustor [website](https://help.rustore.ru//rustore/for_developers/worki_with_RuStore_API/authorization_rustore_api_1)
2. Get the CompanyId [here](https://console.rustore.ru/company/api-key)
3. Initialize the RustoreClient

```csharp
using RustoreApi;

RustoreClient rustoreClient = new RustoreClient(new RustoreParams
{
    KeyId = <Your company id>,
    PrivateKey = <Your private key>,
    TimeZone = <Timezone server> //example +03:00
});

...
```

4. Perform one of the methods described below

- Payment receipt method (info [here](https://help.rustore.ru/rustore/for_developers/worki_with_RuStore_API/public_api_1))

```csharp
...

var data = await rustoreClient.GetPaymentByPaymentId(new PaymentByPaymentIdRequest
{
    SubscriptionToken = <Your subscription token>
});
```

- Payment receipt method for testing (info [here](https://help.rustore.ru/rustore/for_developers/worki_with_RuStore_API/public_api_1))

```csharp
...

var data = await rustoreClient.GetPaymentByPaymentIdTest(new PaymentByPaymentIdRequest
{
    SubscriptionToken = <Your subscription token>
});
```

- Method for retrieving subscription data (info [here](https://help.rustore.ru/rustore/for_developers/worki_with_RuStore_API/subscription_data_payment_id_3))

```csharp
var data = await rustoreClient.GetPaymentBySubscriptionId(new PaymentBySubscriptionIdRequest
{
    SubscriptionToken = <Your subscription token>
});
```

- Method for retrieving subscription data. Method for test pauments (info [here](https://help.rustore.ru/rustore/for_developers/worki_with_RuStore_API/subscription_data_payment_id_3))

```csharp
var data = await rustoreClient.GetPaymentBySubscriptionIdTest(new PaymentBySubscriptionIdRequest
{
    SubscriptionToken = <Your subscription token>
});
```

- Subscription data retrieval method (V2) Outdated (info [here](https://help.rustore.ru/rustore/for_developers/worki_with_RuStore_API/subscription_data_by_payment_id_2_](https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-id-payment-method)

```csharp
var receipt = await rustoreClient.GetSubscriptionsByPaymentIdV2(new SubscriptionsV2Request
{
    SubscriptionToken = <Your subscription token>,
    UserId = <Your user id>,
    SubscriptionId = <Your subscription id>, //example test_subscription_1
    PackageName = <Your package name> //example com.app
});
```

- Subscription data retrieval method (V3)  (info [here](https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-id-payment-method-v3)

```csharp
var receipt = await rustoreClient.GetSubscriptionsByPaymentIdV3(new SubscriptionsV2Request
{
    SubscriptionToken = <Your subscription token>,
    UserId = <Your user id>,
    SubscriptionId = <Your subscription id>, //example test_subscription_1
    PackageName = <Your package name> //example com.app
});
```

- Subscription data retrieval method (V3). For a test subscription  (info [here](https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-id-payment-method-v3)

```csharp
var receipt = await rustoreClient.GetSubscriptionsByPaymentIdV3Test(new SubscriptionsV2Request
{
    SubscriptionToken = <Your subscription token>,
    UserId = <Your user id>,
    SubscriptionId = <Your subscription id>, //example test_subscription_1
    PackageName = <Your package name> //example com.app
});
```

- Method for obtaining subscription status (info [here](https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-token-substatus-method))

```csharp
var data = await rustoreClient.GetStatusSubscription(new StatusSubscriptionRequest
{
    SubscriptionToken = <Your subscription token>
});
```


- Method for obtaining subscription status.  For a test subscription (info [here](https://www.rustore.ru/help/work-with-rustore-api/api-subscription-payment/api-token-substatus-method))

```csharp
var data = await rustoreClient.GetStatusSubscriptionTest(new StatusSubscriptionRequest
{
    SubscriptionToken = <Your subscription token>
});
```
