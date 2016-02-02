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
    public class FileObjectTests
    {
        private FileObject instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FileObject();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of FileObject
        /// </summary>
        [Test]
        public void FileObjectInstanceTest()
        {
            Assert.IsInstanceOf<FileObject> (instance, "instance is a FileObject");
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
        /// Test the property 'Src' 
        /// </summary>
        [Test]
        public void SrcTest()
        {
            // TODO: unit test for the property 'Src' 
        }
        
        /// <summary>
        /// Test the property 'Size' 
        /// </summary>
        [Test]
        public void SizeTest()
        {
            // TODO: unit test for the property 'Size' 
        }
        

    }

}
