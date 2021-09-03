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
    /// IdentityProvidersResponse
    /// </summary>
    [DataContract]
    public partial class IdentityProvidersResponse :  IEquatable<IdentityProvidersResponse>, IValidatableObject
    {
        public IdentityProvidersResponse()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityProvidersResponse" /> class.
        /// </summary>
        /// <param name="IdentityProviders">IdentityProviders.</param>
        public IdentityProvidersResponse(List<IdentityProviderResponse> IdentityProviders = default(List<IdentityProviderResponse>))
        {
            this.IdentityProviders = IdentityProviders;
        }
        
        /// <summary>
        /// Gets or Sets IdentityProviders
        /// </summary>
        [DataMember(Name="identity_providers", EmitDefaultValue=false)]
        public List<IdentityProviderResponse> IdentityProviders { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityProvidersResponse {\n");
            sb.Append("  IdentityProviders: ").Append(IdentityProviders).Append("\n");
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
            return this.Equals(obj as IdentityProvidersResponse);
        }

        /// <summary>
        /// Returns true if IdentityProvidersResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityProvidersResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityProvidersResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IdentityProviders == other.IdentityProviders ||
                    this.IdentityProviders != null &&
                    this.IdentityProviders.SequenceEqual(other.IdentityProviders)
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
                if (this.IdentityProviders != null)
                    hash = hash * 59 + this.IdentityProviders.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
