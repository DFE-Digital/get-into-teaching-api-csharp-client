# GetIntoTeachingApi.Client.Api.TeachingEventsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddTeachingEventAttendee**](TeachingEventsApi.md#addteachingeventattendee) | **POST** /api/teaching_events/{id}/attendees | Adds an attendee to a teaching event.
[**GetTeachingEvent**](TeachingEventsApi.md#getteachingevent) | **GET** /api/teaching_events/{id} | Retrieves an event.
[**GetUpcomingTeachingEvents**](TeachingEventsApi.md#getupcomingteachingevents) | **GET** /api/teaching_events/upcoming | Retrieves the upcoming teaching events.
[**SearchTeachingEvents**](TeachingEventsApi.md#searchteachingevents) | **GET** /api/teaching_events/search | Searches for teaching events.


<a name="addteachingeventattendee"></a>
# **AddTeachingEventAttendee**
> void AddTeachingEventAttendee (Guid? id, TeachingEventRegistrationRequest body)

Adds an attendee to a teaching event.

If the `CandidateId` is specified then the existing candidate will be registered for the event, otherwise a new candidate will be created.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class AddTeachingEventAttendeeExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeachingEventsApi();
            var id = new Guid?(); // Guid? | The `id` of the `TeachingEvent`.
            var body = new TeachingEventRegistrationRequest(); // TeachingEventRegistrationRequest | Attendee to add to the teaching event.

            try
            {
                // Adds an attendee to a teaching event.
                apiInstance.AddTeachingEventAttendee(id, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingEventsApi.AddTeachingEventAttendee: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The &#x60;id&#x60; of the &#x60;TeachingEvent&#x60;. | 
 **body** | [**TeachingEventRegistrationRequest**](TeachingEventRegistrationRequest.md)| Attendee to add to the teaching event. | 

### Return type

void (empty response body)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachingevent"></a>
# **GetTeachingEvent**
> TeachingEvent GetTeachingEvent (Guid? id)

Retrieves an event.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetTeachingEventExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeachingEventsApi();
            var id = new Guid?(); // Guid? | The `id` of the `TeachingEvent`.

            try
            {
                // Retrieves an event.
                TeachingEvent result = apiInstance.GetTeachingEvent(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingEventsApi.GetTeachingEvent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | [**Guid?**](Guid?.md)| The &#x60;id&#x60; of the &#x60;TeachingEvent&#x60;. | 

### Return type

[**TeachingEvent**](TeachingEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getupcomingteachingevents"></a>
# **GetUpcomingTeachingEvents**
> List<TeachingEvent> GetUpcomingTeachingEvents (int? limit = null)

Retrieves the upcoming teaching events.

  Retrieves the upcoming teaching events; limited to 10 by default, but this can be increased to a   maximum of 50 using the `limit` query parameter.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetUpcomingTeachingEventsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeachingEventsApi();
            var limit = 56;  // int? | Number of results to return (maximum of 50). (optional)  (default to 10)

            try
            {
                // Retrieves the upcoming teaching events.
                List&lt;TeachingEvent&gt; result = apiInstance.GetUpcomingTeachingEvents(limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingEventsApi.GetUpcomingTeachingEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| Number of results to return (maximum of 50). | [optional] [default to 10]

### Return type

[**List<TeachingEvent>**](TeachingEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="searchteachingevents"></a>
# **SearchTeachingEvents**
> List<TeachingEvent> SearchTeachingEvents (string postcode, int? radius = null, int? typeId = null, DateTime? startAfter = null, DateTime? startBefore = null, double? radiusInKm = null)

Searches for teaching events.

Searches for teaching events by postcode. Optionally limit the results by distance (in miles) and the type of event.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class SearchTeachingEventsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TeachingEventsApi();
            var postcode = postcode_example;  // string | 
            var radius = 56;  // int? |  (optional) 
            var typeId = 56;  // int? |  (optional) 
            var startAfter = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var startBefore = 2013-10-20T19:20:30+01:00;  // DateTime? |  (optional) 
            var radiusInKm = 1.2;  // double? |  (optional) 

            try
            {
                // Searches for teaching events.
                List&lt;TeachingEvent&gt; result = apiInstance.SearchTeachingEvents(postcode, radius, typeId, startAfter, startBefore, radiusInKm);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TeachingEventsApi.SearchTeachingEvents: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **postcode** | **string**|  | 
 **radius** | **int?**|  | [optional] 
 **typeId** | **int?**|  | [optional] 
 **startAfter** | **DateTime?**|  | [optional] 
 **startBefore** | **DateTime?**|  | [optional] 
 **radiusInKm** | **double?**|  | [optional] 

### Return type

[**List<TeachingEvent>**](TeachingEvent.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

