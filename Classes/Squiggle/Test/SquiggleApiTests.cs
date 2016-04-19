using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Squiggle.Client;
using Squiggle.Api;
using Squiggle.Model;

namespace Squiggle.Test
{
    [TestFixture]
    public class SquiggleApiTests
    {
        private SquiggleApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
           instance = new SquiggleApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of SquiggleApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<SquiggleApi> (instance, "instance is a SquiggleApi");
        }

        
        /// <summary>
        /// Test FindAddresses
        /// </summary>
        [Test]
        public void FindAddressesTest()
        {
            // TODO: add unit test for the method 'FindAddresses'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindAddresses(offset, limit);
            Assert.IsInstanceOf<AddressResponseMultiple> (response, "response is AddressResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddAddress
        /// </summary>
        [Test]
        public void AddAddressTest()
        {
            // TODO: add unit test for the method 'AddAddress'
            Address data = null; // TODO: replace null with proper value
            
            var response = instance.AddAddress(data);
            Assert.IsInstanceOf<AddressResponseSingle> (response, "response is AddressResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetAddress
        /// </summary>
        [Test]
        public void GetAddressTest()
        {
            // TODO: add unit test for the method 'GetAddress'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetAddress(id);
            Assert.IsInstanceOf<AddressResponseSingle> (response, "response is AddressResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteAddress
        /// </summary>
        [Test]
        public void DeleteAddressTest()
        {
            // TODO: add unit test for the method 'DeleteAddress'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteAddress(id);
             
        }
        
        /// <summary>
        /// Test EditAddress
        /// </summary>
        [Test]
        public void EditAddressTest()
        {
            // TODO: add unit test for the method 'EditAddress'
            long? id = null; // TODO: replace null with proper value
            Address data = null; // TODO: replace null with proper value
            
            var response = instance.EditAddress(id, data);
            Assert.IsInstanceOf<AddressResponseSingle> (response, "response is AddressResponseSingle"); 
        }
        
        /// <summary>
        /// Test FindFiles
        /// </summary>
        [Test]
        public void FindFilesTest()
        {
            // TODO: add unit test for the method 'FindFiles'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindFiles(offset, limit);
            Assert.IsInstanceOf<FileResponseMultiple> (response, "response is FileResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddFile
        /// </summary>
        [Test]
        public void AddFileTest()
        {
            // TODO: add unit test for the method 'AddFile'
            Stream file = null; // TODO: replace null with proper value
            
            var response = instance.AddFile(file);
            Assert.IsInstanceOf<FileResponseSingle> (response, "response is FileResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetFile
        /// </summary>
        [Test]
        public void GetFileTest()
        {
            // TODO: add unit test for the method 'GetFile'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetFile(id);
            Assert.IsInstanceOf<FileResponseSingle> (response, "response is FileResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteFile
        /// </summary>
        [Test]
        public void DeleteFileTest()
        {
            // TODO: add unit test for the method 'DeleteFile'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteFile(id);
             
        }
        
        /// <summary>
        /// Test EditFile
        /// </summary>
        [Test]
        public void EditFileTest()
        {
            // TODO: add unit test for the method 'EditFile'
            long? id = null; // TODO: replace null with proper value
            FileObject data = null; // TODO: replace null with proper value
            
            var response = instance.EditFile(id, data);
            Assert.IsInstanceOf<FileResponseSingle> (response, "response is FileResponseSingle"); 
        }
        
        /// <summary>
        /// Test FindGlobalTemplates
        /// </summary>
        [Test]
        public void FindGlobalTemplatesTest()
        {
            // TODO: add unit test for the method 'FindGlobalTemplates'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindGlobalTemplates(offset, limit);
            Assert.IsInstanceOf<GlobalTemplateResponseMultiple> (response, "response is GlobalTemplateResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddGlobalTemplate
        /// </summary>
        [Test]
        public void AddGlobalTemplateTest()
        {
            // TODO: add unit test for the method 'AddGlobalTemplate'
            GlobalTemplate data = null; // TODO: replace null with proper value
            
            var response = instance.AddGlobalTemplate(data);
            Assert.IsInstanceOf<GlobalTemplateResponseSingle> (response, "response is GlobalTemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetGlobalTemplate
        /// </summary>
        [Test]
        public void GetGlobalTemplateTest()
        {
            // TODO: add unit test for the method 'GetGlobalTemplate'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetGlobalTemplate(id);
            Assert.IsInstanceOf<GlobalTemplateResponseSingle> (response, "response is GlobalTemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteGlobalTemplate
        /// </summary>
        [Test]
        public void DeleteGlobalTemplateTest()
        {
            // TODO: add unit test for the method 'DeleteGlobalTemplate'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteGlobalTemplate(id);
             
        }
        
        /// <summary>
        /// Test EditGlobalTemplate
        /// </summary>
        [Test]
        public void EditGlobalTemplateTest()
        {
            // TODO: add unit test for the method 'EditGlobalTemplate'
            long? id = null; // TODO: replace null with proper value
            GlobalTemplate data = null; // TODO: replace null with proper value
            
            var response = instance.EditGlobalTemplate(id, data);
            Assert.IsInstanceOf<GlobalTemplateResponseSingle> (response, "response is GlobalTemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test FindSnippets
        /// </summary>
        [Test]
        public void FindSnippetsTest()
        {
            // TODO: add unit test for the method 'FindSnippets'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindSnippets(offset, limit);
            Assert.IsInstanceOf<SnippetResponseMultiple> (response, "response is SnippetResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddSnippet
        /// </summary>
        [Test]
        public void AddSnippetTest()
        {
            // TODO: add unit test for the method 'AddSnippet'
            Snippet data = null; // TODO: replace null with proper value
            
            var response = instance.AddSnippet(data);
            Assert.IsInstanceOf<SnippetResponseSingle> (response, "response is SnippetResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetSnippet
        /// </summary>
        [Test]
        public void GetSnippetTest()
        {
            // TODO: add unit test for the method 'GetSnippet'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetSnippet(id);
            Assert.IsInstanceOf<SnippetResponseSingle> (response, "response is SnippetResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteSnippet
        /// </summary>
        [Test]
        public void DeleteSnippetTest()
        {
            // TODO: add unit test for the method 'DeleteSnippet'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteSnippet(id);
             
        }
        
        /// <summary>
        /// Test EditSnippet
        /// </summary>
        [Test]
        public void EditSnippetTest()
        {
            // TODO: add unit test for the method 'EditSnippet'
            long? id = null; // TODO: replace null with proper value
            Snippet data = null; // TODO: replace null with proper value
            
            var response = instance.EditSnippet(id, data);
            Assert.IsInstanceOf<SnippetResponseSingle> (response, "response is SnippetResponseSingle"); 
        }
        
        /// <summary>
        /// Test FindTemplates
        /// </summary>
        [Test]
        public void FindTemplatesTest()
        {
            // TODO: add unit test for the method 'FindTemplates'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindTemplates(offset, limit);
            Assert.IsInstanceOf<TemplateResponseMultiple> (response, "response is TemplateResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddTemplate
        /// </summary>
        [Test]
        public void AddTemplateTest()
        {
            // TODO: add unit test for the method 'AddTemplate'
            Template data = null; // TODO: replace null with proper value
            
            var response = instance.AddTemplate(data);
            Assert.IsInstanceOf<TemplateResponseSingle> (response, "response is TemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetTemplate
        /// </summary>
        [Test]
        public void GetTemplateTest()
        {
            // TODO: add unit test for the method 'GetTemplate'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetTemplate(id);
            Assert.IsInstanceOf<TemplateResponseSingle> (response, "response is TemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteTemplate
        /// </summary>
        [Test]
        public void DeleteTemplateTest()
        {
            // TODO: add unit test for the method 'DeleteTemplate'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteTemplate(id);
             
        }
        
        /// <summary>
        /// Test EditTemplate
        /// </summary>
        [Test]
        public void EditTemplateTest()
        {
            // TODO: add unit test for the method 'EditTemplate'
            long? id = null; // TODO: replace null with proper value
            Template data = null; // TODO: replace null with proper value
            
            var response = instance.EditTemplate(id, data);
            Assert.IsInstanceOf<TemplateResponseSingle> (response, "response is TemplateResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetAddressToken
        /// </summary>
        [Test]
        public void GetAddressTokenTest()
        {
            // TODO: add unit test for the method 'GetAddressToken'
            LoginDetails data = null; // TODO: replace null with proper value
            
            var response = instance.GetAddressToken(data);
            Assert.IsInstanceOf<JSONWebTokenResponse> (response, "response is JSONWebTokenResponse"); 
        }
        
        /// <summary>
        /// Test GetUserToken
        /// </summary>
        [Test]
        public void GetUserTokenTest()
        {
            // TODO: add unit test for the method 'GetUserToken'
            LoginDetails data = null; // TODO: replace null with proper value
            
            var response = instance.GetUserToken(data);
            Assert.IsInstanceOf<JSONWebTokenResponse> (response, "response is JSONWebTokenResponse"); 
        }
        
        /// <summary>
        /// Test FindUsers
        /// </summary>
        [Test]
        public void FindUsersTest()
        {
            // TODO: add unit test for the method 'FindUsers'
            int? offset = null; // TODO: replace null with proper value
            int? limit = null; // TODO: replace null with proper value
            
            var response = instance.FindUsers(offset, limit);
            Assert.IsInstanceOf<UserResponseMultiple> (response, "response is UserResponseMultiple"); 
        }
        
        /// <summary>
        /// Test AddUser
        /// </summary>
        [Test]
        public void AddUserTest()
        {
            // TODO: add unit test for the method 'AddUser'
            User data = null; // TODO: replace null with proper value
            
            var response = instance.AddUser(data);
            Assert.IsInstanceOf<UserResponseSingle> (response, "response is UserResponseSingle"); 
        }
        
        /// <summary>
        /// Test GetUser
        /// </summary>
        [Test]
        public void GetUserTest()
        {
            // TODO: add unit test for the method 'GetUser'
            long? id = null; // TODO: replace null with proper value
            
            var response = instance.GetUser(id);
            Assert.IsInstanceOf<UserResponseSingle> (response, "response is UserResponseSingle"); 
        }
        
        /// <summary>
        /// Test DeleteUser
        /// </summary>
        [Test]
        public void DeleteUserTest()
        {
            // TODO: add unit test for the method 'DeleteUser'
            long? id = null; // TODO: replace null with proper value
            
            instance.DeleteUser(id);
             
        }
        
        /// <summary>
        /// Test EditUser
        /// </summary>
        [Test]
        public void EditUserTest()
        {
            // TODO: add unit test for the method 'EditUser'
            long? id = null; // TODO: replace null with proper value
            User data = null; // TODO: replace null with proper value
            
            var response = instance.EditUser(id, data);
            Assert.IsInstanceOf<UserResponseSingle> (response, "response is UserResponseSingle"); 
        }
        
    }

}
