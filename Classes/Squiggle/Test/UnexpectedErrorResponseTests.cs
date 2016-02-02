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
    public class UnexpectedErrorResponseTests
    {
        private UnexpectedErrorResponse instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new UnexpectedErrorResponse();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of UnexpectedErrorResponse
        /// </summary>
        [Test]
        public void UnexpectedErrorResponseInstanceTest()
        {
            Assert.IsInstanceOf<UnexpectedErrorResponse> (instance, "instance is a UnexpectedErrorResponse");
        }

        
        /// <summary>
        /// Test the property 'Errors' 
        /// </summary>
        [Test]
        public void ErrorsTest()
        {
            // TODO: unit test for the property 'Errors' 
        }
        

    }

}
