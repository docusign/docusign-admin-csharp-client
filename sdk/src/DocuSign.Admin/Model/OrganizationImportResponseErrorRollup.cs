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
    /// OrganizationImportResponseErrorRollup
    /// </summary>
    [DataContract]
    public partial class OrganizationImportResponseErrorRollup :  IEquatable<OrganizationImportResponseErrorRollup>, IValidatableObject
    {
        public OrganizationImportResponseErrorRollup()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationImportResponseErrorRollup" /> class.
        /// </summary>
        /// <param name="ErrorType">ErrorType.</param>
        /// <param name="Count">Count.</param>
        public OrganizationImportResponseErrorRollup(string ErrorType = default(string), int? Count = default(int?))
        {
            this.ErrorType = ErrorType;
            this.Count = Count;
        }
        
        /// <summary>
        /// Gets or Sets ErrorType
        /// </summary>
        [DataMember(Name="error_type", EmitDefaultValue=false)]
        public string ErrorType { get; set; }
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
            sb.Append("class OrganizationImportResponseErrorRollup {\n");
            sb.Append("  ErrorType: ").Append(ErrorType).Append("\n");
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
            return this.Equals(obj as OrganizationImportResponseErrorRollup);
        }

        /// <summary>
        /// Returns true if OrganizationImportResponseErrorRollup instances are equal
        /// </summary>
        /// <param name="other">Instance of OrganizationImportResponseErrorRollup to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationImportResponseErrorRollup other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ErrorType == other.ErrorType ||
                    this.ErrorType != null &&
                    this.ErrorType.Equals(other.ErrorType)
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
                if (this.ErrorType != null)
                    hash = hash * 59 + this.ErrorType.GetHashCode();
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
