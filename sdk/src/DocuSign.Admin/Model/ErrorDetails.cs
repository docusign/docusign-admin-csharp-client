/* 
 * DocuSign Admin API
 *
 * An API for an organization administrator to manage organizations, accounts and users
 *
 * OpenAPI spec version: v2
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
    /// ErrorDetails
    /// </summary>
    [DataContract]
    public partial class ErrorDetails :  IEquatable<ErrorDetails>, IValidatableObject
    {
        public ErrorDetails()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorDetails" /> class.
        /// </summary>
        /// <param name="Error">Error.</param>
        /// <param name="ErrorDescription">ErrorDescription.</param>
        public ErrorDetails(string Error = default(string), string ErrorDescription = default(string))
        {
            this.Error = Error;
            this.ErrorDescription = ErrorDescription;
        }
        
        /// <summary>
        /// Gets or Sets Error
        /// </summary>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }
        /// <summary>
        /// Gets or Sets ErrorDescription
        /// </summary>
        [DataMember(Name="error_description", EmitDefaultValue=false)]
        public string ErrorDescription { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ErrorDetails {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  ErrorDescription: ").Append(ErrorDescription).Append("\n");
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
            return this.Equals(obj as ErrorDetails);
        }

        /// <summary>
        /// Returns true if ErrorDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of ErrorDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ErrorDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Error == other.Error ||
                    this.Error != null &&
                    this.Error.Equals(other.Error)
                ) && 
                (
                    this.ErrorDescription == other.ErrorDescription ||
                    this.ErrorDescription != null &&
                    this.ErrorDescription.Equals(other.ErrorDescription)
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
                if (this.Error != null)
                    hash = hash * 59 + this.Error.GetHashCode();
                if (this.ErrorDescription != null)
                    hash = hash * 59 + this.ErrorDescription.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
