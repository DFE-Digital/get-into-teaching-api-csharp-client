# GetIntoTeachingApi.Client.Api.OperationsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GenerateMappingInfo**](OperationsApi.md#generatemappinginfo) | **GET** /api/operations/generate_mapping_info | Generates the mapping information.
[**HealthCheck**](OperationsApi.md#healthcheck) | **GET** /api/operations/health_check | Performs a health check.


<a name="generatemappinginfo"></a>
# **GenerateMappingInfo**
> List<MappingInfo> GenerateMappingInfo ()

Generates the mapping information.

Generates the mapping information describing how the models in the API map to the corresponding entities in Dynamics 365.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class GenerateMappingInfoExample
    {
        public void main()
        {
            var apiInstance = new OperationsApi();

            try
            {
                // Generates the mapping information.
                List&lt;MappingInfo&gt; result = apiInstance.GenerateMappingInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.GenerateMappingInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<MappingInfo>**](MappingInfo.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="healthcheck"></a>
# **HealthCheck**
> HealthCheckResponse HealthCheck ()

Performs a health check.

### Example
```csharp
using System;
using System.Diagnostics;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Model;

namespace Example
{
    public class HealthCheckExample
    {
        public void main()
        {
            var apiInstance = new OperationsApi();

            try
            {
                // Performs a health check.
                HealthCheckResponse result = apiInstance.HealthCheck();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OperationsApi.HealthCheck: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**HealthCheckResponse**](HealthCheckResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

