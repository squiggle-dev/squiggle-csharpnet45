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
    public class AddressTests
    {
        private Address instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new Address();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of Address
        /// </summary>
        [Test]
        public void AddressInstanceTest()
        {
            Assert.IsInstanceOf<Address> (instance, "instance is a Address");
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
        /// Test the property 'Email' 
        /// </summary>
        [Test]
        public void EmailTest()
        {
            // TODO: unit test for the property 'Email' 
        }
        
        /// <summary>
        /// Test the property 'Password' 
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO: unit test for the property 'Password' 
        }
        
        /// <summary>
        /// Test the property 'FirstName' 
        /// </summary>
        [Test]
        public void FirstNameTest()
        {
            // TODO: unit test for the property 'FirstName' 
        }
        
        /// <summary>
        /// Test the property 'LastName' 
        /// </summary>
        [Test]
        public void LastNameTest()
        {
            // TODO: unit test for the property 'LastName' 
        }
        
        /// <summary>
        /// Test the property 'JobTitle' 
        /// </summary>
        [Test]
        public void JobTitleTest()
        {
            // TODO: unit test for the property 'JobTitle' 
        }
        
        /// <summary>
        /// Test the property 'TelMobile' 
        /// </summary>
        [Test]
        public void TelMobileTest()
        {
            // TODO: unit test for the property 'TelMobile' 
        }
        
        /// <summary>
        /// Test the property 'TelDirect' 
        /// </summary>
        [Test]
        public void TelDirectTest()
        {
            // TODO: unit test for the property 'TelDirect' 
        }
        
        /// <summary>
        /// Test the property 'Linkedin' 
        /// </summary>
        [Test]
        public void LinkedinTest()
        {
            // TODO: unit test for the property 'Linkedin' 
        }
        
        /// <summary>
        /// Test the property 'Facebook' 
        /// </summary>
        [Test]
        public void FacebookTest()
        {
            // TODO: unit test for the property 'Facebook' 
        }
        
        /// <summary>
        /// Test the property 'Twitter' 
        /// </summary>
        [Test]
        public void TwitterTest()
        {
            // TODO: unit test for the property 'Twitter' 
        }
        
        /// <summary>
        /// Test the property 'Instagram' 
        /// </summary>
        [Test]
        public void InstagramTest()
        {
            // TODO: unit test for the property 'Instagram' 
        }
        
        /// <summary>
        /// Test the property 'Googleplus' 
        /// </summary>
        [Test]
        public void GoogleplusTest()
        {
            // TODO: unit test for the property 'Googleplus' 
        }
        
        /// <summary>
        /// Test the property 'Signatures' 
        /// </summary>
        [Test]
        public void SignaturesTest()
        {
            // TODO: unit test for the property 'Signatures' 
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
