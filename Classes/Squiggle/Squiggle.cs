using System;
using System.IO;
using System.Collections.Generic;
using RestSharp;
using Squiggle.Client;

namespace Squiggle
{
    
    public interface ISquiggle
    {
        
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        Object FindAddresses (int? offset, int? limit);
  
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> FindAddressesAsync (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AddAddress (Object data);
  
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddAddressAsync (Object data);
        
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>Object</returns>
        Object GetAddress (long? id);
  
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetAddressAsync (long? id);
        
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns></returns>
        void DeleteAddress (long? id);
  
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteAddressAsync (long? id);
        
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object EditAddress (long? id, Object data);
  
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> EditAddressAsync (long? id, Object data);
        
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        Object FindGlobalTemplates (int? offset, int? limit);
  
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> FindGlobalTemplatesAsync (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AddGlobalTemplate (Object data);
  
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddGlobalTemplateAsync (Object data);
        
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Object</returns>
        Object GetGlobalTemplate (long? id);
  
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetGlobalTemplateAsync (long? id);
        
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns></returns>
        void DeleteGlobalTemplate (long? id);
  
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteGlobalTemplateAsync (long? id);
        
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object EditGlobalTemplate (long? id, Object data);
  
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> EditGlobalTemplateAsync (long? id, Object data);
        
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        Object FindSnippets (int? offset, int? limit);
  
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> FindSnippetsAsync (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AddSnippet (Object data);
  
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddSnippetAsync (Object data);
        
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Object</returns>
        Object GetSnippet (long? id);
  
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetSnippetAsync (long? id);
        
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns></returns>
        void DeleteSnippet (long? id);
  
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteSnippetAsync (long? id);
        
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object EditSnippet (long? id, Object data);
  
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> EditSnippetAsync (long? id, Object data);
        
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        Object FindTemplates (int? offset, int? limit);
  
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> FindTemplatesAsync (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AddTemplate (Object data);
  
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddTemplateAsync (Object data);
        
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>Object</returns>
        Object GetTemplate (long? id);
  
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetTemplateAsync (long? id);
        
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns></returns>
        void DeleteTemplate (long? id);
  
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteTemplateAsync (long? id);
        
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object EditTemplate (long? id, Object data);
  
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> EditTemplateAsync (long? id, Object data);
        
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        Object FindUsers (int? offset, int? limit);
  
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> FindUsersAsync (int? offset, int? limit);
        
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object AddUser (Object data);
  
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> AddUserAsync (Object data);
        
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>Object</returns>
        Object GetUser (long? id);
  
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> GetUserAsync (long? id);
        
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns></returns>
        void DeleteUser (long? id);
  
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns></returns>
        System.Threading.Tasks.Task DeleteUserAsync (long? id);
        
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        Object EditUser (long? id, Object data);
  
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        System.Threading.Tasks.Task<Object> EditUserAsync (long? id, Object data);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class Squiggle : ISquiggle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Squiggle"/> class.
        /// </summary>
        /// <param name="apiClient"> an instance of ApiClient (optional)</param>
        /// <returns></returns>
        public Squiggle(ApiClient apiClient = null)
        {
            if (apiClient == null) // use the default one in Configuration
                this.ApiClient = Configuration.DefaultApiClient; 
            else
                this.ApiClient = apiClient;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Squiggle"/> class.
        /// </summary>
        /// <returns></returns>
        public Squiggle(String basePath)
        {
            this.ApiClient = new ApiClient(basePath);
        }
    
        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public void SetBasePath(String basePath)
        {
            this.ApiClient.BasePath = basePath;
        }
    
        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <param name="basePath">The base path</param>
        /// <value>The base path</value>
        public String GetBasePath(String basePath)
        {
            return this.ApiClient.BasePath;
        }
    
        /// <summary>
        /// Gets or sets the API client.
        /// </summary>
        /// <value>An instance of the ApiClient</param>
        public ApiClient ApiClient {get; set;}
    
        
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>Object</returns>            
        public Object FindAddresses (int? offset, int? limit)
        {
            
    
            var path = "/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindAddresses: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> FindAddressesAsync (int? offset, int? limit)
        {
            
    
            var path = "/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindAddresses: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object AddAddress (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddAddress");
            
    
            var path = "/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddAddressAsync (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddAddress");
            
    
            var path = "/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddAddress: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param> 
        /// <returns>Object</returns>            
        public Object GetAddress (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetAddressAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] {  };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetAddress: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param> 
        /// <returns></returns>            
        public void DeleteAddress (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteAddressAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteAddress: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param> 
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object EditAddress (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditAddress");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAddress: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> EditAddressAsync (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditAddress");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditAddress");
            
    
            var path = "/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditAddress: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>Object</returns>            
        public Object FindGlobalTemplates (int? offset, int? limit)
        {
            
    
            var path = "/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindGlobalTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindGlobalTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> FindGlobalTemplatesAsync (int? offset, int? limit)
        {
            
    
            var path = "/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindGlobalTemplates: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object AddGlobalTemplate (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddGlobalTemplate");
            
    
            var path = "/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddGlobalTemplateAsync (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddGlobalTemplate");
            
    
            var path = "/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddGlobalTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param> 
        /// <returns>Object</returns>            
        public Object GetGlobalTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetGlobalTemplateAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetGlobalTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param> 
        /// <returns></returns>            
        public void DeleteGlobalTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteGlobalTemplateAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteGlobalTemplate: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param> 
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object EditGlobalTemplate (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditGlobalTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditGlobalTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> EditGlobalTemplateAsync (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditGlobalTemplate");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditGlobalTemplate");
            
    
            var path = "/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditGlobalTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>Object</returns>            
        public Object FindSnippets (int? offset, int? limit)
        {
            
    
            var path = "/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindSnippets: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindSnippets: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> FindSnippetsAsync (int? offset, int? limit)
        {
            
    
            var path = "/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindSnippets: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object AddSnippet (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddSnippet");
            
    
            var path = "/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddSnippetAsync (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddSnippet");
            
    
            var path = "/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddSnippet: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param> 
        /// <returns>Object</returns>            
        public Object GetSnippet (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetSnippetAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetSnippet: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param> 
        /// <returns></returns>            
        public void DeleteSnippet (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteSnippetAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteSnippet: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param> 
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object EditSnippet (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditSnippet");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditSnippet: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> EditSnippetAsync (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditSnippet");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditSnippet");
            
    
            var path = "/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditSnippet: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>Object</returns>            
        public Object FindTemplates (int? offset, int? limit)
        {
            
    
            var path = "/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindTemplates: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> FindTemplatesAsync (int? offset, int? limit)
        {
            
    
            var path = "/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindTemplates: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object AddTemplate (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddTemplate");
            
    
            var path = "/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddTemplateAsync (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddTemplate");
            
    
            var path = "/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param> 
        /// <returns>Object</returns>            
        public Object GetTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetTemplateAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param> 
        /// <returns></returns>            
        public void DeleteTemplate (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteTemplateAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param> 
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object EditTemplate (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTemplate: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> EditTemplateAsync (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTemplate");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditTemplate");
            
    
            var path = "/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditTemplate: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>Object</returns>            
        public Object FindUsers (int? offset, int? limit)
        {
            
    
            var path = "/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> FindUsersAsync (int? offset, int? limit)
        {
            
    
            var path = "/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling FindUsers: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object AddUser (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddUser");
            
    
            var path = "/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> AddUserAsync (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddUser");
            
    
            var path = "/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.POST, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling AddUser: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param> 
        /// <returns>Object</returns>            
        public Object GetUser (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> GetUserAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.GET, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling GetUser: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param> 
        /// <returns></returns>            
        public void DeleteUser (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return;
        }
    
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns></returns>
        public async System.Threading.Tasks.Task DeleteUserAsync (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling DeleteUser: " + response.Content, response.Content);

            
            return;
        }
        
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param> 
        /// <param name="data"></param> 
        /// <returns>Object</returns>            
        public Object EditUser (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditUser");
            
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;

            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) ApiClient.CallApi(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
    
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (((int)response.StatusCode) == 0)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
    
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Object</returns>
        public async System.Threading.Tasks.Task<Object> EditUserAsync (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditUser");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditUser");
            
    
            var path = "/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            String postBody = null;
    
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = ApiClient.Serialize(data); // http body (model) parameter
            
    
            // authentication setting, if any
            String[] authSettings = new String[] { "jwt" };
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) await ApiClient.CallApiAsync(path, Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, pathParams, authSettings);
            if (((int)response.StatusCode) >= 400)
                throw new ApiException ((int)response.StatusCode, "Error calling EditUser: " + response.Content, response.Content);

            return (Object) ApiClient.Deserialize(response.Content, typeof(Object), response.Headers);
        }
        
    }
    
}
