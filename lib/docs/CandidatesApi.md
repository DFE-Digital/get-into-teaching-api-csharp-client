# GetIntoTeachingApi.Client.Api.CandidatesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCandidateAccessToken**](CandidatesApi.md#createcandidateaccesstoken) | **POST** /api/candidates/access_tokens | Creates a candidate access token.


<a name="createcandidateaccesstoken"></a>
# **CreateCandidateAccessToken**
> void CreateCandidateAccessToken (ExistingCandidateRequest body)

Creates a candidate access token.

  Finds a candidate matching at least 3 of the provided CandidateAccessTokenRequest attributes (including email).   If a candidate is found, an access token (PIN code) will be sent to the candidate email address   that can then be used for verification.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class CreateCandidateAccessTokenExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CandidatesApi();
            var body = new ExistingCandidateRequest(); // ExistingCandidateRequest | Candidate access token request (must match an existing candidate).

            try
            {
                // Creates a candidate access token.
                apiInstance.CreateCandidateAccessToken(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CandidatesApi.CreateCandidateAccessToken: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ExistingCandidateRequest**](ExistingCandidateRequest.md)| Candidate access token request (must match an existing candidate). | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

