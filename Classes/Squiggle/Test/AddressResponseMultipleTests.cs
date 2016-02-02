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
    public class AddressResponseMultipleTests
    {
        private AddressResponseMultiple instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new AddressResponseMultiple();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of AddressResponseMultiple
        /// </summary>
        [Test]
        public void AddressResponseMultipleInstanceTest()
        {
            Assert.IsInstanceOf<AddressResponseMultiple> (instance, "instance is a AddressResponseMultiple");
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
