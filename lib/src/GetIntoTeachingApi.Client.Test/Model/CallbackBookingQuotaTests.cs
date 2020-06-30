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
    ///  Class for testing CallbackBookingQuota
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CallbackBookingQuotaTests
    {
        // TODO uncomment below to declare an instance variable for CallbackBookingQuota
        //private CallbackBookingQuota instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CallbackBookingQuota
            //instance = new CallbackBookingQuota();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CallbackBookingQuota
        /// </summary>
        [Test]
        public void CallbackBookingQuotaInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CallbackBookingQuota
            //Assert.IsInstanceOfType<CallbackBookingQuota> (instance, "variable 'instance' is a CallbackBookingQuota");
        }


        /// <summary>
        /// Test the property 'TimeSlot'
        /// </summary>
        [Test]
        public void TimeSlotTest()
        {
            // TODO unit test for the property 'TimeSlot'
        }
        /// <summary>
        /// Test the property 'Day'
        /// </summary>
        [Test]
        public void DayTest()
        {
            // TODO unit test for the property 'Day'
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
        /// Test the property 'NumberOfBookings'
        /// </summary>
        [Test]
        public void NumberOfBookingsTest()
        {
            // TODO unit test for the property 'NumberOfBookings'
        }
        /// <summary>
        /// Test the property 'Quota'
        /// </summary>
        [Test]
        public void QuotaTest()
        {
            // TODO unit test for the property 'Quota'
        }
        /// <summary>
        /// Test the property 'IsAvailable'
        /// </summary>
        [Test]
        public void IsAvailableTest()
        {
            // TODO unit test for the property 'IsAvailable'
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
