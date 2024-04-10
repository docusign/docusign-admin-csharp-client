/* 
 * DocuSign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using DocuSign.Admin.Client;
using DocuSign.Admin.Model;

namespace DocuSign.Admin.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IReservedDomainsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Returns the list of reserved domains for the organization.
        /// </summary>
        /// <remarks>
        /// Required scopes: domain_read
        /// </remarks>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns></returns>
        DomainsResponse GetReservedDomains(Guid? organizationId);

        /// <summary>
        /// Returns the list of reserved domains for the organization.
        /// </summary>
        /// <remarks>
        /// Required scopes: domain_read
        /// </remarks>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>ApiResponse of </returns>
        ApiResponse<DomainsResponse> GetReservedDomainsWithHttpInfo(Guid? organizationId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Returns the list of reserved domains for the organization.
        /// </summary>
        /// <remarks>
        /// Required scopes: domain_read
        /// </remarks>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>Task of DomainsResponse</returns>
        System.Threading.Tasks.Task<DomainsResponse> GetReservedDomainsAsync(Guid? organizationId);

        /// <summary>
        /// Returns the list of reserved domains for the organization.
        /// </summary>
        /// <remarks>
        /// Required scopes: domain_read
        /// </remarks>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>Task of ApiResponse (DomainsResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<DomainsResponse>> GetReservedDomainsAsyncWithHttpInfo(Guid? organizationId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ReservedDomainsApi : IReservedDomainsApi
    {
        private DocuSign.Admin.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReservedDomainsApi"/> class
        /// using AplClient object
        /// </summary>
        /// <param name="aplClient">An instance of AplClient</param>
        /// <returns></returns>
        public ReservedDomainsApi(DocuSignClient aplClient)
        {
            this.ApiClient = aplClient;

            ExceptionFactory = Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.ApiClient.GetBasePath();
        }

        /// <summary>
        /// Gets or sets the ApiClient object
        /// </summary>
        /// <value>An instance of the ApiClient</value>
        public DocuSignClient ApiClient { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public DocuSign.Admin.Client.ExceptionFactory ExceptionFactory
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
        /// Returns the list of reserved domains for the organization. Required scopes: domain_read
        /// </summary>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>DomainsResponse</returns>
        public DomainsResponse GetReservedDomains(Guid? organizationId)
        {
             ApiResponse<DomainsResponse> localVarResponse = GetReservedDomainsWithHttpInfo(organizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of reserved domains for the organization. Required scopes: domain_read
        /// </summary>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>ApiResponse of DomainsResponse</returns>
        public ApiResponse<DomainsResponse> GetReservedDomainsWithHttpInfo(Guid? organizationId)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReservedDomainsApi->GetReservedDomains");

            var localVarPath = "/v2/organizations/{organizationId}/reserved_domains";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (organizationId != null) localVarPathParams.Add("organizationId", this.ApiClient.ParameterToString(organizationId)); // path parameter

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = this.ApiClient.CallApi(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReservedDomains", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DomainsResponse>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (DomainsResponse)this.ApiClient.Deserialize(localVarResponse, typeof(DomainsResponse)));
        }

        /// <summary>
        /// Returns the list of reserved domains for the organization. Required scopes: domain_read
        /// </summary>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>Task of DomainsResponse</returns>
        public async System.Threading.Tasks.Task<DomainsResponse> GetReservedDomainsAsync(Guid? organizationId)
        {
             ApiResponse<DomainsResponse> localVarResponse = await GetReservedDomainsAsyncWithHttpInfo(organizationId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Returns the list of reserved domains for the organization. Required scopes: domain_read
        /// </summary>
        /// <exception cref="DocuSign.Admin.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">The organization ID Guid</param>
        /// <returns>Task of ApiResponse (DomainsResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<DomainsResponse>> GetReservedDomainsAsyncWithHttpInfo(Guid? organizationId)
        {
            // verify the required parameter 'organizationId' is set
            if (organizationId == null)
                throw new ApiException(400, "Missing required parameter 'organizationId' when calling ReservedDomainsApi->GetReservedDomains");

            var localVarPath = "/v2/organizations/{organizationId}/reserved_domains";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(this.ApiClient.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new List<FileParameter>();
            Object localVarPostBody = null;
            String localVarHttpContentDisposition = string.Empty;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (organizationId != null) localVarPathParams.Add("organizationId", this.ApiClient.ParameterToString(organizationId)); // path parameter

            // authentication (docusignAccessCode) required
            // oauth required
            if (!String.IsNullOrEmpty(this.ApiClient.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.ApiClient.Configuration.AccessToken;
            }


            // make the HTTP request
            DocuSignRequest localVarRequest = this.ApiClient.PrepareRequest(localVarPath, new HttpMethod("GET"), localVarQueryParams.ToList(), localVarPostBody, localVarHeaderParams.ToList(), localVarFormParams.ToList(), localVarPathParams.ToList(), localVarFileParams, localVarHttpContentType, localVarHttpContentDisposition);
            DocuSignResponse localVarResponse = await this.ApiClient.CallApiAsync(localVarRequest);

            int localVarStatusCode = (int)localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetReservedDomains", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<DomainsResponse>(localVarStatusCode, 
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()), 
                (DomainsResponse)this.ApiClient.Deserialize(localVarResponse, typeof(DomainsResponse)));
        }

    }
}