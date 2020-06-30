# GetIntoTeachingApi.Client.Api.CallbackBookingQuotasApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCallbackBookingQuotas**](CallbackBookingQuotasApi.md#getcallbackbookingquotas) | **GET** /api/callback_booking_quotas | Retrieves all callback booking quotas.


<a name="getcallbackbookingquotas"></a>
# **GetCallbackBookingQuotas**
> CallbackBookingQuota GetCallbackBookingQuotas ()

Retrieves all callback booking quotas.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCallbackBookingQuotasExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CallbackBookingQuotasApi();

            try
            {
                // Retrieves all callback booking quotas.
                CallbackBookingQuota result = apiInstance.GetCallbackBookingQuotas();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CallbackBookingQuotasApi.GetCallbackBookingQuotas: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**CallbackBookingQuota**](CallbackBookingQuota.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

