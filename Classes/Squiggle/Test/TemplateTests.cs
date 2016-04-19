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
    public class TemplateTests
    {
        private Template instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Template();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Template
        /// </summary>
        [Test]
        public void TemplateInstanceTest()
        {
            Assert.IsInstanceOf<Template> (instance, "instance is a Template");
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        
        /// <summary>
        /// Test the property 'GlobalTemplate' 
        /// </summary>
        [Test]
        public void GlobalTemplateTest()
        {
            // TODO: unit test for the property 'GlobalTemplate' 
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
        /// Test the property 'Thumbnail' 
        /// </summary>
        [Test]
        public void ThumbnailTest()
        {
            // TODO: unit test for the property 'Thumbnail' 
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
