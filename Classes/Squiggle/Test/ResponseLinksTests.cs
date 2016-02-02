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
    public class ResponseLinksTests
    {
        private ResponseLinks instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ResponseLinks();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of ResponseLinks
        /// </summary>
        [Test]
        public void ResponseLinksInstanceTest()
        {
            Assert.IsInstanceOf<ResponseLinks> (instance, "instance is a ResponseLinks");
        }

        
        /// <summary>
        /// Test the property 'Self' 
        /// </summary>
        [Test]
        public void SelfTest()
        {
            // TODO: unit test for the property 'Self' 
        }
        
        /// <summary>
        /// Test the property 'Related' 
        /// </summary>
        [Test]
        public void RelatedTest()
        {
            // TODO: unit test for the property 'Related' 
        }
        
        /// <summary>
        /// Test the property 'Next' 
        /// </summary>
        [Test]
        public void NextTest()
        {
            // TODO: unit test for the property 'Next' 
        }
        
        /// <summary>
        /// Test the property 'Last' 
        /// </summary>
        [Test]
        public void LastTest()
        {
            // TODO: unit test for the property 'Last' 
        }
        

    }

}
