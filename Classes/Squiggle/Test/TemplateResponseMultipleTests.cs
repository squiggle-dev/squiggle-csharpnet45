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
    public class TemplateResponseMultipleTests
    {
        private TemplateResponseMultiple instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new TemplateResponseMultiple();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of TemplateResponseMultiple
        /// </summary>
        [Test]
        public void TemplateResponseMultipleInstanceTest()
        {
            Assert.IsInstanceOf<TemplateResponseMultiple> (instance, "instance is a TemplateResponseMultiple");
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
