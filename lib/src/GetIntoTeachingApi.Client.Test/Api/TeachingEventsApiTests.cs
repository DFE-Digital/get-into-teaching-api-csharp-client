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
    ///  Class for testing TeachingEventsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class TeachingEventsApiTests
    {
        private TeachingEventsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TeachingEventsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeachingEventsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' TeachingEventsApi
            //Assert.IsInstanceOfType(typeof(TeachingEventsApi), instance, "instance is a TeachingEventsApi");
        }

        
        /// <summary>
        /// Test AddTeachingEventAttendee
        /// </summary>
        [Test]
        public void AddTeachingEventAttendeeTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //TeachingEventRegistrationRequest body = null;
            //instance.AddTeachingEventAttendee(id, body);
            
        }
        
        /// <summary>
        /// Test GetTeachingEvent
        /// </summary>
        [Test]
        public void GetTeachingEventTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Guid? id = null;
            //var response = instance.GetTeachingEvent(id);
            //Assert.IsInstanceOf<TeachingEvent> (response, "response is TeachingEvent");
        }
        
        /// <summary>
        /// Test GetUpcomingTeachingEvents
        /// </summary>
        [Test]
        public void GetUpcomingTeachingEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? limit = null;
            //var response = instance.GetUpcomingTeachingEvents(limit);
            //Assert.IsInstanceOf<List<TeachingEvent>> (response, "response is List<TeachingEvent>");
        }
        
        /// <summary>
        /// Test SearchTeachingEvents
        /// </summary>
        [Test]
        public void SearchTeachingEventsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string postcode = null;
            //int? radius = null;
            //int? typeId = null;
            //DateTime? startAfter = null;
            //DateTime? startBefore = null;
            //double? radiusInKm = null;
            //var response = instance.SearchTeachingEvents(postcode, radius, typeId, startAfter, startBefore, radiusInKm);
            //Assert.IsInstanceOf<List<TeachingEvent>> (response, "response is List<TeachingEvent>");
        }
        
    }

}