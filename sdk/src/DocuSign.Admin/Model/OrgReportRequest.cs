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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = DocuSign.Admin.Client.SwaggerDateConverter;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// OrgReportRequest
    /// </summary>
    [DataContract]
    public partial class OrgReportRequest :  IEquatable<OrgReportRequest>, IValidatableObject
    {
        public OrgReportRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgReportRequest" /> class.
        /// </summary>
        /// <param name="ReportType">ReportType.</param>
        /// <param name="ReportDateRange">ReportDateRange.</param>
        /// <param name="AccountIds">AccountIds.</param>
        /// <param name="CustomStartDate">CustomStartDate.</param>
        /// <param name="CustomEndDate">CustomEndDate.</param>
        public OrgReportRequest(string ReportType = default(string), string ReportDateRange = default(string), List<Guid?> AccountIds = default(List<Guid?>), DateTime CustomStartDate = default(DateTime), DateTime CustomEndDate = default(DateTime))
        {
            this.ReportType = ReportType;
            this.ReportDateRange = ReportDateRange;
            this.AccountIds = AccountIds;
            this.CustomStartDate = CustomStartDate;
            this.CustomEndDate = CustomEndDate;
        }
        
        /// <summary>
        /// Gets or Sets ReportType
        /// </summary>
        [DataMember(Name="report_type", EmitDefaultValue=false)]
        public string ReportType { get; set; }
        /// <summary>
        /// Gets or Sets ReportDateRange
        /// </summary>
        [DataMember(Name="report_date_range", EmitDefaultValue=false)]
        public string ReportDateRange { get; set; }
        /// <summary>
        /// Gets or Sets AccountIds
        /// </summary>
        [DataMember(Name="account_ids", EmitDefaultValue=false)]
        public List<Guid?> AccountIds { get; set; }
        /// <summary>
        /// Gets or Sets CustomStartDate
        /// </summary>
        [DataMember(Name="custom_start_date", EmitDefaultValue=false)]
        public DateTime CustomStartDate { get; set; }
        /// <summary>
        /// Gets or Sets CustomEndDate
        /// </summary>
        [DataMember(Name="custom_end_date", EmitDefaultValue=false)]
        public DateTime CustomEndDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgReportRequest {\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  ReportDateRange: ").Append(ReportDateRange).Append("\n");
            sb.Append("  AccountIds: ").Append(AccountIds).Append("\n");
            sb.Append("  CustomStartDate: ").Append(CustomStartDate).Append("\n");
            sb.Append("  CustomEndDate: ").Append(CustomEndDate).Append("\n");
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
            return this.Equals(obj as OrgReportRequest);
        }

        /// <summary>
        /// Returns true if OrgReportRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgReportRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ReportType == other.ReportType ||
                    this.ReportType != null &&
                    this.ReportType.Equals(other.ReportType)
                ) && 
                (
                    this.ReportDateRange == other.ReportDateRange ||
                    this.ReportDateRange != null &&
                    this.ReportDateRange.Equals(other.ReportDateRange)
                ) && 
                (
                    this.AccountIds == other.AccountIds ||
                    this.AccountIds != null &&
                    this.AccountIds.SequenceEqual(other.AccountIds)
                ) && 
                (
                    this.CustomStartDate == other.CustomStartDate ||
                    this.CustomStartDate != null &&
                    this.CustomStartDate.Equals(other.CustomStartDate)
                ) && 
                (
                    this.CustomEndDate == other.CustomEndDate ||
                    this.CustomEndDate != null &&
                    this.CustomEndDate.Equals(other.CustomEndDate)
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
                if (this.ReportType != null)
                    hash = hash * 59 + this.ReportType.GetHashCode();
                if (this.ReportDateRange != null)
                    hash = hash * 59 + this.ReportDateRange.GetHashCode();
                if (this.AccountIds != null)
                    hash = hash * 59 + this.AccountIds.GetHashCode();
                if (this.CustomStartDate != null)
                    hash = hash * 59 + this.CustomStartDate.GetHashCode();
                if (this.CustomEndDate != null)
                    hash = hash * 59 + this.CustomEndDate.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
