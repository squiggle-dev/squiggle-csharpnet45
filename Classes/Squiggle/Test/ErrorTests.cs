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
    public class ErrorTests
    {
        private Error instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Error();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Error
        /// </summary>
        [Test]
        public void ErrorInstanceTest()
        {
            Assert.IsInstanceOf<Error> (instance, "instance is a Error");
        }

        
        /// <summary>
        /// Test the property 'Code' 
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO: unit test for the property 'Code' 
        }
        
        /// <summary>
        /// Test the property 'Detail' 
        /// </summary>
        [Test]
        public void DetailTest()
        {
            // TODO: unit test for the property 'Detail' 
        }
        

    }

}
