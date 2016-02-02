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
    public class SignatureResponseSingleTests
    {
        private SignatureResponseSingle instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new SignatureResponseSingle();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of SignatureResponseSingle
        /// </summary>
        [Test]
        public void SignatureResponseSingleInstanceTest()
        {
            Assert.IsInstanceOf<SignatureResponseSingle> (instance, "instance is a SignatureResponseSingle");
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
