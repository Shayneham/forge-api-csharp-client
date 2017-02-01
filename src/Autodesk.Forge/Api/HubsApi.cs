/* 
 * Forge SDK
 *
 * The Forge Platform contains an expanding collection of web service components that can be used with Autodesk cloud-based products or your own technologies. Take advantage of Autodesk’s expertise in design and engineering.
 *
 * OpenAPI spec version: 0.1.0
 * Contact: forge.help@autodesk.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Newtonsoft.Json.Linq;
using Autodesk.Forge.Client;
using Autodesk.Forge.Model;

namespace Autodesk.Forge
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IHubsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns data on a specific &#x60;hub_id&#x60;. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Hub</returns>
        /*Hub*/dynamic GetHub (string hubId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns data on a specific &#x60;hub_id&#x60;. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>ApiResponse of Hub</returns>
        ApiResponse</*Hub*/dynamic> GetHubWithHttpInfo (string hubId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Hubs</returns>
        /*Hubs*/dynamic GetHubs (List<string> filterId = null, List<string> filterExtensionType = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>ApiResponse of Hubs</returns>
        ApiResponse</*Hubs*/dynamic> GetHubsWithHttpInfo (List<string> filterId = null, List<string> filterExtensionType = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns data on a specific &#x60;hub_id&#x60;. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Task of Hub</returns>
        System.Threading.Tasks.Task</*Hub*/dynamic> GetHubAsync (string hubId);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns data on a specific &#x60;hub_id&#x60;. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Task of ApiResponse (Hub)</returns>
        System.Threading.Tasks.Task<ApiResponse</*Hub*/dynamic>> GetHubAsyncWithHttpInfo (string hubId);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Task of Hubs</returns>
        System.Threading.Tasks.Task</*Hubs*/dynamic> GetHubsAsync (List<string> filterId = null, List<string> filterExtensionType = null);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </remarks>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Task of ApiResponse (Hubs)</returns>
        System.Threading.Tasks.Task<ApiResponse</*Hubs*/dynamic>> GetHubsAsyncWithHttpInfo (List<string> filterId = null, List<string> filterExtensionType = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class HubsApi : IHubsApi
    {
        private Autodesk.Forge.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="HubsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public HubsApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HubsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public HubsApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Autodesk.Forge.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
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
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Autodesk.Forge.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

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
        ///  Returns data on a specific &#x60;hub_id&#x60;. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Hub</returns>
        public /*Hub*/dynamic GetHub (string hubId)
        {
             ApiResponse</*Hub*/dynamic> localVarResponse = GetHubWithHttpInfo(hubId);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns data on a specific &#x60;hub_id&#x60;. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>ApiResponse of Hub</returns>
        public ApiResponse< /*Hub*/dynamic > GetHubWithHttpInfo (string hubId)
        {
            // verify the required parameter 'hubId' is set
            if (hubId == null)
                throw new ApiException(400, "Missing required parameter 'hubId' when calling HubsApi->GetHub");

            var localVarPath = "/project/v1/hubs/{hub_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (hubId != null) localVarPathParams.Add("hub_id", Configuration.ApiClient.ParameterToString(hubId)); // path parameter

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHub", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Hub*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Hub)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(Hub)));
            
        }

        /// <summary>
        ///  Returns data on a specific &#x60;hub_id&#x60;. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Task of Hub</returns>
        public async System.Threading.Tasks.Task</*Hub*/dynamic> GetHubAsync (string hubId)
        {
             ApiResponse</*Hub*/dynamic> localVarResponse = await GetHubAsyncWithHttpInfo(hubId);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns data on a specific &#x60;hub_id&#x60;. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="hubId">the &#x60;hub id&#x60; for the current operation</param>
        /// <returns>Task of ApiResponse (Hub)</returns>
        public async System.Threading.Tasks.Task<ApiResponse</*Hub*/dynamic>> GetHubAsyncWithHttpInfo (string hubId)
        {
            // verify the required parameter 'hubId' is set
            if (hubId == null)
                throw new ApiException(400, "Missing required parameter 'hubId' when calling HubsApi->GetHub");

            var localVarPath = "/project/v1/hubs/{hub_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (hubId != null) localVarPathParams.Add("hub_id", Configuration.ApiClient.ParameterToString(hubId)); // path parameter

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHub", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Hub*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Hub)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(Hub)));
            
        }

        /// <summary>
        ///  Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Hubs</returns>
        public /*Hubs*/dynamic GetHubs (List<string> filterId = null, List<string> filterExtensionType = null)
        {
             ApiResponse</*Hubs*/dynamic> localVarResponse = GetHubsWithHttpInfo(filterId, filterExtensionType);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>ApiResponse of Hubs</returns>
        public ApiResponse< /*Hubs*/dynamic > GetHubsWithHttpInfo (List<string> filterId = null, List<string> filterExtensionType = null)
        {

            var localVarPath = "/project/v1/hubs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (filterId != null) localVarQueryParams.Add("filter[id]", Configuration.ApiClient.ParameterToString(filterId)); // query parameter
            if (filterExtensionType != null) localVarQueryParams.Add("filter[extension.type]", Configuration.ApiClient.ParameterToString(filterExtensionType)); // query parameter

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHubs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Hubs*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Hubs)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(Hubs)));
            
        }

        /// <summary>
        ///  Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Task of Hubs</returns>
        public async System.Threading.Tasks.Task</*Hubs*/dynamic> GetHubsAsync (List<string> filterId = null, List<string> filterExtensionType = null)
        {
             ApiResponse</*Hubs*/dynamic> localVarResponse = await GetHubsAsyncWithHttpInfo(filterId, filterExtensionType);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  Returns a collection of accessible hubs for this member. A Hub represents an A360 Team/Personal hub or a BIM 360 account. 
        /// </summary>
        /// <exception cref="Autodesk.Forge.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterId">filter by the &#x60;id&#x60; of the &#x60;ref&#x60; target (optional)</param>
        /// <param name="filterExtensionType">filter by the extension type (optional)</param>
        /// <returns>Task of ApiResponse (Hubs)</returns>
        public async System.Threading.Tasks.Task<ApiResponse</*Hubs*/dynamic>> GetHubsAsyncWithHttpInfo (List<string> filterId = null, List<string> filterExtensionType = null)
        {

            var localVarPath = "/project/v1/hubs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/vnd.api+json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/vnd.api+json", 
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (filterId != null) localVarQueryParams.Add("filter[id]", Configuration.ApiClient.ParameterToString(filterId)); // query parameter
            if (filterExtensionType != null) localVarQueryParams.Add("filter[extension.type]", Configuration.ApiClient.ParameterToString(filterExtensionType)); // query parameter

            // authentication (oauth2_access_code) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetHubs", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse</*Hubs*/dynamic>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                /*(Hubs)*/ Configuration.ApiClient.Deserialize(localVarResponse, typeof(Hubs)));
            
        }

    }
}