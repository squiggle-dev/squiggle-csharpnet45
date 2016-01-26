using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Squiggle.Client;
using Squiggle.Model;

namespace Squiggle
{
    
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISquiggleApi
    {
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request JWT for Address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>JSONWebTokenResponse</returns>
        JSONWebTokenResponse RequestAddressToken (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request JWT for Address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of JSONWebTokenResponse</returns>
        ApiResponse<JSONWebTokenResponse> RequestAddressTokenWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request JWT for Address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of JSONWebTokenResponse</returns>
        System.Threading.Tasks.Task<JSONWebTokenResponse> RequestAddressTokenAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Request JWT for Address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (JSONWebTokenResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<JSONWebTokenResponse>> RequestAddressTokenAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets addresses
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>AddressResponseMultiple</returns>
        AddressResponseMultiple FindAddresses (int? offset, int? limit);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets addresses
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>ApiResponse of AddressResponseMultiple</returns>
        ApiResponse<AddressResponseMultiple> FindAddressesWithHttpInfo (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets addresses
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of AddressResponseMultiple</returns>
        System.Threading.Tasks.Task<AddressResponseMultiple> FindAddressesAsync (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets addresses
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (AddressResponseMultiple)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressResponseMultiple>> FindAddressesAsyncWithHttpInfo (int? offset, int? limit);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle AddAddress (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        ApiResponse<AddressResponseSingle> AddAddressWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of AddressResponseSingle</returns>
        System.Threading.Tasks.Task<AddressResponseSingle> AddAddressAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new address
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> AddAddressAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to get</param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle GetAddress (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to get</param>
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        ApiResponse<AddressResponseSingle> GetAddressWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to get</param>
        /// <returns>Task of AddressResponseSingle</returns>
        System.Threading.Tasks.Task<AddressResponseSingle> GetAddressAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to get</param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> GetAddressAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to delete</param>
        /// <returns></returns>
        void DeleteAddress (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteAddressWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteAddressAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes an address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAddressAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>AddressResponseSingle</returns>
        AddressResponseSingle EditAddress (long? id, Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        ApiResponse<AddressResponseSingle> EditAddressWithHttpInfo (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Task of AddressResponseSingle</returns>
        System.Threading.Tasks.Task<AddressResponseSingle> EditAddressAsync (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing address with the specified ID
        /// </remarks>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> EditAddressAsyncWithHttpInfo (long? id, Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets global templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>GlobalTemplateResponseMultiple</returns>
        GlobalTemplateResponseMultiple FindGlobalTemplates (int? offset, int? limit);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets global templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>ApiResponse of GlobalTemplateResponseMultiple</returns>
        ApiResponse<GlobalTemplateResponseMultiple> FindGlobalTemplatesWithHttpInfo (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets global templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of GlobalTemplateResponseMultiple</returns>
        System.Threading.Tasks.Task<GlobalTemplateResponseMultiple> FindGlobalTemplatesAsync (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets global templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseMultiple)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseMultiple>> FindGlobalTemplatesAsyncWithHttpInfo (int? offset, int? limit);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new global template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle AddGlobalTemplate (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new global template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        ApiResponse<GlobalTemplateResponseSingle> AddGlobalTemplateWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new global template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        System.Threading.Tasks.Task<GlobalTemplateResponseSingle> AddGlobalTemplateAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new global template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> AddGlobalTemplateAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to get</param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle GetGlobalTemplate (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to get</param>
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        ApiResponse<GlobalTemplateResponseSingle> GetGlobalTemplateWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        System.Threading.Tasks.Task<GlobalTemplateResponseSingle> GetGlobalTemplateAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> GetGlobalTemplateAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to delete</param>
        /// <returns></returns>
        void DeleteGlobalTemplate (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteGlobalTemplateWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteGlobalTemplateAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteGlobalTemplateAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>GlobalTemplateResponseSingle</returns>
        GlobalTemplateResponseSingle EditGlobalTemplate (long? id, Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        ApiResponse<GlobalTemplateResponseSingle> EditGlobalTemplateWithHttpInfo (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        System.Threading.Tasks.Task<GlobalTemplateResponseSingle> EditGlobalTemplateAsync (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing global template with the specified ID
        /// </remarks>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> EditGlobalTemplateAsyncWithHttpInfo (long? id, Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets snippets
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>SnippetResponseMultiple</returns>
        SnippetResponseMultiple FindSnippets (int? offset, int? limit);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets snippets
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>ApiResponse of SnippetResponseMultiple</returns>
        ApiResponse<SnippetResponseMultiple> FindSnippetsWithHttpInfo (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets snippets
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of SnippetResponseMultiple</returns>
        System.Threading.Tasks.Task<SnippetResponseMultiple> FindSnippetsAsync (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets snippets
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (SnippetResponseMultiple)</returns>
        System.Threading.Tasks.Task<ApiResponse<SnippetResponseMultiple>> FindSnippetsAsyncWithHttpInfo (int? offset, int? limit);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new snippet
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle AddSnippet (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new snippet
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        ApiResponse<SnippetResponseSingle> AddSnippetWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new snippet
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of SnippetResponseSingle</returns>
        System.Threading.Tasks.Task<SnippetResponseSingle> AddSnippetAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new snippet
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> AddSnippetAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle GetSnippet (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        ApiResponse<SnippetResponseSingle> GetSnippetWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Task of SnippetResponseSingle</returns>
        System.Threading.Tasks.Task<SnippetResponseSingle> GetSnippetAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> GetSnippetAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns></returns>
        void DeleteSnippet (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteSnippetWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteSnippetAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSnippetAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>SnippetResponseSingle</returns>
        SnippetResponseSingle EditSnippet (long? id, Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        ApiResponse<SnippetResponseSingle> EditSnippetWithHttpInfo (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Task of SnippetResponseSingle</returns>
        System.Threading.Tasks.Task<SnippetResponseSingle> EditSnippetAsync (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing snippet with the specified ID
        /// </remarks>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> EditSnippetAsyncWithHttpInfo (long? id, Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>TemplateResponseMultiple</returns>
        TemplateResponseMultiple FindTemplates (int? offset, int? limit);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>ApiResponse of TemplateResponseMultiple</returns>
        ApiResponse<TemplateResponseMultiple> FindTemplatesWithHttpInfo (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of TemplateResponseMultiple</returns>
        System.Threading.Tasks.Task<TemplateResponseMultiple> FindTemplatesAsync (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets templates
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (TemplateResponseMultiple)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResponseMultiple>> FindTemplatesAsyncWithHttpInfo (int? offset, int? limit);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle AddTemplate (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        ApiResponse<TemplateResponseSingle> AddTemplateWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of TemplateResponseSingle</returns>
        System.Threading.Tasks.Task<TemplateResponseSingle> AddTemplateAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new template
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> AddTemplateAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to get</param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle GetTemplate (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to get</param>
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        ApiResponse<TemplateResponseSingle> GetTemplateWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to get</param>
        /// <returns>Task of TemplateResponseSingle</returns>
        System.Threading.Tasks.Task<TemplateResponseSingle> GetTemplateAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to get</param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> GetTemplateAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to delete</param>
        /// <returns></returns>
        void DeleteTemplate (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteTemplateWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteTemplateAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTemplateAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>TemplateResponseSingle</returns>
        TemplateResponseSingle EditTemplate (long? id, Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        ApiResponse<TemplateResponseSingle> EditTemplateWithHttpInfo (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of TemplateResponseSingle</returns>
        System.Threading.Tasks.Task<TemplateResponseSingle> EditTemplateAsync (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing template with the specified ID
        /// </remarks>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> EditTemplateAsyncWithHttpInfo (long? id, Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets users
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>UserResponseMultiple</returns>
        UserResponseMultiple FindUsers (int? offset, int? limit);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets users
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>ApiResponse of UserResponseMultiple</returns>
        ApiResponse<UserResponseMultiple> FindUsersWithHttpInfo (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets users
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of UserResponseMultiple</returns>
        System.Threading.Tasks.Task<UserResponseMultiple> FindUsersAsync (int? offset, int? limit);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets users
        /// </remarks>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (UserResponseMultiple)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseMultiple>> FindUsersAsyncWithHttpInfo (int? offset, int? limit);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle AddUser (Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>ApiResponse of UserResponseSingle</returns>
        ApiResponse<UserResponseSingle> AddUserWithHttpInfo (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of UserResponseSingle</returns>
        System.Threading.Tasks.Task<UserResponseSingle> AddUserAsync (Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Creates a new user
        /// </remarks>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> AddUserAsyncWithHttpInfo (Object data);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to get</param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle GetUser (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to get</param>
        /// <returns>ApiResponse of UserResponseSingle</returns>
        ApiResponse<UserResponseSingle> GetUserWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to get</param>
        /// <returns>Task of UserResponseSingle</returns>
        System.Threading.Tasks.Task<UserResponseSingle> GetUserAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Gets a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to get</param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> GetUserAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to delete</param>
        /// <returns></returns>
        void DeleteUser (long? id);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to delete</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteUserWithHttpInfo (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to delete</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteUserAsync (long? id);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Deletes a user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to delete</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (long? id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>UserResponseSingle</returns>
        UserResponseSingle EditUser (long? id, Object data);
  
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>ApiResponse of UserResponseSingle</returns>
        ApiResponse<UserResponseSingle> EditUserWithHttpInfo (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Task of UserResponseSingle</returns>
        System.Threading.Tasks.Task<UserResponseSingle> EditUserAsync (long? id, Object data);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Updates an existing user with the specified ID
        /// </remarks>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> EditUserAsyncWithHttpInfo (long? id, Object data);
        
    }
  
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public class SquiggleApi : ISquiggleApi
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SquiggleApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SquiggleApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SquiggleApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SquiggleApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default; 
            else
                this.Configuration = configuration;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuraiton.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }
    
        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }
   
        
        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>JSONWebTokenResponse</returns>
        public JSONWebTokenResponse RequestAddressToken (Object data)
        {
             ApiResponse<JSONWebTokenResponse> response = RequestAddressTokenWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of JSONWebTokenResponse</returns>
        public ApiResponse< JSONWebTokenResponse > RequestAddressTokenWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->RequestAddressToken");
            
    
            var path_ = "/authentication/address";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RequestAddressToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RequestAddressToken: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<JSONWebTokenResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JSONWebTokenResponse) Configuration.ApiClient.Deserialize(response, typeof(JSONWebTokenResponse)));
            
        }
    
        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of JSONWebTokenResponse</returns>
        public async System.Threading.Tasks.Task<JSONWebTokenResponse> RequestAddressTokenAsync (Object data)
        {
             ApiResponse<JSONWebTokenResponse> response = await RequestAddressTokenAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Request JWT for Address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (JSONWebTokenResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<JSONWebTokenResponse>> RequestAddressTokenAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling RequestAddressToken");
            
    
            var path_ = "/authentication/address";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling RequestAddressToken: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling RequestAddressToken: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<JSONWebTokenResponse>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (JSONWebTokenResponse) Configuration.ApiClient.Deserialize(response, typeof(JSONWebTokenResponse)));
            
        }
        
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>AddressResponseMultiple</returns>
        public AddressResponseMultiple FindAddresses (int? offset, int? limit)
        {
             ApiResponse<AddressResponseMultiple> response = FindAddressesWithHttpInfo(offset, limit);
             return response.Data;
        }

        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>ApiResponse of AddressResponseMultiple</returns>
        public ApiResponse< AddressResponseMultiple > FindAddressesWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindAddresses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindAddresses: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AddressResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseMultiple)));
            
        }
    
        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of AddressResponseMultiple</returns>
        public async System.Threading.Tasks.Task<AddressResponseMultiple> FindAddressesAsync (int? offset, int? limit)
        {
             ApiResponse<AddressResponseMultiple> response = await FindAddressesAsyncWithHttpInfo(offset, limit);
             return response.Data;

        }

        /// <summary>
        ///  Gets addresses
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (AddressResponseMultiple)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressResponseMultiple>> FindAddressesAsyncWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindAddresses: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindAddresses: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AddressResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseMultiple)));
            
        }
        
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>AddressResponseSingle</returns>
        public AddressResponseSingle AddAddress (Object data)
        {
             ApiResponse<AddressResponseSingle> response = AddAddressWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        public ApiResponse< AddressResponseSingle > AddAddressWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->AddAddress");
            
    
            var path_ = "/v1/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
    
        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of AddressResponseSingle</returns>
        public async System.Threading.Tasks.Task<AddressResponseSingle> AddAddressAsync (Object data)
        {
             ApiResponse<AddressResponseSingle> response = await AddAddressAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Creates a new address
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> AddAddressAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddAddress");
            
    
            var path_ = "/v1/addresses";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddAddress: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param> 
        /// <returns>AddressResponseSingle</returns>
        public AddressResponseSingle GetAddress (long? id)
        {
             ApiResponse<AddressResponseSingle> response = GetAddressWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param> 
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        public ApiResponse< AddressResponseSingle > GetAddressWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->GetAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
    
        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>Task of AddressResponseSingle</returns>
        public async System.Threading.Tasks.Task<AddressResponseSingle> GetAddressAsync (long? id)
        {
             ApiResponse<AddressResponseSingle> response = await GetAddressAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Gets an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to get</param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> GetAddressAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetAddress: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
        
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param> 
        /// <returns></returns>
        public void DeleteAddress (long? id)
        {
             DeleteAddressWithHttpInfo(id);
        }

        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteAddressWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->DeleteAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteAddressAsync (long? id)
        {
             await DeleteAddressAsyncWithHttpInfo(id);

        }

        /// <summary>
        ///  Deletes an address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteAddressAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteAddress: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param> 
        /// <param name="data"></param> 
        /// <returns>AddressResponseSingle</returns>
        public AddressResponseSingle EditAddress (long? id, Object data)
        {
             ApiResponse<AddressResponseSingle> response = EditAddressWithHttpInfo(id, data);
             return response.Data;
        }

        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param> 
        /// <param name="data"></param> 
        /// <returns>ApiResponse of AddressResponseSingle</returns>
        public ApiResponse< AddressResponseSingle > EditAddressWithHttpInfo (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->EditAddress");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->EditAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditAddress: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
    
        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Task of AddressResponseSingle</returns>
        public async System.Threading.Tasks.Task<AddressResponseSingle> EditAddressAsync (long? id, Object data)
        {
             ApiResponse<AddressResponseSingle> response = await EditAddressAsyncWithHttpInfo(id, data);
             return response.Data;

        }

        /// <summary>
        ///  Updates an existing address with the specified ID
        /// </summary>
        /// <param name="id">ID of address to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (AddressResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<AddressResponseSingle>> EditAddressAsyncWithHttpInfo (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditAddress");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditAddress");
            
    
            var path_ = "/v1/addresses/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditAddress: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditAddress: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<AddressResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (AddressResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(AddressResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>GlobalTemplateResponseMultiple</returns>
        public GlobalTemplateResponseMultiple FindGlobalTemplates (int? offset, int? limit)
        {
             ApiResponse<GlobalTemplateResponseMultiple> response = FindGlobalTemplatesWithHttpInfo(offset, limit);
             return response.Data;
        }

        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>ApiResponse of GlobalTemplateResponseMultiple</returns>
        public ApiResponse< GlobalTemplateResponseMultiple > FindGlobalTemplatesWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindGlobalTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindGlobalTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GlobalTemplateResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseMultiple)));
            
        }
    
        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of GlobalTemplateResponseMultiple</returns>
        public async System.Threading.Tasks.Task<GlobalTemplateResponseMultiple> FindGlobalTemplatesAsync (int? offset, int? limit)
        {
             ApiResponse<GlobalTemplateResponseMultiple> response = await FindGlobalTemplatesAsyncWithHttpInfo(offset, limit);
             return response.Data;

        }

        /// <summary>
        ///  Gets global templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseMultiple)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseMultiple>> FindGlobalTemplatesAsyncWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindGlobalTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindGlobalTemplates: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GlobalTemplateResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseMultiple)));
            
        }
        
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>GlobalTemplateResponseSingle</returns>
        public GlobalTemplateResponseSingle AddGlobalTemplate (Object data)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = AddGlobalTemplateWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        public ApiResponse< GlobalTemplateResponseSingle > AddGlobalTemplateWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->AddGlobalTemplate");
            
    
            var path_ = "/v1/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<GlobalTemplateResponseSingle> AddGlobalTemplateAsync (Object data)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = await AddGlobalTemplateAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Creates a new global template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> AddGlobalTemplateAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddGlobalTemplate");
            
    
            var path_ = "/v1/global-templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param> 
        /// <returns>GlobalTemplateResponseSingle</returns>
        public GlobalTemplateResponseSingle GetGlobalTemplate (long? id)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = GetGlobalTemplateWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param> 
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        public ApiResponse< GlobalTemplateResponseSingle > GetGlobalTemplateWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->GetGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<GlobalTemplateResponseSingle> GetGlobalTemplateAsync (long? id)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = await GetGlobalTemplateAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Gets a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to get</param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> GetGlobalTemplateAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param> 
        /// <returns></returns>
        public void DeleteGlobalTemplate (long? id)
        {
             DeleteGlobalTemplateWithHttpInfo(id);
        }

        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteGlobalTemplateWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->DeleteGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteGlobalTemplateAsync (long? id)
        {
             await DeleteGlobalTemplateAsyncWithHttpInfo(id);

        }

        /// <summary>
        ///  Deletes a global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteGlobalTemplateAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param> 
        /// <param name="data"></param> 
        /// <returns>GlobalTemplateResponseSingle</returns>
        public GlobalTemplateResponseSingle EditGlobalTemplate (long? id, Object data)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = EditGlobalTemplateWithHttpInfo(id, data);
             return response.Data;
        }

        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param> 
        /// <param name="data"></param> 
        /// <returns>ApiResponse of GlobalTemplateResponseSingle</returns>
        public ApiResponse< GlobalTemplateResponseSingle > EditGlobalTemplateWithHttpInfo (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->EditGlobalTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->EditGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of GlobalTemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<GlobalTemplateResponseSingle> EditGlobalTemplateAsync (long? id, Object data)
        {
             ApiResponse<GlobalTemplateResponseSingle> response = await EditGlobalTemplateAsyncWithHttpInfo(id, data);
             return response.Data;

        }

        /// <summary>
        ///  Updates an existing global template with the specified ID
        /// </summary>
        /// <param name="id">ID of global template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (GlobalTemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GlobalTemplateResponseSingle>> EditGlobalTemplateAsyncWithHttpInfo (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditGlobalTemplate");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditGlobalTemplate");
            
    
            var path_ = "/v1/global-templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditGlobalTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditGlobalTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<GlobalTemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GlobalTemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(GlobalTemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>SnippetResponseMultiple</returns>
        public SnippetResponseMultiple FindSnippets (int? offset, int? limit)
        {
             ApiResponse<SnippetResponseMultiple> response = FindSnippetsWithHttpInfo(offset, limit);
             return response.Data;
        }

        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>ApiResponse of SnippetResponseMultiple</returns>
        public ApiResponse< SnippetResponseMultiple > FindSnippetsWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindSnippets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindSnippets: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SnippetResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseMultiple)));
            
        }
    
        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of SnippetResponseMultiple</returns>
        public async System.Threading.Tasks.Task<SnippetResponseMultiple> FindSnippetsAsync (int? offset, int? limit)
        {
             ApiResponse<SnippetResponseMultiple> response = await FindSnippetsAsyncWithHttpInfo(offset, limit);
             return response.Data;

        }

        /// <summary>
        ///  Gets snippets
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (SnippetResponseMultiple)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SnippetResponseMultiple>> FindSnippetsAsyncWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindSnippets: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindSnippets: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SnippetResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseMultiple)));
            
        }
        
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>SnippetResponseSingle</returns>
        public SnippetResponseSingle AddSnippet (Object data)
        {
             ApiResponse<SnippetResponseSingle> response = AddSnippetWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        public ApiResponse< SnippetResponseSingle > AddSnippetWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->AddSnippet");
            
    
            var path_ = "/v1/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
    
        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of SnippetResponseSingle</returns>
        public async System.Threading.Tasks.Task<SnippetResponseSingle> AddSnippetAsync (Object data)
        {
             ApiResponse<SnippetResponseSingle> response = await AddSnippetAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Creates a new snippet
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> AddSnippetAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddSnippet");
            
    
            var path_ = "/v1/snippets";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddSnippet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param> 
        /// <returns>SnippetResponseSingle</returns>
        public SnippetResponseSingle GetSnippet (long? id)
        {
             ApiResponse<SnippetResponseSingle> response = GetSnippetWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param> 
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        public ApiResponse< SnippetResponseSingle > GetSnippetWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->GetSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
    
        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Task of SnippetResponseSingle</returns>
        public async System.Threading.Tasks.Task<SnippetResponseSingle> GetSnippetAsync (long? id)
        {
             ApiResponse<SnippetResponseSingle> response = await GetSnippetAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Gets a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to get</param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> GetSnippetAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetSnippet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
        
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param> 
        /// <returns></returns>
        public void DeleteSnippet (long? id)
        {
             DeleteSnippetWithHttpInfo(id);
        }

        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteSnippetWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->DeleteSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteSnippetAsync (long? id)
        {
             await DeleteSnippetAsyncWithHttpInfo(id);

        }

        /// <summary>
        ///  Deletes a snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteSnippetAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteSnippet: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param> 
        /// <param name="data"></param> 
        /// <returns>SnippetResponseSingle</returns>
        public SnippetResponseSingle EditSnippet (long? id, Object data)
        {
             ApiResponse<SnippetResponseSingle> response = EditSnippetWithHttpInfo(id, data);
             return response.Data;
        }

        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param> 
        /// <param name="data"></param> 
        /// <returns>ApiResponse of SnippetResponseSingle</returns>
        public ApiResponse< SnippetResponseSingle > EditSnippetWithHttpInfo (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->EditSnippet");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->EditSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditSnippet: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
    
        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Task of SnippetResponseSingle</returns>
        public async System.Threading.Tasks.Task<SnippetResponseSingle> EditSnippetAsync (long? id, Object data)
        {
             ApiResponse<SnippetResponseSingle> response = await EditSnippetAsyncWithHttpInfo(id, data);
             return response.Data;

        }

        /// <summary>
        ///  Updates an existing snippet with the specified ID
        /// </summary>
        /// <param name="id">ID of snippet to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (SnippetResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SnippetResponseSingle>> EditSnippetAsyncWithHttpInfo (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditSnippet");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditSnippet");
            
    
            var path_ = "/v1/snippets/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditSnippet: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditSnippet: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<SnippetResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SnippetResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(SnippetResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>TemplateResponseMultiple</returns>
        public TemplateResponseMultiple FindTemplates (int? offset, int? limit)
        {
             ApiResponse<TemplateResponseMultiple> response = FindTemplatesWithHttpInfo(offset, limit);
             return response.Data;
        }

        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>ApiResponse of TemplateResponseMultiple</returns>
        public ApiResponse< TemplateResponseMultiple > FindTemplatesWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindTemplates: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseMultiple)));
            
        }
    
        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of TemplateResponseMultiple</returns>
        public async System.Threading.Tasks.Task<TemplateResponseMultiple> FindTemplatesAsync (int? offset, int? limit)
        {
             ApiResponse<TemplateResponseMultiple> response = await FindTemplatesAsyncWithHttpInfo(offset, limit);
             return response.Data;

        }

        /// <summary>
        ///  Gets templates
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (TemplateResponseMultiple)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateResponseMultiple>> FindTemplatesAsyncWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindTemplates: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindTemplates: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseMultiple)));
            
        }
        
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>TemplateResponseSingle</returns>
        public TemplateResponseSingle AddTemplate (Object data)
        {
             ApiResponse<TemplateResponseSingle> response = AddTemplateWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        public ApiResponse< TemplateResponseSingle > AddTemplateWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->AddTemplate");
            
    
            var path_ = "/v1/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of TemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<TemplateResponseSingle> AddTemplateAsync (Object data)
        {
             ApiResponse<TemplateResponseSingle> response = await AddTemplateAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Creates a new template
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> AddTemplateAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddTemplate");
            
    
            var path_ = "/v1/templates";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param> 
        /// <returns>TemplateResponseSingle</returns>
        public TemplateResponseSingle GetTemplate (long? id)
        {
             ApiResponse<TemplateResponseSingle> response = GetTemplateWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param> 
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        public ApiResponse< TemplateResponseSingle > GetTemplateWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->GetTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>Task of TemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<TemplateResponseSingle> GetTemplateAsync (long? id)
        {
             ApiResponse<TemplateResponseSingle> response = await GetTemplateAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Gets a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to get</param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> GetTemplateAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param> 
        /// <returns></returns>
        public void DeleteTemplate (long? id)
        {
             DeleteTemplateWithHttpInfo(id);
        }

        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteTemplateWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->DeleteTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteTemplateAsync (long? id)
        {
             await DeleteTemplateAsyncWithHttpInfo(id);

        }

        /// <summary>
        ///  Deletes a template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteTemplateAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteTemplate: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param> 
        /// <param name="data"></param> 
        /// <returns>TemplateResponseSingle</returns>
        public TemplateResponseSingle EditTemplate (long? id, Object data)
        {
             ApiResponse<TemplateResponseSingle> response = EditTemplateWithHttpInfo(id, data);
             return response.Data;
        }

        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param> 
        /// <param name="data"></param> 
        /// <returns>ApiResponse of TemplateResponseSingle</returns>
        public ApiResponse< TemplateResponseSingle > EditTemplateWithHttpInfo (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->EditTemplate");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->EditTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditTemplate: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
    
        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of TemplateResponseSingle</returns>
        public async System.Threading.Tasks.Task<TemplateResponseSingle> EditTemplateAsync (long? id, Object data)
        {
             ApiResponse<TemplateResponseSingle> response = await EditTemplateAsyncWithHttpInfo(id, data);
             return response.Data;

        }

        /// <summary>
        ///  Updates an existing template with the specified ID
        /// </summary>
        /// <param name="id">ID of template to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (TemplateResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TemplateResponseSingle>> EditTemplateAsyncWithHttpInfo (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditTemplate");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditTemplate");
            
    
            var path_ = "/v1/templates/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditTemplate: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditTemplate: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<TemplateResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TemplateResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(TemplateResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>UserResponseMultiple</returns>
        public UserResponseMultiple FindUsers (int? offset, int? limit)
        {
             ApiResponse<UserResponseMultiple> response = FindUsersWithHttpInfo(offset, limit);
             return response.Data;
        }

        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param> 
        /// <param name="limit">Max records to return</param> 
        /// <returns>ApiResponse of UserResponseMultiple</returns>
        public ApiResponse< UserResponseMultiple > FindUsersWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindUsers: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(UserResponseMultiple)));
            
        }
    
        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of UserResponseMultiple</returns>
        public async System.Threading.Tasks.Task<UserResponseMultiple> FindUsersAsync (int? offset, int? limit)
        {
             ApiResponse<UserResponseMultiple> response = await FindUsersAsyncWithHttpInfo(offset, limit);
             return response.Data;

        }

        /// <summary>
        ///  Gets users
        /// </summary>
        /// <param name="offset">The start offset of the result set</param>
        /// <param name="limit">Max records to return</param>
        /// <returns>Task of ApiResponse (UserResponseMultiple)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseMultiple>> FindUsersAsyncWithHttpInfo (int? offset, int? limit)
        {
            
    
            var path_ = "/v1/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            if (offset != null) queryParams.Add("offset", Configuration.ApiClient.ParameterToString(offset)); // query parameter
            if (limit != null) queryParams.Add("limit", Configuration.ApiClient.ParameterToString(limit)); // query parameter
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling FindUsers: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling FindUsers: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserResponseMultiple>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseMultiple) Configuration.ApiClient.Deserialize(response, typeof(UserResponseMultiple)));
            
        }
        
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>UserResponseSingle</returns>
        public UserResponseSingle AddUser (Object data)
        {
             ApiResponse<UserResponseSingle> response = AddUserWithHttpInfo(data);
             return response.Data;
        }

        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param> 
        /// <returns>ApiResponse of UserResponseSingle</returns>
        public ApiResponse< UserResponseSingle > AddUserWithHttpInfo (Object data)
        {
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->AddUser");
            
    
            var path_ = "/v1/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
    
        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of UserResponseSingle</returns>
        public async System.Threading.Tasks.Task<UserResponseSingle> AddUserAsync (Object data)
        {
             ApiResponse<UserResponseSingle> response = await AddUserAsyncWithHttpInfo(data);
             return response.Data;

        }

        /// <summary>
        ///  Creates a new user
        /// </summary>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> AddUserAsyncWithHttpInfo (Object data)
        {
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling AddUser");
            
    
            var path_ = "/v1/users";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.POST, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling AddUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling AddUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
        
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param> 
        /// <returns>UserResponseSingle</returns>
        public UserResponseSingle GetUser (long? id)
        {
             ApiResponse<UserResponseSingle> response = GetUserWithHttpInfo(id);
             return response.Data;
        }

        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param> 
        /// <returns>ApiResponse of UserResponseSingle</returns>
        public ApiResponse< UserResponseSingle > GetUserWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->GetUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
    
        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>Task of UserResponseSingle</returns>
        public async System.Threading.Tasks.Task<UserResponseSingle> GetUserAsync (long? id)
        {
             ApiResponse<UserResponseSingle> response = await GetUserAsyncWithHttpInfo(id);
             return response.Data;

        }

        /// <summary>
        ///  Gets a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to get</param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> GetUserAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling GetUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.GET, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling GetUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
        
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param> 
        /// <returns></returns>
        public void DeleteUser (long? id)
        {
             DeleteUserWithHttpInfo(id);
        }

        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param> 
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteUserWithHttpInfo (long? id)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->DeleteUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);
    
            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
    
        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteUserAsync (long? id)
        {
             await DeleteUserAsyncWithHttpInfo(id);

        }

        /// <summary>
        ///  Deletes a user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to delete</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteUserAsyncWithHttpInfo (long? id)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling DeleteUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.DELETE, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling DeleteUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling DeleteUser: " + response.ErrorMessage, response.ErrorMessage);

            
            return new ApiResponse<Object>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }
        
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param> 
        /// <param name="data"></param> 
        /// <returns>UserResponseSingle</returns>
        public UserResponseSingle EditUser (long? id, Object data)
        {
             ApiResponse<UserResponseSingle> response = EditUserWithHttpInfo(id, data);
             return response.Data;
        }

        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param> 
        /// <param name="data"></param> 
        /// <returns>ApiResponse of UserResponseSingle</returns>
        public ApiResponse< UserResponseSingle > EditUserWithHttpInfo (long? id, Object data)
        {
            
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling SquiggleApi->EditUser");
            
            // verify the required parameter 'data' is set
            if (data == null)
                throw new ApiException(400, "Missing required parameter 'data' when calling SquiggleApi->EditUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            if (data.GetType() != typeof(byte[]))
            {
                postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            }
            else
            {
                postBody = data; // byte array
            }

            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            
    
            // make the HTTP request
            IRestResponse response = (IRestResponse) Configuration.ApiClient.CallApi(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams,
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
    
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);
    
            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
    
        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Task of UserResponseSingle</returns>
        public async System.Threading.Tasks.Task<UserResponseSingle> EditUserAsync (long? id, Object data)
        {
             ApiResponse<UserResponseSingle> response = await EditUserAsyncWithHttpInfo(id, data);
             return response.Data;

        }

        /// <summary>
        ///  Updates an existing user with the specified ID
        /// </summary>
        /// <param name="id">ID of user to update</param>
        /// <param name="data"></param>
        /// <returns>Task of ApiResponse (UserResponseSingle)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UserResponseSingle>> EditUserAsyncWithHttpInfo (long? id, Object data)
        {
            // verify the required parameter 'id' is set
            if (id == null) throw new ApiException(400, "Missing required parameter 'id' when calling EditUser");
            // verify the required parameter 'data' is set
            if (data == null) throw new ApiException(400, "Missing required parameter 'data' when calling EditUser");
            
    
            var path_ = "/v1/users/{id}";
    
            var pathParams = new Dictionary<String, String>();
            var queryParams = new Dictionary<String, String>();
            var headerParams = new Dictionary<String, String>();
            var formParams = new Dictionary<String, String>();
            var fileParams = new Dictionary<String, FileParameter>();
            Object postBody = null;

            // to determine the Content-Type header
            String[] httpContentTypes = new String[] {
                
            };
            String httpContentType = Configuration.ApiClient.SelectHeaderContentType(httpContentTypes);

            // to determine the Accept header
            String[] httpHeaderAccepts = new String[] {
                "application/vnd.api+json"
            };
            String httpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(httpHeaderAccepts);
            if (httpHeaderAccept != null)
                headerParams.Add("Accept", httpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            pathParams.Add("format", "json");
            if (id != null) pathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter
            
            
            
            
            postBody = Configuration.ApiClient.Serialize(data); // http body (model) parameter
            

            
            // authentication (jwt) required
            
            var apiKeyValue = Configuration.GetApiKeyWithPrefix("Authorization");
            if (!String.IsNullOrEmpty(apiKeyValue))
            {
                headerParams["Authorization"] = apiKeyValue;
            }
            

            // make the HTTP request
            IRestResponse response = (IRestResponse) await Configuration.ApiClient.CallApiAsync(path_, 
                Method.PATCH, queryParams, postBody, headerParams, formParams, fileParams, 
                pathParams, httpContentType);

            int statusCode = (int) response.StatusCode;
 
            if (statusCode >= 400)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.Content, response.Content);
            else if (statusCode == 0)
                throw new ApiException (statusCode, "Error calling EditUser: " + response.ErrorMessage, response.ErrorMessage);

            return new ApiResponse<UserResponseSingle>(statusCode,
                response.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UserResponseSingle) Configuration.ApiClient.Deserialize(response, typeof(UserResponseSingle)));
            
        }
        
    }
    
}
