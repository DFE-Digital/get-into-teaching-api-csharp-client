# GetIntoTeachingApi.Client.Api.TeacherTrainingAdviserApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExistingTeacherTrainingAdviserCandidate**](TeacherTrainingAdviserApi.md#getexistingteachertrainingadvisercandidate) | **POST** /api/teacher_training_adviser/candidates/{accessToken} | Retrieves an existing candidate for the Teacher Training Adviser service.
[**UpsertTeacherTrainingAdviserCandidate**](TeacherTrainingAdviserApi.md#upsertteachertrainingadvisercandidate) | **POST** /api/teacher_training_adviser/candidates | Upserts a candidate for the Teacher Training Adviser service.


<a name="getexistingteachertrainingadvisercandidate"></a>
# **GetExistingTeacherTrainingAdviserCandidate**
> Candidate GetExistingTeacherTrainingAdviserCandidate (string accessToken, ExistingCandidateRequest body)

Retrieves an existing candidate for the Teacher Training Adviser service.

  Retrieves an existing candidate for the Teacher Training Adviser service. The `accessToken` is obtained from a   `POST /candidates/access_tokens` request (you must also ensure the `ExistingCandidateRequest` payload you   exchanged for your token matches the request payload here).

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetExistingTeacherTrainingAdviserCandidateExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeacherTrainingAdviserApi();
            var accessToken = accessToken_example;  // string | Access token (PIN code).
            var body = new ExistingCandidateRequest(); // ExistingCandidateRequest | Candidate access token request (must match an existing candidate).

            try
            {
                // Retrieves an existing candidate for the Teacher Training Adviser service.
                Candidate result = apiInstance.GetExistingTeacherTrainingAdviserCandidate(accessToken, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeacherTrainingAdviserApi.GetExistingTeacherTrainingAdviserCandidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accessToken** | **string**| Access token (PIN code). | 
 **body** | [**ExistingCandidateRequest**](ExistingCandidateRequest.md)| Candidate access token request (must match an existing candidate). | 

### Return type

[**Candidate**](Candidate.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertteachertrainingadvisercandidate"></a>
# **UpsertTeacherTrainingAdviserCandidate**
> void UpsertTeacherTrainingAdviserCandidate (Candidate body)

Upserts a candidate for the Teacher Training Adviser service.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class UpsertTeacherTrainingAdviserCandidateExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeacherTrainingAdviserApi();
            var body = new Candidate(); // Candidate | Candidate to upsert for the Teacher Training Adviser service.

            try
            {
                // Upserts a candidate for the Teacher Training Adviser service.
                apiInstance.UpsertTeacherTrainingAdviserCandidate(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeacherTrainingAdviserApi.UpsertTeacherTrainingAdviserCandidate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Candidate**](Candidate.md)| Candidate to upsert for the Teacher Training Adviser service. | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

