/* 
 * Docusign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace DocuSign.Admin.Client
{
    public interface IHttpClient
    {
        void AddDefaultRequestHeader(string header, string value);

        DocuSignResponse SendRequest(DocuSignRequest request);

        Task<DocuSignResponse> SendRequestAsync(DocuSignRequest request, CancellationToken cancellationToken);
    }
}