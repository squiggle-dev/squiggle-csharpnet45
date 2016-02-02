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
    public class LoginDetailsTests
    {
        private LoginDetails instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new LoginDetails();
        }
    
        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }   

        /// <summary>
        /// Test an instance of LoginDetails
        /// </summary>
        [Test]
        public void LoginDetailsInstanceTest()
        {
            Assert.IsInstanceOf<LoginDetails> (instance, "instance is a LoginDetails");
        }

        
        /// <summary>
        /// Test the property 'Username' 
        /// </summary>
        [Test]
        public void UsernameTest()
        {
            // TODO: unit test for the property 'Username' 
        }
        
        /// <summary>
        /// Test the property 'Password' 
        /// </summary>
        [Test]
        public void PasswordTest()
        {
            // TODO: unit test for the property 'Password' 
        }
        

    }

}
