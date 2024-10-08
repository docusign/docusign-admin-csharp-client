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
    /// OrgReportConfigurationResponse
    /// </summary>
    [DataContract]
    public partial class OrgReportConfigurationResponse :  IEquatable<OrgReportConfigurationResponse>, IValidatableObject
    {
        public OrgReportConfigurationResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrgReportConfigurationResponse" /> class.
        /// </summary>
        /// <param name="IsAccountLimitDisabled">IsAccountLimitDisabled.</param>
        /// <param name="CustomDatesEnabled">CustomDatesEnabled.</param>
        /// <param name="EnabledReportTypes">EnabledReportTypes.</param>
        public OrgReportConfigurationResponse(bool? IsAccountLimitDisabled = default(bool?), bool? CustomDatesEnabled = default(bool?), List<int?> EnabledReportTypes = default(List<int?>))
        {
            this.IsAccountLimitDisabled = IsAccountLimitDisabled;
            this.CustomDatesEnabled = CustomDatesEnabled;
            this.EnabledReportTypes = EnabledReportTypes;
        }
        
        /// <summary>
        /// Gets or Sets IsAccountLimitDisabled
        /// </summary>
        [DataMember(Name="is_account_limit_disabled", EmitDefaultValue=false)]
        public bool? IsAccountLimitDisabled { get; set; }
        /// <summary>
        /// Gets or Sets CustomDatesEnabled
        /// </summary>
        [DataMember(Name="custom_dates_enabled", EmitDefaultValue=false)]
        public bool? CustomDatesEnabled { get; set; }
        /// <summary>
        /// Gets or Sets EnabledReportTypes
        /// </summary>
        [DataMember(Name="enabled_report_types", EmitDefaultValue=false)]
        public List<int?> EnabledReportTypes { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrgReportConfigurationResponse {\n");
            sb.Append("  IsAccountLimitDisabled: ").Append(IsAccountLimitDisabled).Append("\n");
            sb.Append("  CustomDatesEnabled: ").Append(CustomDatesEnabled).Append("\n");
            sb.Append("  EnabledReportTypes: ").Append(EnabledReportTypes).Append("\n");
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
            return this.Equals(obj as OrgReportConfigurationResponse);
        }

        /// <summary>
        /// Returns true if OrgReportConfigurationResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of OrgReportConfigurationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrgReportConfigurationResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsAccountLimitDisabled == other.IsAccountLimitDisabled ||
                    this.IsAccountLimitDisabled != null &&
                    this.IsAccountLimitDisabled.Equals(other.IsAccountLimitDisabled)
                ) && 
                (
                    this.CustomDatesEnabled == other.CustomDatesEnabled ||
                    this.CustomDatesEnabled != null &&
                    this.CustomDatesEnabled.Equals(other.CustomDatesEnabled)
                ) && 
                (
                    this.EnabledReportTypes == other.EnabledReportTypes ||
                    this.EnabledReportTypes != null &&
                    this.EnabledReportTypes.SequenceEqual(other.EnabledReportTypes)
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
                if (this.IsAccountLimitDisabled != null)
                    hash = hash * 59 + this.IsAccountLimitDisabled.GetHashCode();
                if (this.CustomDatesEnabled != null)
                    hash = hash * 59 + this.CustomDatesEnabled.GetHashCode();
                if (this.EnabledReportTypes != null)
                    hash = hash * 59 + this.EnabledReportTypes.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
