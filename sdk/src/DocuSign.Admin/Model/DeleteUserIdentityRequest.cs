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
    /// DeleteUserIdentityRequest
    /// </summary>
    [DataContract]
    public partial class DeleteUserIdentityRequest :  IEquatable<DeleteUserIdentityRequest>, IValidatableObject
    {
        public DeleteUserIdentityRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteUserIdentityRequest" /> class.
        /// </summary>
        /// <param name="Identities">Identities (required).</param>
        public DeleteUserIdentityRequest(List<UserIdentityRequest> Identities = default(List<UserIdentityRequest>))
        {
            // to ensure "Identities" is required (not null)
            if (Identities == null)
            {
                throw new InvalidDataException("Identities is a required property for DeleteUserIdentityRequest and cannot be null");
            }
            else
            {
                this.Identities = Identities;
            }
        }
        
        /// <summary>
        /// Gets or Sets Identities
        /// </summary>
        [DataMember(Name="identities", EmitDefaultValue=false)]
        public List<UserIdentityRequest> Identities { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteUserIdentityRequest {\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
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
            return this.Equals(obj as DeleteUserIdentityRequest);
        }

        /// <summary>
        /// Returns true if DeleteUserIdentityRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DeleteUserIdentityRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeleteUserIdentityRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Identities == other.Identities ||
                    this.Identities != null &&
                    this.Identities.SequenceEqual(other.Identities)
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
                if (this.Identities != null)
                    hash = hash * 59 + this.Identities.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
