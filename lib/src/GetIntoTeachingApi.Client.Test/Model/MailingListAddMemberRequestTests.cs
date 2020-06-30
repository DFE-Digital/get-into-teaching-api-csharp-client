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
    ///  Class for testing MailingListAddMemberRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class MailingListAddMemberRequestTests
    {
        // TODO uncomment below to declare an instance variable for MailingListAddMemberRequest
        //private MailingListAddMemberRequest instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of MailingListAddMemberRequest
            //instance = new MailingListAddMemberRequest();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of MailingListAddMemberRequest
        /// </summary>
        [Test]
        public void MailingListAddMemberRequestInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" MailingListAddMemberRequest
            //Assert.IsInstanceOfType<MailingListAddMemberRequest> (instance, "variable 'instance' is a MailingListAddMemberRequest");
        }


        /// <summary>
        /// Test the property 'CandidateId'
        /// </summary>
        [Test]
        public void CandidateIdTest()
        {
            // TODO unit test for the property 'CandidateId'
        }
        /// <summary>
        /// Test the property 'PreferredTeachingSubjectId'
        /// </summary>
        [Test]
        public void PreferredTeachingSubjectIdTest()
        {
            // TODO unit test for the property 'PreferredTeachingSubjectId'
        }
        /// <summary>
        /// Test the property 'FirstName'
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO unit test for the property 'FirstName'
        }
        /// <summary>
        /// Test the property 'LastName'
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO unit test for the property 'LastName'
        }
        /// <summary>
        /// Test the property 'Email'
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO unit test for the property 'Email'
        }
        /// <summary>
        /// Test the property 'Telephone'
        /// </summary>
        [Test]
        public void TelephoneTest()
        {
            // TODO unit test for the property 'Telephone'
        }
        /// <summary>
        /// Test the property 'AddressPostcode'
        /// </summary>
        [Test]
        public void AddressPostcodeTest()
        {
            // TODO unit test for the property 'AddressPostcode'
        }
        /// <summary>
        /// Test the property 'PrivacyPolicy'
        /// </summary>
        [Test]
        public void PrivacyPolicyTest()
        {
            // TODO unit test for the property 'PrivacyPolicy'
        }

    }

}
