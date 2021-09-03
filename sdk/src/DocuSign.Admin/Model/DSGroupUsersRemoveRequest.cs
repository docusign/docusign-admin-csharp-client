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
    /// DSGroupUsersRemoveRequest
    /// </summary>
    [DataContract]
    public partial class DSGroupUsersRemoveRequest :  IEquatable<DSGroupUsersRemoveRequest>, IValidatableObject
    {
        public DSGroupUsersRemoveRequest()
        {
            // Empty Constructor
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DSGroupUsersRemoveRequest" /> class.
        /// </summary>
        /// <param name="UserIds">UserIds (required).</param>
        public DSGroupUsersRemoveRequest(List<Guid?> UserIds = default(List<Guid?>))
        {
            // to ensure "UserIds" is required (not null)
            if (UserIds == null)
            {
                throw new InvalidDataException("UserIds is a required property for DSGroupUsersRemoveRequest and cannot be null");
            }
            else
            {
                this.UserIds = UserIds;
            }
        }
        
        /// <summary>
        /// Gets or Sets UserIds
        /// </summary>
        [DataMember(Name="user_ids", EmitDefaultValue=false)]
        public List<Guid?> UserIds { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DSGroupUsersRemoveRequest {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
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
            return this.Equals(obj as DSGroupUsersRemoveRequest);
        }

        /// <summary>
        /// Returns true if DSGroupUsersRemoveRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of DSGroupUsersRemoveRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DSGroupUsersRemoveRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserIds == other.UserIds ||
                    this.UserIds != null &&
                    this.UserIds.SequenceEqual(other.UserIds)
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
                if (this.UserIds != null)
                    hash = hash * 59 + this.UserIds.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }
}
