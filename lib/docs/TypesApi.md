# GetIntoTeachingApi.Client.Api.TypesApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCandidateChannels**](TypesApi.md#getcandidatechannels) | **GET** /api/types/candidate/channels | Retrieves the list of candidate channels.
[**GetCandidateInitialTeacherTrainingYears**](TypesApi.md#getcandidateinitialteachertrainingyears) | **GET** /api/types/candidate/initial_teacher_training_years | Retrieves the list of candidate initial teacher training years.
[**GetCandidateLocations**](TypesApi.md#getcandidatelocations) | **GET** /api/types/candidate/locations | Retrieves the list of candidate locations.
[**GetCandidatePreferredEducationPhases**](TypesApi.md#getcandidatepreferrededucationphases) | **GET** /api/types/candidate/preferred_education_phases | Retrieves the list of candidate preferred education phases.
[**GetCountryTypes**](TypesApi.md#getcountrytypes) | **GET** /api/types/countries | Retrieves the list of countries.
[**GetPastTeachingPositionEducationPhases**](TypesApi.md#getpastteachingpositioneducationphases) | **GET** /api/types/past_teaching_position/education_phases | Retrieves the list of past teaching position education phases.
[**GetPhoneCallChannels**](TypesApi.md#getphonecallchannels) | **GET** /api/types/phone_call/channels | Retrieves the list of phone call channels.
[**GetQualificationCategories**](TypesApi.md#getqualificationcategories) | **GET** /api/types/qualification/categories | Retrieves the list of qualification categories.
[**GetQualificationDegreeStatus**](TypesApi.md#getqualificationdegreestatus) | **GET** /api/types/qualification/degree_status | Retrieves the list of qualification degree status.
[**GetQualificationTypes**](TypesApi.md#getqualificationtypes) | **GET** /api/types/qualification/types | Retrieves the list of qualification types.
[**GetTeachingEventTypes**](TypesApi.md#getteachingeventtypes) | **GET** /api/types/teaching_event/types | Retrieves the list of teaching event types.
[**GetTeachingSubjects**](TypesApi.md#getteachingsubjects) | **GET** /api/types/teaching_subjects | Retrieves the list of teaching subjects.


<a name="getcandidatechannels"></a>
# **GetCandidateChannels**
> List<TypeEntity> GetCandidateChannels ()

Retrieves the list of candidate channels.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCandidateChannelsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of candidate channels.
                List&lt;TypeEntity&gt; result = apiInstance.GetCandidateChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetCandidateChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandidateinitialteachertrainingyears"></a>
# **GetCandidateInitialTeacherTrainingYears**
> List<TypeEntity> GetCandidateInitialTeacherTrainingYears ()

Retrieves the list of candidate initial teacher training years.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCandidateInitialTeacherTrainingYearsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of candidate initial teacher training years.
                List&lt;TypeEntity&gt; result = apiInstance.GetCandidateInitialTeacherTrainingYears();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetCandidateInitialTeacherTrainingYears: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandidatelocations"></a>
# **GetCandidateLocations**
> List<TypeEntity> GetCandidateLocations ()

Retrieves the list of candidate locations.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCandidateLocationsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of candidate locations.
                List&lt;TypeEntity&gt; result = apiInstance.GetCandidateLocations();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetCandidateLocations: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcandidatepreferrededucationphases"></a>
# **GetCandidatePreferredEducationPhases**
> List<TypeEntity> GetCandidatePreferredEducationPhases ()

Retrieves the list of candidate preferred education phases.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCandidatePreferredEducationPhasesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of candidate preferred education phases.
                List&lt;TypeEntity&gt; result = apiInstance.GetCandidatePreferredEducationPhases();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetCandidatePreferredEducationPhases: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcountrytypes"></a>
# **GetCountryTypes**
> List<TypeEntity> GetCountryTypes ()

Retrieves the list of countries.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetCountryTypesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of countries.
                List&lt;TypeEntity&gt; result = apiInstance.GetCountryTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetCountryTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpastteachingpositioneducationphases"></a>
# **GetPastTeachingPositionEducationPhases**
> List<TypeEntity> GetPastTeachingPositionEducationPhases ()

Retrieves the list of past teaching position education phases.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetPastTeachingPositionEducationPhasesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of past teaching position education phases.
                List&lt;TypeEntity&gt; result = apiInstance.GetPastTeachingPositionEducationPhases();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetPastTeachingPositionEducationPhases: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getphonecallchannels"></a>
# **GetPhoneCallChannels**
> List<TypeEntity> GetPhoneCallChannels ()

Retrieves the list of phone call channels.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetPhoneCallChannelsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of phone call channels.
                List&lt;TypeEntity&gt; result = apiInstance.GetPhoneCallChannels();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetPhoneCallChannels: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqualificationcategories"></a>
# **GetQualificationCategories**
> List<TypeEntity> GetQualificationCategories ()

Retrieves the list of qualification categories.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetQualificationCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of qualification categories.
                List&lt;TypeEntity&gt; result = apiInstance.GetQualificationCategories();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetQualificationCategories: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqualificationdegreestatus"></a>
# **GetQualificationDegreeStatus**
> List<TypeEntity> GetQualificationDegreeStatus ()

Retrieves the list of qualification degree status.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetQualificationDegreeStatusExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of qualification degree status.
                List&lt;TypeEntity&gt; result = apiInstance.GetQualificationDegreeStatus();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetQualificationDegreeStatus: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getqualificationtypes"></a>
# **GetQualificationTypes**
> List<TypeEntity> GetQualificationTypes ()

Retrieves the list of qualification types.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetQualificationTypesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of qualification types.
                List&lt;TypeEntity&gt; result = apiInstance.GetQualificationTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetQualificationTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachingeventtypes"></a>
# **GetTeachingEventTypes**
> List<TypeEntity> GetTeachingEventTypes ()

Retrieves the list of teaching event types.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetTeachingEventTypesExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of teaching event types.
                List&lt;TypeEntity&gt; result = apiInstance.GetTeachingEventTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetTeachingEventTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getteachingsubjects"></a>
# **GetTeachingSubjects**
> List<TypeEntity> GetTeachingSubjects ()

Retrieves the list of teaching subjects.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GetTeachingSubjectsExample
    {
        public void main()
        {
            // Configure API key authorization: apiKey
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new TypesApi();

            try
            {
                // Retrieves the list of teaching subjects.
                List&lt;TypeEntity&gt; result = apiInstance.GetTeachingSubjects();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TypesApi.GetTeachingSubjects: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<TypeEntity>**](TypeEntity.md)

### Authorization

[apiKey](../README.md#apiKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

