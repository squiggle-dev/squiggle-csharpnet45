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
    public class GlobalTemplateTests
    {
        private GlobalTemplate instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new GlobalTemplate();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of GlobalTemplate
        /// </summary>
        [Test]
        public void GlobalTemplateInstanceTest()
        {
            Assert.IsInstanceOf<GlobalTemplate> (instance, "instance is a GlobalTemplate");
        }

        
        /// <summary>
        /// Test the property 'Id' 
        /// </summary>
        [Test]
        public void IdTest()
        {
            // TODO: unit test for the property 'Id' 
        }
        
        /// <summary>
        /// Test the property 'Name' 
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO: unit test for the property 'Name' 
        }
        
        /// <summary>
        /// Test the property 'Description' 
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO: unit test for the property 'Description' 
        }
        
        /// <summary>
        /// Test the property 'Thumbnail' 
        /// </summary>
        [Test]
        public void ThumbnailTest()
        {
            // TODO: unit test for the property 'Thumbnail' 
        }
        
        /// <summary>
        /// Test the property 'ContentHtml' 
        /// </summary>
        [Test]
        public void ContentHtmlTest()
        {
            // TODO: unit test for the property 'ContentHtml' 
        }
        
        /// <summary>
        /// Test the property 'ContentPlaintext' 
        /// </summary>
        [Test]
        public void ContentPlaintextTest()
        {
            // TODO: unit test for the property 'ContentPlaintext' 
        }
        
        /// <summary>
        /// Test the property 'Settings' 
        /// </summary>
        [Test]
        public void SettingsTest()
        {
            // TODO: unit test for the property 'Settings' 
        }
        
        /// <summary>
        /// Test the property 'CreatedAt' 
        /// </summary>
        [Test]
        public void CreatedAtTest()
        {
            // TODO: unit test for the property 'CreatedAt' 
        }
        
        /// <summary>
        /// Test the property 'UpdatedAt' 
        /// </summary>
        [Test]
        public void UpdatedAtTest()
        {
            // TODO: unit test for the property 'UpdatedAt' 
        }
        

    }

}
