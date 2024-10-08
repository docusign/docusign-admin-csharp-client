/* 
 * Docusign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
 *
 * OpenAPI spec version: v2.1
 * Contact: devcenter@docusign.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// OrganizationAccountSettingsImportResultResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationAccountSettingsImportResultResponse :  IEquatable<OrganizationAccountSettingsImportResultResponse>, IValidatableObject
    {
        public OrganizationAccountSettingsImportResultResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationAccountSettingsImportResultResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="Url">Url.</param>
        /// <param name="NumberProcessedAccounts">NumberProcessedAccounts.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        /// <param name="ProcessingIssuesByAccount">ProcessingIssuesByAccount.</param>
        /// <param name="NumberUnprocessedAccounts">NumberUnprocessedAccounts.</param>
        public OrganizationAccountSettingsImportResultResponse(Guid? Id = default(Guid?), int? SiteId = default(int?), string Url = default(string), long? NumberProcessedAccounts = default(long?), OASIRRErrorDetails ErrorDetails = default(OASIRRErrorDetails), List<OASIRROrganizationAccountSettingsErrorDataResponse> ProcessingIssuesByAccount = default(List<OASIRROrganizationAccountSettingsErrorDataResponse>), long? NumberUnprocessedAccounts = default(long?))
        {
            this.Id = Id;
            this.SiteId = SiteId;
            this.Url = Url;
            this.NumberProcessedAccounts = NumberProcessedAccounts;
            this.ErrorDetails = ErrorDetails;
            this.ProcessingIssuesByAccount = ProcessingIssuesByAccount;
            this.NumberUnprocessedAccounts = NumberUnprocessedAccounts;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name="site_id", EmitDefaultValue=false)]
        public int? SiteId { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets NumberProcessedAccounts
        /// </summary>
        [DataMember(Name="number_processed_accounts", EmitDefaultValue=false)]
        public long? NumberProcessedAccounts { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="error_details", EmitDefaultValue=false)]
        public OASIRRErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Gets or Sets ProcessingIssuesByAccount
        /// </summary>
        [DataMember(Name="processing_issues_by_account", EmitDefaultValue=false)]
        public List<OASIRROrganizationAccountSettingsErrorDataResponse> ProcessingIssuesByAccount { get; set; }
        /// <summary>
        /// Gets or Sets NumberUnprocessedAccounts
        /// </summary>
        [DataMember(Name="number_unprocessed_accounts", EmitDefaultValue=false)]
        public long? NumberUnprocessedAccounts { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationAccountSettingsImportResultResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  NumberProcessedAccounts: ").Append(NumberProcessedAccounts).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
            sb.Append("  ProcessingIssuesByAccount: ").Append(ProcessingIssuesByAccount).Append("\n");
            sb.Append("  NumberUnprocessedAccounts: ").Append(NumberUnprocessedAccounts).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as OrganizationAccountSettingsImportResultResponse);
        }

        /// <summary>
        /// Returns true if OrganizationAccountSettingsImportResultResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationAccountSettingsImportResultResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationAccountSettingsImportResultResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.SiteId == other.SiteId ||
                    this.SiteId != null &&
                    this.SiteId.Equals(other.SiteId)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.NumberProcessedAccounts == other.NumberProcessedAccounts ||
                    this.NumberProcessedAccounts != null &&
                    this.NumberProcessedAccounts.Equals(other.NumberProcessedAccounts)
                ) && 
                (
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
                ) && 
                (
                    this.ProcessingIssuesByAccount == other.ProcessingIssuesByAccount ||
                    this.ProcessingIssuesByAccount != null &&
                    this.ProcessingIssuesByAccount.SequenceEqual(other.ProcessingIssuesByAccount)
                ) && 
                (
                    this.NumberUnprocessedAccounts == other.NumberUnprocessedAccounts ||
                    this.NumberUnprocessedAccounts != null &&
                    this.NumberUnprocessedAccounts.Equals(other.NumberUnprocessedAccounts)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.SiteId != null)
                    hash = hash * 59 + this.SiteId.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.NumberProcessedAccounts != null)
                    hash = hash * 59 + this.NumberProcessedAccounts.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                if (this.ProcessingIssuesByAccount != null)
                    hash = hash * 59 + this.ProcessingIssuesByAccount.GetHashCode();
                if (this.NumberUnprocessedAccounts != null)
                    hash = hash * 59 + this.NumberUnprocessedAccounts.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
