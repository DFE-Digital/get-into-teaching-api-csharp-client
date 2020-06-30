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
    ///  Class for testing CandidatePastTeachingPosition
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class CandidatePastTeachingPositionTests
    {
        // TODO uncomment below to declare an instance variable for CandidatePastTeachingPosition
        //private CandidatePastTeachingPosition instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of CandidatePastTeachingPosition
            //instance = new CandidatePastTeachingPosition();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of CandidatePastTeachingPosition
        /// </summary>
        [Test]
        public void CandidatePastTeachingPositionInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" CandidatePastTeachingPosition
            //Assert.IsInstanceOfType<CandidatePastTeachingPosition> (instance, "variable 'instance' is a CandidatePastTeachingPosition");
        }


        /// <summary>
        /// Test the property 'SubjectTaughtId'
        /// </summary>
        [Test]
        public void SubjectTaughtIdTest()
        {
            // TODO unit test for the property 'SubjectTaughtId'
        }
        /// <summary>
        /// Test the property 'EducationPhaseId'
        /// </summary>
        [Test]
        public void EducationPhaseIdTest()
        {
            // TODO unit test for the property 'EducationPhaseId'
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
