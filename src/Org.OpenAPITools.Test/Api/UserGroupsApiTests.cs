/*
 * Theta Lake API
 *
 * We are excited to inform you that our documentation is interactive!  If you are logged in, this means that you can not only read about the features and capabilities of our product, but also try them out directly from the documentation pages. Our interactive documentation provides a hands-on experience that allows you to test the API endpoints, experiment with the input parameters, and see the corresponding responses. This makes it easier to understand how the API works and how to integrate it into your own applications. With interactive documentation, you can save time and avoid frustration by testing the API right from the documentation pages, without having to set up a local development environment. Whether you're a seasoned developer or just starting out, our interactive documentation is the perfect tool to help you learn, experiment, and succeed with our API. 
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing UserGroupsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserGroupsApiTests : IDisposable
    {
        private UserGroupsApi instance;

        public UserGroupsApiTests()
        {
            instance = new UserGroupsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserGroupsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserGroupsApi
            //Assert.IsType<UserGroupsApi>(instance);
        }

        /// <summary>
        /// Test UserGroupsGet
        /// </summary>
        [Fact]
        public void UserGroupsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGroupsGet();
            //Assert.IsType<GetUserGroupsResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsIdAddUsersPut
        /// </summary>
        [Fact]
        public void UserGroupsIdAddUsersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //List<int> requestBody = null;
            //var response = instance.UserGroupsIdAddUsersPut(id, requestBody);
            //Assert.IsType<PutUserGroupsResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsIdDelete
        /// </summary>
        [Fact]
        public void UserGroupsIdDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.UserGroupsIdDelete(id);
            //Assert.IsType<DeleteUserGroupsResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsIdGet
        /// </summary>
        [Fact]
        public void UserGroupsIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //var response = instance.UserGroupsIdGet(id);
            //Assert.IsType<GetUserGroupsIdResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsIdPut
        /// </summary>
        [Fact]
        public void UserGroupsIdPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //PostPutUserGroupsRequest postPutUserGroupsRequest = null;
            //var response = instance.UserGroupsIdPut(id, postPutUserGroupsRequest);
            //Assert.IsType<PostUserGroupsResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsIdRemoveUsersPut
        /// </summary>
        [Fact]
        public void UserGroupsIdRemoveUsersPutTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //List<int> requestBody = null;
            //var response = instance.UserGroupsIdRemoveUsersPut(id, requestBody);
            //Assert.IsType<PutUserGroupsResponse>(response);
        }

        /// <summary>
        /// Test UserGroupsPost
        /// </summary>
        [Fact]
        public void UserGroupsPostTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PostPutUserGroupsRequest postPutUserGroupsRequest = null;
            //var response = instance.UserGroupsPost(postPutUserGroupsRequest);
            //Assert.IsType<PostUserGroupsResponse>(response);
        }
    }
}
