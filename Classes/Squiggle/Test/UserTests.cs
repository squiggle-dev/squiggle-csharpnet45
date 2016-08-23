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
    public class UserTests
    {
        private User instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new User();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of User
        /// </summary>
        [Test]
        public void UserInstanceTest()
        {
            Assert.IsInstanceOf<User> (instance, "instance is a User");
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
        /// Test the property 'CompanyName' 
        /// </summary>
        [Test]
        public void CompanyNameTest()
        {
            // TODO: unit test for the property 'CompanyName' 
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
        /// Test the property 'Domain' 
        /// </summary>
        [Test]
        public void DomainTest()
        {
            // TODO: unit test for the property 'Domain' 
        }
        
        /// <summary>
        /// Test the property 'Address1' 
        /// </summary>
        [Test]
        public void Address1Test()
        {
            // TODO: unit test for the property 'Address1' 
        }
        
        /// <summary>
        /// Test the property 'Address2' 
        /// </summary>
        [Test]
        public void Address2Test()
        {
            // TODO: unit test for the property 'Address2' 
        }
        
        /// <summary>
        /// Test the property 'Address3' 
        /// </summary>
        [Test]
        public void Address3Test()
        {
            // TODO: unit test for the property 'Address3' 
        }
        
        /// <summary>
        /// Test the property 'AddressCity' 
        /// </summary>
        [Test]
        public void AddressCityTest()
        {
            // TODO: unit test for the property 'AddressCity' 
        }
        
        /// <summary>
        /// Test the property 'AddressPostcode' 
        /// </summary>
        [Test]
        public void AddressPostcodeTest()
        {
            // TODO: unit test for the property 'AddressPostcode' 
        }
        
        /// <summary>
        /// Test the property 'AddressCountry' 
        /// </summary>
        [Test]
        public void AddressCountryTest()
        {
            // TODO: unit test for the property 'AddressCountry' 
        }
        
        /// <summary>
        /// Test the property 'Website' 
        /// </summary>
        [Test]
        public void WebsiteTest()
        {
            // TODO: unit test for the property 'Website' 
        }
        
        /// <summary>
        /// Test the property 'Tel' 
        /// </summary>
        [Test]
        public void TelTest()
        {
            // TODO: unit test for the property 'Tel' 
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
        /// Test the property 'Logo' 
        /// </summary>
        [Test]
        public void LogoTest()
        {
            // TODO: unit test for the property 'Logo' 
        }
        
        /// <summary>
        /// Test the property 'Snippet' 
        /// </summary>
        [Test]
        public void SnippetTest()
        {
            // TODO: unit test for the property 'Snippet' 
        }
        
        /// <summary>
        /// Test the property 'SecretKey' 
        /// </summary>
        [Test]
        public void SecretKeyTest()
        {
            // TODO: unit test for the property 'SecretKey' 
        }
        
        /// <summary>
        /// Test the property 'AccessToken' 
        /// </summary>
        [Test]
        public void AccessTokenTest()
        {
            // TODO: unit test for the property 'AccessToken' 
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
