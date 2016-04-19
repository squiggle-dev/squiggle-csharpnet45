using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Squiggle.Api;
using Squiggle.Model;
using Squiggle.Client;
using System.Reflection;

namespace Squiggle.Test
{
    [TestFixture]
    public class JSONWebTokenResponseTests
    {
        private JSONWebTokenResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JSONWebTokenResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of JSONWebTokenResponse
        /// </summary>
        [Test]
        public void JSONWebTokenResponseInstanceTest()
        {
            Assert.IsInstanceOf<JSONWebTokenResponse> (instance, "instance is a JSONWebTokenResponse");
        }

        
        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
        }
        

    }

}
