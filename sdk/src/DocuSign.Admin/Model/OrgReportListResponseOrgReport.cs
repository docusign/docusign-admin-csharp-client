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
using System.Text;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace DocuSign.Admin.Model
{
    /// <summary>
    /// OrgReportListResponseOrgReport
    /// </summary>
    [DataContract]
    public partial class OrgReportListResponseOrgReport :  IEquatable<OrgReportListResponseOrgReport>, IValidatableObject
    {
        public OrgReportListResponseOrgReport()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgReportListResponseOrgReport" /> class.
        /// </summary>
        /// <param name="Complete">Complete.</param>
        /// <param name="ReportCorrelationId">ReportCorrelationId.</param>
        /// <param name="SiteId">SiteId.</param>
        /// <param name="ReportId">ReportId.</param>
        /// <param name="Requestor">Requestor.</param>
        /// <param name="CreatedOn">CreatedOn.</param>
        /// <param name="AccountExportCount">AccountExportCount.</param>
        /// <param name="Url">Url.</param>
        /// <param name="ReportTypeId">ReportTypeId.</param>
        /// <param name="ReportDateRange">ReportDateRange.</param>
        /// <param name="CustomStartDate">CustomStartDate.</param>
        /// <param name="CustomEndDate">CustomEndDate.</param>
        public OrgReportListResponseOrgReport(bool? Complete = default(bool?), Guid? ReportCorrelationId = default(Guid?), int? SiteId = default(int?), Guid? ReportId = default(Guid?), OrgReportListResponseRequestor Requestor = default(OrgReportListResponseRequestor), DateTime? CreatedOn = default(DateTime?), int? AccountExportCount = default(int?), string Url = default(string), string ReportTypeId = default(string), string ReportDateRange = default(string), DateTime? CustomStartDate = default(DateTime?), DateTime? CustomEndDate = default(DateTime?))
        {
            this.Complete = Complete;
            this.ReportCorrelationId = ReportCorrelationId;
            this.SiteId = SiteId;
            this.ReportId = ReportId;
            this.Requestor = Requestor;
            this.CreatedOn = CreatedOn;
            this.AccountExportCount = AccountExportCount;
            this.Url = Url;
            this.ReportTypeId = ReportTypeId;
            this.ReportDateRange = ReportDateRange;
            this.CustomStartDate = CustomStartDate;
            this.CustomEndDate = CustomEndDate;
        }
        
        /// <summary>
        /// Gets or Sets Complete
        /// </summary>
        [DataMember(Name="complete", EmitDefaultValue=false)]
        public bool? Complete { get; set; }
        /// <summary>
        /// Gets or Sets ReportCorrelationId
        /// </summary>
        [DataMember(Name="report_correlation_id", EmitDefaultValue=false)]
        public Guid? ReportCorrelationId { get; set; }
        /// <summary>
        /// Gets or Sets SiteId
        /// </summary>
        [DataMember(Name="site_id", EmitDefaultValue=false)]
        public int? SiteId { get; set; }
        /// <summary>
        /// Gets or Sets ReportId
        /// </summary>
        [DataMember(Name="report_id", EmitDefaultValue=false)]
        public Guid? ReportId { get; set; }
        /// <summary>
        /// Gets or Sets Requestor
        /// </summary>
        [DataMember(Name="requestor", EmitDefaultValue=false)]
        public OrgReportListResponseRequestor Requestor { get; set; }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name="created_on", EmitDefaultValue=false)]
        public DateTime? CreatedOn { get; set; }
        /// <summary>
        /// Gets or Sets AccountExportCount
        /// </summary>
        [DataMember(Name="account_export_count", EmitDefaultValue=false)]
        public int? AccountExportCount { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Gets or Sets ReportTypeId
        /// </summary>
        [DataMember(Name="report_type_id", EmitDefaultValue=false)]
        public string ReportTypeId { get; set; }
        /// <summary>
        /// Gets or Sets ReportDateRange
        /// </summary>
        [DataMember(Name="report_date_range", EmitDefaultValue=false)]
        public string ReportDateRange { get; set; }
        /// <summary>
        /// Gets or Sets CustomStartDate
        /// </summary>
        [DataMember(Name="custom_start_date", EmitDefaultValue=false)]
        public DateTime? CustomStartDate { get; set; }
        /// <summary>
        /// Gets or Sets CustomEndDate
        /// </summary>
        [DataMember(Name="custom_end_date", EmitDefaultValue=false)]
        public DateTime? CustomEndDate { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgReportListResponseOrgReport {\n");
            sb.Append("  Complete: ").Append(Complete).Append("\n");
            sb.Append("  ReportCorrelationId: ").Append(ReportCorrelationId).Append("\n");
            sb.Append("  SiteId: ").Append(SiteId).Append("\n");
            sb.Append("  ReportId: ").Append(ReportId).Append("\n");
            sb.Append("  Requestor: ").Append(Requestor).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  AccountExportCount: ").Append(AccountExportCount).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  ReportTypeId: ").Append(ReportTypeId).Append("\n");
            sb.Append("  ReportDateRange: ").Append(ReportDateRange).Append("\n");
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
            return this.Equals(obj as OrgReportListResponseOrgReport);
        }

        /// <summary>
        /// Returns true if OrgReportListResponseOrgReport instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgReportListResponseOrgReport to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgReportListResponseOrgReport other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Complete == other.Complete ||
                    this.Complete != null &&
                    this.Complete.Equals(other.Complete)
                ) && 
                (
                    this.ReportCorrelationId == other.ReportCorrelationId ||
                    this.ReportCorrelationId != null &&
                    this.ReportCorrelationId.Equals(other.ReportCorrelationId)
                ) && 
                (
                    this.SiteId == other.SiteId ||
                    this.SiteId != null &&
                    this.SiteId.Equals(other.SiteId)
                ) && 
                (
                    this.ReportId == other.ReportId ||
                    this.ReportId != null &&
                    this.ReportId.Equals(other.ReportId)
                ) && 
                (
                    this.Requestor == other.Requestor ||
                    this.Requestor != null &&
                    this.Requestor.Equals(other.Requestor)
                ) && 
                (
                    this.CreatedOn == other.CreatedOn ||
                    this.CreatedOn != null &&
                    this.CreatedOn.Equals(other.CreatedOn)
                ) && 
                (
                    this.AccountExportCount == other.AccountExportCount ||
                    this.AccountExportCount != null &&
                    this.AccountExportCount.Equals(other.AccountExportCount)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) && 
                (
                    this.ReportTypeId == other.ReportTypeId ||
                    this.ReportTypeId != null &&
                    this.ReportTypeId.Equals(other.ReportTypeId)
                ) && 
                (
                    this.ReportDateRange == other.ReportDateRange ||
                    this.ReportDateRange != null &&
                    this.ReportDateRange.Equals(other.ReportDateRange)
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
                if (this.Complete != null)
                    hash = hash * 59 + this.Complete.GetHashCode();
                if (this.ReportCorrelationId != null)
                    hash = hash * 59 + this.ReportCorrelationId.GetHashCode();
                if (this.SiteId != null)
                    hash = hash * 59 + this.SiteId.GetHashCode();
                if (this.ReportId != null)
                    hash = hash * 59 + this.ReportId.GetHashCode();
                if (this.Requestor != null)
                    hash = hash * 59 + this.Requestor.GetHashCode();
                if (this.CreatedOn != null)
                    hash = hash * 59 + this.CreatedOn.GetHashCode();
                if (this.AccountExportCount != null)
                    hash = hash * 59 + this.AccountExportCount.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                if (this.ReportTypeId != null)
                    hash = hash * 59 + this.ReportTypeId.GetHashCode();
                if (this.ReportDateRange != null)
                    hash = hash * 59 + this.ReportDateRange.GetHashCode();
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
