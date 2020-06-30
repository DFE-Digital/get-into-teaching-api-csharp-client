/* 
 * Get into Teaching API - V1
 *
 *   Provides a RESTful API for integrating with the Get into Teaching CRM.    The Get into Teaching (GIT) API sits in front of the GIT CRM, which uses the [Microsoft Dynamics365](https://docs.microsoft.com/en-us/dynamics365/) platform (the [Customer Engagement](https://docs.microsoft.com/en-us/dynamics365/customerengagement/on-premises/developer/overview) module is used for storing Candidate information and the [Marketing](https://docs.microsoft.com/en-us/dynamics365/marketing/developer/using-events-api) module for managing Events).    The GIT API aims to provide:    * Simple, task-based RESTful APIs.  * Message queueing (while the GIT CRM is offline for updates).  * Validation to ensure consistency across services writing to the GIT CRM.                          
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using GetIntoTeachingApi.Client.Api;
using GetIntoTeachingApi.Client.Model;
using GetIntoTeachingApi.Client.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace GetIntoTeachingApi.Client.Test
{
    /// <summary>
    ///  Class for testing TeachingEvent
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class TeachingEventTests
    {
        // TODO uncomment below to declare an instance variable for TeachingEvent
        //private TeachingEvent instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of TeachingEvent
            //instance = new TeachingEvent();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of TeachingEvent
        /// </summary>
        [Test]
        public void TeachingEventInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" TeachingEvent
            //Assert.IsInstanceOfType<TeachingEvent> (instance, "variable 'instance' is a TeachingEvent");
        }


        /// <summary>
        /// Test the property 'TypeId'
        /// </summary>
        [Test]
        public void TypeIdTest()
        {
            // TODO unit test for the property 'TypeId'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
        }
        /// <summary>
        /// Test the property 'StartAt'
        /// </summary>
        [Test]
        public void StartAtTest()
        {
            // TODO unit test for the property 'StartAt'
        }
        /// <summary>
        /// Test the property 'EndAt'
        /// </summary>
        [Test]
        public void EndAtTest()
        {
            // TODO unit test for the property 'EndAt'
        }
        /// <summary>
        /// Test the property 'Building'
        /// </summary>
        [Test]
        public void BuildingTest()
        {
            // TODO unit test for the property 'Building'
        }
        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

    }

}
