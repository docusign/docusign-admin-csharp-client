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
    /// OrganizationExportTaskResponse
    /// </summary>
    [DataContract]
    public partial class OrganizationExportTaskResponse :  IEquatable<OrganizationExportTaskResponse>, IValidatableObject
    {
        public OrganizationExportTaskResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationExportTaskResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="Url">Url.</param>
        /// <param name="NumberRows">NumberRows.</param>
        /// <param name="SizeBytes">SizeBytes.</param>
        /// <param name="ErrorDetails">ErrorDetails.</param>
        public OrganizationExportTaskResponse(Guid? Id = default(Guid?), int? SiteId = default(int?), string Url = default(string), long? NumberRows = default(long?), long? SizeBytes = default(long?), OETRErrorDetails ErrorDetails = default(OETRErrorDetails))
        {
            this.Id = Id;
            this.SiteId = SiteId;
            this.Url = Url;
            this.NumberRows = NumberRows;
            this.SizeBytes = SizeBytes;
            this.ErrorDetails = ErrorDetails;
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
        /// Gets or Sets ErrorDetails
        /// </summary>
        [DataMember(Name="error_details", EmitDefaultValue=false)]
        public OETRErrorDetails ErrorDetails { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationExportTaskResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  NumberRows: ").Append(NumberRows).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
            sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
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
            return this.Equals(obj as OrganizationExportTaskResponse);
        }

        /// <summary>
        /// Returns true if OrganizationExportTaskResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationExportTaskResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationExportTaskResponse other)
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
                    this.ErrorDetails == other.ErrorDetails ||
                    this.ErrorDetails != null &&
                    this.ErrorDetails.Equals(other.ErrorDetails)
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
                if (this.NumberRows != null)
                    hash = hash * 59 + this.NumberRows.GetHashCode();
                if (this.SizeBytes != null)
                    hash = hash * 59 + this.SizeBytes.GetHashCode();
                if (this.ErrorDetails != null)
                    hash = hash * 59 + this.ErrorDetails.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
