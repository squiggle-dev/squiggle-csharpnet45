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
    public class GlobalTemplateResponseMultipleTests
    {
        private GlobalTemplateResponseMultiple instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GlobalTemplateResponseMultiple();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of GlobalTemplateResponseMultiple
        /// </summary>
        [Test]
        public void GlobalTemplateResponseMultipleInstanceTest()
        {
            Assert.IsInstanceOf<GlobalTemplateResponseMultiple> (instance, "instance is a GlobalTemplateResponseMultiple");
        }

        
        /// <summary>
        /// Test the property 'Data' 
        /// </summary>
        [Test]
        public void DataTest()
        {
            // TODO: unit test for the property 'Data' 
        }
        
        /// <summary>
        /// Test the property 'Links' 
        /// </summary>
        [Test]
        public void LinksTest()
        {
            // TODO: unit test for the property 'Links' 
        }
        

    }

}
