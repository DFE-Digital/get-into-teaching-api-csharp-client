/* 
 * Get into Teaching API - V1
 *
 *   Provides a RESTful API for integrating with the Get into Teaching CRM.    The Get into Teaching (GIT) API sits in front of the GIT CRM, which uses the [Microsoft Dynamics365](https://docs.microsoft.com/en-us/dynamics365/) platform (the [Customer Engagement](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/overview) module is used for storing Candidate information and the [Marketing](https://docs.microsoft.com/en-us/dynamics365/marketing/developer/using-events-api) module for managing Events).    The GIT API aims to provide:    * Simple, task-based RESTful APIs.  * Message queueing (while the GIT CRM is offline for updates).  * Validation to ensure consistency across services writing to the GIT CRM.                          
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using GetIntoTeachingApi.Client.Client;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Model;

namespace GetIntoTeachingApi.Client.Test
{
    /// <summary>
    ///  Class for testing OperationsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class OperationsApiTests
    {
        private OperationsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new OperationsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OperationsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' OperationsApi
            //Assert.IsInstanceOfType(typeof(OperationsApi), instance, "instance is a OperationsApi");
        }

        
        /// <summary>
        /// Test GenerateMappingInfo
        /// </summary>
        [Test]
        public void GenerateMappingInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GenerateMappingInfo();
            //Assert.IsInstanceOf<List<MappingInfo>> (response, "response is List<MappingInfo>");
        }
        
        /// <summary>
        /// Test HealthCheck
        /// </summary>
        [Test]
        public void HealthCheckTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.HealthCheck();
            //Assert.IsInstanceOf<HealthCheckResponse> (response, "response is HealthCheckResponse");
        }
        
    }

}
