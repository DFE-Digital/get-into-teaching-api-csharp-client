# GetIntoTeachingApi.Client.Model.TeachingEventSearchRequest
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Postcode** | **string** | Postcode to center search around. | 
**Radius** | **int?** | Set to filter results to a radius (in miles) around the postcode. | [optional] 
**TypeId** | **int?** | Set to filter results to a type of teaching event. Must match an &#x60;typeId&#x60; of the &#x60;TeachingEvent&#x60; schema. | [optional] 
**StartAfter** | **DateTime?** | Set to filter results to those that start after a given date. | [optional] 
**StartBefore** | **DateTime?** | Set to filter results to those that start before a given date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

