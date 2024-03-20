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
    /// OrganizationExportResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationExportResponse :  IEquatable<OrganizationExportResponse>, IValidatableObject
    {
        public OrganizationExportResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationExportResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Type">Type.</param>
        /// <param name="Requestor">Requestor.</param>
        /// <param name="Created">Created.</param>
        /// <param name="LastModified">LastModified.</param>
        /// <param name="Completed">Completed.</param>
        /// <param name="Expires">Expires.</param>
        /// <param name="Status">Status.</param>
        /// <param name="SelectedAccounts">SelectedAccounts.</param>
        /// <param name="SelectedDomains">SelectedDomains.</param>
        /// <param name="MetadataUrl">MetadataUrl.</param>
        /// <param name="PercentCompleted">PercentCompleted.</param>
        /// <param name="NumberRows">NumberRows.</param>
        /// <param name="SizeBytes">SizeBytes.</param>
        /// <param name="Results">Results.</param>
        /// <param name="Success">Success.</param>
        public OrganizationExportResponse(Guid? Id = default(Guid?), string Type = default(string), OrganizationExportRequestorResponse Requestor = default(OrganizationExportRequestorResponse), DateTime? Created = default(DateTime?), DateTime? LastModified = default(DateTime?), DateTime? Completed = default(DateTime?), DateTime? Expires = default(DateTime?), string Status = default(string), List<OrgExportSelectedAccount> SelectedAccounts = default(List<OrgExportSelectedAccount>), List<OrgExportSelectedDomain> SelectedDomains = default(List<OrgExportSelectedDomain>), string MetadataUrl = default(string), int? PercentCompleted = default(int?), long? NumberRows = default(long?), long? SizeBytes = default(long?), List<OrganizationExportTaskResponse> Results = default(List<OrganizationExportTaskResponse>), bool? Success = default(bool?))
        {
            this.Id = Id;
            this.Type = Type;
            this.Requestor = Requestor;
            this.Created = Created;
            this.LastModified = LastModified;
            this.Completed = Completed;
            this.Expires = Expires;
            this.Status = Status;
            this.SelectedAccounts = SelectedAccounts;
            this.SelectedDomains = SelectedDomains;
            this.MetadataUrl = MetadataUrl;
            this.PercentCompleted = PercentCompleted;
            this.NumberRows = NumberRows;
            this.SizeBytes = SizeBytes;
            this.Results = Results;
            this.Success = Success;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets Requestor
        /// </summary>
        [DataMember(Name="requestor", EmitDefaultValue=false)]
        public OrganizationExportRequestorResponse Requestor { get; set; }
        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name="created", EmitDefaultValue=false)]
        public DateTime? Created { get; set; }
        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        [DataMember(Name="last_modified", EmitDefaultValue=false)]
        public DateTime? LastModified { get; set; }
        /// <summary>
        /// Gets or Sets Completed
        /// </summary>
        [DataMember(Name="completed", EmitDefaultValue=false)]
        public DateTime? Completed { get; set; }
        /// <summary>
        /// Gets or Sets Expires
        /// </summary>
        [DataMember(Name="expires", EmitDefaultValue=false)]
        public DateTime? Expires { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets SelectedAccounts
        /// </summary>
        [DataMember(Name="selected_accounts", EmitDefaultValue=false)]
        public List<OrgExportSelectedAccount> SelectedAccounts { get; set; }
        /// <summary>
        /// Gets or Sets SelectedDomains
        /// </summary>
        [DataMember(Name="selected_domains", EmitDefaultValue=false)]
        public List<OrgExportSelectedDomain> SelectedDomains { get; set; }
        /// <summary>
        /// Gets or Sets MetadataUrl
        /// </summary>
        [DataMember(Name="metadata_url", EmitDefaultValue=false)]
        public string MetadataUrl { get; set; }
        /// <summary>
        /// Gets or Sets PercentCompleted
        /// </summary>
        [DataMember(Name="percent_completed", EmitDefaultValue=false)]
        public int? PercentCompleted { get; set; }
        /// <summary>
        /// Gets or Sets NumberRows
        /// </summary>
        [DataMember(Name="number_rows", EmitDefaultValue=false)]
        public long? NumberRows { get; set; }
        /// <summary>
        /// Gets or Sets SizeBytes
        /// </summary>
        [DataMember(Name="size_bytes", EmitDefaultValue=false)]
        public long? SizeBytes { get; set; }
        /// <summary>
        /// Gets or Sets Results
        /// </summary>
        [DataMember(Name="results", EmitDefaultValue=false)]
        public List<OrganizationExportTaskResponse> Results { get; set; }
        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name="success", EmitDefaultValue=false)]
        public bool? Success { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationExportResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Requestor: ").Append(Requestor).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Expires: ").Append(Expires).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SelectedAccounts: ").Append(SelectedAccounts).Append("\n");
            sb.Append("  SelectedDomains: ").Append(SelectedDomains).Append("\n");
            sb.Append("  MetadataUrl: ").Append(MetadataUrl).Append("\n");
            sb.Append("  PercentCompleted: ").Append(PercentCompleted).Append("\n");
            sb.Append("  NumberRows: ").Append(NumberRows).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  Results: ").Append(Results).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
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
            return this.Equals(obj as OrganizationExportResponse);
        }

        /// <summary>
        /// Returns true if OrganizationExportResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationExportResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationExportResponse other)
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
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.Requestor == other.Requestor ||
                    this.Requestor != null &&
                    this.Requestor.Equals(other.Requestor)
                ) && 
                (
                    this.Created == other.Created ||
                    this.Created != null &&
                    this.Created.Equals(other.Created)
                ) && 
                (
                    this.LastModified == other.LastModified ||
                    this.LastModified != null &&
                    this.LastModified.Equals(other.LastModified)
                ) && 
                (
                    this.Completed == other.Completed ||
                    this.Completed != null &&
                    this.Completed.Equals(other.Completed)
                ) && 
                (
                    this.Expires == other.Expires ||
                    this.Expires != null &&
                    this.Expires.Equals(other.Expires)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.SelectedAccounts == other.SelectedAccounts ||
                    this.SelectedAccounts != null &&
                    this.SelectedAccounts.SequenceEqual(other.SelectedAccounts)
                ) && 
                (
                    this.SelectedDomains == other.SelectedDomains ||
                    this.SelectedDomains != null &&
                    this.SelectedDomains.SequenceEqual(other.SelectedDomains)
                ) && 
                (
                    this.MetadataUrl == other.MetadataUrl ||
                    this.MetadataUrl != null &&
                    this.MetadataUrl.Equals(other.MetadataUrl)
                ) && 
                (
                    this.PercentCompleted == other.PercentCompleted ||
                    this.PercentCompleted != null &&
                    this.PercentCompleted.Equals(other.PercentCompleted)
                ) && 
                (
                    this.NumberRows == other.NumberRows ||
                    this.NumberRows != null &&
                    this.NumberRows.Equals(other.NumberRows)
                ) && 
                (
                    this.SizeBytes == other.SizeBytes ||
                    this.SizeBytes != null &&
                    this.SizeBytes.Equals(other.SizeBytes)
                ) && 
                (
                    this.Results == other.Results ||
                    this.Results != null &&
                    this.Results.SequenceEqual(other.Results)
                ) && 
                (
                    this.Success == other.Success ||
                    this.Success != null &&
                    this.Success.Equals(other.Success)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.Requestor != null)
                    hash = hash * 59 + this.Requestor.GetHashCode();
                if (this.Created != null)
                    hash = hash * 59 + this.Created.GetHashCode();
                if (this.LastModified != null)
                    hash = hash * 59 + this.LastModified.GetHashCode();
                if (this.Completed != null)
                    hash = hash * 59 + this.Completed.GetHashCode();
                if (this.Expires != null)
                    hash = hash * 59 + this.Expires.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.SelectedAccounts != null)
                    hash = hash * 59 + this.SelectedAccounts.GetHashCode();
                if (this.SelectedDomains != null)
                    hash = hash * 59 + this.SelectedDomains.GetHashCode();
                if (this.MetadataUrl != null)
                    hash = hash * 59 + this.MetadataUrl.GetHashCode();
                if (this.PercentCompleted != null)
                    hash = hash * 59 + this.PercentCompleted.GetHashCode();
                if (this.NumberRows != null)
                    hash = hash * 59 + this.NumberRows.GetHashCode();
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                if (this.Results != null)
                    hash = hash * 59 + this.Results.GetHashCode();
                if (this.Success != null)
                    hash = hash * 59 + this.Success.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
