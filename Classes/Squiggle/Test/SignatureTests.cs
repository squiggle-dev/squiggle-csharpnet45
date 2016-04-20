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
    public class SignatureTests
    {
        private Signature instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Signature();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Signature
        /// </summary>
        [Test]
        public void SignatureInstanceTest()
        {
            Assert.IsInstanceOf<Signature> (instance, "instance is a Signature");
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
        /// Test the property 'Template' 
        /// </summary>
        [Test]
        public void TemplateTest()
        {
            // TODO: unit test for the property 'Template' 
        }
        
        /// <summary>
        /// Test the property 'Plain' 
        /// </summary>
        [Test]
        public void PlainTest()
        {
            // TODO: unit test for the property 'Plain' 
        }
        
        /// <summary>
        /// Test the property 'Html' 
        /// </summary>
        [Test]
        public void HtmlTest()
        {
            // TODO: unit test for the property 'Html' 
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
