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
    /// OrganizationImportResponseWarningRollup
    /// </summary>
    [DataContract]
    public partial class OrganizationImportResponseWarningRollup :  IEquatable<OrganizationImportResponseWarningRollup>, IValidatableObject
    {
        public OrganizationImportResponseWarningRollup()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationImportResponseWarningRollup" /> class.
        /// </summary>
        /// <param name="WarningType">WarningType.</param>
        /// <param name="Count">Count.</param>
        public OrganizationImportResponseWarningRollup(string WarningType = default(string), int? Count = default(int?))
        {
            this.WarningType = WarningType;
            this.Count = Count;
        }
        
        /// <summary>
        /// Gets or Sets WarningType
        /// </summary>
        [DataMember(Name="warning_type", EmitDefaultValue=false)]
        public string WarningType { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationImportResponseWarningRollup {\n");
            sb.Append("  WarningType: ").Append(WarningType).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(obj as OrganizationImportResponseWarningRollup);
        }

        /// <summary>
        /// Returns true if OrganizationImportResponseWarningRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationImportResponseWarningRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationImportResponseWarningRollup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.WarningType == other.WarningType ||
                    this.WarningType != null &&
                    this.WarningType.Equals(other.WarningType)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
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
                if (this.WarningType != null)
                    hash = hash * 59 + this.WarningType.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
