# GetIntoTeachingApi.Client.Api.MailingListApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddMailingListMember**](MailingListApi.md#addmailinglistmember) | **POST** /api/mailing_list/members | Adds a new member to the mailing list.


<a name="addmailinglistmember"></a>
# **AddMailingListMember**
> void AddMailingListMember (MailingListAddMemberRequest body)

Adds a new member to the mailing list.

If the `CandidateId` is specified then the existing candidate will be added to the mailing list, otherwise a new candidate will be created.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class AddMailingListMemberExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MailingListApi();
            var body = new MailingListAddMemberRequest(); // MailingListAddMemberRequest | Member to add to the mailing list.

            try
            {
                // Adds a new member to the mailing list.
                apiInstance.AddMailingListMember(body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MailingListApi.AddMailingListMember: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MailingListAddMemberRequest**](MailingListAddMemberRequest.md)| Member to add to the mailing list. | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

