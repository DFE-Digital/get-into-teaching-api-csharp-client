# GetIntoTeachingApi.Client.Api.PrivacyPoliciesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetLatestPrivacyPolicy**](PrivacyPoliciesApi.md#getlatestprivacypolicy) | **GET** /api/privacy_policies/latest | Retrieves the latest privacy policy.


<a name="getlatestprivacypolicy"></a>
# **GetLatestPrivacyPolicy**
> PrivacyPolicy GetLatestPrivacyPolicy ()

Retrieves the latest privacy policy.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetLatestPrivacyPolicyExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PrivacyPoliciesApi();

            try
            {
                // Retrieves the latest privacy policy.
                PrivacyPolicy result = apiInstance.GetLatestPrivacyPolicy();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PrivacyPoliciesApi.GetLatestPrivacyPolicy: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**PrivacyPolicy**](PrivacyPolicy.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

