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
    public class SnippetTests
    {
        private Snippet instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Snippet();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Snippet
        /// </summary>
        [Test]
        public void SnippetInstanceTest()
        {
            Assert.IsInstanceOf<Snippet> (instance, "instance is a Snippet");
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
        /// Test the property 'ContentRichtext' 
        /// </summary>
        [Test]
        public void ContentRichtextTest()
        {
            // TODO: unit test for the property 'ContentRichtext' 
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
        /// Test the property 'User' 
        /// </summary>
        [Test]
        public void UserTest()
        {
            // TODO: unit test for the property 'User' 
        }
        

    }

}
