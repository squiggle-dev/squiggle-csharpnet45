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
    public class JSONWebTokenTests
    {
        private JSONWebToken instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new JSONWebToken();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of JSONWebToken
        /// </summary>
        [Test]
        public void JSONWebTokenInstanceTest()
        {
            Assert.IsInstanceOf<JSONWebToken> (instance, "instance is a JSONWebToken");
        }

        
        /// <summary>
        /// Test the property 'Token' 
        /// </summary>
        [Test]
        public void TokenTest()
        {
            // TODO: unit test for the property 'Token' 
        }
        

    }

}
